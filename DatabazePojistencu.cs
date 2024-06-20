using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniProjekt
{
    /// <summary>
    /// Třída spravuje kolekci pojištěnců (zde jsou uloženy záznamy čili seznam
    /// všech pojištěných)
    /// </summary>
    internal class DatabazePojistencu
    {
        /// <summary>
        /// Kolekce pojištěnců - seznam všech pojištěnců
        /// </summary>
        private List<Pojistenec> pojistenci;

        /// <summary>
        /// Vytvoří novou instanci databáze
        /// </summary>
        public DatabazePojistencu()
        {
            pojistenci = new List<Pojistenec>();
        }

        /// <summary>
        /// Metoda přidá nového pojištěného do databáze pojištěnců
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefonCislo"></param>
        public void PridejPojistence(string jmeno, string prijmeni, int vek, string telefonCislo)
        {
            pojistenci.Add(new Pojistenec(jmeno, prijmeni, vek, telefonCislo));
        }

        /// <summary>
        /// Metoda vypíše pojištěného 
        /// </summary>
        public void VypisPojisteneho()
        {
            Console.WriteLine();
            foreach (Pojistenec p in pojistenci)
            {
                Console.WriteLine(p);
            }
        }

        /// <summary>
        /// Metoda vyhledá pojištěného podle jména a přijmení
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        public void VyhledejPojisteneho(string jmeno, string prijmeni)
        {
            bool nalezeno = false;
            if (pojistenci.Count > 0)
            {
                Console.WriteLine();
                foreach (Pojistenec po in pojistenci)
                {
                    if (po.Jmeno == jmeno && po.Prijmeni == prijmeni)
                    {
                        Console.WriteLine(po);
                        nalezeno = true;
                        break;
                    }
                }
                if (!nalezeno)
                {
                    Console.WriteLine("Záznam nenalezen!");
                }
            }
            else
            {
                //Nenalezeno
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
            }
        }
    }
}
