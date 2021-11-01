using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPubs.Data;

namespace WindowsPubs
{
    public partial class Form1 : Form
    {
        PubsContext context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodosLosAutores_Click(object sender, EventArgs e)
        {
            var lista = (from p in context.authors
                         select p).ToList();
            gridAuthors.DataSource = lista;
        }

        private void btnTraerLosPublicadores_Click(object sender, EventArgs e)
        {
            var lista = (from p in context.publishers
                         select p).ToList();
            gridAuthors.DataSource = lista;
        }

        private void btnTraerAutoresxCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = "Oakland";

            var lista = (from p in context.authors
                         where p.city == ciudad
                         select p).ToList();

            gridAuthors.DataSource = lista;
        }

        private void btnTraerAutorxID_Click(object sender, EventArgs e)
        {
            string ID = "172-32-1176";

            var author = (from p in context.authors
                         where p.au_id == ID
                         select p).SingleOrDefault();

            MessageBox.Show("\n " + author.au_lname + "\n "+ author.au_fname + "\n " + author.address + "\n " + author.city);
        }

        private void btnTraerPublicadorxNombre_Click(object sender, EventArgs e)
        {
            string consulta = "Ramona Publishers";

            var publishers = (from p in context.publishers
                              where p.pub_name == consulta
                              select p).SingleOrDefault();

            MessageBox.Show("\n " + publishers.pub_id + "\n " + publishers.pub_name + "\n " + publishers.city + "\n " + publishers.state + "\n " + publishers.country);
        }

        private void btnMostrarSalesyStores_Click(object sender, EventArgs e)
        {
            //Id, NombreTienda, Ciudad, NroOrden, fecha, Cantidad y IdTitulo
            var lista = (from p in context.sales
                         join
                         s in context.stores
                         on p.stor_id equals s.stor_id
                         select new
                         {
                             p.stor_id,
                             NombreTienda = s.stor_name,
                             Ciudad = s.city,
                             NroOrden = p.ord_num,
                             Fecha = p.ord_date,
                             Cantidad = p.qty,
                             IdTitulo = p.title_id
                         }
                         ).ToList();
            gridAuthors.DataSource = lista;
        }

        private void btnMostrarEmployeeYpublisher_Click(object sender, EventArgs e)
        {
            //Nombre, apellido, nombre del publicador
            var lista = (from employee in context.employees
                         join
                         publisher in context.publishers
                         on employee.pub_id equals publisher.pub_id
                         select new
                         {
                             Nombre = employee.fname,
                             Apellido = employee.lname,
                             NombrePublicador = publisher.pub_name
                         }
                         ).ToList();
            gridAuthors.DataSource = lista;
        }

        private void btnEmpleadoxPais_Click(object sender, EventArgs e)
        {
            //Nombre, apellido, nombre del publicador
            string pais = "USA";
            var lista = (from employee in context.employees
                         join
                         publisher in context.publishers
                         on employee.pub_id equals publisher.pub_id
                         where publisher.country == pais
                         select new
                         {
                             Nombre = employee.fname,
                             Apellido = employee.lname,
                             NombrePublicador = publisher.pub_name
                         }
                         ).ToList();
            gridAuthors.DataSource = lista;
        }
        
    }
}
