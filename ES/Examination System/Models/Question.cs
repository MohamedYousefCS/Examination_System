using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class Question
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public string Title { get; set; } = null!;

    public byte Type { get; set; }

    public int Grade { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<ExamStQ> ExamStQs { get; set; } = new List<ExamStQ>();

    public virtual ICollection<QuestionChoice> QuestionChoices { get; set; } = new List<QuestionChoice>();
}
