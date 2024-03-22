using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class Branch
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
