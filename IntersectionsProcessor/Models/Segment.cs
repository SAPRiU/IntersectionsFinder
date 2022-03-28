using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntersectionsProcessor.Models
{
    [Table("Segments")]
    public partial class SegmentDBEntity
    {
        public int Id { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public int SetId { get; set; }
        public bool IsSplitted { get; set; }

        public virtual Set Set { get; set; } = null!;
    }
}
