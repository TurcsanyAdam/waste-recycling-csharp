using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteRecycling
{
    public class Dustbin
    {
        public string Color { get; set; }
        public PaperGarbage[] PaperContent = new PaperGarbage[0];
        public PlasticGarbage[] PlasticContent = new PlasticGarbage[0];
        public Garbage[] HouseWasteContent = new Garbage[0];

        public Dustbin(string aColor)
        {
            Color = aColor;

        }

        public void DisplayContents()
        {
            Console.WriteLine(this.Color + "Dustbin");
            Console.WriteLine("House waste content: " + Convert.ToString(this.HouseWasteContent.Length) + "item(s)");
            foreach(Garbage garbage in HouseWasteContent)
            {
                Console.WriteLine(garbage);
            }

            Console.WriteLine("Paper content: " + Convert.ToString(this.PaperContent.Length) + "item(s)");
            foreach (PaperGarbage papergarbage in PaperContent)
            {
                Console.WriteLine(papergarbage);
            }

            Console.WriteLine("Plastic waste content: " + Convert.ToString(this.PlasticContent.Length) + "item(s)");
            foreach (PlasticGarbage plasticgarbage in PlasticContent)
            {
                Console.WriteLine(plasticgarbage);
            }
        }

        public void ThrowOutGarbage(Garbage garbage)
        {
            if((garbage is PlasticGarbage) && ((PlasticGarbage)garbage).Cleaned)
            {
                Array.Resize(ref PlasticContent, PlasticContent.Length + 1);
                PlasticContent[PlasticContent.GetUpperBound(0)] = ((PlasticGarbage)garbage);
            }
            else if((garbage is PlasticGarbage) && !((PlasticGarbage)garbage).Cleaned)
            {
                throw new DustbinContentException();
            }
            else if ((garbage is PaperGarbage) && ((PaperGarbage)garbage).Squeezed)
            {
                Array.Resize(ref PaperContent, PaperContent.Length + 1);
                PaperContent[PaperContent.GetUpperBound(0)] = ((PaperGarbage)garbage);
            }
            else if ((garbage is PaperGarbage) && !((PaperGarbage)garbage).Squeezed)
            {
                throw new DustbinContentException();
            }
            else if (!(garbage is PaperGarbage) && !(garbage is PlasticGarbage))
            {
                Array.Resize(ref HouseWasteContent, HouseWasteContent.Length + 1);
                HouseWasteContent[HouseWasteContent.GetUpperBound(0)] = garbage;
            }
            else
            {
                throw new DustbinContentException();
            }
        }
        public void EmptyContents()
        {
            Array.Clear(PlasticContent, 0, PlasticContent.Length);
            Array.Resize(ref PlasticContent, 0);
            Array.Clear(PaperContent, 0, PaperContent.Length);
            Array.Resize(ref PaperContent, 0);
            Array.Clear(HouseWasteContent, 0, HouseWasteContent.Length);
            Array.Resize(ref HouseWasteContent, 0);
        }
    }



}
