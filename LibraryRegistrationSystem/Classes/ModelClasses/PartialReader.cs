using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRegistrationSystem
{
    public partial class Reader
    {
        public String hasNote
        {
            get 
            {
                if (!String.IsNullOrEmpty(this.Notes))
                    return "!";
                else return "";
            }
        }

    }
}
