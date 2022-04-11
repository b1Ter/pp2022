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
    /// Логика взаимодействия для ReadersPage.xaml
    /// </summary>
    public partial class ReadersPage : Page
    {
        CLS_Entities context = new CLS_Entities();
        List<Reader> readers;
        public ReadersPage()
        {
            InitializeComponent();
            readers = context.Reader.ToList();
            dataReaders.ItemsSource = readers.ToList();
        }
        public void Filtering()
        {
            readers = context.Reader.ToList();
            if (txtName.Text != null || txtName.Text != "")
                readers = readers.Where(x => x.FullName.ToLower().Contains(txtName.Text.ToLower())).ToList();
            if (txtYear.Text != null || txtYear.Text != "")
                readers = readers.Where(x => x.Birthday.HasValue && x.Birthday.Value.Year.ToString() == txtYear.Text.ToString()).ToList();
            dataReaders.ItemsSource = readers.ToList();
        }

        private void btnLookIn_Click(object sender, RoutedEventArgs e)
        {
            Reader reader = dataReaders.SelectedItem as Reader;
            FrameManager.MainFrame.Navigate(new ReaderInfoPage(reader));
        }

        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            Reader reader = new Reader();
            context.Reader.Add(reader);
            FrameManager.MainFrame.Navigate(new EditReaderPage(context, reader));
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var row = (Reader)dataReaders.SelectedItem;
            if (row == null)
            {
                MessageBox.Show("Читатели не выбраны",
                    "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить выбранных читателей?",
                "Удаление", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                context.Reader.Remove(row);
                context.SaveChanges();
                readers = context.Reader.ToList();
                dataReaders.ItemsSource = readers.ToList();
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filtering();
        }

        private void txtYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filtering();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button btnReader = (Button)sender;
            Reader department = btnReader.DataContext as Reader;
            FrameManager.MainFrame.Navigate(new EditReaderPage(context, department));
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            dataReaders.ItemsSource = context.Reader.ToList();
        }
    }
}
