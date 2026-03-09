using System;

namespace NeljasOsaPraktilineToo
{
    class StartPage
    {
        public static void Main(string[] args)
        {
            bool RestoranTootab = true;
            while (RestoranTootab)
            {
                try
                {
                    System.Console.Write("Tee valik: ");
                    int valik = int.Parse(Console.ReadLine());
                    switch (valik)
                    {
                        case 1:
                            Alamfunktsioonid.Itaalia_Retseptid();
                        break;
                        case 2:
                            Alamfunktsioonid.Retsepti_Kuvamine();
                            break;
                        case 3:
                            Alamfunktsioonid.Koostisosad_Muutmine();
                            break;
                        case 4:
                            RestoranTootab = false;
                            break;
                    }
                }
                catch
                {
                    System.Console.WriteLine("Midagi juhtus valesti!");
                }

            }
        }
    }
}