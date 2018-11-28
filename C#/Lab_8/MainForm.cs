using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            AnimalForm af = new AnimalForm(animal);
            if(af.ShowDialog() == DialogResult.OK)
            {
                tbAnimalInfo.Text += string.Format(
                "--------------------------------------------------------\r\n" +
                "Данные про животное: \r\n" +
                "--------------------------------------------------------\r\n" +
                "Имя: {0}; \r\n" +
                "Вид: {1}; \r\n" +
                "Порода: {2}; \r\n" +
                "Цвет: {3}; \r\n" +
                "Возраст: {4}; \r\n" +
                "Вес: {5} кг; \r\n", animal.Name, animal.Type, animal.Breed, animal.Color, animal.Age, animal.Weight);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Прекратить роботу?", "Завершение работы", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
