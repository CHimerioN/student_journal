using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Dziennik
{
    public static class MyClass
    {
        public static void SerializeObject(this List<int> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<int>));
            using (var stream = File.OpenWrite(fileName))
            {
                serializer.Serialize(stream, list);
            }
        }

        public static void Deserialize(this List<int> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<int>));
            using (var stream = File.OpenRead(fileName))
            {
                var other = (List<int>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
            }
        }
    }
    class Program
    {
        //public class Student
        //{
        //    [XmlArray("StudentList")]
        //    [XmlArrayItem("Ocena")]
        //    public List<int> student { get; set; }
        //}
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
            //Student student1 = new Student();
            //student1.StudentList = new List<int>();
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
            Console.WriteLine("----------------UWAGA------------------\n" +
                              "Jezeli uruchamiasz program poraz pierwszy\nto pamietaj o serializacji danych (zapisie).\n\n" +
                              "Jezeli uruchamiasz program poraz drugi,\n to pamietaj o deserializacji danych (wczytaniu)\n\n"+
                              "Jezeli przeprowadzisz zapis danych \nbez wczesniejszego ich wczytania\nto dane sie nadpisza, czyli stare oceny\n zostana usuniete i zastapione nowymi");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("a = Uruchom program\n" +
                              "b = Koniec programu\n");
            

            char wybor = Console.ReadKey(true).KeyChar;
            while (wybor != 'b')
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
                                var ocena1 = Convert.ToInt32(Console.ReadLine());
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
                                Console.Write("Usuwanie oceny: ");
                                foreach (int i in student1)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                int ocena1 = Convert.ToInt32(Console.ReadLine());
                                student1.Remove(ocena1);
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
                                Console.Write("Usuwanie oceny: ");
                                Console.Write("Oceny: ");
                                foreach (int i in student2)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                int ocena2 = Convert.ToInt32(Console.ReadLine());
                                student2.Remove(ocena2);
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
                                Console.Write("Usuwanie oceny: ");
                                Console.Write("Oceny: ");
                                foreach (int i in student3)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                int ocena3 = Convert.ToInt32(Console.ReadLine());
                                student3.Remove(ocena3);
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
                                Console.Write("Usuwanie oceny: ");
                                Console.Write("Oceny: ");
                                foreach (int i in student4)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                int ocena4 = Convert.ToInt32(Console.ReadLine());
                                student4.Remove(ocena4);
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
                                Console.Write("Usuwanie oceny: ");
                                Console.Write("Oceny: ");
                                foreach (int i in student5)
                                {
                                    Console.Write("{0}, ", i);
                                }
                                Console.WriteLine("\n");
                                int ocena5 = Convert.ToInt32(Console.ReadLine());
                                student5.Remove(ocena5);
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

                        char d;
                        d = Console.ReadKey(true).KeyChar;
                        switch (d)
                        {
                            case 'a':
                                MyClass.SerializeObject(student1, "student1.xml");
                                MyClass.SerializeObject(student2, "student2.xml");
                                MyClass.SerializeObject(student3, "student3.xml");
                                MyClass.SerializeObject(student4, "student4.xml");
                                MyClass.SerializeObject(student5, "student5.xml");
                                break;
                            case 'b':
                                MyClass.Deserialize(student1, "student1.xml");
                                MyClass.Deserialize(student2, "student2.xml");
                                MyClass.Deserialize(student3, "student3.xml");
                                MyClass.Deserialize(student4, "student4.xml");
                                MyClass.Deserialize(student5, "student5.xml");
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


