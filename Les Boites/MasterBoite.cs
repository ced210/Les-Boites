using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Boites
{
    public class MasterBoite
    {
        public int Height { get; set; }
        public int Width {get; set;}
        public List<string> Text { get; set; }

        public MasterBoite()
        {
            Height = 0;
            Width = 0;
            Text = new List<string>();
        }

        public MasterBoite(string text)
        {
            Text = text.Split('\n').Select(s => s.TrimEnd('\r')).ToList();
            Height = text.Count(c => c == '\n') + 1;
            Width = Text.Max(s => s.Length);

            Text = ReseizeWidth(Text, Width);
        }

        protected List<string> ReseizeWidth(List<string> text, int width) => text.Select(s => s.PadRight(width)).ToList();

        public override string ToString() => string.Join("\n", Text.ToArray());

        public void Copy(ref Boite otherBox)
        {
            Height = otherBox.Height;
            Width = otherBox.Width;
            Text = otherBox.Text;
        }

    }
}
