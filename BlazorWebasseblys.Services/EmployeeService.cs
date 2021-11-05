using BlazorWebasseblys.Models.Emp;
using BlazorWebasseblys.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebasseblys.Services
{
    public class EmployeeService : HttpService<Employee>, IEmployeeService
    {
        public async Task<IList<Employee>> GetEmployees(string url)
        {
            return await Get(url);
        }
    }

    public interface IEmployeeService
    {
        Task<IList<Employee>> GetEmployees(string url);
    }
}
