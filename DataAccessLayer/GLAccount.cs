//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class glAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public glAccount()
        {
            this.BankInfomations = new HashSet<BankInfomation>();
            this.fbAccounts = new HashSet<fbAccount>();
            this.glInformations = new HashSet<glInformation>();
            this.StatusTables = new HashSet<StatusTable>();
        }
    
        public int glId { get; set; }
        public string glUsername { get; set; }
        public string glPassword { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankInfomation> BankInfomations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fbAccount> fbAccounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<glInformation> glInformations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StatusTable> StatusTables { get; set; }
    }
}