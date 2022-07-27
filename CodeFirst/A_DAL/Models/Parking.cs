using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.A_DAL.Models
{
    internal class Parking
    {
        [Key]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        [Column("Vị trí")]
        public string Location { get; set; }
        [Column("Diện tích")]
        [Required]
        public double Area { get; set; }
        [Column("Sức chứa")]
        [Required]
        public int Capacity { get; set; }
        [Column("Chủ sở hữu",TypeName = "nvarchar(100)")]
        [Required]
        public string? Owner { get; set; }
        public DateTime Establish { get; set; }
        public List<Vehicle> Vehicles { get; set; }

    }
}
