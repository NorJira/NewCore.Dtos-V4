using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewCore.Dtos
{
    public record PolicyDto
    {
        [Key]
        public int polRef { get; set; }
        [Required]
        [StringLength(15)]
        public string polId { get; set; }
        [Required]
        [StringLength(5)]
        public string polStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime polCommDt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime polExpryDate { get; set; }
        [Required]
        [StringLength(15)]
        public string customerId { get; set; }
        [Required]
        [StringLength(15)]
        public string planId { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal polFaceAmt { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal polPremAmt { get; set; }
    }

    public record PolIdDto
    {
        [Required]
        [StringLength(15)]
        public string polId { get; set; }
    }
}
