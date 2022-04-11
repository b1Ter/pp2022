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
    /// Логика взаимодействия для EditReaderPage.xaml
    /// </summary>
    public partial class EditReaderPage : Page
    {
        CLS_Entities context;
        Reader reader;
        public EditReaderPage(CLS_Entities context, Reader reader)
        {
            InitializeComponent();
            this.context = context;
            this.reader = reader;
            this.DataContext = reader;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new ReadersPage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!reader.RegistrationDate.HasValue)
                reader.RegistrationDate = DateTime.Now;
            MessageBox.Show("Данные сохранены");
            context.SaveChanges();
            FrameManager.MainFrame.Navigate(new ReaderInfoPage(reader));
        }
    }
}
