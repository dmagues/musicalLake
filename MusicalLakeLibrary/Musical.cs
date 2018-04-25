using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace MusicalLakeLibrary
{
    public static class Musical
    {
        
        private static IEnumerable<ISong> Create()
        {
            var animals = new List<IAnimal> {new Frog(), new Dragonfly(), new Criket()};
            return new List<ISong>
            {
                new FirstSong(animals),
                new SecondSong(animals),
                new ThirdSong(animals)
            };
        }

        public static string Play(string sound)
        {
            var muscalSongs = Create();

            var asong = (from s in muscalSongs where s.Contains(sound) select s.MelodyFrom(sound)).FirstOrDefault();

            return asong != null ? string.Join(", ", asong.Select(s => s.Animal.SoundAt(s.Soundidx))) : string.Empty;
        }
    }
}