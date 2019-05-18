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
            Width = text.Split('\n').Select(s => s.TrimEnd('\r')).Max(s => s.Length);
            Height = text.Count(c => c == '\n');
        }

        public int Height { get; set; }

        public int Width { get; set; }

        public string Text { get; set; }
    }
}