using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Les_Boites
{
    public abstract class IBox
    {
        public IBox() { Height = 0; Width = 0; }

        public IBox(string text)
        {
            Text = text;
            Width = text.Length;
            Height = text.Count(c => c == '\n') + 1;
        }

        public int Height { get; set; }

        public int Width { get; set; }

        public string[] Text { get; set; }
    }
}