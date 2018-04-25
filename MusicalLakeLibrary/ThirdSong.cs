using System;
using System.Collections.Generic;

namespace MusicalLakeLibrary
{
    public class ThirdSong : Song
    {
        public ThirdSong(List<IAnimal> animals): base(animals)
        {
            Create();
        }

        protected sealed override void Create()
        {
            if (Animals == null) throw new ArgumentException();

            Melody = new List<Note>
            {
                new Note(Animals[(int) LittleAnimals.Criket], 3),
                new Note(Animals[(int) LittleAnimals.Dragonfly], 2),
                new Note(Animals[(int) LittleAnimals.Criket], 1),
                new Note(Animals[(int) LittleAnimals.Frog], 3)
            };
        }
    }
}