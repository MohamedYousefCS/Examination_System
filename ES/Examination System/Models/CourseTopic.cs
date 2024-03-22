using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class CourseTopic
{
    public int CourseId { get; set; }

    public string Topic { get; set; } = null!;

    public virtual Course Course { get; set; } = null!;
}
