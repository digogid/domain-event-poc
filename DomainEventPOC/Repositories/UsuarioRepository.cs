using DomainEventPOC.Domain.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEventPOC.Repositories
{
    public class UsuarioRepository
    {
        public async void AddAsync(Usuario usuario)
        {
            var userAsJson = Newtonsoft.Json.JsonConvert.SerializeObject(usuario);
            var writer = new StreamWriter($"{Directory.GetDirectoryRoot(Directory.GetCurrentDirectory())}/TxtData/Usuario.txt");

            await writer.WriteLineAsync(userAsJson);
        }
    }
}
