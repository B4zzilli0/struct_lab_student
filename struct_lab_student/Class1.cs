using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Natalya
    {
        public void Variant8(Student[] studs)
        {
            Console.WriteLine("Молодшi 16ти:");
            int count = 0;
            DateTime now = DateTime.Now;
            int ye16 = 16 * 365;
            for (int i = 0; i < studs.Length; i++)
            {
                string date = studs[i].dateOfBirth;
                string[] arr = date.Split('.').ToArray();
                DateTime date1 = new DateTime(Int32.Parse(arr[2]), Int32.Parse(arr[1]), Int32.Parse(arr[0]));
                TimeSpan t = now.Subtract(date1);
                string aaaaaaa = $"{now.Subtract(date1)}";
                int daysPast = Int32.Parse(aaaaaaa.Substring(0, 4));
                if (daysPast >= ye16)
                {
                    string s = $"{studs[i].surName} {studs[i].firstName} {studs[i].patronymic}";
                    Console.WriteLine(s);
                    count++;
                }
            }
            Console.WriteLine("Усього: " + count);
            Console.ReadKey();
        }
    }
}
