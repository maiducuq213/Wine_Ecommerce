//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wine_e_commerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class my_Funtion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public my_Funtion()
        {
            this.Authorizes = new HashSet<Authorize>();
        }
    
        public int ID { get; set; }
        public string FunctionName { get; set; }
        public string FunctionCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Authorize> Authorizes { get; set; }
    }
}
