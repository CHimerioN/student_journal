using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

// ogarnij zapis do xml/json!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

namespace Dziennik
{
    class Program
    {
        public static void show()
        {
            Console.WriteLine("Lista studentow: \n" +
                              "a. 181211\n" +
                              "b. 112343\n" +
                              "c. 123456\n" +
                              "d. 153421\n" +
                              "e. 166564\n");
        }
        static void Main(string[] args)
        {

            //-----------------------------
            List<int> student1 = new List<int>();
            List<int> student2 = new List<int>();
            List<int> student3 = new List<int>();
            List<int> student4 = new List<int>();
            List<int> student5 = new List<int>();
            //-----------------------------


            Console.WriteLine("------------Dziennik ocen-------------\n" +
                              "--------------------------------------\n" +
                              "-------------MATEUSZ KUC--------------\n\n");
            Console.WriteLine("a = Uruchom program\n" +
                              "b = Koniec programu");

            char wybor = Console.ReadKey(true).KeyChar;
            while(wybor!='b')
            {
                Console.WriteLine("a. Wpisanie oceny do wybranego studenta  ");
                Console.WriteLine("b. Usuniecie oceny wybranego studenta    ");
                Console.WriteLine("c. Wyswietlenie listy studentow z ocenami");
                Console.WriteLine("d. Serializacja i deserializacja danych  ");
                Console.WriteLine("e. Wyjscie z programu\n");
                char z;

                z = Console.ReadKey(true).KeyChar;
                switch (z)
                {
                    // --------------------  a  ---------------
                    case 'a':
                        show();

                        char c;
                        c = Console.ReadKey(true).KeyChar;
                        switch (c)
                        {
                            case 'a':
                                //---------INDEKS STUDENTA--------
                                Console.WriteLine("a. 181211\n");
                                //---------WPISYWANIE OCENY-------
                                Console.Write("Wpisywanie oceny: ");
                                int ocena1 = Convert.ToInt32(Console.ReadLine());
                                student1.Add(ocena1);
                                //WYSWIETLANIE LISTY OCEN STUDENTA
                                Console.Write("Oceny: ");
                                foreach (int i in student1)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                //---------KONIEC OPERACJI--------
                                break;
                            case 'b':
                                //---------INDEKS STUDENTA--------
                                Console.WriteLine("b. 112343\n");
                                //---------WPISYWANIE OCENY-------
                                Console.Write("Wpisywanie oceny: ");
                                int ocena2 = Convert.ToInt32(Console.ReadLine());
                                student2.Add(ocena2);
                                //WYSWIETLANIE LISTY OCEN STUDENTA
                                Console.Write("Oceny: ");
                                foreach (int i in student2)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                //---------KONIEC OPERACJI--------
                                break;
                            case 'c':
                                //---------INDEKS STUDENTA--------
                                Console.WriteLine("c. 123456\n");
                                //---------WPISYWANIE OCENY-------
                                Console.Write("Wpisywanie oceny: ");
                                int ocena3 = Convert.ToInt32(Console.ReadLine());
                                student3.Add(ocena3);
                                //WYSWIETLANIE LISTY OCEN STUDENTA
                                Console.Write("Oceny: ");
                                foreach (int i in student3)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                //---------KONIEC OPERACJI--------
                                break;
                            case 'd':
                                //---------INDEKS STUDENTA--------
                                Console.WriteLine("d. 153421\n");
                                //---------WPISYWANIE OCENY-------
                                Console.Write("Wpisywanie oceny: ");
                                int ocena4 = Convert.ToInt32(Console.ReadLine());
                                student4.Add(ocena4);
                                //WYSWIETLANIE LISTY OCEN STUDENTA
                                Console.Write("Oceny: ");
                                foreach (int i in student4)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                //---------KONIEC OPERACJI--------
                                break;
                            case 'e':
                                //---------INDEKS STUDENTA--------
                                Console.WriteLine("e. 166564\n");
                                //---------WPISYWANIE OCENY-------
                                Console.Write("Wpisywanie oceny: ");
                                int ocena5 = Convert.ToInt32(Console.ReadLine());
                                student5.Add(ocena5);
                                //WYSWIETLANIE LISTY OCEN STUDENTA
                                Console.Write("Oceny: ");
                                foreach (int i in student5)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                //---------KONIEC OPERACJI--------
                                break;
                        }
                        break;
                    //-----------------  b  --------------------
                    case 'b':
                        show();

                        char v;
                        v = Console.ReadKey(true).KeyChar;
                        switch (v)
                        {
                            case 'a':
                                //---------INDEKS STUDENTA--------
                                Console.WriteLine("a. 181211\n");
                                //---------WPISYWANIE OCENY-------
                                Console.Write("Wpisywanie oceny: ");
                                int ocena1 = Convert.ToInt32(Console.ReadLine());
                                student1.Add(ocena1);
                                //WYSWIETLANIE LISTY OCEN STUDENTA
                                Console.Write("Oceny: ");
                                foreach (int i in student1)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                //---------KONIEC OPERACJI--------
                                break;
                            case 'b':
                                //---------INDEKS STUDENTA--------
                                Console.WriteLine("b. 112343\n");
                                //---------WPISYWANIE OCENY-------
                                Console.Write("Wpisywanie oceny: ");
                                int ocena2 = Convert.ToInt32(Console.ReadLine());
                                student2.Add(ocena2);
                                //WYSWIETLANIE LISTY OCEN STUDENTA
                                Console.Write("Oceny: ");
                                foreach (int i in student2)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                //---------KONIEC OPERACJI--------
                                break;
                            case 'c':
                                //---------INDEKS STUDENTA--------
                                Console.WriteLine("c. 123456\n");
                                //---------WPISYWANIE OCENY-------
                                Console.Write("Wpisywanie oceny: ");
                                int ocena3 = Convert.ToInt32(Console.ReadLine());
                                student3.Add(ocena3);
                                //WYSWIETLANIE LISTY OCEN STUDENTA
                                Console.Write("Oceny: ");
                                foreach (int i in student3)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                //---------KONIEC OPERACJI--------
                                break;
                            case 'd':
                                //---------INDEKS STUDENTA--------
                                Console.WriteLine("d. 153421\n");
                                //---------WPISYWANIE OCENY-------
                                Console.Write("Wpisywanie oceny: ");
                                int ocena4 = Convert.ToInt32(Console.ReadLine());
                                student4.Add(ocena4);
                                //WYSWIETLANIE LISTY OCEN STUDENTA
                                Console.Write("Oceny: ");
                                foreach (int i in student4)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                //---------KONIEC OPERACJI--------
                                break;
                            case 'e':
                                //---------INDEKS STUDENTA--------
                                Console.WriteLine("e. 166564\n");
                                //---------WPISYWANIE OCENY-------
                                Console.Write("Wpisywanie oceny: ");
                                int ocena5 = Convert.ToInt32(Console.ReadLine());
                                student5.Add(ocena5);
                                //WYSWIETLANIE LISTY OCEN STUDENTA
                                Console.Write("Oceny: ");
                                foreach (int i in student5)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                //---------KONIEC OPERACJI--------
                                break;
                        }
                        break;
                    //-----------------  c  --------------------
                    case 'c':
                        Console.Write("181211: ");
                        foreach (int i in student1)
                        {
                            Console.Write("{0}, ", i);
                        }
                        Console.WriteLine("\n");
                        Console.Write("112343: ");
                        foreach (int i in student2)
                        {
                            Console.Write("{0}, ", i);
                        }
                        Console.WriteLine("\n");
                        Console.Write("123456: ");
                        foreach (int i in student3)
                        {
                            Console.Write("{0}, ", i);
                        }
                        Console.WriteLine("\n");
                        Console.Write("153421: ");
                        foreach (int i in student4)
                        {
                            Console.Write("{0}, ", i);
                        }
                        Console.WriteLine("\n");
                        Console.Write("166564: ");
                        foreach (int i in student5)
                        {
                            Console.Write("{0}, ", i);
                        }
                        Console.WriteLine("\n");
                        break;
                    //-----------------  d  --------------------
                    case 'd':
                        Console.WriteLine("a. Serializacja danych");
                        Console.WriteLine("b. Deserializacja danych");

                        char json;
                        json = Console.ReadKey(true).KeyChar;
                        switch(json)
                        {
                            case 'a':
                                JsonConvert.SerializeObject(student1);
                                JsonConvert.SerializeObject(student2);
                                JsonConvert.SerializeObject(student3);
                                JsonConvert.SerializeObject(student4);
                                JsonConvert.SerializeObject(student5);

                                break;
                            case 'b':

                                break;
                        }
                        break;
                    case 'e':
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                        break;

                }

            }




        }
    }
}


