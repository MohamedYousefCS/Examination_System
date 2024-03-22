using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class DeptInst
{
    public int DeptId { get; set; }

    public int InstId { get; set; }

    public DateOnly? HiringDate { get; set; }

    public virtual Department Dept { get; set; } = null!;

    public virtual Instructor Inst { get; set; } = null!;
}
