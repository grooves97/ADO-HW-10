using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicGroup.Models;

namespace MusicGroup.DataAcces
{
    public class DataContextServices
    {
        public void AddGroup(MusicCrew musicGroup)
        {
            using (var context = new DataContext())
            {
                context.MusicCrews.Add(musicGroup);
                context.SaveChanges();
            }
        }
        public void AddSong(Song song)
        {
            using (var context = new DataContext())
            {
                context.Songs.Add(song);
                context.SaveChanges();
            }
        }

        public List<MusicCrew> GetMusicGroups()
        {
            using (var context = new DataContext())
            {
                return context.MusicCrews.ToList();
            }
        }

        public List<MusicCrew> GetSortedMusicGroups()
        {
            using (var context = new DataContext())
            {
                return context.MusicCrews.OrderBy(mus => mus.Rating).ToList();
            }
        }

        public List<MusicCrew> GetDescendSortedMusicGroups()
        {
            using (var context = new DataContext())
            {
                return context.MusicCrews.OrderByDescending(mus => mus.Rating).ToList();
            }
        }

        public List<Song> GetSongs()
        {
            using (var context = new DataContext())
            {
                return context.Songs.ToList();
            }
        }
        public MusicCrew GetMusicGroupByGroupName(string groupName)
        {
            using (var context = new DataContext())
            {
                return context.MusicCrews.FirstOrDefault(msGr => msGr.Name == groupName);
            }
        }
        public MusicCrew GetMusicGroupBySong(string songName)
        {
            using (var context = new DataContext())
            {
                return context.Songs.FirstOrDefault(song => song.Name == songName).MusicCrew;
            }
        }
    }
}
