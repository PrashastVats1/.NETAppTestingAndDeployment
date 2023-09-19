using System;
using System.Collections.Generic;

namespace EmployeeMgmt.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Fname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public double? Salary { get; set; }

    public string? Designation { get; set; }
}
