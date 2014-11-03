//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestMVC.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class hEmployee
    {
        public hEmployee()
        {
            this.hEmployeeAddresses = new HashSet<hEmployeeAddress>();
        }
    
        public int EmployeeID { get; set; }
        public string EmployeeNumber { get; set; }
        public string SSN { get; set; }
        public string Badge { get; set; }
        public Nullable<int> EmployerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public Nullable<int> Salutation { get; set; }
        public Nullable<int> Status { get; set; }
        public string NickName { get; set; }
        public Nullable<int> PayGroupID { get; set; }
        public Nullable<int> TimeGroupID { get; set; }
        public Nullable<int> WorkCodeCountryID { get; set; }
        public Nullable<int> TimeSheetWorkCodeID { get; set; }
        public string CustomTimeRule { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> LastHireDate { get; set; }
        public Nullable<System.DateTime> AdjSeniorityDate { get; set; }
        public Nullable<System.DateTime> OriginalHireDate { get; set; }
        public Nullable<int> MaritialStatus { get; set; }
        public Nullable<int> SystemValueCodeID { get; set; }
        public string Email { get; set; }
        public Nullable<int> EthnicOrigin { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<int> Disability { get; set; }
        public Nullable<int> Smoker { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<System.DateTime> ChangeDate { get; set; }
        public string ReCalculate { get; set; }
        public Nullable<int> Exempt { get; set; }
        [Range(0,50)]
        public Nullable<decimal> SeniorityHours { get; set; }
    
        public virtual ICollection<hEmployeeAddress> hEmployeeAddresses { get; set; }
    }
}
