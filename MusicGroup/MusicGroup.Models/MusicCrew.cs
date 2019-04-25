using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGroup.Models
{
    public class MusicCrew : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
        public int Rating { get; set; }
    }
}
