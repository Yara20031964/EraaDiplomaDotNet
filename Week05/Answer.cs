using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05
{
    //Each Answer contain text and is correct or not to make with this class list of answer
    internal class Answer
    {
        public string Text {  get; set; }
        public bool IsCorrect { get; set; }
        public Answer(string text, bool correct)
        {
            Text = text;
            IsCorrect = correct;
        }
    }
}
