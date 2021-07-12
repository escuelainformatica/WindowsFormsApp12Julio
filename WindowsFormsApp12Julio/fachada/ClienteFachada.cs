using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp12Julio.basedatos;

namespace WindowsFormsApp12Julio.fachada
{
    // Fachada/ Facade = a clases de servicio que sirven:
    // * para transformar una clase en otra.
    // * para tener funciones cercano a la interface visual.

    class ClienteFachada
    {
        public static Clientes FactoryForm(TextBox rut,TextBox nombre,TextBox apellido)
        {
            Clientes cli = new Clientes();
            cli.Rut = rut.Text;
            cli.Nombre = nombre.Text;
            cli.Apellido = apellido.Text;
            return cli;
        }

        /// <summary>
        /// una funcion factory, es una funcion que se usa para crear un objeto.
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public static Clientes FactoryForm(Form1 form)
        {
            Clientes cli = new Clientes();
            // el cuadro de texto tiene que tener la propiedad modifier en public.
            // O puede ir al designer, y cambiar la propiedad a publica
            cli.Rut = form.textBoxRut.Text;
            cli.Nombre = form.textBoxNombre.Text;
            cli.Apellido = form.textBoxApellido.Text;
            return cli;
        }

        /// <summary>
        /// La funcion render sirve para dibujar (visualmente) un valor, en este
        /// caso sirve para dibujar un objeto del tipo cliente
        /// </summary>
        /// <param name="form"></param>
        /// <param name="cli"></param>
        public static void RenderForm(Form1 form,Clientes cli)
        {
            form.textBoxRut.Text=cli.Rut;
            form.textBoxNombre.Text = cli.Nombre;
            form.textBoxApellido.Text = cli.Apellido;
        }
    }
}
