using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LibraryRegistrationSystem.ViewModel
{
    public class ItemMenu
    {
        /*
         * Конструкторы, инициализирующие экземпляр данными
         */
        public ItemMenu(string header, List<SubItem> subItems)
        {
            Header = header;
            SubItems = subItems;
        }

        public ItemMenu(string header, Page screen)
        {
            Header = header;
            Frame = screen;
        }
        /*
         * Данные экземпляра меню
         */
        public string Header { get; private set; }
        public List<SubItem> SubItems { get; private set; }
        public Page Frame { get; private set; }
    }
}
