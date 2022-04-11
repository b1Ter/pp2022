using LibraryRegistrationSystem.Pages.DepartmentsPages;
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
    /// Логика взаимодействия для BranchInfoPage.xaml
    /// </summary>
    public partial class BranchInfoPage : Page
    {
        CLS_Entities context = new CLS_Entities();
        Branch branch;
        public BranchInfoPage(Branch branch)
        {
            InitializeComponent();
            this.branch = branch;
            this.DataContext = branch;
            dataDepartments.ItemsSource = context.Department.Where(x => x.Branch.ToString() == branch.ID.ToString()).ToList();
        }

        private void btnEditBranch_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Branch reader = btn.DataContext as Branch;
            FrameManager.MainFrame.Navigate(new EditBranchPage(context, reader));
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Department department = btn.DataContext as Department;
            FrameManager.MainFrame.Navigate(new EditDepartmentPage(context, department));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Department department = new Department();
            context.Department.Add(department);
            FrameManager.MainFrame.Navigate(new EditDepartmentPage(context, department));
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var row = (Department)dataDepartments.SelectedItem;
            if (row == null)
            {
                MessageBox.Show("Отделы не выбраны",
                    "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить выбранные отделы?",
                "Удаление", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                context.Department.Remove(row);
                context.SaveChanges();
                dataDepartments.ItemsSource = context.Department.Where(x => x.Branch.ToString() == branch.ID.ToString()).ToList();
            }
        }
    }
}
