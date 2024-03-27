#nullable disable
using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public int? BranchId { get; set; }

    public int? DeptId { get; set; }

    public virtual Branch Branch { get; set; }

    public virtual Department Dept { get; set; }

    public virtual ICollection<ExamStQ> ExamStQs { get; set; } = new List<ExamStQ>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}