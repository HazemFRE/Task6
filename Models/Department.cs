using System;
using System.Collections.Generic;

namespace Task6.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string Name { get; set; } = null!;

    public string ManagerName { get; set; } = null!;

    public string OfficeLocation { get; set; } = null!;

    public int EmployeeCount { get; set; }
}
