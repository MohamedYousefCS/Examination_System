﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Examination_System.Models;

public partial class CourseDepartment
{
    public int CourseId { get; set; }

    public int DepartmentId { get; set; }

    public int? Duration { get; set; }

    public virtual Course Course { get; set; }

    public virtual Department Department { get; set; }
}