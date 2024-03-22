using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class ExamStQ
{
    public int ExamId { get; set; }

    public int StudentId { get; set; }

    public int QId { get; set; }

    public string? Answer { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual Question QIdNavigation { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
