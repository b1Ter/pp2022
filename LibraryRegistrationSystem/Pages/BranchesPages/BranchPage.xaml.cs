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
    /// Логика взаимодействия для BranchPage.xaml
    /// </summary>
    public partial class BranchPage : Page
    {
        CLS_Entities context;
        List<Branch> branches;
        public BranchPage()
        {
            InitializeComponent();
            context = new CLS_Entities();
            branches = context.Branch.ToList();
            dataBranches.ItemsSource = branches;
        }
        public void Filtering()
        {
            branches = context.Branch.ToList();
            if (txtName.Text != "" || txtName.Text == null)
                branches = branches.Where(x => x.Name.Contains(txtName.Text)).ToList();
            dataBranches.ItemsSource = branches;
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filtering();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Branch reader = btn.DataContext as Branch;
            FrameManager.MainFrame.Navigate(new EditBranchPage(context, reader));
        }
        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            Branch department = new Branch();
            context.Branch.Add(department);
            FrameManager.MainFrame.Navigate(new EditBranchPage(context, department));
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var row = (Branch)dataBranches.SelectedItem;
            if (row == null)
            {
                MessageBox.Show("Филиалы не выбраны",
                    "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить выбранные филиалы?",
                "Удаление", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                context.Branch.Remove(row);
                context.SaveChanges();
                branches = context.Branch.ToList();
                Filtering();
            }
        }

        private void btnDepartments_Click_1(object sender, RoutedEventArgs e)
        {
            Branch row = (Branch)dataBranches.SelectedItem;
            if (row == null)
            {
                MessageBox.Show("Филиал не выбран",
                    "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            FrameManager.MainFrame.Navigate(new BranchInfoPage(row));
        }
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtName.Text = null;
            branches = context.Branch.ToList();
            dataBranches.ItemsSource = branches;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            branches = context.Branch.ToList();
            dataBranches.ItemsSource = branches;
        }
    }
}
