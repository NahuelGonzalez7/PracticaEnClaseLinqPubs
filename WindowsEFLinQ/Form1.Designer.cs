
namespace WindowsEFLinQ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTraerTodosProdutcots = new System.Windows.Forms.Button();
            this.btnTraerPorCategoria = new System.Windows.Forms.Button();
            this.btnTraerPorNombreProducto = new System.Windows.Forms.Button();
            this.btnTraerPorID = new System.Windows.Forms.Button();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.btnTraerProductoCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodosProdutcots
            // 
            this.btnTraerTodosProdutcots.Location = new System.Drawing.Point(58, 12);
            this.btnTraerTodosProdutcots.Name = "btnTraerTodosProdutcots";
            this.btnTraerTodosProdutcots.Size = new System.Drawing.Size(209, 41);
            this.btnTraerTodosProdutcots.TabIndex = 0;
            this.btnTraerTodosProdutcots.Text = "Traer todos los productos";
            this.btnTraerTodosProdutcots.UseVisualStyleBackColor = true;
            this.btnTraerTodosProdutcots.Click += new System.EventHandler(this.btnTraerTodosProdutcots_Click);
            // 
            // btnTraerPorCategoria
            // 
            this.btnTraerPorCategoria.Location = new System.Drawing.Point(58, 59);
            this.btnTraerPorCategoria.Name = "btnTraerPorCategoria";
            this.btnTraerPorCategoria.Size = new System.Drawing.Size(209, 41);
            this.btnTraerPorCategoria.TabIndex = 1;
            this.btnTraerPorCategoria.Text = "Traer todos los productos por categoria";
            this.btnTraerPorCategoria.UseVisualStyleBackColor = true;
            this.btnTraerPorCategoria.Click += new System.EventHandler(this.btnTraerPorCategoria_Click);
            // 
            // btnTraerPorNombreProducto
            // 
            this.btnTraerPorNombreProducto.Location = new System.Drawing.Point(58, 106);
            this.btnTraerPorNombreProducto.Name = "btnTraerPorNombreProducto";
            this.btnTraerPorNombreProducto.Size = new System.Drawing.Size(209, 41);
            this.btnTraerPorNombreProducto.TabIndex = 2;
            this.btnTraerPorNombreProducto.Text = "Traer por Nombre del Producto";
            this.btnTraerPorNombreProducto.UseVisualStyleBackColor = true;
            this.btnTraerPorNombreProducto.Click += new System.EventHandler(this.btnTraerPorNombreProducto_Click);
            // 
            // btnTraerPorID
            // 
            this.btnTraerPorID.Location = new System.Drawing.Point(58, 153);
            this.btnTraerPorID.Name = "btnTraerPorID";
            this.btnTraerPorID.Size = new System.Drawing.Size(209, 41);
            this.btnTraerPorID.TabIndex = 3;
            this.btnTraerPorID.Text = "Traer por ID";
            this.btnTraerPorID.UseVisualStyleBackColor = true;
            this.btnTraerPorID.Click += new System.EventHandler(this.btnTraerPorID_Click);
            // 
            // grdProductos
            // 
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Location = new System.Drawing.Point(12, 200);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.Size = new System.Drawing.Size(776, 238);
            this.grdProductos.TabIndex = 4;
            // 
            // btnTraerProductoCategoria
            // 
            this.btnTraerProductoCategoria.Location = new System.Drawing.Point(330, 12);
            this.btnTraerProductoCategoria.Name = "btnTraerProductoCategoria";
            this.btnTraerProductoCategoria.Size = new System.Drawing.Size(175, 41);
            this.btnTraerProductoCategoria.TabIndex = 5;
            this.btnTraerProductoCategoria.Text = "Traer ProductoCategoria";
            this.btnTraerProductoCategoria.UseVisualStyleBackColor = true;
            this.btnTraerProductoCategoria.Click += new System.EventHandler(this.btnTraerProductoCategoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTraerProductoCategoria);
            this.Controls.Add(this.grdProductos);
            this.Controls.Add(this.btnTraerPorID);
            this.Controls.Add(this.btnTraerPorNombreProducto);
            this.Controls.Add(this.btnTraerPorCategoria);
            this.Controls.Add(this.btnTraerTodosProdutcots);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodosProdutcots;
        private System.Windows.Forms.Button btnTraerPorCategoria;
        private System.Windows.Forms.Button btnTraerPorNombreProducto;
        private System.Windows.Forms.Button btnTraerPorID;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.Button btnTraerProductoCategoria;
    }
}

