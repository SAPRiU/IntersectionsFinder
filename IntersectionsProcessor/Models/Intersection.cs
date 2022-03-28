using System;
using System.Collections.Generic;

namespace IntersectionsProcessor.Models
{
    public partial class Intersection
    {
        public int Id { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public int SetId { get; set; }

        public virtual Set Set { get; set; } = null!;
    }
}
