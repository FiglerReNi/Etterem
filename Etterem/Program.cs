using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Etterem
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Tetel> tetelek = new List<Tetel>();
            List<Asztal> asztalok = new List<Asztal>();
            string[] beolvas = File.ReadAllLines("etelek.txt", Encoding.Default);
            for (int i = 0; i < beolvas.Length; i++)
            {
                string[] sor = beolvas[i].Split('|');
                string neve = beolvas[i].Split('|')[0];
                int ara = int.Parse(beolvas[i].Split('|')[1]);
                tetelek.Add(new Tetel(neve, ara));
            }
            string[] beolvas_1 = File.ReadAllLines("asztalok.txt", Encoding.Default);
            bool elso = true;
            Asztal asztaluj = null;
            for (int i = 0; i < beolvas_1.Length; i++)
            {

                if (elso)
                {
                    asztaluj = new Asztal(beolvas_1[i]);
                    asztalok.Add(asztaluj);
                    asztaluj.Tetelek = new List<Tetel>();
                    elso = false;
                }
                else
                {
                    if (!String.IsNullOrEmpty(beolvas_1[i]))
                    {
                        int tetelar = 0;
                        for (int j = 0; j < tetelek.Count; j++)
                        {
                            if (beolvas_1[i] == tetelek[j].Nev)
                            {
                                tetelar = tetelek[j].Ar;
                            }
                        }
                        asztaluj.Tetelek.Add(new Tetel(beolvas_1[i], tetelar));
                    }
                    else
                    {
                        elso = true;
                    }
                }
            }
            foreach (Asztal asztal in asztalok)
            {
                Console.WriteLine(asztal.AsztalNev + " Asztal");
                Console.WriteLine("=============================================");
                Console.WriteLine();
                foreach (Tetel tetel in asztal.Tetelek)
                {
                    Console.WriteLine("{0, -17}{1, 10} Ft" ,tetel.Nev, tetel.Ar);
                }
                Console.WriteLine("______________________________________________");
                Console.Write("Fizetendő: ");
                osszeg(asztal.Tetelek);
                Console.Write(" Ft");
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void osszeg(List<Tetel> tetelek)
        {
            int ossz = 0;
            for (int i = 0; i < tetelek.Count; i++)
            {               
                ossz = ossz + tetelek[i].Ar;
                   
                }
            Console.Write("{0, 16}", ossz);
        }
        }
    }
 
        
     
   

