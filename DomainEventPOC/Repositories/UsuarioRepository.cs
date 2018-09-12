using DomainEventPOC.Domain.Model;
using System;
using System.IO;

namespace DomainEventPOC.Repositories
{
    public class UsuarioRepository
    {
        private readonly StreamWriter writer;
        private readonly StreamReader reader;
        private readonly string dbPath;

        public UsuarioRepository()
        {
            dbPath = $"{Directory.GetCurrentDirectory()}\\TxtData\\Usuarios.txt";
            writer = new StreamWriter(dbPath, true);
            reader = new StreamReader(dbPath);
        }

        public async void AddAsync(Usuario usuario)
        {
            var userAsJson = Newtonsoft.Json.JsonConvert.SerializeObject(usuario);
            
            await writer.WriteLineAsync(userAsJson);
            
            Dispose();
        }

        private void Dispose()
        {
            writer.Dispose();
            reader.Dispose();
        }

        public async void UpdatePassword(Guid usuarioId, string novaSenha)
        {
            string[] allUsers = File.ReadAllLines(dbPath);
            string newUserData = string.Empty;
            int indexToChange = 0;

            for(int i = 0; i < allUsers.Length; i++)
            {
                string userData = allUsers[i];
                if (userData.Contains(usuarioId.ToString()))
                {
                    indexToChange = i;
                    var properties = userData.Split(',');
                    foreach (var property in properties)
                    {
                        var propertyName = property.Split(':')[0];
                        var propertyValue = property.Split(':')[1];
                        var oldValue = property.Split(':')[1];

                        if (propertyName.Equals("Senha"))
                        {
                            propertyValue = $"\"{novaSenha}\"";
                            newUserData = userData.Replace(oldValue, propertyValue);
                        }
                    }
                }
            }

            allUsers[indexToChange] = newUserData;
            File.WriteAllLines(dbPath, allUsers);
            Dispose();
        }
    }
}
