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
    /// Логика взаимодействия для UserControlMenuItem.xaml
    /// </summary>
    public partial class UserControlMenuItem : UserControl
    {
        /*
         * Конструктор при создании экземпляра объекта
         */
        public UserControlMenuItem(ItemMenu itemMenu)
        {
            InitializeComponent();
            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;
            this.DataContext = itemMenu;
        }
        /*
         *  Действие при нажатии на элемент меню
         */
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ListView)sender).SelectedItem != null)
            {
                FrameManager.MainFrame.Navigate(((SubItem)((ListView)sender).SelectedItem).Frame);
                ((ListView)sender).UnselectAll();
            }
        }
    }
}
