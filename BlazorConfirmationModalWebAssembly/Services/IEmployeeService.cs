using BlazorConfirmationModalWebAssembly.Data;
using BlazorConfirmationModalWebAssembly.Models;

namespace BlazorConfirmationModalWebAssembly.Services
{
    public interface IEmployeeService
    {
        Task addNewEmployeeAsync(Employee emloyee);
    }

    public class EmployeeService : IEmployeeService
    {
        public async Task addNewEmployeeAsync(Employee emloyee)
        {
            using (var dbcontext = new ApplicationDbContext())
            {
                await dbcontext.employees.AddAsync(emloyee);
                await dbcontext.SaveChangesAsync();
            }
        }
    }
}
