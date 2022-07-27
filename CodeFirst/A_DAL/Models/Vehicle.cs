using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.A_DAL.Models
{
    internal class Vehicle
    {
        [Key]
        [Column("Biển số xe",TypeName="varchar(10)")]
        public string VCP { get; set; }
        [Column("Loại xe", TypeName = "nvarchar(50)")]
        [Required]
        public string Type { get; set; }
        [Column("Tên xe", TypeName = "nvarchar(50)")]
        [Required]
        public string Name { get; set; }
        [Column("Căn cước công dân", TypeName = "varchar(12)")]
        [Required]
        public string OwnerIdCard { get; set; }
        [Column("Hình thức gửi xe", TypeName = "nvarchar(50)")]
        [Required]
        public string ParkingMethod { get; set; }
        public string ParkingName { get; set; }
    }
}
