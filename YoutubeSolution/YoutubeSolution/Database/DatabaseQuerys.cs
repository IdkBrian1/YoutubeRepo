using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using YoutubeSolution.Models;

namespace YoutubeSolution.Database
{
    public class DatabaseQuerys
    {
        #region Creacion - Tabla - DbPath 
        readonly SQLiteAsyncConnection _database;

        public DatabaseQuerys(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);


            #region Creacion - Tablas

            _database.CreateTableAsync<UserModel>().Wait();
            #endregion
        }

        #endregion


        #region CRUD - USER TABLE

        /* METOD-O SELECT SEARCH BAR()*/
        public Task<UserModel> GetUserModelAynsc(int id)
        {
            return _database.Table<UserModel>()
                            .Where(i => i.UserID == id)
                            .FirstOrDefaultAsync();
        }

        /* METOD-O SELECT ()*/
        public Task<List<UserModel>> GetUserModel()
        {
            return _database.Table<UserModel>().ToListAsync();
        }

        /* METOD-O GUARDAR Y ACTUALIZAR ()*/
        public Task<int> SaveUserModelAsync(UserModel userModel)
        {
            if (userModel.UserID != 0)
            {
                return _database.UpdateAsync(userModel);
            }
            else
            {
                return _database.InsertAsync(userModel);
            }
        }

        /* METOD-O ELIMINAR () */
        public Task<int> DeleteUserModelAsync(UserModel userModel)
        {
            return _database.DeleteAsync(userModel);
        }

        public Task<List<UserModel>> GetUsersValidate(string email, string password)
        {
            return _database.QueryAsync<UserModel>("SELECT * FROM UserModel WHERE EmailField = '" + email + "' AND PasswordField = '" + password + "'");
        }

        #endregion
    }
}
