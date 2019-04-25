using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Program
    {
        static Student[] ReadData(string fileName)
        {
            string path = @"input.txt";
            Student[] arr = new Student[0];
            int i = 0;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Student s = new Student(line);
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[i] = s;
                    i++;
                }

            }
            return arr;
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill 
        }

        static void runMenu(Student[] studs)
        {
            Console.WriteLine("Enter the num of variant: ");
            string s = Console.ReadLine();
            if (s == "15")
            {
                Maksym m = new Maksym();
                m.Variant15(studs);
            }
            else if (s == "8")
            {
                Natalya m = new Natalya();
                m.Variant8(studs);
            }
            else if (s == "13")
            {
                Jenya m = new Jenya();
                m.Variant13(studs);
            }
            else
                Console.WriteLine("This variant doesn`t exist");
            // TODO   implement this method
            // It should call method(s) for concrete variant(s)
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
        }
    }
}
