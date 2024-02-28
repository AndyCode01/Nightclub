using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nightclub.Models;

namespace Nightclub.Repositories
{
    public interface IUserRepositoty
    {
        List <Client> GetAll();
        List<Type_rol>GetAll(int id_type_rol);
        void CreateUser (Client client);
        void updtaeUser (Client client);
        void DeleteUser(int id);

    }
    //Obliga a implementar todas las funciones
    public class UserRespository : IUserRepositoty
    {
        public void CreateUser(Client client)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Type_rol> GetAll(int id_type_rol)
        {
            throw new NotImplementedException();
        }

        public void updtaeUser(Client client)
        {
            throw new NotImplementedException();
        }
    }
}