using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class QuestionChoice
{
    public int QId { get; set; }

    public string Choice { get; set; } = null!;

    public bool IsCorrect { get; set; }

    public virtual Question QIdNavigation { get; set; } = null!;
}
