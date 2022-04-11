using LibraryRegistrationSystem.Pages;
using LibraryRegistrationSystem.Pages.BranchesPages;
using LibraryRegistrationSystem.Pages.ReadersCardsPages;
using LibraryRegistrationSystem.Pages.ReadersPages;
using LibraryRegistrationSystem.ViewModel;
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

namespace LibraryRegistrationSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var menuReaders = new List<SubItem>();
            menuReaders.Add(new SubItem("Читательские билеты", new ReadersCardsPage()));
            menuReaders.Add(new SubItem("Читатели", new ReadersPage()));
            var item1 = new ItemMenu("Данные о читателях", menuReaders);

            var menuCompany = new List<SubItem>();
            menuCompany.Add(new SubItem("Филиалы и их отделы", new BranchPage()));
            var item2 = new ItemMenu("Данные организации", menuCompany);

            Menu.Children.Add(new UserControlMenuItem(item1));
            Menu.Children.Add(new UserControlMenuItem(item2));

            FrameManager.MainFrame = MainFrame;
        }
    }
}
