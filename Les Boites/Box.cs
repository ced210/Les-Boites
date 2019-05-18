using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Les_Boites
{
    public class Box : Frame
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public string Text { get; set; }

        public static void Display(Stream outStream, params Box[] boxes)
        {
            Console.WriteLine($"{boxes.Length} nombre boite");
            Console.WriteLine($"Total Height: {boxes.Sum(x => x.Height)} \n Total Width: {boxes.Sum(x => x.Width)}");
        }

        public Frame frame = new Frame();


        public Box() { Height = 0; Width = 0; }

        public Box(string text)
        {
            Text = text;
            Width = text.Split('\n').Select(s => s.TrimEnd('\r')).Max(s => s.Length);
            Height = text.Count(c => c == '\n') + 1;

            frame.setTopBottom(Width);
            frame.setCenter(Text, Width);
        }
    }
}
