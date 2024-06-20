using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniProjekt
{
    /// <summary>
    /// Třída reprezentuje pojištěnce, který má jméno, přijmení, věk, telefonní číslo
    /// </summary>
    internal class Pojistenec
    {
        /// <summary>
        /// Jméno pojištěnce
        /// </summary>
        public string Jmeno { get; private set; }

        /// <summary>
        /// Přijmení pojištěnce
        /// </summary>
        public string Prijmeni { get; private set; }

        /// <summary>
        /// Věk pojištěnce
        /// </summary>
        public int Vek { get; private set; }

        /// <summary>
        /// Telefonní číslo pojištěnce (kontakt)
        /// </summary>
        public string TelefonCislo { get; private set; }

        /// <summary>
        /// Vytvoří novou instanci pojištěnce
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefonCislo"></param>
        public Pojistenec(string jmeno, string prijmeni, int vek, string telefonCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonCislo = telefonCislo;
        }
        /// <summary>
        /// Vrátí jméno a přijmení pojištěnce
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}\t {1}\t {2}\t {3}", Jmeno, Prijmeni, Vek, TelefonCislo);
        }

    }
}
