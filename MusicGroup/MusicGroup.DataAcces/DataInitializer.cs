using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MusicGroup.Models;

namespace MusicGroup.DataAcces
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        private List<Song> songs;
        private List<MusicCrew> musicCrew;

        protected override void Seed(DataContext context)
        {
            musicCrew = new List<MusicCrew>
            {
                new MusicCrew
                {
                    Name="Post Malone",
                    Rating = 5
                },

                new MusicCrew
                {
                    Name="Travis Scott",
                    Rating = 10
                },

                new MusicCrew
                {
                    Name = "XXXTentacion",
                    Rating = 1
                }
            };

            songs = new List<Song>
            {
                new Song
                {
                    Name = "Rockstar",
                    LenghtInSeconds = 220,
                    MusicCrewId = musicCrew[0].Id,
                    Text = "Ayy, I've been fuckin' hoes and poppin' pillies"
                },

                new Song
                {
                    Name="Sloppy Toppy",
                    LenghtInSeconds = 500,
                    MusicCrewId = musicCrew[1].Id,
                    Text = "She see me pull up in that 'Rari"
                },

                new Song
                {
                    Name="SAD!",
                    LenghtInSeconds = 170,
                    MusicCrewId=musicCrew[2].Id,
                    Text="Who am I? Someone that's afraid to let go, uh"
                }
            };

            musicCrew[0].Songs.Add(songs[0]);
            musicCrew[1].Songs.Add(songs[1]);
            musicCrew[2].Songs.Add(songs[2]);

            context.MusicCrews.AddRange(musicCrew);
            context.Songs.AddRange(songs);
            base.Seed(context);
        }
    }
}
