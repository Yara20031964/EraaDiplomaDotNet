using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Week05
{
    internal class TrueORFalse : Question 
    {
        public TrueORFalse(string Qlevel, QType QHeader, string QBody, int QMark) :base(Qlevel, QHeader, QBody, QMark)
        {}

        public override void Print ()
        {
            Console.WriteLine($"Type of the Question: ({QHeader}), (QLevel: {Qlevel}), (QMark: {QMark})");
            Console.WriteLine($"Q: {QBody}");
            Console.Write("Options: True / False enter number between (1...2) ");
            Console.WriteLine();
        }
    }
}
