using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp12Julio.basedatos;

namespace WindowsFormsApp12Julio.repo
{
    class ClienteRepo
    {
        public static void Insertar(Clientes cli)
        {
            using (var contexto = new BaseContexto())
            {
                contexto.Clientes.Add(cli);
                contexto.SaveChanges();
            }
        }
        public static List<Clientes>  ListarTodo()
        {
            var resultado=new List<Clientes>();
            using (var contexto = new BaseContexto())
            {
                resultado= contexto.Clientes.ToList();
            }
            return resultado;
        }
    }
}
