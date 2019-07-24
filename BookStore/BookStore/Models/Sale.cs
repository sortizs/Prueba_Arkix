namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store.Sale")]
    public partial class Sale
    {
        public short Id { get; set; }

        [DisplayName("Cliente")]
        public short ClientId { get; set; }

        [DisplayName("Libro")]
        public short BookId { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Fecha Venta")]
        public DateTime Sale_Date { get; set; }

        public string SaleDate
        {
            get { return string.Format("{0:dd/MM/yyyy}", Sale_Date); }
        }

        [DisplayName("Valor Venta")]
        public int Sale_Value { get; set; }

        public string SaleValue
        {
            get { return string.Format("{0:C}", Sale_Value); }
        }

        [Required]
        [StringLength(100)]
        [DisplayName("Vendedor")]
        public string Salesman { get; set; }

        public virtual Book Book { get; set; }

        public virtual Client Client { get; set; }
    }
}
