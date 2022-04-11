using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRegistrationSystem
{
    public partial class Department
    {
        public String FullName
        {
            get
            {
                return this.Name + " | " + this.Branch1.Name;
            }
        }

    }
}
