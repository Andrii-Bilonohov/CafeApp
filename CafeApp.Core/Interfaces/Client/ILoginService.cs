using CafeApp.Core.DTOs.Inputs;
using CafeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApp.Core.Interfaces.Client
{
    public interface ILoginService
    {
        Task<Customer> Login(LoginDto loginDto, CancellationToken cancellationToken);
    }
}
