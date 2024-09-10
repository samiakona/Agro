using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_Aggregate
{
    public class Booking
    {

        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string VisitingPlace { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Seat must be greater than 0.")]

        public int Seat { get; set; }

        public DateOnly Date { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        [MaxLength(20)]
        public string PostalCode { get; set; }
    }
}
