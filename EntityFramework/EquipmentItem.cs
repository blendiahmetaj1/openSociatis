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
    
    public partial class EquipmentItem
    {
        public int ID { get; set; }
        public int EquipmentID { get; set; }
        public int ProductID { get; set; }
        public int Quality { get; set; }
        public int Amount { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
