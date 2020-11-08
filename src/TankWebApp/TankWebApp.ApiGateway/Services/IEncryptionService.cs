using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TankWebApp.ApiGateway.Services
{
    public interface IEncryptionService
    {
        Task<string> Encrypt(string data);

        Task<string> Decrypt(string data);
    }
}
