//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShopping.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.orders = new HashSet<order>();
            this.shopOwners = new HashSet<shopOwner>();
        }
    
        public string userID { get; set; }
        [Required(ErrorMessage = "Required"), MaxLength(30, ErrorMessage = "Max length is 30")]
        public string name { get; set; }
        [Required(ErrorMessage = "Required"), MaxLength(30, ErrorMessage = "Max length is 30"), EmailAddress(ErrorMessage = "Please enter correct email address")]
        public string email { get; set; }
        [Required(ErrorMessage = "Required"), MaxLength(15, ErrorMessage = "Max length is 15")]
        public string contactNo { get; set; }
        public string role { get; set; }
        [Required(ErrorMessage = "Required"), MinLength(3, ErrorMessage = "Min length is 3"), MaxLength(10, ErrorMessage = "Max length is 10")]
        public string password { get; set; }
    
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shopOwner> shopOwners { get; set; }
    }
}
