using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LibraryRegistrationSystem.ViewModel
{
    public class SubItem
    {
        /*
         * Конструкторы, инициализирующие экземпляр данными
         */
        public SubItem(string name, Page screen)
        {
            Name = name;
            Frame = screen;
        }
        /*
         * Данные экземпляра меню
         */
        public string Name { get; private set; }
        public Page Frame { get; private set; }
    }
}
