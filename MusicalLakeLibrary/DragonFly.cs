using System.Collections.Generic;

namespace MusicalLakeLibrary
{
    public class Dragonfly : Animal
    {
        public Dragonfly()
        {
            Sounds = new Dictionary<byte, string> { { 1, "fiu" }, { 2, "plop" }, { 3, "pep" } };
        }
    }
}