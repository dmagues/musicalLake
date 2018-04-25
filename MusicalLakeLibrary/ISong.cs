using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MusicalLakeLibrary
{
    public interface ISong
    {
        List<IAnimal> Animals { get; set; }
        bool Contains(string sound);
        List<Note> MelodyFrom(string sound);

    }
}