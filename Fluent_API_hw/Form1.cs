using Fluent_API_hw; // Пространство имён ManageContext
using Microsoft.EntityFrameworkCore; // Для работы с DbContext
using System; // Для Convert.ToInt32
using Fluent_API_hw;
using Models;
using System.CodeDom;
using System.Diagnostics.Metrics;

namespace Fluent_API_hw
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }


        private void ClearAreas()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private async void Add()
        {

            string name = textBox1.Text.Trim();
            string surname = textBox2.Text.Trim();
            if (!int.TryParse(textBox3.Text, out int age))
            {
                MessageBox.Show("Enter a correct age!");
                return;
            }
            string position = textBox4.Text.Trim();
            if (!int.TryParse(textBox5.Text, out int salary))
            {
                MessageBox.Show("Enter a correct salary!");
                return;
            }

            if (name == "" || surname == "" || position == "")
            {
                MessageBox.Show("Not specified one of values");
            }
            if (!int.TryParse(textBox3.Text, out int sal))
            {
                MessageBox.Show("Salary is not a valid number.");
                return;
            }


            using (var db = new ManageContext())
            {
                var existingPosition = await db.Positions.FirstOrDefaultAsync(p => p.Name == position);

                if (existingPosition == null)
                {
                    existingPosition = new Position(position, salary);
                    await db.Positions.AddAsync(existingPosition);
                    await db.SaveChangesAsync(); // Сохраняем новую позицию
                }

                var worker = new Worker
                {
                    Name = name,
                    Surname = surname,
                    Age = age,
                    PositionId = existingPosition.Id // Привязываем к существующей позиции
                };

                await db.Workers.AddAsync(worker);
                await db.SaveChangesAsync();
            }

            ClearAreas();
        }

        private async void Remove()
        {

            string surname = textBox2.Text.Trim();

            using (var db = new ManageContext())
            {

                if (string.IsNullOrWhiteSpace(surname))
                {
                    MessageBox.Show("Please enter a  surname.");
                    return;
                }

                var remove = await db.Workers.Where(c => c.Surname == surname).ToListAsync();
                if (remove.Count == 0)
                {
                    MessageBox.Show("An employee not found.");
                    return;
                }

                db.Workers.RemoveRange(remove);
                await db.SaveChangesAsync();
            }
            ClearAreas();
        }

        private async void Edit()
        {
            string name = textBox1.Text.Trim();
            string surname = textBox2.Text.Trim();
            if (!int.TryParse(textBox3.Text, out int age))
            {
                MessageBox.Show("Enter a correct age!");
                return;
            }

            string position = textBox4.Text.Trim();
            if (!int.TryParse(textBox5.Text, out int salary))
            {
                MessageBox.Show("Enter a correct salary!");
                return;
            }

            using (var db = new ManageContext())
            {
                var query = await db.Workers.SingleOrDefaultAsync(c => c.Surname == surname);

                if (query == null)
                {
                    MessageBox.Show("An employee not found.");
                    return;
                }

                // Обновляем данные
                query.Name = name;
                query.Surname = surname;
                query.Age = age;
                query.Position = new Position(position, salary);
                await db.SaveChangesAsync();
            }

        }


          private async void FindByName()
        {
            listBox1.Items.Clear();

            string name = textBox6.Text;

            if(name == null)
            {
                return;
            }
            try
            {
                using (var db = new ManageContext())
                {

                    var workers = await db.Workers.Where(c => c.Name == name).ToListAsync();

                    foreach (var worker in workers)
                    {
                        listBox1.Items.Add(worker);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


         
            
        }

        private async void FindBySurname()
        {
            listBox1.Items.Clear();

            string surname = textBox6.Text;

            if (surname == null)
            {
                return;
            }
            try
            {
                using (var db = new ManageContext())
                {

                    var workers = await db.Workers.Where(c => c.Surname == surname).ToListAsync();


                    foreach (var worker in workers)
                    {
                        listBox1.Items.Add(worker);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private async void FindByAge()
        {
            listBox1.Items.Clear();

            int age = Convert.ToInt32(textBox6.Text);

            if (age == 0)
            {
                return;
            }
            try
            {
                using (var db = new ManageContext())
                {

                    var workers = await db.Workers.Where(c => c.Age == age).ToListAsync();

                    foreach (var worker in workers)
                    {
                        listBox1.Items.Add(worker);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void FindBySalary()
        {
            listBox1.Items.Clear();

            int salary = Convert.ToInt32(textBox6.Text);

            if (salary == 0)
            {
                return;
            }
            try
            {
                using (var db = new ManageContext())
                {

                    var workers = await db.Workers.Where(c => c.Position.Salary == salary).ToListAsync();

                    foreach (var worker in workers)
                    {
                        listBox1.Items.Add(worker);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             

        }


        private async void FindByPosition()
        {
            listBox1.Items.Clear();

            string position = textBox6.Text;

            if (position == null)
            {
                return;
            }
            try
            {
                using (var db = new ManageContext())
                {

                    var workers = await db.Workers.Where(c => c.Position.Name == position).ToListAsync();

                    foreach (var worker in workers)
                    {
                        listBox1.Items.Add(worker);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                FindByName();
            }

            if (radioButton2.Checked)
            {
                FindBySurname();
            }

            if (radioButton3.Checked)
            {
                FindByAge();
            }

            if (radioButton4.Checked)
            {
                FindByPosition();
            }

            if (radioButton5.Checked)
            {
                FindBySalary();
            }
        }
    }
}
