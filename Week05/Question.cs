using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Week05
{
    internal abstract class Question
    {
        public string Qlevel { get; set; }
        public QType QHeader { get; set; }
        public string QBody { get; set; }
        public int QMark { get; set; }
        public List<Answer> Answers {  get; set; }

        public Question(string Qlevel, QType QHeader, string QBody, int QMark)
        {
            this.Qlevel = Qlevel;
            this.QHeader = QHeader;
            this.QBody = QBody;
            this.QMark = QMark;
            Answers = new List<Answer>();

        }
        public abstract void Print();

    }
}
