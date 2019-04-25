using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGroup.Models
{
    public class Song : Entity
    {
        public string Name { get; set; }
        public virtual Guid MusicCrewId { get; set; }
        public virtual MusicCrew MusicCrew { get; set; }
        public string Text { get; set; }
        public int LenghtInSeconds { get; set; }
    }
}
