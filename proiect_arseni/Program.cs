using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_arseni
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Gestionare gest = new Gestionare();
            string meniu, alege;
            do
            {
                Console.Clear();
                Console.WriteLine("\n              FARMACIE                 \n------------------------------------------");
                Console.WriteLine(" 1. Adaugare medicamente (tastatura)\n");
                Console.WriteLine(" 2. Citire date din fisier\n");
                Console.WriteLine(" 3. Salvare date in fisier\n");
                Console.WriteLine(" 4. Afisare medicamente\n");
                Console.WriteLine(" 5. Eliminare medicament\n");
                Console.WriteLine(" 6. Cauta cod produs dupa denumirea produsului\n");
                Console.WriteLine(" 7. Cauta denumire produs dupa codul produsului\n");
                Console.WriteLine(" 8. Info Farmacie\n");
                Console.WriteLine(" 9. Iesire\n");
                

                Console.Write("Alegeti o optiune:  ");
                meniu = Console.ReadLine();
                switch (meniu)
                {
                   
                    case "1":
                        while (true)
                        {
                            Console.Clear();
                            Console.Write("Adaugati produs nou? (DA/NU): ");
                            alege = Console.ReadLine();
                            if (alege.ToUpper() == "DA")
                                gest.adauga_produs();
                            else
                            {
                                break;
                            }
                        }
                        Console.WriteLine("\nApasa alta tasta");
                        Console.ReadKey();
                        break;

                    

                    case "2":
                        gest.citire_din_fisier();
                        Console.WriteLine("Citire cu succes!");
                        Console.WriteLine("\nApasa alta tasta");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        gest.scriere_in_fisier();
                        Console.WriteLine("Medicament salvat!");
                        Console.WriteLine("\nApasa alta tasta!");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        gest.afisare_medicamente();
                        Console.WriteLine("\nApasa alta tasta");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.Clear();
                        Console.Write("Introduceti denumirea produsului pentru eliminare: ");
                        string med = Console.ReadLine();
                        gest.sterge_produs(med);
                        Console.WriteLine("\nApasa alta tasta");
                        Console.ReadKey();
                        break;

                    
                    case "6":
                        Console.Clear();
                        Console.Write("Introduceti denumirea produsului: ");
                        string den = Console.ReadLine();
                        Console.WriteLine("Codul asociat produsului introdus este: " + gest.c_cod_produs(den));
                        Console.WriteLine("\nApasa alta tasta");
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.Clear();
                        Console.Write("Introduceti codul produsului: ");
                        int x = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Denumirea asociata codului introdus este: " + gest.denumirea_produs(x));
                        Console.WriteLine("\n Apasa alta tasta!");
                        Console.ReadKey();
                        break;

                    case "8":
                        Console.WriteLine(" Farmacia ARSENI, strada Principala, Suceava");
                        Console.WriteLine("\nApasa alta tasta!");
                        Console.ReadKey();
                        break;

                    case "9":
                        System.Environment.Exit(0);
                        Console.WriteLine("\nApasa orice pentru o noua alegere...");
                        Console.ReadKey();
                        break;

                }

            } while (true);*/

             bool gasit;
            for (int i = 65; i < 91; i++)
            {
                gasit = false;

                char a, b;
                for (int j = 0; j < args.Length; j++)
                {
                    b = Convert.ToChar(i);
                    a = args[j].First();
                    //Console.WriteLine("{0},{1}", a, b);
                    if (a == b || a == b + 32)
                    {
                        Console.Write(args[j] + " ");
                        gasit = true;
                    }

                }
                if (gasit == true)
                {
                    Console.WriteLine();
                }
            }
           
        }
    }
}
