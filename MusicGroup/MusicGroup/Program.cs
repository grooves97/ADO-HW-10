using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicGroup.DataAcces;
using MusicGroup.Models;

namespace MusicGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicCrew musicCrew = new MusicCrew();

            DataContextServices dataContextUseServices = new DataContextServices();

            List<MusicCrew> musicGroups = dataContextUseServices.GetDescendSortedMusicGroups();

            foreach (var group in musicGroups)
            {
                Console.WriteLine(group.Name);
            }

            Console.ReadLine();
        }
    }
}
