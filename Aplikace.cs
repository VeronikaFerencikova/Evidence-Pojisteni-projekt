using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniProjekt
{
    // <summary>
    /// Třída reprezentuje aplikace 
    /// </summary>
    internal class Aplikace
    {
        /// <summary>
        /// Metoda mi spustí aplikaci 
        /// </summary>
        public void SpustitAplikaci()
        {
            //Vytvoření instance záhlaví
            ZahlaviAplikace zahlavi = new ZahlaviAplikace();

            //Vytvoření instance uživatelské rozhraní
            UzivatelskeRozhrani uzivatelskeRozhrani = new UzivatelskeRozhrani();

            char volba = '0';

            //Hlavní cyklus 
            while (volba != '4')
            {
                zahlavi.VypisZahlavi();
                Console.WriteLine();
                //Vyzve uživatele k vybrání akce
                Console.WriteLine("Vyberte si akci: ");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného dle jména a příjmení");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();

                //reakce na volbu výběru od uživatele 
                switch (volba)
                {
                    case '1':
                        //Volání metody Přidej pojištěného - přidání do seznamu pojištěných
                        uzivatelskeRozhrani.PridejPojistence();
                        Console.WriteLine("\nData byla uložena. Pokračujte libovolnou klávesou...");
                        break;
                    case '2':
                        //Volání metody Vypiš pojištěného - vypíše všechny pojištěné
                        uzivatelskeRozhrani.VypisPojisteneho();
                        Console.WriteLine("\nPokračujte libovolnou klávesou...");
                        break;
                    case '3':
                        //Volání metody Vyhledej pojistěného - vyhledá pojištěného podle jména a příjmení
                        uzivatelskeRozhrani.VyhledejPojisteneho(uzivatelskeRozhrani.ZiskatJmeno(), uzivatelskeRozhrani.ZiskatPrijmeni());
                        Console.WriteLine("\nPokračujte libovolnou klávesou...");
                        break;
                    case '4':
                        //Ukončení programu
                        Console.WriteLine("\nLibovolnou klávesou ukončíte program...");
                        break;
                    default:
                        Console.WriteLine("\nNeplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
