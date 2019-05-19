using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Boites
{
    public class ComboHorizontal : MasterBoite
    {

        Boite leftBox { get; set; }
        Boite rigthBox { get; set; }



        public ComboHorizontal()
        {

        }

        public ComboHorizontal(Boite _leftBox, Boite _rightBox)
        {
            leftBox = new Boite();
            rigthBox = new Boite();
            leftBox.Copy(ref _leftBox);
            rigthBox.Copy(ref _rightBox);

            Height = Math.Max(leftBox.Height, rigthBox.Height);
            Width = leftBox.Width + 1 + rigthBox.Width;

            Text = CombineHorizontalText();
        }

        private List<string> CombineHorizontalText()
        {
            List<string> lst = new List<string>();

            for (int i = 0; i < Height; i++)
            {
                lst.Add((i >= leftBox.Height ? "".PadRight(leftBox.Width) : leftBox.Text.ToArray()[i])
                    + "|"
                    + (i >= rigthBox.Height ? "".PadRight(rigthBox.Width) : rigthBox.Text.ToArray()[i]));
            }
            return lst;
        }


    }
}
