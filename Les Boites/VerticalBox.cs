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
        }
    }
}