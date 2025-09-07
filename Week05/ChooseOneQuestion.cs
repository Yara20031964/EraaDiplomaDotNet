using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Week05
{
    internal class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string Qlevel, QType QHeader, string QBody, int QMark) : base(Qlevel, QHeader, QBody, QMark)
        { }

        public override void Print()
        {
            Console.WriteLine($"Type of the Question: ({QHeader}), (QLevel: {Qlevel}), (QMark: {QMark})");
            Console.WriteLine($"Q: {QBody}");
            int i = 1;
            foreach (var ans in Answers)
            {
                Console.WriteLine($"{i++}) {ans.Text}");
            }
        }
    }
}
