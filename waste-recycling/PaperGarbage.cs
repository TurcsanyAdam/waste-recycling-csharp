namespace WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        public bool Squeezed { get; set; }

        public PaperGarbage (string aName, bool aSqueezed) : base(aName)
        {
            Name = aName;
            Squeezed = aSqueezed;
        }

        public void Squeeze()
        {
            this.Squeezed = true;
        }
    }

}
