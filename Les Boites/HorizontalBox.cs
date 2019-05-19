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

            Width = leftBox.Width + rightBox.Width + 1;

            

            if (leftBox.Height > rightBox.Height)
            {
                Height = leftBox.Height;
                this.rightBox.ResizeTextHeight(Height);
            }
            else {
                Height = rightBox.Height;
                this.leftBox.ResizeTextHeight(Height);
            }

            frame.SetTopBottom(Width);

        }


    }
}