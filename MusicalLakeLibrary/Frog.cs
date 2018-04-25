using System.Collections.Generic;

namespace MusicalLakeLibrary
{
    public class Frog : Animal
    {
        public Frog()
        {
            Sounds = new Dictionary<byte, string> {{1, "brr"}, {2, "birip"}, {3, "brrah"}, {4, "croac"}};
        }
        
    }
}