using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniProjekt
{
    /// <summary>
    /// Třída reprezentuje uživatelské rozhraní, která komunikuje s uživatelem
    /// </summary>
    internal class UzivatelskeRozhrani
    {
        /// <summary>
        /// Databáze pojištenců, která obsahuje záznamy všech pojištěnců 
        /// </summary>
        private DatabazePojistencu databaze;

        /// <summary>
        /// Vytvoření nové instance uživatelského rozhraní??
        /// </summary>
        public UzivatelskeRozhrani()
        {
            databaze = new DatabazePojistencu();
        }

        /// <summary>
        /// Metoda vyzve uživatele k přidání jména, přijmení, věk, telefonní číslo 
        /// </summary>
        public void PridejPojistence()
        {
            string jmeno = ZiskatJmeno();

            string prijmeni = ZiskatPrijmeni();

            //Uživatel zadá svůj věk
            Console.WriteLine("Zadejte věk pojištěného: ");
            int vek;
            //kontrolo správného vstupu od uživatele - zadat číslo
            while (!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.WriteLine("Neplatný věk, zadej věk znovu: ");
            }

            //Uživatel zadá svoje telefonní číslo
            Console.WriteLine("Zadejte telefonní číslo pojištěného: ");
            string telefonCislo;
            //kontrola správného vstupu od uživatele - zadat řetězec
            while (string.IsNullOrWhiteSpace(telefonCislo = Console.ReadLine()))
            {
                Console.WriteLine("Zadej telefonCislo znovu: ");
            }
            databaze.PridejPojistence(jmeno, prijmeni, vek, telefonCislo);
        }

        //Metoda vyzve uživatele o zadání svého jména
        public string ZiskatJmeno()
        {
            Console.WriteLine();
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string jmeno;
            //kontrola vstupu od uživatele
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadej jméno znovu: ");
            }
            return jmeno;
        }

        //Metoda vyzve uživatele o zadaní svého přijmení
        public string ZiskatPrijmeni()
        {
            Console.WriteLine("Zadejte přijmení pojištěného: ");
            string prijmeni;
            //kontrola vstupu od uživatele 
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadej přijmení znovu: ");
            }
            return prijmeni;
        }

        //Vypíše pojištěného
        public void VypisPojisteneho()
        {
            databaze.VypisPojisteneho();
        }

        //vyhledá pojištěného podle jména a přijmení
        public void VyhledejPojisteneho(string jmeno, string prijmeni)
        {
            databaze.VyhledejPojisteneho(jmeno, prijmeni);
        }
    }
}
