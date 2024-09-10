using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_Aggregate
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] // Example limit
        public string LocationName { get; set; }

        [MaxLength(250)]
        public string LocationAddress { get; set; }

        [MaxLength(50)]
        public string LocationCity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Cost must be a positive value.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cost { get; set; } // Changed to decimal for currency handling

        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be greater than 0.")]
        public int Capacity { get; set; }

        public bool IsBooked { get; set; } = false; // Default value
    }
}
