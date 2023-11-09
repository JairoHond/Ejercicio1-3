using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_3.Controladores
{
    public class Personas
    {
        readonly SQLiteAsyncConnection _connection;
        public Personas(string dbpath)
        {
            _connection = new SQLiteAsyncConnection(dbpath);
            _connection.CreateTableAsync<Modelos.Persona>().Wait();

        }

        public Task<int> StorePersonas(Modelos.Persona person)
        {
            if (person.Id != 0)
            {
                return _connection.UpdateAsync(person);
            }
            else
            {
                return _connection.InsertAsync(person);
            }
        }

        public Task<List<Modelos.Persona>> ListaPersonas()
        {
            return _connection.Table<Modelos.Persona>().ToListAsync();
        }


        public Task<Modelos.Persona> ObtenerPersonas(int pid)
        {
            return _connection.Table<Modelos.Persona>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }

        public Task<int> DeletePersonas(Modelos.Persona person)
        {
            return _connection.DeleteAsync(person);
        }

    }
}
