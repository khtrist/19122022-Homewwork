using System;
using System.Xml.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _19122022_ye_olan_dersler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // TASK 1 

            string arr = Console.ReadLine();
            Console.WriteLine(makespace(arr).Trim());


           




        }

        // TASK 1 

        //   -Verilmiş string dəyərindəki bütün sözlərin arasında bir boşluq qalacaq
        //   vəziyyətə salan metod.(Metoda "  Men   rusca    bilmirem" dəyəri göndərilərsə onu
        //   "Men rusca bilmirem" halına gətirməlidir.

        static string makespace(string strr)
        {
            strr = strr.Replace(" " + ' ', string.Empty);
            return strr;


        }





        // TASK 2
        //- Verilmiş string dəyərdəki sözlərin sayını tapan metod(boşluqlarla ayrılmış bütün ifadələr)
        public static int counter(string str)
        {

            if (str == null || str.Length == 0)
            {
                return 0;
            }
            string[] words = str.Split(" ");
            int count = 1;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length != 0) 
                    count++;
            }

            return count;
        }

        //TASK 3
        //- Parameter olaraq int array variable - ı(reference) və bir integer value qəbul edən və
        //həmin integer value - nu integer array - ə yəni element kimi əlavə edən metod.

        static int arrey(ref int[] num, ref int nums)
        {
            
            int[] newtype = new int[num.Length + 1];
            int n = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (n == i)
                {
                    newtype[i] = num[i];
                    n++;

                }
            }
            newtype[n++] = nums;
            return newtype;
        }



        //TASK 4

        //- Gonderilmis fullname arrayinden yeni bir names arrayi duzeldib geri qaytaran metod.
        //Fullname arrayinin icindeki butun value - lar ad + " " + soyad formatindadir.Misalcun "Hikmet Abbasov".
        //Misalcun gelen arraydeki deyerler { "Hikmet Abbasov","Abdulla Qulamov","Cemile Hikmetova"}
        //            olarsa return olunan arraydeki deyerler { "Hikmet","Abdulla","Cemile"}
        //            olmalidir

        static string[] vozvratname(string[] fullname)
        {
            string[] names = new string[fullname.Length];
            for (int i = 0; i < fullname.Length; i++)
            {

                int namee = fullname[i].IndexOf(" ");
                int surname = fullname.Length - namee;
                names[i] = fullname[i].Substring(0, namee);

            }
            return names;

        }


        //- Verilmiş string dəyərin bir fullname olub olmadığını yoxlayan metod.
        //(Dəyərin fullname olma şərti daxilində yalnız hərflərin ola bilməsi, yalnız 2 sözdən
        //ibarət olması və hər bir sözün böyük hərfə başlayıb kiçik hərflərlə davam etməsidir.




        static bool fullka(string fullname)
        {
            bool check = false;
            bool isupper = false;
            bool islover = false;
            bool isleter = false;
            bool count = false;
            bool isupper2 = false;
            if (fullname.Contains(" "))
            {
                for (int i = 1; i < fullname.Length; i++)
                {
                    if (char.IsLetter(fullname[i]))
                    {
                        isleter = true;
                    }
                    else if (!isleter)
                    {
                        isleter = false;
                        break;
                    }
                    else if (char.IsUpper(fullname[0]) && char.IsUpper(fullname[fullname.IndexOf(' ')]))
                    {
                        isupper = true;
                    }
                    else if  (!isupper)
                    {
                        isupper = false;
                        break;
                    }
                    else if (char.IsLower(fullname[i])) 
                    {
                        islover= true;  
                    }
                    else if (!islover)
                    {
                        islover = false;
                        break;
                    }

                    else if (char.IsUpper(fullname[0]) && char.IsUpper(fullname[fullname.IndexOf(' ') + 1]))
                    {
                        isupper2 = true;
                    }
                    else if (!isupper2)
                    {
                        isupper2 = false;
                        break;

                    }
                    else if (true)
                    {
                        return true;
                    }

                }
            
            }
            else if (false)
            {
                return false;

            }
















        }
        
    } 
}
