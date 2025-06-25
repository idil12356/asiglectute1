using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asiglectute1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Idil Mahad Yusuf";
            Console.WriteLine("Name: " + name); 
            string mothername = "Xamdi Ali";
            Console.WriteLine("Momother'Name: " + mothername);
           
            int birthYear = 2000;
            int birthMonth = 05;
            int birthDay = 15;
            DateTime dob = new DateTime(birthYear, birthMonth, birthDay);
            Console.WriteLine("Date Of Birth: " + dob.ToString("yyyy-MM-dd"));

            string pob = "Galkio";
            Console.WriteLine("Place Of Pirth: " + pob);
            string address = "Garsoor";
            Console.WriteLine("Address: " + address);
            int telphone = 097765567;
            Console.WriteLine("Telphone: " + telphone);
            string sex = "Female";
            Console.WriteLine("Sex: " + sex);
            string status = "Single";
            Console.WriteLine("Status: " + status);




        }
    }
}
