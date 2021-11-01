
namespace WindowsPubs
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
            this.btnTraerTodosLosAutores = new System.Windows.Forms.Button();
            this.btnTraerLosPublicadores = new System.Windows.Forms.Button();
            this.btnTraerAutoresxCiudad = new System.Windows.Forms.Button();
            this.btnTraerAutorxID = new System.Windows.Forms.Button();
            this.gridAuthors = new System.Windows.Forms.DataGridView();
            this.btnTraerPublicadorxNombre = new System.Windows.Forms.Button();
            this.btnMostrarSalesyStores = new System.Windows.Forms.Button();
            this.btnMostrarEmployeeYpublisher = new System.Windows.Forms.Button();
            this.btnEmpleadoxPais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraerTodosLosAutores
            // 
            this.btnTraerTodosLosAutores.Location = new System.Drawing.Point(13, 12);
            this.btnTraerTodosLosAutores.Name = "btnTraerTodosLosAutores";
            this.btnTraerTodosLosAutores.Size = new System.Drawing.Size(142, 37);
            this.btnTraerTodosLosAutores.TabIndex = 0;
            this.btnTraerTodosLosAutores.Text = "Traer todos los Autores";
            this.btnTraerTodosLosAutores.UseVisualStyleBackColor = true;
            this.btnTraerTodosLosAutores.Click += new System.EventHandler(this.btnTraerTodosLosAutores_Click);
            // 
            // btnTraerLosPublicadores
            // 
            this.btnTraerLosPublicadores.Location = new System.Drawing.Point(13, 55);
            this.btnTraerLosPublicadores.Name = "btnTraerLosPublicadores";
            this.btnTraerLosPublicadores.Size = new System.Drawing.Size(142, 37);
            this.btnTraerLosPublicadores.TabIndex = 1;
            this.btnTraerLosPublicadores.Text = "Traer todos los Publicadores";
            this.btnTraerLosPublicadores.UseVisualStyleBackColor = true;
            this.btnTraerLosPublicadores.Click += new System.EventHandler(this.btnTraerLosPublicadores_Click);
            // 
            // btnTraerAutoresxCiudad
            // 
            this.btnTraerAutoresxCiudad.Location = new System.Drawing.Point(13, 98);
            this.btnTraerAutoresxCiudad.Name = "btnTraerAutoresxCiudad";
            this.btnTraerAutoresxCiudad.Size = new System.Drawing.Size(142, 37);
            this.btnTraerAutoresxCiudad.TabIndex = 2;
            this.btnTraerAutoresxCiudad.Text = "Traer Autores por Ciudad";
            this.btnTraerAutoresxCiudad.UseVisualStyleBackColor = true;
            this.btnTraerAutoresxCiudad.Click += new System.EventHandler(this.btnTraerAutoresxCiudad_Click);
            // 
            // btnTraerAutorxID
            // 
            this.btnTraerAutorxID.Location = new System.Drawing.Point(13, 141);
            this.btnTraerAutorxID.Name = "btnTraerAutorxID";
            this.btnTraerAutorxID.Size = new System.Drawing.Size(142, 37);
            this.btnTraerAutorxID.TabIndex = 3;
            this.btnTraerAutorxID.Text = "Traer Autor por ID";
            this.btnTraerAutorxID.UseVisualStyleBackColor = true;
            this.btnTraerAutorxID.Click += new System.EventHandler(this.btnTraerAutorxID_Click);
            // 
            // gridAuthors
            // 
            this.gridAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthors.Location = new System.Drawing.Point(13, 211);
            this.gridAuthors.Name = "gridAuthors";
            this.gridAuthors.Size = new System.Drawing.Size(775, 227);
            this.gridAuthors.TabIndex = 4;
            // 
            // btnTraerPublicadorxNombre
            // 
            this.btnTraerPublicadorxNombre.Location = new System.Drawing.Point(181, 12);
            this.btnTraerPublicadorxNombre.Name = "btnTraerPublicadorxNombre";
            this.btnTraerPublicadorxNombre.Size = new System.Drawing.Size(139, 37);
            this.btnTraerPublicadorxNombre.TabIndex = 5;
            this.btnTraerPublicadorxNombre.Text = "Traer publicador por nombre";
            this.btnTraerPublicadorxNombre.UseVisualStyleBackColor = true;
            this.btnTraerPublicadorxNombre.Click += new System.EventHandler(this.btnTraerPublicadorxNombre_Click);
            // 
            // btnMostrarSalesyStores
            // 
            this.btnMostrarSalesyStores.Location = new System.Drawing.Point(181, 55);
            this.btnMostrarSalesyStores.Name = "btnMostrarSalesyStores";
            this.btnMostrarSalesyStores.Size = new System.Drawing.Size(139, 36);
            this.btnMostrarSalesyStores.TabIndex = 6;
            this.btnMostrarSalesyStores.Text = "Mostrar Sales y Stores";
            this.btnMostrarSalesyStores.UseVisualStyleBackColor = true;
            this.btnMostrarSalesyStores.Click += new System.EventHandler(this.btnMostrarSalesyStores_Click);
            // 
            // btnMostrarEmployeeYpublisher
            // 
            this.btnMostrarEmployeeYpublisher.Location = new System.Drawing.Point(181, 98);
            this.btnMostrarEmployeeYpublisher.Name = "btnMostrarEmployeeYpublisher";
            this.btnMostrarEmployeeYpublisher.Size = new System.Drawing.Size(139, 37);
            this.btnMostrarEmployeeYpublisher.TabIndex = 7;
            this.btnMostrarEmployeeYpublisher.Text = "Mostrar Employee y Publisher";
            this.btnMostrarEmployeeYpublisher.UseVisualStyleBackColor = true;
            this.btnMostrarEmployeeYpublisher.Click += new System.EventHandler(this.btnMostrarEmployeeYpublisher_Click);
            // 
            // btnEmpleadoxPais
            // 
            this.btnEmpleadoxPais.Location = new System.Drawing.Point(181, 141);
            this.btnEmpleadoxPais.Name = "btnEmpleadoxPais";
            this.btnEmpleadoxPais.Size = new System.Drawing.Size(139, 36);
            this.btnEmpleadoxPais.TabIndex = 8;
            this.btnEmpleadoxPais.Text = "Mostrar empleados por pais";
            this.btnEmpleadoxPais.UseVisualStyleBackColor = true;
            this.btnEmpleadoxPais.Click += new System.EventHandler(this.btnEmpleadoxPais_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmpleadoxPais);
            this.Controls.Add(this.btnMostrarEmployeeYpublisher);
            this.Controls.Add(this.btnMostrarSalesyStores);
            this.Controls.Add(this.btnTraerPublicadorxNombre);
            this.Controls.Add(this.gridAuthors);
            this.Controls.Add(this.btnTraerAutorxID);
            this.Controls.Add(this.btnTraerAutoresxCiudad);
            this.Controls.Add(this.btnTraerLosPublicadores);
            this.Controls.Add(this.btnTraerTodosLosAutores);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraerTodosLosAutores;
        private System.Windows.Forms.Button btnTraerLosPublicadores;
        private System.Windows.Forms.Button btnTraerAutoresxCiudad;
        private System.Windows.Forms.Button btnTraerAutorxID;
        private System.Windows.Forms.DataGridView gridAuthors;
        private System.Windows.Forms.Button btnTraerPublicadorxNombre;
        private System.Windows.Forms.Button btnMostrarSalesyStores;
        private System.Windows.Forms.Button btnMostrarEmployeeYpublisher;
        private System.Windows.Forms.Button btnEmpleadoxPais;
    }
}

