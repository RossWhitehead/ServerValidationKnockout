using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerValidationKnockout.Models
{
    public class ProductCategory
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProductCategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Navigational Properties
        public virtual ICollection<Product> Products { get; set; }
    }
}