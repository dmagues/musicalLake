using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace MusicalLakeLibrary
{
    public abstract class Song : ISong
    {
        public List<IAnimal> Animals { get; set; }
        protected abstract void Create();
        protected List<Note> Melody { get; set; }

        protected Song(List<IAnimal> animals)
        {
            Animals = animals;
        }

        public bool Contains(string sound)
        {
            return (from m in Melody where m.Animal.Sounds[m.Soundidx] == sound select m).Any();
        }
        public List<Note> MelodyFrom(string sound)
        {
            var index = Melody.FindIndex(n => n.Animal.Sounds[n.Soundidx] == sound) + 1;
            return index == Melody.Count ? null : Melody.GetRange(index, Melody.Count - index);
        }
    }
}