using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLot
{
    public partial class Cars : Form
    {
        Functions Con; // Об'єкт класу Functions для взаємодії з базою даних
        public Cars()
        {
            InitializeComponent();
            Con = new Functions(); // Ініціалізація об'єкта класу Functions
            ShowCars(); // Відображення списку автомобілів під час завантаження форми
        }

        private void ShowCars()
        {
            string Query = "select * from CarsTbl"; // Запит для вибору всіх автомобілів з бази даних
            CarsDGV.DataSource = Con.GetData(Query);  // Встановлення даних у DataGridView з результатами запиту
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Перевірка на введення всіх обов'язкових даних
            if (PNumberTb.Text == "" || DriverTb.Text == "" || CarType.Text == "" || ColorTb.Text == "") 
            {
                MessageBox.Show("Невірні дані!!!");
            }else
            {
                try
                {
                    // Отримання даних про новий автомобіль з полів введення
                    string PNumber = PNumberTb.Text;
                    string Driver = DriverTb.Text;
                    string Gen = GenTb.SelectedItem.ToString();
                    string CType = CarType.Text;
                    string Color = ColorTb.Text;

                    // Формування запиту для додавання нового автомобіля до бази даних
                    string Query = "insert into CarsTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, PNumber, Driver, Gen, CType, Color);

                    // Виклик методу для збереження даних у базі даних
                    Con.SetData(Query);
                    MessageBox.Show("Авто додано!!!");
                    ShowCars(); // Оновлення відображення списку автомобілів
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0; // Змінна для збереження ключа редагованого автомобіля
        private void EditBtn_Click(object sender, EventArgs e)
        {
            // Перевірка на введення всіх обов'язкових даних
            if (PNumberTb.Text == "" || DriverTb.Text == "" || CarType.Text == "" || ColorTb.Text == "")
            {
                MessageBox.Show("Невірні дані!!!");
            }
            else
            {
                try
                {
                    // Отримання даних про автомобіль з полів введення
                    string PNumber = PNumberTb.Text;
                    string Driver = DriverTb.Text;
                    string Gen = GenTb.SelectedItem.ToString();
                    string CType = CarType.Text;
                    string Color = ColorTb.Text;

                    // Формування запиту для редагування автомобіля у базі даних
                    string Query = "update CarsTbl set PNumber = '{0}', Driver = '{1}', Gender = '{2}', CarType = '{3}', Color = '{4}' where CNum = {5}";
                    Query = string.Format(Query, PNumber, Driver, Gen, CType, Color, Key);

                    // Виклик методу для збереження змін у базі даних
                    Con.SetData(Query);
                    MessageBox.Show("Авто відредаговано!!!");
                    ShowCars(); // Оновлення відображення списку автомобілів
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Перевірка на наявність вибраного автомобіля для видалення
            if (Key == 0)
            {
                MessageBox.Show("Виберіть авто!!!");
            }
            else
            {
                try
                {
                    // Формування запиту для видалення автомобіля з бази даних
                    string Query = "delete from CarsTbl  where CNum = {0}";
                    Query = string.Format(Query, Key);

                    // Виклик методу для виконання запиту на видалення
                    Con.SetData(Query);
                    MessageBox.Show("Авто видалено!!!");
                    ShowCars(); // Оновлення відображення списку автомобілів
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CarsDGV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Перевірка на зміну стану рядка та його вибір
            if (e.StateChanged == DataGridViewElementStates.Selected && e.Row != null && e.Row.Index >= 0 && e.Row.Index < CarsDGV.Rows.Count)
            {
                // Оновлення полів введення даних автомобіля відповідно до вибраного рядка
                PNumberTb.Text = e.Row.Cells[1].Value?.ToString();
                DriverTb.Text = e.Row.Cells[2].Value?.ToString();
                GenTb.SelectedItem = e.Row.Cells[3].Value?.ToString();
                CarType.Text = e.Row.Cells[4].Value?.ToString();
                ColorTb.Text = e.Row.Cells[5].Value?.ToString();

                // Оновлення ключа вибраного автомобіля для подальшої роботи з ним
                if (PNumberTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(e.Row.Cells[0].Value);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Перехід до модуля машини
            Cars Obj = new Cars();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Перехід до модуля парковка
            Parking Obj = new Parking();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Перехід до модуля місця
            Places Obj = new Places();
            Obj.Show();
            this.Hide();
        }


        // Кнопка закрити 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // перехід до модуля логін
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
