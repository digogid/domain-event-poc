using DomainEventPOC.Domain.Model;
using System.IO;

namespace DomainEventPOC.Repositories
{
    public class UsuarioRepository
    {
        public async void AddAsync(Usuario usuario)
        {
            var userAsJson = Newtonsoft.Json.JsonConvert.SerializeObject(usuario);
            var writer = new StreamWriter($"{Directory.GetCurrentDirectory()}\\TxtData\\Usuarios.txt", true);

            await writer.WriteLineAsync(userAsJson);
            
            writer.Dispose();
        }
    }
}
