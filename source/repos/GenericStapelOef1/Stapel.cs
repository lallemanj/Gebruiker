using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStapelOef1
{
    internal class Stapel<T>
    {
        List<T> lijstStapel = new List<T>();
        //List<T> lijstStapel2 = new List<T>();


        public void toevoegenStapel(T toevoegen)
        {
            lijstStapel.Add(toevoegen);
        }

        public T verwijderenStapel()
        {
            if (lijstStapel.Count == 0)
                throw new StackOverflowException();
            T plaats = lijstStapel[0];
            lijstStapel.RemoveAt(0);
            return plaats;
        }

        public void leegmakenStapel()
        {
            if (lijstStapel.Count == 0)
                throw new StackOverflowException();
            lijstStapel.Clear();

            
        }

        public override string ToString()
        {
            return String.Join(" / ", lijstStapel);
        }

        public bool IsAanwezig(T aanwezig)
        {
            if (lijstStapel.Contains(aanwezig))
          
                return true;
            else
                return false;
            
        }

        //public void CopyTo(T[] array, int arrayIndex)
        //{
        //    //lijstStapel.CopyTo(array);
        //    trow new NotIpmle
        //}

        public List<T> Copy(List<T> copy)
        {
            List<T> lijstStapel2 = new List<T>();
            foreach (T toevoegen in copy)
            {
                lijstStapel2.Add(toevoegen);
            }
            return lijstStapel2;
        }

        //internal void CopyTo(int[] lijstStapel2, int v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
