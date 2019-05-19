using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Boites
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterBoite mb = new MasterBoite("yo\ncornet");

            Console.WriteLine(mb.ToString());


            Boite simpleBox = new Boite("yo");
            Boite multiLineBox = new Boite("yo\ncornet");

            Boite.Display(simpleBox);

            Boite.Display(new Boite(new ComboHorizontal(simpleBox, multiLineBox)));

            Boite.Display(new Boite(new ComboHorizontal(multiLineBox, simpleBox)));


            Boite.Display(new Boite(new ComboVertical(simpleBox, multiLineBox)));

            Boite.Display(new Boite(new ComboVertical(multiLineBox, simpleBox)));



            MainPatrice();
        }

        
        static void MainPatrice()
        {
            Boite b = new Boite();
            Boite.Display(b);
            Boite.Display(new Boite("yo"));
            string texte = @"Man! Hey!!!
ceci est un test
multiligne";
            string aut_texte = "Ceci\nitou, genre";
            Boite b0 = new Boite(texte);
            Boite b1 = new Boite(aut_texte);
            Boite.Display(b0);
            Boite.Display(b1);
            ComboVertical cv = new ComboVertical(b0, b1);
            Boite.Display(new Boite(cv));
            ComboHorizontal ch = new ComboHorizontal(b0, b1);
            Boite.Display(new Boite(ch));


            ComboVertical cvplus = new ComboVertical(new Boite(cv), new Boite(ch));
            Boite.Display(new Boite(cvplus));


            ComboHorizontal chplus = new ComboHorizontal(new Boite(cv), new Boite(ch));
            Boite.Display(new Boite(chplus));



            ComboVertical cvv = new ComboVertical(new Boite(chplus), new Boite("coucou"));
            Boite.Display(new Boite(cvv));
            Boite.Display(new Boite(
                new ComboHorizontal(
                    new Boite("a\nb\nc\nd\ne"),
                        new Boite(
                        new ComboVertical(
                            new Boite("allo"), new Boite("yo")
                        )
                        )
                    )
                )
            );
            Boite.Display(
                new Boite(new ComboHorizontal(new Boite("Yo"), new Boite()))
            );
            Boite.Display(
                new Boite(new ComboHorizontal(new Boite(), new Boite("Ya")))
            );
            Boite.Display(
                new Boite(new ComboHorizontal(new Boite(), new Boite()))
            );
            Boite.Display(
                new Boite(new ComboVertical(new Boite(), new Boite()))
            );
            Boite.Display(
                new Boite(new ComboVertical(new Boite("Yip"), new Boite()))
            );
            Boite.Display(
                new Boite(new ComboVertical(new Boite(), new Boite("Yap")))
            );
        }
    }
}



