//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobContract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobContract()
        {
            this.CompanyEmployees = new HashSet<CompanyEmployee>();
        }
    
        public int ID { get; set; }
        public decimal MinSalary { get; set; }
        public int MinHP { get; set; }
        public int Length { get; set; }
        public int SigneeID { get; set; }
        public bool AbusedByEmployee { get; set; }
        public bool AbusedByCompany { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyEmployee> CompanyEmployees { get; set; }
        public virtual Entity Entity { get; set; }
    }
}