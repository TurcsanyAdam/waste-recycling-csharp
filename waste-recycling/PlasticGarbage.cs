namespace WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public bool Cleaned { get; set; }

        public PlasticGarbage(string aName, bool aCleaned) : base(aName)
        {
            Name = aName;
            Cleaned = aCleaned;
        }

        public void Clean()
        {
            this.Cleaned = true;
        }
    }
}
