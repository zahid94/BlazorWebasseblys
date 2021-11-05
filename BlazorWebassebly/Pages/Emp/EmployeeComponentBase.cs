using BlazorWebasseblys.Models.Emp;
using BlazorWebasseblys.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebassebly.Pages.Emp
{
    public class EmployeeComponentBase:ComponentBase
    {
        public IList<Employee> Employees { get; set; }

        protected override async Task<object> OnInitializedAsync()
        {
            EmployeeService employeeService = new();
            Employees = await employeeService.Get("sample-data/employees.json");
            return base.OnInitializedAsync();
        }
    }
}
