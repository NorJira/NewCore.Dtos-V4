using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NewCore.Dtos;

namespace NewCore.Dtos
{
    public record PolCvgDto
    {
        public PolicyDto polInfo { get; set; }
        public IEnumerable<CoverageDto> cvgsInfo { get; set; }
    }
}
