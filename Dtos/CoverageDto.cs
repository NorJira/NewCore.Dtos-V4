using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewCore.Dtos
{
    public record CoverageDto
    {
        [Key]
        public int cvgRef { get; set; }
        [Required]
        [StringLength(15)]
        public string polId { get; set; }
        [Required]
        [StringLength(3)]
        public string cvgNo { get; set; }
        [Required]
        [StringLength(5)]
        public string cvgStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime cvgCommDt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime cvgExpryDate { get; set; }
        [Required]
        [StringLength(15)]
        public string customerId { get; set; }
        [Required]
        [StringLength(15)]
        public string planId { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal cvgFaceAmt { get; set; }
        [Column(TypeName = "decimal(14, 2)")]
        public decimal cvgPremAmt { get; set; }     
    }
}
