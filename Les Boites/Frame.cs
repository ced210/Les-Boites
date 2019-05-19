using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Boites
{
    public class Frame
    {
        public string TopBottom { get; private set; }
        public string Center { get; private set; }
        public string SetTopBottom(int size) // size of 4 should give +----+
        {
            TopBottom = "+";
            for (int i = 0; i < size; ++i)
            {
                TopBottom += "-";
            }
            TopBottom += "+";

            return TopBottom;
        }

     
        public string SetCenter(string center, int size)
        {
            Center = "|" + center;
            for (int i = center.Length; i < size; ++i) // yo should give |yo| if size == 4 should give |yo  | instead
            {
                Center += " ";
            }
            Center += "|";
            return Center;
        }

       
        public string SetCenterHorizontalCombo(HorizontalBox box)
        {
            List<string> centerText = new List<string>();
            for (int i = 0; i < box.Height; i++)
            {
                centerText.Add(string.Join("|", "|" + box.leftBox.Text[i], box.rightBox.Text[i] + "|"));
            }
            return string.Join("\n", centerText.ToArray());
        }

        public string SetCenterVerticalCombo(VerticalBox box)
        {
            List<string> centerText = new List<string>();
            centerText.AddRange(box.topBox.Text.ToList());
            centerText.Add(new string('-', box.Width));
            centerText.AddRange(box.buttomBox.Text.ToList());

            centerText = centerText.Select(s => "|" + s + "|").ToList();

            return string.Join("\n", centerText.ToArray());
        }
    }
}
