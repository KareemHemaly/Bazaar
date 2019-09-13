using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BazzarManagment.DAL.Models
{
    public class Product
    {
        [Key]
        [Column("ProductId")]
        public Guid Id { get; set; }
        public string ProdCode { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public string Photo { get; set; }
        public bool HasSize { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastUpated { get; set; }

    }
}
