using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TankWebApp.ApiGateway.Services;

namespace TankWebApp.ApiGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EncryptionController : ControllerBase
    {
        IEncryptionService _encryptionService;

        public EncryptionController(IEncryptionService encryptionService)
        {
            _encryptionService = encryptionService;
        }


        [HttpPost]
        [Route("encrypt")]
        public async Task<IActionResult> Encrypt([FromBody]string data)
        {
            var encryptedData = await _encryptionService.Encrypt(data);

            return Ok(encryptedData);
        }

        [HttpPost]
        [Route("decrypt")]
        public async Task<IActionResult> Decrypt([FromBody] string data)
        {
            var decryptedData = await _encryptionService.Decrypt(data);

            return Ok(decryptedData);
        }
    }
}
