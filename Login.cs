using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLot
{
    public partial class Login : Form
    {
        private SqlConnection Con; // З'єднання з базою даних
        private string ConStr; // Рядок підключення до бази даних

        public Login()
        {
            InitializeComponent();
            // Ініціалізація рядка підключення
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ilya\Documents\ParkingLot.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr); // Ініціалізація об'єкта з'єднання з базою даних
        }

        // кнопка закрити
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Отримання логіну та паролю користувача з полей введення
            string username = LoginTb.Text;
            string password = PasswordTb.Text;

            // Перевірка на заповненість обох полів введення
            if (LoginTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Введіть логін та пароль!");
            }
            else if (ValidateLogin(username, password)) // Перевірка введеного логіну та паролю
            {
                MessageBox.Show("Вхід у систему: Успішно!");
                // вхід у систему
                Cars Obj = new Cars();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль!");
            }
            
        }

        private bool ValidateLogin(string username, string password)
        {
            bool isValid = false; // Початкове значення перевірки вірності логіну та паролю
            try
            {
                // Запит для перевірки наявності в базі даних відповідного запису з логіном та паролем
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                // Виконання запиту до бази даних
                using (SqlConnection connection = new SqlConnection(ConStr))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Додавання параметру логіну та паролю до запиту
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open(); // Відкриття з'єднання з базою даних

                        // Виконання запиту та отримання кількості відповідних записів у базі даних
                        int count = (int)command.ExecuteScalar();

                        // Якщо є відповідний запис, то isValid = true
                        if (count > 0)
                            isValid = true; 

                    }
                }
            }
            catch (Exception ex)
            {
                // Обробка помилки
                Console.WriteLine("Error: " + ex.Message);
            }
            return isValid; // Повернення значення перевірки вірності логіну та паролю
        }

    }
}
