using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp.DataStructure.LinarList;
using Csharp.DataStructure.LinarList.Interface;

namespace Csharp.DataStructure.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ILinarList<string> list = SequenceList<string>.GetInstance(3);
            Console.WriteLine(list.IsEmpty());
            list.InsertNode("aa");
            list.InsertNode("bb");
            list.InsertNode("cc");
            Console.WriteLine(list.IsEmpty());
            Console.WriteLine(list.GetLength());
            Console.WriteLine(list);
            Console.ReadLine();
        }
    }
}
