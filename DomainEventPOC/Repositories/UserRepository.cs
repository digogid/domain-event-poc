using DomainEventPOC.Domain.Model;
using DomainEventPOC.Interfaces.Repositories;
using System;
using System.IO;

namespace DomainEventPOC.Repositories
{
    public class UserRepository : IUserRepository
    {
        private StreamWriter writer;
        private readonly string dbPath;

        public UserRepository()
        {
            dbPath = $"{Directory.GetCurrentDirectory()}\\TxtData\\Usuarios.txt";
        }

        public async void AddAsync(User user)
        {
            writer = new StreamWriter(dbPath, true);
            var userAsJson = Newtonsoft.Json.JsonConvert.SerializeObject(user);
            
            await writer.WriteLineAsync(userAsJson);
            Dispose();
        }

        private void Dispose()
        {
            if (writer != null)
                writer.Dispose();

            writer = null;
        }

        public async void UpdatePassword(Guid userId, string newPassword)
        {
            string[] allUsers = File.ReadAllLines(dbPath);
            string newUserData = string.Empty;
            int indexToChange = 0;

            for(int i = 0; i < allUsers.Length; i++)
            {
                string userData = allUsers[i];
                if (userData.Contains(userId.ToString()))
                {
                    indexToChange = i;
                    var properties = userData.Split(',');
                    foreach (var property in properties)
                    {
                        var propertyName = property.Split(':')[0];
                        var propertyValue = property.Split(':')[1];
                        var oldValue = property.Split(':')[1];

                        if (propertyName.Equals("\"Password\""))
                        {
                            propertyValue = $"\"{newPassword}\"}}";
                            newUserData = userData.Replace(oldValue, propertyValue);
                        }
                    }
                }
            }

            allUsers[indexToChange] = newUserData;
            await File.WriteAllLinesAsync(dbPath, allUsers);
        }
    }
}
