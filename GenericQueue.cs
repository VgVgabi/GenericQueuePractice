using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace GenericQueuePractice
{
    class GenericQueue<TypeParameter>
    {               
        private Queue<TypeParameter> intQ = new Queue<TypeParameter>();
        //
        public int Count { get { return intQ.Count; } }
        public void Enqueue(TypeParameter number)
        {
             intQ.Enqueue(number);
        }
        //
        public object Dequeue()
        {           
            return intQ.Dequeue();
        }
        //
        public object Peek()
        {
            if (intQ.Count > 0)            
                return intQ.Peek();
            else
                return null;
        }
        //
        public bool Contains(TypeParameter number)
        {
            bool searchStatus = intQ.Contains(number);
            return searchStatus;
        }
        //                
        public object GetItemsTypeName()
        {
            return intQ.FirstOrDefault().GetType().Name;
        }
    }
}
