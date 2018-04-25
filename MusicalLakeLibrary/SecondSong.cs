using System;
using System.Collections.Generic;

namespace MusicalLakeLibrary
{
    public class SecondSong : Song
    {

        public SecondSong(List<IAnimal> animals) : base(animals)
            => Create();

        protected sealed override void Create()
        {
            if (Animals == null) throw new ArgumentException();

            Melody = new List<Note>
            {
                new Note(Animals[(int) LittleAnimals.Dragonfly], 3),
                new Note(Animals[(int) LittleAnimals.Frog], 2),
                new Note(Animals[(int) LittleAnimals.Criket], 2),
                new Note(Animals[(int) LittleAnimals.Frog], 4)
            };
        }
    }
}