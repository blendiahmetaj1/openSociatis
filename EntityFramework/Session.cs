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
    
    public partial class Session
    {
        public int ID { get; set; }
        public string Cookie { get; set; }
        public int CitizenID { get; set; }
        public string IP { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public bool RememberMe { get; set; }
    
        public virtual Citizen Citizen { get; set; }
    }
}
