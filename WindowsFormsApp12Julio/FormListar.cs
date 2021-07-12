using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp12Julio.basedatos;
using WindowsFormsApp12Julio.repo;

namespace WindowsFormsApp12Julio
{
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            List<Clientes> clientes=ClienteRepo.ListarTodo();
            dataGridView1.DataSource=clientes;
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            Form1 form1=new Form1();
            form1.ShowDialog(); // esto muestra el formulario en modo exclusivo.
            List<Clientes> clientes = ClienteRepo.ListarTodo();
            dataGridView1.DataSource = clientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3=new Form3();
            form3.ShowDialog();
        }
    }
}
