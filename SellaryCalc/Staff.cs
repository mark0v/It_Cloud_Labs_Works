using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SellaryCalc
{
    public class Staff : IEnumerable<Worker>, IEnumerator<Worker>
    {
        public List<Worker> Emploees { get; set; }
        private int Index { get; set; }


        public Worker Current
        {
            get { return Emploees[Index]; }          
        } 

        object IEnumerator.Current
        {
            get { return Emploees[Index]; }
        }

        public Staff()
        {
            Emploees = new List<Worker>();
        }

        public IEnumerator<Worker> GetEnumerator()
        {
            return Emploees.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (Index == Emploees.Count-1)
            {
                Reset();
                return false;
            }
            Index++;
            return true;
        }

        public void Reset()
        {
            Index = -1;
        }

        public void Dispose()
        {
            Emploees = null;
        }
    }
}
