using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class Instructor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Salary { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<DeptInst> DeptInsts { get; set; } = new List<DeptInst>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
