//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EVACart.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        public Staff()
        {
            this.Departments = new HashSet<Department>();
        }
    
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime D_O_B_ { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int DepartmentID { get; set; }
        public bool IsActive { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string UserID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> DateOfSeparation { get; set; }
    
        public virtual ICollection<Department> Departments { get; set; }
        public virtual Department Department { get; set; }
    }
}
