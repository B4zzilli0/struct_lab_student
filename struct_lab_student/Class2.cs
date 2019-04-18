using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Maksym
    {
        public void Variant15(Student[] studs)
        {
            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].physicsMark > '2' && studs[i].mathematicsMark > '2' && studs[i].informaticsMark > '2')
                {
                    string s = $"{studs[i].surName} {studs[i].firstName} {studs[i].patronymic} {studs[i].scholarship}";
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
