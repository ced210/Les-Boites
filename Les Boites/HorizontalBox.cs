using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les_Boites
{
    public class HorizontalBox : IBox
    {

        public Frame frame = new Frame();

        public Box leftBox = new Box();
        public Box rightBox = new Box();

        public HorizontalBox(Box box1, Box box2) 
        {
            box1.CopyIn(ref leftBox);
            box2.CopyIn(ref rightBox);

            Width = box1.Width + box2.Width + 1;

            if (box1.Height > box2.Height)
            {
                Height = box1.Height;
                this.rightBox.ResizeTextHeight(box1.Height);
            }
            else {
                Height = box2.Height;
                this.leftBox.ResizeTextHeight(box1.Height);
            }

            frame.SetTopBottom(Width);
        }

    }
}