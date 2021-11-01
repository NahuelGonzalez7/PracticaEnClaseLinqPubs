using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFLinQ.Data;

namespace WindowsEFLinQ
{
    public partial class Form1 : Form
    {
        //Crear una instancia del DBCONTEXT a nivel frm.
        NorthwindContext context = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodosProdutcots_Click(object sender, EventArgs e)
        {
            //Traer todos los productos
            var lista = (from p in context.Products
                         select p).ToList();

            grdProductos.DataSource = lista;
        }

        private void btnTraerPorCategoria_Click(object sender, EventArgs e)
        {
            int categoriaID = 2;

            var lista = (from p in context.Products
                         where p.CategoryID == categoriaID
                         select p).ToList();

            grdProductos.DataSource = lista;
        }

        private void btnTraerPorNombreProducto_Click(object sender, EventArgs e)
        {
            string productoOrigen = "Tofu";

            var producto = (from p in context.Products
                            where p.ProductName == productoOrigen
                            select p).SingleOrDefault();

            MessageBox.Show(producto.ProductName + " " + producto.UnitPrice.ToString());
        }

        private void btnTraerPorID_Click(object sender, EventArgs e)
        {
            int ID = 3;
            var producto = (from p in context.Products
                            where p.ProductID == ID
                            select p).SingleOrDefault();
            MessageBox.Show(producto.ProductName + " " + producto.UnitPrice.ToString());
        }

        private void btnTraerProductoCategoria_Click(object sender, EventArgs e)
        {
            var lista = (from 
                         c in context.Categories
                         join
                         p in context.Products
                         on c.CategoryID equals p.CategoryID
                         select new
                         {
                             c.CategoryID, 
                             Category = c.CategoryName,
                             Product = p.ProductName,
                             p.UnitPrice
                         }
                         ).ToList(); 
            grdProductos.DataSource = lista;
        }
    }
}
