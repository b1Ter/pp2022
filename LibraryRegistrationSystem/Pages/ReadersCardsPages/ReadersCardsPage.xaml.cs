using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryRegistrationSystem.Pages.ReadersCardsPages
{
    /// <summary>
    /// Логика взаимодействия для ReadersCardsPage.xaml
    /// </summary>
    public partial class ReadersCardsPage : Page
    {
        CLS_Entities context;
        List<DepartmentReader> readers;
        /*
         * Конструктор страницы
         */
        public ReadersCardsPage()
        {
            InitializeComponent();
            context = new CLS_Entities();
            readers = context.DepartmentReader.ToList();
            dataGrid.ItemsSource = readers;
            txtStartYear.Text = "2000";
            txtEndYear.Text = "2022";
            this.UpdateLayout();
            cmbBranch.ItemsSource = context.Branch.ToList();
        }
        /*
         * Фильтрация таблицы
         */
        public void Filtering()
        {
            readers = context.DepartmentReader.ToList();
            if (txtName.Text != null)
                readers = readers.Where(x => x.Reader1.FullName.ToLower().Contains(txtName.Text.ToLower())).ToList();
            if (txtStartYear.Text != null || txtStartYear.Text != "")
                readers = (from x in readers
                           where x.Year >= int.Parse(txtStartYear.Text)
                           select x).ToList();
            /*if (txtEndYear.Text != null || txtStartYear.Text != "")
                readers = readers = (from x in readers
                                     where x.Year < (int.Parse(txtEndYear.Text) + 1)
                                     select x).ToList();*/
            if (cmbBranch.SelectedItem != null)
                readers = readers.Where(x => x.Department1.Branch1 == ((Branch)cmbBranch.SelectedItem)).ToList();
            if (cmbDepartment.SelectedItem != null)
                readers = readers.Where(x => x.Department1 == ((Department)cmbDepartment.SelectedItem)).ToList();
            dataGrid.ItemsSource = readers;
        }

        /*
         * Действий при изменении значений в текстовых полях
         */
        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filtering();
        }
        private void cmbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filtering();
        }
        private void cmbBranch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox branchBox = (ComboBox)sender;
            Branch branch = branchBox.SelectedItem as Branch;
            cmbDepartment.ItemsSource = context.Department.Where(x => x.Branch1.ID == branch.ID).ToList();
            Filtering();
        }
        /*
         * Действия при нажатии на кнопку "Сброс"
         */
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            readers = context.DepartmentReader.ToList();
            txtEndYear.Clear();
            txtName.Clear();
            txtStartYear.Text = DateTime.Now.Year.ToString();
        }
        /*
         * Действие при добавлении нового читательского билета
         */
        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            DepartmentReader reader = new DepartmentReader();
            context.DepartmentReader.Add(reader);
            FrameManager.MainFrame.Navigate(new EditReadersCardPage(context, reader));
        }
        /*
         * Действие при нажатии на кнопку удаления читательского билета
         */
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var row = (DepartmentReader)dataGrid.SelectedItem;
            if (row == null)
            {
                MessageBox.Show("Читательские билеты не выбраны",
                    "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить выбранные читательские билеты?",
                "Удаление", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                context.DepartmentReader.Remove(row);
                context.SaveChanges();
                readers = context.DepartmentReader.ToList();
                Filtering();
            }
        }
        /*
         * Действие при нажатии на кнопку изменения данных читательского билета
         */
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button btnReader = (Button)sender;
            DepartmentReader reader = btnReader.DataContext as DepartmentReader;
            FrameManager.MainFrame.Navigate(new EditReadersCardPage(context, reader));
        }       
        /*
         * Действие при нажатии на кнопку обновления данных
         */
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Filtering();
        }
    }
}
