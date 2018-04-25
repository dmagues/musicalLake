using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicalLakeLibrary
{
    public class FirstSong : Song
    {
        public FirstSong(List<IAnimal> animals) : base(animals)
        {
            Create();
        }

        protected sealed override void Create()
        {
            if(Animals==null) throw new ArgumentException();

            Melody = new List<Note>
            {
                new Note(Animals[(int) LittleAnimals.Frog], 1),
                new Note(Animals[(int) LittleAnimals.Dragonfly], 1),
                new Note(Animals[(int) LittleAnimals.Criket], 1),
                new Note(Animals[(int) LittleAnimals.Frog], 3)
            };

        }
        

        
    }
}