//show();
////Console.WriteLine("1. Wyswietlenie listy studentow       ");
//Console.WriteLine("a. Wpisanie oceny do wybranego studenta");
//            Console.WriteLine("b. Usuniecie oceny wybranego studenta  ");
//            char z;

//z = Console.ReadKey(true).KeyChar;
//            switch (z)
//            {
//                case 'a':
//                    ////---------INDEKS STUDENTA--------
//                    //Console.WriteLine("1. 181211");
//                    ////---------WPISYWANIE OCENY-------
//                    //Console.WriteLine("Wpisywanie oceny: ");
//                    //int ocena = Convert.ToInt32(Console.ReadLine());
//                    //student1.Add(ocena);
//                    ////WYSWIETLANIE LISTY OCEN STUDENTA
//                    //Console.Write("Oceny: ");
//                    //foreach(int i in student1)
//                    //{
//                    //    Console.Write("{0}, ", i);
//                    //}
//                    ////---------KONIEC OPERACJI--------

//                    //break;

//                    //   WYBRANIE INDEKSU STUDENTA
//                    show();

//char c;
//c = Console.ReadKey(true).KeyChar;
//                    switch(c)
//                    {
//                        case 'a':
//                            //---------INDEKS STUDENTA--------
//                            Console.WriteLine("a. 181211");
//                            //---------WPISYWANIE OCENY-------
//                            Console.WriteLine("Wpisywanie oceny: ");
//                            int ocena = Convert.ToInt32(Console.ReadLine());
//student1.Add(ocena);
//                            //WYSWIETLANIE LISTY OCEN STUDENTA
//                            Console.Write("Oceny: ");
//                            foreach (int i in student1)
//                            {
//                                Console.Write("{0}, ", i);
//                            }
//                            //---------KONIEC OPERACJI--------
//                            break;
//                    }
//                    break;
               
//            }