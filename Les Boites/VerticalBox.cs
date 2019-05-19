using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les_Boites
{
    public class VerticalBox : IBox
    {
        public Frame frame = new Frame();

        public Box topBox = new Box();
        public Box buttomBox = new Box();

        public VerticalBox(Box box1, Box box2)
        {
            box1.CopyIn(ref this.topBox);
            box2.CopyIn(ref this.buttomBox);

            Height = topBox.Height + 1 + buttomBox.Height;

            if (topBox.Width > buttomBox.Width)
            {
                Width = topBox.Width;
                this.buttomBox.ResizeTextLength(Width);
            }
            else
            {
                Width = buttomBox.Width;
                this.topBox.ResizeTextLength(Width);
            }

            frame.SetTopBottom(Width);

            Text = SetVerticalBoxText();
        }

        public string[] SetVerticalBoxText()
        {
            List<string> centerText = new List<string>();
            centerText.AddRange(topBox.Text.ToList());
            centerText.Add(new string('-', Width));
            centerText.AddRange(buttomBox.Text.ToList());

            centerText = centerText.Select(s => "|" + s + "|").ToList();

            return string.Join("\n", centerText.ToArray());
        }
    }
}