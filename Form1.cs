using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		void FELADAT()
		{
            using (new Frissítés(false))
            {
				Fa5(4,100);
            }
		}

		/// <summary>
		/// függőlegestől való eltérés
		/// </summary>
		/// <param name="x">fok</param>
		/// <returns>eltérés mértéke</returns>
		double f(double x) => Math.Abs(90 - x);
		double felfelébb(double a, double b) => f(Irány + a) <= f(Irány + b) ? a : b;

		//(double) iránybaállít(double egyik, double másik)
        void Fa5(int szint, double méret)
        {
            if (szint>0)
            {
				Előre(méret / 4);
				using (new Átmenetileg(Balra, felfelébb(60, -60)))
					Fa5(szint - 3, méret / 4);
				Előre(méret / 4);
				using (new Átmenetileg(Balra, felfelébb(60, -60)))
					Fa5(szint - 1, méret / 2);
				using (new Átmenetileg(Jobbra, felfelébb(60, -60)))
					Fa5(szint - 3, méret / 4);
				Előre(méret / 2);
				using (new Átmenetileg(Balra, 60))
					Fa5(szint - 1, méret / 2);
				using (new Átmenetileg(Jobbra, 60))
					Fa5(szint - 1, méret / 2);
				Hátra(méret);
            }
        }
    }
}
