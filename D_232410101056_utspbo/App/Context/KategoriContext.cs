
    using D_232410101056_utspbo.App.Core;
    using Npgsql;
    using NpgsqlTypes;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using D_232410101056_utspbo.App.Core;
    using D_232410101056_utspbo.App.Models;
namespace D_232410101056_utspbo.App.Context
{
    internal class KategoriContext : DatabaseWrapper
    {
        private static string table = "kategori";
        public static DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataKategori = queryExecutor(query);
            return dataKategori;
        }
        public static void AddKategori(K_Kategori newKategori)
        {
            string query = $"INSERT INTO {table} (nama_kategori) values (@nama_kategori)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_kategori", NpgsqlDbType.Varchar){Value =
                newKategori.nama_kategori},
};
            commandExecutor(query, parameters);
        }
        public static void UpdateKategori(K_Kategori editKategori)
        {
            string query = $"UPDATE {table} SET nama_kategori = @nama_kategori WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_kategori", NpgsqlDbType.Varchar){Value =
                editKategori.nama_kategori},
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = editKategori.id}
};
            commandExecutor(query, parameters);
        }
        public static void DeleteKategori(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},};
            commandExecutor(query, parameters);
        }
}