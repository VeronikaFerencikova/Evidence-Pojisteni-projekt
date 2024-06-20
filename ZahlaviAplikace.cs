using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniProjekt
{
    /// <summary>
    /// Třída reprezentuje záhlaví aplikace Evidene pojištění 
    /// </summary>
    internal class ZahlaviAplikace
    {
        /// <summary>
        /// Metoda vypíše úvodní obrazku programu
        /// </summary>
        public void VypisZahlavi()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Vítejte v evidenci pojistných událostí".ToUpper());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            //Výpis datumu a času
            Console.WriteLine("Dnes je: {0}", DateTime.Now);
            Console.WriteLine();

        }
    }
}
