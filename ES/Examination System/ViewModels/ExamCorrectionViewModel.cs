using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.ViewModels
{
    internal class ExamCorrectionViewModel
    {
        public int Question_ID { get; set; }
        public string Title { get; set; }
        public string Question_type { get; set; }
        public int QuestionFullMark { get; set; }
        public int StudentMarks { get; set; }
        public string choice { get; set; }
    }
}
