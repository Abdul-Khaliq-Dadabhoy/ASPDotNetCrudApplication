using System;
using System.Collections.Generic;

namespace AbdulKhaliqDotNet.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Semester { get; set; }

    public int? Age { get; set; }

    public string? Contact { get; set; }
}
