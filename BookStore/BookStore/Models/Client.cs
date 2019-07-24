namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store.Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Sale = new HashSet<Sale>();
        }

        public short Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Nombre(s)")]
        public string Name { get; set; }

        [StringLength(100)]
        [DisplayName("Apellido(s)")]
        public string Last_Name { get; set; }

        public string Full_Name
        {
            get { return string.Format("{0} {1}", Name, Last_Name); }
        }

        [StringLength(20)]
        [DisplayName("Teléfono")]
        public string Telephone { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Dirección envío")]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
