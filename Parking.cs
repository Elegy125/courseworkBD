using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLot
{
    public partial class Parking : Form
    {
        public Parking()
        {
            InitializeComponent();
            Con = new Functions(); // Ініціалізація об'єкта класу Functions
            GetCars(); // Отримання списку автомобілів
            GetPlaces(); // Отримання списку вільних місць
            ShowBookings(); // Відображення бронювань парковок
        }
        Functions Con; // Об'єкт класу Functions для взаємодії з базою даних
        private void GetCars()
        {
            string Query = "select * from CarsTbl";  // Запит для вибору всіх автомобілів з бази даних
            Cars.ValueMember = Con.GetData(Query).Columns["CNum"].ToString(); // Встановлення значень для властивостей Value та DisplayMember об'єкта Cars
            Cars.DisplayMember = Con.GetData(Query).Columns["PNumber"].ToString();
            Cars.DataSource = Con.GetData(Query); // Встановлення даних у ComboBox Place
        }

        private void GetPlaces()
        {
            string PSt = "Вільно";
            string Query = "select * from PlaceTbl where PStatus= '{0}'"; // Запит для вибору вільних місць з бази даних
            Query = string.Format(Query, PSt); // Форматування запиту з врахуванням статусу місць
            Place.ValueMember = Con.GetData(Query).Columns["PlNum"].ToString(); // Встановлення значень для властивостей Value та DisplayMember об'єкта Place
            Place.DisplayMember = Con.GetData(Query).Columns["Pposition"].ToString(); 
            Place.DataSource = Con.GetData(Query); // Встановлення даних у ComboBox Place

        }
        private void ShowBookings()
        {
            // Запит для вибору даних про бронювання парковок з бази даних
            String Query = "SELECT CarsTbl.Pnumber, CarsTbl.Driver, ParkingTbl.Care, ParkingTbl.Date, ParkingTbl.Duration, ParkingTbl.Amount, ParkingTbl.Place, ParkingTbl.[Worker Tag], Workers.Name, Workers.Position\r\nFROM Workers INNER JOIN (PlaceTbl INNER JOIN (CarsTbl INNER JOIN ParkingTbl ON CarsTbl.CNum = ParkingTbl.Care) ON PlaceTbl.PlNum = ParkingTbl.Place) ON Workers.Tag = ParkingTbl.[Worker Tag];\r\n";
            ParkingDGV.DataSource = Con.GetData(Query);
        }

        private void UpdateStatus()
        {
            try
            {
                string PSt = "Заброньовано"; // Новий статус парковочного місця
                string Places = Place.SelectedValue.ToString(); // Отримання значення вибраного парковочного місця
                string Query = "update PlaceTbl set PStatus = '{0}' where PlNum = {1}"; // Запит для оновлення статусу парковочного місця у базі даних

                Query = string.Format(Query, PSt, Places); // Форматування запиту з врахуванням нового статусу та номера місця
                Con.SetData(Query); // Виклик методу для збереження змін у базі даних
                MessageBox.Show("Місце відредаговано!!!"); 
               // ShowPlaces();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        private void BookBtn_Click(object sender, EventArgs e)
        {
            // Перевірка на заповненість всіх обов'язкових полів
            if (Cars.SelectedIndex == -1 || Place.SelectedIndex == -1 || AmountTb.Text == "" || DurationTb.Text == "" || TagTb.Text =="")
            {
                MessageBox.Show("Некоректні дані!!!");
            }
            else
            {
                try
                {
                    // Отримання даних для бронювання парковочного місця з відповідних полів введення
                    string Car = Cars.SelectedValue.ToString();
                    string Duration = DurationTb.Text;
                    int Amount = Convert.ToInt32(AmountTb.Text);
                    string Places = Place.SelectedValue.ToString();
                    string Number = TagTb.Text;

                    // Формування запиту для додавання запису про бронювання у базу даних
                    string Query = "insert into ParkingTbl values ('{0}', '{1}', '{2}', '{3}', '{4}','{5}')";
                    Query = string.Format(Query, Car, System.DateTime.Today.ToString("yyyy-MM-dd"), Duration, Amount, Place.SelectedValue, Number);

                    // Виклик методу для виконання запиту та збереження даних у базі даних
                    Con.SetData(Query);
                    MessageBox.Show("Місце заброньовано!!!");
                    ShowBookings(); // Оновлення відображення списку бронювань
                    UpdateStatus(); // Оновлення статусу парковочного місця
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // перехід до модуля машини
            Cars Obj = new Cars();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // перехід до модуля місця
            Places Obj = new Places();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Cars Obj = new Cars();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // перехід до модуля парковка
            Parking Obj = new Parking();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Places Obj = new Places();
            Obj.Show();
            this.Hide();
        }

        // кнопка виходу
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            // оновлення даних
            ShowBookings();
        }

        private void ShowTagBtn_Click(object sender, EventArgs e)
        {
            // Перевірка на наявність введеного номеру працівника
            if (TagTb.Text == "")
            {
                MessageBox.Show("Введіть номер працівника!!!");
            }
            else
            {
                try
                {
                    string tagName = TagTb.Text; // Отримання номеру працівника з поля введення
                    // Запит для вибору даних про бронювання парковок для введеного працівника
                    string Query = "SELECT CarsTbl.Pnumber, CarsTbl.Driver, ParkingTbl.Care, ParkingTbl.Date, ParkingTbl.Duration, ParkingTbl.Amount, ParkingTbl.Place, ParkingTbl.[Worker Tag], Workers.Name, Workers.Position " +
                                   "FROM PlaceTbl " +
                                   "INNER JOIN (CarsTbl INNER JOIN (Workers INNER JOIN ParkingTbl ON Workers.Tag = ParkingTbl.[Worker Tag]) ON CarsTbl.CNum = ParkingTbl.Care) ON PlaceTbl.PlNum = ParkingTbl.Place " +
                                   "WHERE Workers.Tag = @TagName;"; 

                    // Викликаємо функцію для отримання даних з використанням параметра tagName
                    DataTable dt = Con.GetDataWithParameter(Query, "@TagName", tagName);

                    // Перевірка наявності результатів запиту
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Записів не знайдено для введеного номеру працівника.");
                    }
                    else
                    {
                        // Відображаємо результат у DataGridView
                        ParkingDGV.DataSource = dt;
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
