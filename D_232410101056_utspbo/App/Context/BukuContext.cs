
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
    internal class BukuContext : DatabaseWrapper
    {
        private static string table = "buku";
        public static DataTable All()
        {
            string query = @"
            SELECT
            b.id,
            b.judul,
            b.pengarang,
            b.tahun,
            b.id_kategori,
            k.nama_kategori
            FROM
            buku b
            JOIN
            kategori k ON b.id = k.id";
            DataTable databuku = queryExecutor(query);
            return databuku;
        }
        public static DataTable getBukuById(int id)
        {
            string query = @"
            SELECT
            b.id,
            b.judul,
            b.pengarang,
            b.tahun,
            b.id_kategori,
            k.nama_kategori
            FROM
            buku b
            JOIN
            kategori k ON b.id = k.id
            WHERE
            b.id = @id";
            NpgsqlParameter[] parameters =
            {
new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
};
            DataTable databuku = queryExecutor(query, parameters);
            return databuku;
        }
        public static void AddBuku(B_Buku bukuBaru)
        {
            string query = $"INSERT INTO {table} (judul, pengarang, tahun, id_kategori) VALUES(@judul, @pengarang, @tahun, @id_kategori)";

        NpgsqlParameter[] parameters =
        {
            new NpgsqlParameter("@judul", bukuBaru.judul),
            new NpgsqlParameter("@pengarang", bukuBaru.pengarang),
            new NpgsqlParameter("@tahun", bukuBaru.tahun),
            new NpgsqlParameter("@id_kategori", bukuBaru.id_kategori)
};
            commandExecutor(query, parameters);
        }
        public static void UpdateBuku(B_Buku buku)
        {
            string query = $"UPDATE {table} SET judul = @judul, pengarang = @pengarang, tahun = @tahun, id_kategori = @id_kategori WHERE id = @id";
       
            NpgsqlParameter[] parameters =
        {
            new NpgsqlParameter("@judul", buku.judul),
            new NpgsqlParameter("@pengarang", buku.pengarang),
            new NpgsqlParameter("@tahun", buku.tahun),
            new NpgsqlParameter("@id_kategori", buku.id_kategori),
            new NpgsqlParameter("@id", buku.id)
};
            commandExecutor(query, parameters);
        }
        public static void DeleteBuku(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", id)};
            commandExecutor(query, parameters);
        }
    }
}