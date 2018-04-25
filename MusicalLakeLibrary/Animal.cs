using System.Collections.Generic;

namespace MusicalLakeLibrary
{
    public class Animal:IAnimal
    {
        public Dictionary<byte, string> Sounds { get; set; }

        public string SoundAt(byte key)
        {
            return Sounds != null ? Sounds[key] : string.Empty;
        }
    }
}