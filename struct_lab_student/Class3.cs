using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Jenya
    {
        public void Variant13(Student[] studs)
        {
            Console.WriteLine("Cтуденти, що пропустили бiльше двох iспитiв:");
            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].physicsMark == '-' && studs[i].mathematicsMark == '-' && studs[i].informaticsMark == '-')
                {
                    string s = $"{studs[i].surName}";
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
