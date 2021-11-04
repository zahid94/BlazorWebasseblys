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
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            GetEmployees();
            return base.OnInitializedAsync();
        }

        public async void GetEmployees()
        {
            EmployeeService employeeService = new EmployeeService();
            var obj= await employeeService.Get("sample-data/employees.json");
            Employees = obj;
        }
    }
}
