using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ExcelentPupil : Pupil
    {
        public override string Read()
        {
            return "читает отлично";
        }
        public override string Study()
        {
            return "учится отлично";
        }
        public override string Write()
        {
            return "пишет отлично";
        }
        public override string Relax()
        {
            return "отдыхает отлично";
        }
    }
}
