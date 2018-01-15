using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.CBanco;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {

        private string nome, email, endereco, telefone, celular, cursos;

        public Form2()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void getValues()
        {
            nome = Convert.ToString(textBox1.Text);
            endereco = Convert.ToString(textBox2.Text);
            telefone = Convert.ToString(textBox3.Text);
            celular = Convert.ToString(textBox4.Text);
            email = Convert.ToString(textBox5.Text);
        }

        private void WriteInDBValues()
        {
            getValues();
            Console.WriteLine(nome + " | " + endereco + " | " + telefone + " | " + celular +" | "+ email);
            CadastrarAlunoSQL(nome, endereco, telefone, celular, email);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteInDBValues();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
