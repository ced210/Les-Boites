using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Les_Boites
{
    public class ComboVertical : MasterBoite
    {
        Boite topBox { get; set; }
        Boite bottomBox { get; set; }

        public ComboVertical()
        {

        }

        public ComboVertical(Boite _topBox, Boite _bottomBox)
        {
            topBox = new Boite();
            bottomBox = new Boite();
            topBox.Copy(ref _topBox);
            bottomBox.Copy(ref _bottomBox);

            Height = topBox.Height + 1 + bottomBox.Height;
            Width = Math.Max(topBox.Width, bottomBox.Width);

            EqualizeLength();

            Text = CombineVeticalText();
        }

        private void EqualizeLength()
        {
            topBox.Text = base.ReseizeWidth(topBox.Text, Width);
            bottomBox.Text = base.ReseizeWidth(bottomBox.Text, Width);
        }

        private List<string> CombineVeticalText()
        {
            List<string> lst = new List<string>();
            lst.AddRange(topBox.Text);
            lst.Add(new string('-', Width));
            lst.AddRange(bottomBox.Text);
            return lst;
        }
    }

}