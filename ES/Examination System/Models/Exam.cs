using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class Exam
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int NumTf { get; set; }

    public int NumMcq { get; set; }

    public virtual ICollection<ExamStQ> ExamStQs { get; set; } = new List<ExamStQ>();
}
