//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_user()
        {
            this.Tbl_Wallet = new HashSet<Tbl_Wallet>();
        }
    
        public System.Guid UserId { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string EmailConfirmationCode { get; set; }
        public string MobileConfirmationCode { get; set; }
        public string NationalCode { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public System.DateTime EmailConfirmationDatetime { get; set; }
        public System.DateTime MobileConfirmationDatetime { get; set; }
        public System.DateTime EmailConfirmationDatetimeRequest { get; set; }
        public System.DateTime MobileConfirmationDatetimeRequest { get; set; }
        public bool IsDisable { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Wallet> Tbl_Wallet { get; set; }
    }
}