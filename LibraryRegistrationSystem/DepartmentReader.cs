//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryRegistrationSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class DepartmentReader
    {
        public int Department { get; set; }
        public int Reader { get; set; }
        public int Year { get; set; }
        public int LibraryCard { get; set; }
        public int ID { get; set; }
    
        public virtual Department Department1 { get; set; }
        public virtual Reader Reader1 { get; set; }
    }
}