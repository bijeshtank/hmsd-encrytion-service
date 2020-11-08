using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using TankWebApp.ApiGateway.Helper;

namespace TankWebApp.ApiGateway.Services
{
    public class EncryptionService : IEncryptionService
    {
        private string passphrase;

        public EncryptionService(IOptions<GatewayEncryptionSettings> options)
        {
            passphrase = options.Value.Passphrase;
         
        }

        public async Task<string> Encrypt(string data)
        {
            return EncryptionHelper.EncryptString(data, passphrase);
        }

        public async Task<string> Decrypt(string data)
        {
            return EncryptionHelper.DecryptString(data, passphrase);
        }

    }

}