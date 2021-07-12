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
using WindowsFormsApp12Julio.fachada;
using WindowsFormsApp12Julio.repo;

// CODE BEHIND (codigo por detras)

namespace WindowsFormsApp12Julio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // funcion que se llama cuando se ejecuta una operacion evento)
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // 1) entity framework. OK
            // 2) crear un objeto cliente  OK
            // 3) insertarlo en la base de datos.

            Clientes cli = ClienteFachada.FactoryForm(this); // <-- this indica el objeto actual
            ClienteRepo.Insertar(cli);
            MessageBox.Show("Cliente insertado","Titulo",MessageBoxButtons.OK);
            Clientes cliVacio=new Clientes();
            ClienteFachada.RenderForm(this,cliVacio);// borrando el formulario.

            this.Close(); // cierro el formulario actual


            //Button boton=new Button();
            //boton.Text="hohoh";
            //this.components.Add(boton);
        }

        private void textBoxRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListar formulario=new FormListar();
            formulario.ShowDialog();
        }
    }
}
