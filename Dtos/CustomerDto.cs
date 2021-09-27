using System;
using System.ComponentModel.DataAnnotations;
using NewCore.Data.Models;

namespace NewCore.Dtos
{
    public record CustomerDto
    {
        [Key]
        public int customerRef { get; set; }
        [StringLength(15)]
        public string customerId { get; set; }
        [Required]
        [StringLength(50)]
        public string name { get; set; }
        [Required]
        [StringLength(50)]
        public string location { get; set; }
        [Required]
        [StringLength(50)]
        public string email { get; set; }
    }

    public record CusIdDto
    {
        [Required]
        public string customerId { get; set; }
    }
}
