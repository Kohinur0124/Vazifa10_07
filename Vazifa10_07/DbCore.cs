using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;
using Vazifa10_07.Classlar;

namespace Vazifa10_07
{
    public static class DbCore
    {
        private static string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=0124;Database=dvdrental;";

        public static IEnumerable<T> GetObject<T>(string tablename){

            //string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=0124;Database=dvdrental;";
            var con = new NpgsqlConnection(connectionString);
            string sql = $"select * from public.{tablename};";
            con.Open();

            var Objects = con.Query<T>(sql);
            con.Close();
            return Objects;

        }
        
        public static IEnumerable<actor> GetByNameActor(string first_name ,string lastname)
        {

            //string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=0124;Database=dvdrental;";
            var con = new NpgsqlConnection(connectionString);
            string sql = $"select * from public.actor where first_name='{first_name}' or last_name = '{lastname}' ;";
            con.Open();

            var Objects = con.Query<actor>(sql);
            con.Close();
            return Objects;

        }
        
        public static IEnumerable<actor> GetByIdActor(int i)
        {

            //string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=0124;Database=dvdrental;";
            var con = new NpgsqlConnection(connectionString);
            string sql = $"select * from public.actor where actor_id = '{i}' ;";
            con.Open();

            var Objects = con.Query<actor>(sql);
            con.Close();
            return Objects;

        }
        
        public static void Print<T>(IEnumerable <T> objects)
        {
            foreach (var object1 in objects)
            {
                Console.WriteLine(object1);
            }


        }
        
        static public void AddActor(actor a)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {

                var sqlQuery = $"INSERT INTO public.actor VALUES('{a.actor_id}', '{a.first_name}', '{a.last_name}', '{a.last_update}');";
                connection.Query(sqlQuery);
            }
        }

        public static void RemoveActor(int i)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {

                var sqlQuery1 = $"Delete from film_actor Where actor_id = {i}; ";
                var sqlQuery = $"Delete from actor Where actor_id = {i}; ";
                connection.Execute(sqlQuery1);
                connection.Execute(sqlQuery);
            }


        }

        public static void UpdateActor(actor a)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {

                var sqlQuery = $"Update actor set first_name = '{a.first_name}',last_name = '{a.last_name}'," +
                    $"last_update = '{DateTime.Now}' Where actor_id = '{a.actor_id}'; ";
                connection.Execute(sqlQuery);
            }


        }

        public static void DeleteAll()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {

                var sqlQuery1 = $"Delete from film_actor; ";
                var sqlQuery = $"Delete from actor; ";
                connection.Execute(sqlQuery1);
                connection.Execute(sqlQuery);
            }


        }

        public static void DeleteByName(string first_name,string last_name)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {

                var sqlQuery1 = $"Delete from film_actor Where actor_id in (select actor_id from actor where first_name='{first_name}' and last_name ='{last_name}'); ";
                var sqlQuery = $"Delete from public.actor where first_name='{first_name}' and last_name ='{last_name}'; ";
                connection.Execute(sqlQuery1);
                connection.Execute(sqlQuery);
            }


        }


    }
}

