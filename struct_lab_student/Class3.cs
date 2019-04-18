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
            Console.WriteLine("Пропустили бiльше двох iспитiв");
            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].physicsMark == '2' && studs[i].mathematicsMark == '2' && studs[i].informaticsMark == '2')
                {
                    string s = $"{studs[i].surName} {studs[i].firstName} {studs[i].patronymic}";
                    Console.WriteLine(s);
                }
            }
        }
    }
}
