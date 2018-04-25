namespace MusicalLakeLibrary
{
    public class Note
    {
        public IAnimal Animal { get; set; }
        public byte Soundidx { get; set; }

        public Note(IAnimal animal, byte index)
        {
            Animal = animal;
            Soundidx = index;
        }
    }
}