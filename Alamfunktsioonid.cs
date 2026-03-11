using System;

namespace NeljasOsaPraktilineToo
{
    class Alamfunktsioonid
    {
        public static void Itaalia_Retseptid()
        {
            try
            {
                Console.Write("Sisestage mitu toitu tahate lisada: ");
                int mitu_toitu = int.Parse(Console.ReadLine());
                for (byte i = 0; i < mitu_toitu; i++)
                {
                    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt"); //@"..\..\..\Kuud.txt"
                    StreamWriter File = new StreamWriter(path, true); // true = lisa lõppu
                    Console.Write("Sisesta Itaalia toit: ");
                    string lause = Console.ReadLine();
                    File.WriteLine(lause);
                    File.Close();
                }                
            }
            catch (FormatException)
            {
                Console.WriteLine("Sisestatud mitte arv");
            }
            catch (IOException)
            {
                System.Console.WriteLine("Mingi juhtus failiga");
            }
            catch
            {
                System.Console.WriteLine("Ma ei tea mis juhtus");
            }
        }
        public static void Retsepti_Kuvamine()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused); 
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }
        public static void Koostisosad_Muutmine()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");
                List<string> Koostisosad = new List<string>();
                foreach (string ingridients in File.ReadAllLines(path))
                {
                    Koostisosad.Add(ingridients);
                }
                for (int i = 0; i < Koostisosad.Count(); i++)
                {
                    string[] Ingridients = Koostisosad[i].Split(",");
                    List<string> IngridientsList = new List<string>(Ingridients);
                    foreach (string ing in Ingridients) System.Console.Write(ing + " ");
                    System.Console.WriteLine("Kas tahate midagi muuta?\n[y/n] ");
                    char valik = char.Parse(Console.ReadLine());
                    if (valik == 'y')
                    {
                        System.Console.WriteLine("Sisestage mida tahate kustuta: ");
                        string Ingridient = Console.ReadLine();
                        IngridientsList.Remove(Ingridient);
                        IngridientsList[0] = "Kvaliteetne oliiviõli";
                        Console.Write("Sisestage uus ingridient");
                        Ingridient = Console.ReadLine();
                        IngridietnsList.Add(Ingridient);
                    }
                    else if (valik == 'n');
                    else System.Console.WriteLine("Peab olema [y/n]");
                }
                
            }
            catch 
            {
                System.Console.WriteLine("Midagi juhtus valesti");
            }
        }
    }
}
