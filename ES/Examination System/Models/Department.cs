using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class Department
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? BranchId { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<DeptInst> DeptInsts { get; set; } = new List<DeptInst>();
}
