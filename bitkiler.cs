using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public  class bitkiler:canlilar
    {
        protected void fotosentez()
        {
            Console.WriteLine("bitkiler fotosenez yapar");
        }
    }

    public class tohumluBitkiler : bitkiler
    {
        public tohumluBitkiler()
        {
            base.fotosentez();
            base.beslenme();
            base.bosaltim();
            base.solunum();
        }

        public void tohumlaCogalma()
        {
            Console.WriteLine("tohumlu bitkiler tohumla cogalirlar .");
        }
    }

    public class tohumsuzBitkiler:bitkiler
    {
        public tohumsuzBitkiler()
        {
            base.fotosentez();
            base.beslenme();
            base.bosaltim();
            base.solunum();
        }
        public void sporlaCogalme()
        {
            Console.WriteLine("tohumsuz bitkiler spprla cogalirlar .");
        }
    }
}
