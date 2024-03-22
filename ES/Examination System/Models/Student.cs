using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? DeptId { get; set; }

    public virtual ICollection<ExamStQ> ExamStQs { get; set; } = new List<ExamStQ>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
