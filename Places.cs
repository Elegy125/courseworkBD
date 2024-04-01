using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLot
{
    public partial class Places : Form
    {
        public Places()
        {
            InitializeComponent();
            Con = new Functions(); // Ініціалізація об'єкта класу Functions
            ShowPlaces(); // Відображення списку місць під час завантаження форми
        }
        Functions Con;
        private void ShowPlaces()
        {
            string Query = "select * from PlaceTbl"; // Запит для вибору всіх місць з бази даних
            PlaceDGV.DataSource = Con.GetData(Query); // Встановлення даних у DataGridView з результатами запиту
        }
        private void AddPlace_Click(object sender, EventArgs e)
        {
            // Перевірка на введення всіх обов'язкових даних
            if (PositionTb.Text == "" || StatusTb.SelectedIndex == -1)
            {
                MessageBox.Show("Невірні дані!!!");
            }
            else
            {
                try
                {
                    // Отримання даних про нове місце з полів введення
                    string Position = PositionTb.Text;
                    string Status = StatusTb.SelectedItem.ToString();

                    // Формування запиту для додавання нового місця до бази даних
                    string Query = "insert into PlaceTbl values('{0}','{1}')";
                    Query = string.Format(Query, Position, Status);

                    // Виклик методу для збереження даних у базі даних
                    Con.SetData(Query);
                    MessageBox.Show("Місце додано!!!");
                    ShowPlaces(); // Оновлення відображення списку місць
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0; // Змінна для збереження ключа редагованого місця
        private void PlaceDGV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // Перевірка на зміну стану рядка та його вибір
            if (e.StateChanged == DataGridViewElementStates.Selected && e.Row != null && e.Row.Index >= 0 && e.Row.Index < PlaceDGV.Rows.Count)
            {
                // Оновлення полів введення даних місця відповідно до вибраного рядка
                PositionTb.Text = e.Row.Cells[1].Value?.ToString();
                StatusTb.Text = e.Row.Cells[2].Value?.ToString();

                // Оновлення ключа вибраного місця для подальшої роботи з ним
                if (PositionTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(e.Row.Cells[0].Value);
                }
            }
        }

        private void EditPlace_Click(object sender, EventArgs e)
        {
            // Перевірка на введення всіх обов'язкових даних
            if (PositionTb.Text == "" || StatusTb.SelectedIndex == -1)
            {
                MessageBox.Show("Невірні дані!!!");
            }
            else
            {
                try
                {
                    // Отримання даних про місце з полів введення
                    string Position = PositionTb.Text;
                    string Status = StatusTb.SelectedItem.ToString();

                    // Формування запиту для редагування місця у базі даних
                    string Query = "update PlaceTbl set Pposition = '{0}', PStatus = '{1}' where PlNum = {2}";
                    Query = string.Format(Query, Position, Status, Key);

                    // Виклик методу для збереження змін у базі даних
                    Con.SetData(Query);
                    MessageBox.Show("Місце відредаговано!!!");
                    ShowPlaces(); // Оновлення відображення списку місць
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeletePlace_Click(object sender, EventArgs e)
        {
            // Перевірка на наявність вибраного місця для видалення
            if (PositionTb.Text == "" || StatusTb.SelectedIndex == -1)
            {
                MessageBox.Show("Невірні дані!!!");
            }
            else
            {
                try
                {
                    // Отримання даних про місце з полів введення
                    string Position = PositionTb.Text;
                    string Status = StatusTb.SelectedItem.ToString();

                    // Формування запиту для видалення автомобіля з бази даних
                    string Query = "Delete from PlaceTbl where PlNum = {0}";
                    Query = string.Format(Query, Key);

                    // Виклик методу для виконання запиту на видалення
                    Con.SetData(Query);
                    MessageBox.Show("Місце видалено!!!");
                    ShowPlaces(); // Оновлення відображення списку місць
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // перехід до модуля парковка
            Parking Obj = new Parking();    
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // перехід до машини
            Cars Obj = new Cars();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // перехід до місця
            Places Obj = new Places();
            Obj.Show();
            this.Hide();
        }

        // Кнопка виходу
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
