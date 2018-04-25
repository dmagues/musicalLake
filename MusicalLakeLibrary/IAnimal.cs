using System.Collections.Generic;

namespace MusicalLakeLibrary
{
    public interface IAnimal
    {
        Dictionary<byte,string> Sounds { get; set; }
        string SoundAt(byte key);
    }
}