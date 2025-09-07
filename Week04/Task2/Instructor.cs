using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public Instructor(int InstructorId, string Name, string Specialization)
        {
            this.InstructorId = InstructorId;
            this.Name = Name;
            this.Specialization = Specialization;
        }
        public string PrintDetails()
        {
            return $"InstructorId: {InstructorId}, Name: {Name}, Specialization: {Specialization} ";
        }
    }
}
