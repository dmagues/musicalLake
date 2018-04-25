using System.Collections.Generic;

namespace MusicalLakeLibrary
{
    public class Criket : Animal
    {
        public Criket()
        {
            Sounds = new Dictionary<byte, string> { { 1, "cric-cric" }, { 2, "trri-trri" }, { 3, "bri-bri" } };
        }
    }
}