using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Boites
{
    public class Boite
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public List<string> Text { get; set; }


        public Boite()
        {
            Height = 0;
            Width = 0;
            Text = new List<string>();
        }

        public Boite(string text)
        {
            Text = text.Split('\n').Select(s => s.TrimEnd('\r')).ToList();
            Height = text.Count(c => c == '\n') + 1;
            Width = Text.Max(s => s.Length);

            ReseizeWidth();
        }

        public Boite(ComboHorizontal ch)
        {
        }

        public Boite(ComboVertical cv)
        {

        }

        private void ReseizeWidth()
        {
            Text = Text.Select(s => s.PadRight(Width)).ToList();
        }

        public override string ToString() => string.Join("\n", Text.ToArray());

        public void Copy(ref Boite otherBox)
        {
            Height = otherBox.Height;
            Width = otherBox.Width;
            Text = otherBox.Text;
        }

        public static void Display(Boite box)
        {
            Cadre frame = new Cadre(box.Width);

            Console.WriteLine(frame.VerticalFrame);
            box.Text.ForEach(s => Console.WriteLine("|" + s + "|"));
            Console.WriteLine(frame.VerticalFrame);
        }
    }
}
