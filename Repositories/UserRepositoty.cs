using Microsoft.EntityFrameworkCore;
using Nightclub.Context;
using Nightclub.Models;

namespace Nightclub.Repositories
{
    public interface IUserRepositoty
    {
        Task<List<Client>> GetAll();
        List<Type_rol> GetAll(int id_type_rol);
        Task<Client> CreateUser(int Id_Client, string name_client, string surname_client, string document_number, int type_documentId);
        Client UpdateUser(Client client);
        Client DeleteUser(int id);

    }
    //Obliga a implementar todas las funciones
    public class UserRespository : IUserRepositoty
    {
        private readonly UserDbContext _db;

        public UserRespository(UserDbContext db)
        {
            _db = db;

        }

        public async Task<Client> CreateUser(int Id_Client, string name_client, string surname_client, string type_documentIdnumber, int type_documentId)
        {
            Client newClient = new Client { Id_client = Id_Client, name_client = name_client, surname_client = surname_client, document_number = type_documentIdnumber, type_documentId = type_documentId };
            _db.Clients.Add(newClient);
            await _db.SaveChangesAsync();
            return newClient;

        }

        public Client DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Client>> GetAll()
        {
            return await _db.Clients.ToListAsync();
        }


        public List<Type_rol> GetAll(int id_type_rol)
        {
            throw new NotImplementedException();
        }

        public Client UpdateUser(Client client)
        {
            throw new NotImplementedException();
        }
    }
}