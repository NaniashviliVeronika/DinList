using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinList
{
    class Node
    {
        public string val;
        public Node adr;

        //конструктор
        public Node() { }
        public Node(string c)
        { val = c; adr = null; }


        public string ToString()
        {
            return val.ToString();
        }

    }

    public class DinSteck
    {
        Node top = null;

        public DinSteck() { }
       
        public void Push(string c)
        {
            Node temp = new Node(c);
            temp.adr = top;
            top = temp;

        }
        public string ToString()
        {
            string rez = "";
            Node current = top;
            while(current!=null)
            {
                rez += current.ToString();
                current = current.adr;
               
            }
            return rez;
        }

        public string Pop()
        {
            if(!isEmpty())
            {
                string rez = top.val;
                top = top.adr;
                return rez;
            }
            return string.Empty;
            

        }
        public string Peek()
        {
            if (!isEmpty())
            {
                return  top.val;
                
            }
            return string.Empty;
        }
        public bool isEmpty()
        {
            if (top == null) return true;
            return false;
        }
    }


    class Program
    {
        static string sk_open = "({[<";
        static string sk_close = ")}]>";

        static bool para(char close, char open)
        {
            int ind_open = sk_open.IndexOf(open);
            char temp_close=sk_close[ind_open];
            return temp_close == close;
        }
        static void Main(string[] args)
        {
            
            string sk = "([]{()})";
            DinSteck st = new DinSteck();
            string ans = "YES";
            //foreach(var c in sk)
            //{

            //    if (sk_open.IndexOf(c) >= 0)
            //        st.Push(c);
            //    else 
            //    {
            //        if (!st.isEmpty())
            //        {
            //            char temp = st.Pop();//открывающаяся из стека
            //            if (!para(c, temp))
            //            {
            //                ans = "NO";
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            ans = "NO";
            //            break;
            //        }
            //    }
            //}
            if (!st.isEmpty()) ans = "NO";
            Console.WriteLine(ans);
           
        }
    }
}
