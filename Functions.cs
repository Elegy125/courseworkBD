using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    internal class Functions
    {
        private SqlConnection Con; // Підключення до бази даних
        private SqlCommand Cmd; // SQL-команда
        private DataTable dt; // Об'єкт для зберігання даних в форматі таблиці
        private SqlDataAdapter Sda; // Адаптер для взаємодії з базою даних
        private string ConStr; // Рядок підключення до бази даних

        public Functions() {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ilya\Documents\ParkingLot.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        // Метод для виконання запиту SELECT та отримання даних з бази даних
        public DataTable GetData(string Query) {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, ConStr);
            Sda.Fill(dt);
            return dt;
        }

        // Метод для виконання запиту INSERT, UPDATE або DELETE та збереження змін у базі даних
        public int SetData(string Query)
        {
            int Cnt = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }

        // Метод для виконання запиту SELECT з параметром та отримання даних з бази даних
        public DataTable GetDataWithParameter(string Query, string parameterName, string parameterValue)
        {
            dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(Query, Con))
            {
                cmd.Parameters.AddWithValue(parameterName, parameterValue);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

    }
}
