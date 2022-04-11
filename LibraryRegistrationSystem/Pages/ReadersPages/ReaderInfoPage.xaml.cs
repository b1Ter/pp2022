using LibraryRegistrationSystem.Pages.ReadersCardsPages;
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

namespace LibraryRegistrationSystem.Pages.ReadersPages
{
    /// <summary>
    /// Логика взаимодействия для ReaderInfoPage.xaml
    /// </summary>
    public partial class ReaderInfoPage : Page
    {
        CLS_Entities context = new CLS_Entities();
        Reader reader;
        List<DepartmentReader> departments;
        /*
         * Конструктор
         */
        public ReaderInfoPage(Reader reader)
        {
            InitializeComponent();
            this.reader = reader;
            this.DataContext = reader;
            cmbBranch.ItemsSource = context.Branch.ToList();
            departments = context.DepartmentReader.Where(x => x.Reader1.ID == reader.ID).ToList();
            dataCards.ItemsSource = departments;
        }
        /*
         * Фильтрация таблицы читательских билетов
         */
        public void Filtering()
        {
            departments = context.DepartmentReader.Where(x => x.Reader1.ID == reader.ID).ToList();
            if (txtYear.Text != null && txtYear.Text != "")
                departments = departments.Where(x => x.Year.ToString() == txtYear.Text.ToString()).ToList();
            if (cmbBranch.SelectedItem != null)
                departments = departments.Where(x => x.Department1.Branch1.ID == ((Branch)cmbBranch.SelectedItem).ID).ToList();
            if (cmbDepartment.SelectedItem != null)
                departments = departments.Where(x => x.Department1.ID == ((Department)cmbDepartment.SelectedItem).ID).ToList();
            dataCards.ItemsSource = departments;
        }
        /*
         * Взаимодействие при нажатии на кнопку "Изменить"
         */
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button btnReader = (Button)sender;
            DepartmentReader department = btnReader.DataContext as DepartmentReader;
            FrameManager.MainFrame.Navigate(new EditReadersCardPage(context, department));
        }
        /*
         * Взаимодействие при нажатии на кнопку "Сбросить"
         */
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtYear.Text = "";
            departments = context.DepartmentReader.Where(x => x.Reader.ToString() == reader.ID.ToString()).ToList();
            dataCards.ItemsSource = departments;
        }
        /*
         * Взаимодействие при нажатии на кнопку "Добавить"
         */
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DepartmentReader department = new DepartmentReader();
            department.Reader1 = reader;
            context.DepartmentReader.Add(department);
            FrameManager.MainFrame.Navigate(new EditReadersCardPage(context, department));
        }
        /*
         * Действия при изменении текстовых полей сортировки
         */
        private void cmbBranch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox branchBox = (ComboBox)sender;
            Branch branch = branchBox.SelectedItem as Branch;
            cmbDepartment.ItemsSource = context.Department.Where(x => x.Branch1.ID == branch.ID).ToList();
            Filtering();
        }
        private void cmbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filtering();
        }
        private void txtYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filtering();
        }
        /*
         * Взаимодействие при нажатии на кнопку "Удалить"
         */
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var row = (DepartmentReader)dataCards.SelectedItem;
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
                departments = context.DepartmentReader.ToList();
                dataCards.ItemsSource = departments;
            }
        }
        /*
         * Взаимодействие при нажатии на кнопку "Изменить пользователя"
         */
        private void btnEditReader_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new EditReaderPage(context, reader));
        }
    }
}
