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

namespace LibraryRegistrationSystem.Pages.BranchesPages
{
    /// <summary>
    /// Логика взаимодействия для EditBranchPage.xaml
    /// </summary>
    public partial class EditBranchPage : Page
    {
        CLS_Entities context = new CLS_Entities();
        Branch branch;
        public EditBranchPage(CLS_Entities context, Branch branch)
        {
            InitializeComponent();
            this.context = context;
            this.branch = branch;
            this.DataContext = branch;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new BranchInfoPage(branch));
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные сохранены успешно");
            context.SaveChanges();
            FrameManager.MainFrame.Navigate(new BranchInfoPage(branch));
        }
    }
}
