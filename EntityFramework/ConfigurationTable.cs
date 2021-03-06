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
    
    public partial class ConfigurationTable
    {
        public int ID { get; set; }
        public int CurrentDay { get; set; }
        public decimal CompanyCitizenFee { get; set; }
        public decimal CompanyOrganisationFee { get; set; }
        public decimal CompanyCountryFee { get; set; }
        public decimal PartyFoundingFee { get; set; }
        public decimal OrganisationCreationFee { get; set; }
        public decimal NewspaperCreationFee { get; set; }
        public System.DateTime LastDayChange { get; set; }
        public decimal RessistanceWarStartCost { get; set; }
        public decimal RessistanceWarWinCost { get; set; }
        public Nullable<int> GlobalShoutboxChanneID { get; set; }
        public int MinimumMPPLength { get; set; }
        public int MaximumMPPLength { get; set; }
    
        public virtual ShoutboxChannel ShoutboxChannel { get; set; }
    }
}
