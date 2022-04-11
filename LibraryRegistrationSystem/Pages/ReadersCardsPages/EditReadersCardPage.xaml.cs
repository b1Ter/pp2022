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
    /// Логика взаимодействия для EditReadersCardPage.xaml
    /// </summary>
    public partial class EditReadersCardPage : Page
    {
        DepartmentReader reader;
        CLS_Entities context;
        public EditReadersCardPage(CLS_Entities context, DepartmentReader reader)
        {
            InitializeComponent();
            this.reader = reader;
            this.context = context;
            listReaders.ItemsSource = context.Reader.ToList();
            listDepartments.ItemsSource = context.Department.ToList();
            this.DataContext = reader;
            if (txtYear.Text == "0" || txtYear.Text == null)
            {
                ((DepartmentReader)this.DataContext).Year = DateTime.Now.Year;
                txtYear.Text = DateTime.Now.Year.ToString();
            }
            txtYear.UpdateLayout();
            txtYear.Focus();
        }
        public bool CheckNumberCard()
        {
            if (txtYear.Text != null || txtYear.Text != "" || txtYear.Text != "0")
            {
                if (listReaders.SelectedItem != null)
                {
                    if ((Department)listDepartments.SelectedItem != null)
                    {
                        if ((from x in context.DepartmentReader
                            where x.Department == ((Department)listDepartments.SelectedItem).ID &&
                            x.Year.ToString() == txtYear.Text && x.LibraryCard.ToString() == txtCard.Text
                            orderby x.LibraryCard
                            select x.LibraryCard).Any())
                        {
                            MessageBox.Show("Пользователь с таким номером в отделе уже сущестует!");
                            return false;
                        }
                        if (context.DepartmentReader.Where(x => x.Department == ((Department)listDepartments.SelectedItem).ID 
                                && x.Reader == ((Reader)listReaders.SelectedItem).ID && x.Year.ToString() == txtYear.Text).Any())
                        {
                            MessageBox.Show("Пользователь уже был зарегистрирован в этом отделе в текущем году!");
                            return false;
                        }
                        if (txtCard.Text == "0" || txtCard == null)
                        {
                            MessageBox.Show("Номер карточки не заполнен!");
                            return false;
                        }
                    }
                    else
                        MessageBox.Show("Отдел не выбран!");
                }
                else
                    MessageBox.Show("Читатель не выбран!");
            }
            else
                MessageBox.Show("Год не выбран!");
            return true; ;
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new ReadersCardsPage());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (CheckNumberCard())
            {
                context.SaveChanges();
                MessageBox.Show("Данные сохранены");
                FrameManager.MainFrame.Navigate(new ReadersCardsPage());
            }
            else
                MessageBox.Show("Данные не были сохранены");
        }

        /*
         * Генерация номера читательского билета
         */
        private void btnGen_Click(object sender, RoutedEventArgs e)
        {
            if (listReaders.SelectedItem != null)
            {
                if ((Department)listDepartments.SelectedItem != null)
                {
                    if ((from x in context.DepartmentReader
                         where x.Department == ((Department)listDepartments.SelectedItem).ID &&
                         x.Year.ToString() == txtYear.Text
                         select x.LibraryCard).Any())
                    {
                        int number = (from x in context.DepartmentReader
                                      where x.Department == ((Department)listDepartments.SelectedItem).ID &&
                                      x.Year.ToString() == txtYear.Text
                                      select x.LibraryCard).AsEnumerable().LastOrDefault();
                        ((DepartmentReader)(this.DataContext)).LibraryCard = number + 1;
                        txtCard.Text = (number + 1).ToString();
                    }
                    else
                    {
                        ((DepartmentReader)(this.DataContext)).LibraryCard = 1;
                        txtCard.Text = "1";
                    }
                }
                else
                    MessageBox.Show("Отдел не выбран!");
            }
            else
                MessageBox.Show("Читатель не выбран!");
        }
    }
}
