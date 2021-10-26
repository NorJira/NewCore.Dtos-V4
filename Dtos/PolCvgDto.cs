using System.Collections.Generic;

namespace NewCore.Dtos
{
    public record PolCvgDto
    {
        public PolicyDto polInfo { get; set; }
        public IEnumerable<CoverageDto> cvgsInfo { get; set; }
    }
}
