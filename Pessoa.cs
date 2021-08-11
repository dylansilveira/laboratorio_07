using System;
using System.Collections;

namespace Laboratorio7
{
    public class Pessoa : IComparable
    {
        private class sortByAgeHelper: IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Pessoa c1 = (Pessoa)a;
                Pessoa c2 = (Pessoa)b;

                if (c1.Idade > c2.Idade)
                return 1;

                if (c1.Idade < c2.Idade)
                return -1;

                else
                return 0;
            }
        }

        private class sortByNameHelper: IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Pessoa p1 = (Pessoa)a;
                Pessoa p2 = (Pessoa)b;
                return String.Compare(p1.Nome, p2.Nome);
            }
        }

        public string Nome {get;}
        public int Idade {get; private set;}
        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }
        int IComparable.CompareTo(object obj)
        {
            Pessoa c = (Pessoa)obj;
            return String.Compare(this.Nome, c.Nome);
        }
        public static IComparer sortByName()
        {
            return (IComparer) new sortByNameHelper();
        }
        public static IComparer sortByAge()
        {
            return (IComparer) new sortByAgeHelper();
        }
    }
}