using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenți
{
    public class Student
    {
        public string nume;
        public int varsta, an, nota1, nota2, nota3, nota4, nota5;
        public double medie;
        public Student()
        {
            nume = "";
            varsta = an = nota1 = nota2 = nota3 = nota4 = nota5 = 0;
            medie = 0;
        }
        public Student(string s, int v, int a, int n1, int n2, int n3, int n4, int n5)
        {
            nume = s;
            varsta = v;
            an = a;
            nota1 = n1;
            nota2 = n2;
            nota3 = n3;
            nota4 = n4;
            nota5 = n5;
            medie = (n1 + n2 + n3 + n4 + n5) / 5.0;
        }
        public string Afisare()
        {
            return (nume + ", " + varsta + " ani, anul " + an + ", media " + medie);
        }
    }
}
