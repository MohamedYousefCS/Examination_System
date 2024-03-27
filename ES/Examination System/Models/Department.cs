﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? BranchId { get; set; }

    public virtual Branch Branch { get; set; }

    public virtual ICollection<DeptInst> DeptInsts { get; set; } = new List<DeptInst>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}