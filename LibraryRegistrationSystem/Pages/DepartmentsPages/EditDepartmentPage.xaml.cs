using LibraryRegistrationSystem.Pages.BranchesPages;
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

namespace LibraryRegistrationSystem.Pages.DepartmentsPages
{
    /// <summary>
    /// Логика взаимодействия для EditDepartmentPage.xaml
    /// </summary>
    public partial class EditDepartmentPage : Page
    {
        CLS_Entities context;
        Department department;
        public EditDepartmentPage(CLS_Entities context, Department department)
        {
            InitializeComponent();
            this.context = context;
            this.department = department;
            listBranches.ItemsSource = context.Branch.ToList();
            this.DataContext = department;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.MainFrame.Navigate(new BranchPage());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (listBranches.SelectedItem != null)
            {
                if (txtName.Text != null)
                {
                    context.SaveChanges();
                    MessageBox.Show("Данные сохранены успешно");
                    FrameManager.MainFrame.Navigate(new BranchInfoPage(department.Branch1));
                }
                else MessageBox.Show("У отдела нет имени!");
            }
            else MessageBox.Show("Не выбран филиал!");

        }
    }
}
