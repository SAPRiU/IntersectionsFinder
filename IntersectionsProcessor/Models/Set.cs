using System;
using System.Collections.Generic;

namespace IntersectionsProcessor.Models
{
    public partial class Set
    {
        public Set()
        {
            Intersections = new HashSet<Intersection>();
            Segments = new HashSet<SegmentDBEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Intersection> Intersections { get; set; }
        public virtual ICollection<SegmentDBEntity> Segments { get; set; }
    }
}
