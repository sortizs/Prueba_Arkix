namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store.Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Sale = new HashSet<Sale>();
        }

        public short Id { get; set; }

        [Required]
        [StringLength(200)]
        [DisplayName("Título")]
        public string Title { get; set; }

        [DisplayName("Autor")]
        public short AuthorId { get; set; }

        [StringLength(200)]
        [DisplayName("Editorial")]
        public string Editor { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Fecha Publicación")]
        public DateTime Pub_Date { get; set; }

        public string PubDate
        {
            get { return string.Format("{0:dd/MM/yyyy}", Pub_Date); }
        }

        [DisplayName("Edición")]
        public short Edition { get; set; }

        [DisplayName("Precio")]
        public int Price { get; set; }

        public string Value
        {
            get { return string.Format("{0:C}", Price); }
        }

        [DisplayName("Valor Minorista")]
        public int Retail_Price { get; set; }

        public string RetailPrice
        {
            get { return string.Format("{0:C}", Retail_Price); }
        }

        [DisplayName("Estado")]
        public short Status { get; set; }

        public virtual Author Author { get; set; }

        public virtual Status Status1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
