using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Les_Boites
{
    public class HorizontalBox : IBox
    {

        public Frame frame = new Frame();

        public Box box1 = new Box();
        public Box box2 = new Box();

        public HorizontalBox(Box box1, Box box2) 
        {
            Width = box1.Width + box2.Width + 1;

            if (box1.Height > box2.Height)
            {
                Height = box1.Height;
                box2.ResizeTextLength(box1.Height);
            }
            else {
                Height = box2.Height;
                box1.ResizeTextLength(box1.Height);
            }
            this.box1 = box1;
            this.box2 = box2;
            frame.SetTopBottom(Width);
        }

    }
}