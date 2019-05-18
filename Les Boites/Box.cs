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

        public string[] Text { get; set; }

        public void ResizeTextLength(int max)
        {
            var newText = Text.ToList();

            for (int i = Text.Length; i < max; i++)
            {
                newText.Add("");
            }
            Text = newText.ToArray();
        }

        public static void Display(TextWriter outStream, params Box[] boxes)
        {
            Console.WriteLine($"{boxes.Length} nombre boite");
            Console.WriteLine($"Total Height: {boxes.Sum(x => x.Height)} \n Total Width: {boxes.Sum(x => x.Width)}");
            
            //Console.WriteLine(boxes[].frame.TopBottom);
            //for (int i = 0; i < boxes[].Height; ++i)
            //{
            //    Console.WriteLine(boxes[].frame.setCenter(boxes[].Text[i], boxes[].Width));
            //}
            //Console.WriteLine(boxes[].frame.TopBottom);
        }
        public static void Display(Box box)
        {
            Console.WriteLine(box.frame.TopBottom);
            for (int i = 0; i < box.Height; ++i)
            {
                Console.WriteLine(box.frame.SetCenter(box.Text[i],box.Width));
            }
            Console.WriteLine(box.frame.TopBottom);
        }

        public static void Display(HorizontalBox box)
        {
            Console.WriteLine(box.frame.TopBottom);
            for (int i = 0; i < box.Height; ++i)
            {
                Console.WriteLine(box.frame.SetCenterCombo(box.box1, box.box2, i));
            }
            Console.WriteLine(box.frame.TopBottom);
        }

        public Frame frame = new Frame();


        public Box() { Height = 0; Width = 0; }

        public Box(string text)
        {
            Text = text.Split('\n').Select(s => s.TrimEnd('\r')).ToArray();
            Width = Text.Max(s => s.Length);
            Height = text.Count(c => c == '\n') + 1;

            frame.SetTopBottom(Width);
        }
        

    }
}
