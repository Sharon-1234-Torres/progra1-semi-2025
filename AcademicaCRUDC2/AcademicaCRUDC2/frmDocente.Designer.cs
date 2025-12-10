namespace AcademicaCRUDC2
{
    partial class frmDocente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbbusquedaDocente = new System.Windows.Forms.GroupBox();
            this.grdDocente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbuscarDocente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnmodificarDocente = new System.Windows.Forms.Button();
            this.btnagregarDocente = new System.Windows.Forms.Button();
            this.grbnavegacionDocente = new System.Windows.Forms.GroupBox();
            this.lblCantReg = new System.Windows.Forms.Label();
            this.btnultimoDocente = new System.Windows.Forms.Button();
            this.btnsiguienteDocente = new System.Windows.Forms.Button();
            this.btnanteriorDocente = new System.Windows.Forms.Button();
            this.btnprimerDocente = new System.Windows.Forms.Button();
            this.grbdatosDocente = new System.Windows.Forms.GroupBox();
            this.lblidDocente = new System.Windows.Forms.Label();
            this.txttelefonoDocente = new System.Windows.Forms.TextBox();
            this.lbltelefonoDocente = new System.Windows.Forms.Label();
            this.txtdireccionDocente = new System.Windows.Forms.TextBox();
            this.lbldireccionDocente = new System.Windows.Forms.Label();
            this.txtnombreDocente = new System.Windows.Forms.TextBox();
            this.lblnombreDocente = new System.Windows.Forms.Label();
            this.txtcodigoDocente = new System.Windows.Forms.TextBox();
            this.lblcodigoDocente = new System.Windows.Forms.Label();
            this.grbbusquedaDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbnavegacionDocente.SuspendLayout();
            this.grbdatosDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbbusquedaDocente
            // 
            this.grbbusquedaDocente.Controls.Add(this.grdDocente);
            this.grbbusquedaDocente.Controls.Add(this.txtbuscarDocente);
            this.grbbusquedaDocente.Location = new System.Drawing.Point(412, 61);
            this.grbbusquedaDocente.Name = "grbbusquedaDocente";
            this.grbbusquedaDocente.Size = new System.Drawing.Size(678, 290);
            this.grbbusquedaDocente.TabIndex = 12;
            this.grbbusquedaDocente.TabStop = false;
            this.grbbusquedaDocente.Text = "Busqueda docente";
            // 
            // grdDocente
            // 
            this.grdDocente.AllowUserToAddRows = false;
            this.grdDocente.AllowUserToDeleteRows = false;
            this.grdDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Nombre,
            this.Direccion,
            this.Telefono});
            this.grdDocente.Location = new System.Drawing.Point(36, 92);
            this.grdDocente.Name = "grdDocente";
            this.grdDocente.ReadOnly = true;
            this.grdDocente.RowHeadersWidth = 62;
            this.grdDocente.RowTemplate.Height = 28;
            this.grdDocente.Size = new System.Drawing.Size(635, 176);
            this.grdDocente.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IDdocente";
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 150;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 8;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Tel";
            this.Telefono.HeaderText = "Tel";
            this.Telefono.MinimumWidth = 8;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 150;
            // 
            // txtbuscarDocente
            // 
            this.txtbuscarDocente.Location = new System.Drawing.Point(19, 35);
            this.txtbuscarDocente.Name = "txtbuscarDocente";
            this.txtbuscarDocente.Size = new System.Drawing.Size(388, 26);
            this.txtbuscarDocente.TabIndex = 0;
            this.txtbuscarDocente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscarDocente_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarDocente);
            this.groupBox1.Controls.Add(this.btnmodificarDocente);
            this.groupBox1.Controls.Add(this.btnagregarDocente);
            this.groupBox1.Location = new System.Drawing.Point(522, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegación docente";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocente.Location = new System.Drawing.Point(308, 25);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(114, 55);
            this.btnEliminarDocente.TabIndex = 5;
            this.btnEliminarDocente.Text = "Elimi.";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // btnmodificarDocente
            // 
            this.btnmodificarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificarDocente.Location = new System.Drawing.Point(171, 25);
            this.btnmodificarDocente.Name = "btnmodificarDocente";
            this.btnmodificarDocente.Size = new System.Drawing.Size(131, 55);
            this.btnmodificarDocente.TabIndex = 4;
            this.btnmodificarDocente.Text = "Modif.";
            this.btnmodificarDocente.UseVisualStyleBackColor = true;
            this.btnmodificarDocente.Click += new System.EventHandler(this.btnmodificarDocente_Click);
            // 
            // btnagregarDocente
            // 
            this.btnagregarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarDocente.Location = new System.Drawing.Point(19, 25);
            this.btnagregarDocente.Name = "btnagregarDocente";
            this.btnagregarDocente.Size = new System.Drawing.Size(125, 55);
            this.btnagregarDocente.TabIndex = 3;
            this.btnagregarDocente.Text = "Agregar";
            this.btnagregarDocente.UseVisualStyleBackColor = true;
            this.btnagregarDocente.Click += new System.EventHandler(this.btnagregarDocente_Click);
            // 
            // grbnavegacionDocente
            // 
            this.grbnavegacionDocente.Controls.Add(this.lblCantReg);
            this.grbnavegacionDocente.Controls.Add(this.btnultimoDocente);
            this.grbnavegacionDocente.Controls.Add(this.btnsiguienteDocente);
            this.grbnavegacionDocente.Controls.Add(this.btnanteriorDocente);
            this.grbnavegacionDocente.Controls.Add(this.btnprimerDocente);
            this.grbnavegacionDocente.Location = new System.Drawing.Point(22, 357);
            this.grbnavegacionDocente.Name = "grbnavegacionDocente";
            this.grbnavegacionDocente.Size = new System.Drawing.Size(456, 100);
            this.grbnavegacionDocente.TabIndex = 13;
            this.grbnavegacionDocente.TabStop = false;
            this.grbnavegacionDocente.Text = "Navegación docente";
            // 
            // lblCantReg
            // 
            this.lblCantReg.AutoSize = true;
            this.lblCantReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantReg.Location = new System.Drawing.Point(187, 48);
            this.lblCantReg.Name = "lblCantReg";
            this.lblCantReg.Size = new System.Drawing.Size(65, 22);
            this.lblCantReg.TabIndex = 3;
            this.lblCantReg.Text = "x de n";
            // 
            // btnultimoDocente
            // 
            this.btnultimoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnultimoDocente.Location = new System.Drawing.Point(350, 25);
            this.btnultimoDocente.Name = "btnultimoDocente";
            this.btnultimoDocente.Size = new System.Drawing.Size(72, 55);
            this.btnultimoDocente.TabIndex = 5;
            this.btnultimoDocente.Text = ">|";
            this.btnultimoDocente.UseVisualStyleBackColor = true;
            this.btnultimoDocente.Click += new System.EventHandler(this.btnultimoDocente_Click);
            // 
            // btnsiguienteDocente
            // 
            this.btnsiguienteDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguienteDocente.Location = new System.Drawing.Point(268, 25);
            this.btnsiguienteDocente.Name = "btnsiguienteDocente";
            this.btnsiguienteDocente.Size = new System.Drawing.Size(71, 55);
            this.btnsiguienteDocente.TabIndex = 4;
            this.btnsiguienteDocente.Text = ">";
            this.btnsiguienteDocente.UseVisualStyleBackColor = true;
            this.btnsiguienteDocente.Click += new System.EventHandler(this.btnsiguienteDocente_Click);
            // 
            // btnanteriorDocente
            // 
            this.btnanteriorDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanteriorDocente.Location = new System.Drawing.Point(100, 25);
            this.btnanteriorDocente.Name = "btnanteriorDocente";
            this.btnanteriorDocente.Size = new System.Drawing.Size(65, 55);
            this.btnanteriorDocente.TabIndex = 3;
            this.btnanteriorDocente.Text = "<";
            this.btnanteriorDocente.UseVisualStyleBackColor = true;
            this.btnanteriorDocente.Click += new System.EventHandler(this.btnanteriorDocente_Click);
            // 
            // btnprimerDocente
            // 
            this.btnprimerDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprimerDocente.Location = new System.Drawing.Point(15, 25);
            this.btnprimerDocente.Name = "btnprimerDocente";
            this.btnprimerDocente.Size = new System.Drawing.Size(66, 55);
            this.btnprimerDocente.TabIndex = 2;
            this.btnprimerDocente.Text = "|<";
            this.btnprimerDocente.UseVisualStyleBackColor = true;
            this.btnprimerDocente.Click += new System.EventHandler(this.btnprimerDocente_Click);
            // 
            // grbdatosDocente
            // 
            this.grbdatosDocente.Controls.Add(this.lblidDocente);
            this.grbdatosDocente.Controls.Add(this.txttelefonoDocente);
            this.grbdatosDocente.Controls.Add(this.lbltelefonoDocente);
            this.grbdatosDocente.Controls.Add(this.txtdireccionDocente);
            this.grbdatosDocente.Controls.Add(this.lbldireccionDocente);
            this.grbdatosDocente.Controls.Add(this.txtnombreDocente);
            this.grbdatosDocente.Controls.Add(this.lblnombreDocente);
            this.grbdatosDocente.Controls.Add(this.txtcodigoDocente);
            this.grbdatosDocente.Controls.Add(this.lblcodigoDocente);
            this.grbdatosDocente.Enabled = false;
            this.grbdatosDocente.Location = new System.Drawing.Point(22, 46);
            this.grbdatosDocente.Name = "grbdatosDocente";
            this.grbdatosDocente.Size = new System.Drawing.Size(364, 305);
            this.grbdatosDocente.TabIndex = 11;
            this.grbdatosDocente.TabStop = false;
            this.grbdatosDocente.Text = "Datos docente";
            // 
            // lblidDocente
            // 
            this.lblidDocente.AutoSize = true;
            this.lblidDocente.Location = new System.Drawing.Point(6, 35);
            this.lblidDocente.Name = "lblidDocente";
            this.lblidDocente.Size = new System.Drawing.Size(30, 20);
            this.lblidDocente.TabIndex = 8;
            this.lblidDocente.Text = "ID:";
            // 
            // txttelefonoDocente
            // 
            this.txttelefonoDocente.Location = new System.Drawing.Point(87, 246);
            this.txttelefonoDocente.Name = "txttelefonoDocente";
            this.txttelefonoDocente.Size = new System.Drawing.Size(151, 26);
            this.txttelefonoDocente.TabIndex = 6;
            // 
            // lbltelefonoDocente
            // 
            this.lbltelefonoDocente.AutoSize = true;
            this.lbltelefonoDocente.Location = new System.Drawing.Point(11, 246);
            this.lbltelefonoDocente.Name = "lbltelefonoDocente";
            this.lbltelefonoDocente.Size = new System.Drawing.Size(71, 20);
            this.lbltelefonoDocente.TabIndex = 7;
            this.lbltelefonoDocente.Text = "Teléfono";
            // 
            // txtdireccionDocente
            // 
            this.txtdireccionDocente.Location = new System.Drawing.Point(87, 192);
            this.txtdireccionDocente.Name = "txtdireccionDocente";
            this.txtdireccionDocente.Size = new System.Drawing.Size(252, 26);
            this.txtdireccionDocente.TabIndex = 4;
            // 
            // lbldireccionDocente
            // 
            this.lbldireccionDocente.AutoSize = true;
            this.lbldireccionDocente.Location = new System.Drawing.Point(6, 192);
            this.lbldireccionDocente.Name = "lbldireccionDocente";
            this.lbldireccionDocente.Size = new System.Drawing.Size(75, 20);
            this.lbldireccionDocente.TabIndex = 5;
            this.lbldireccionDocente.Text = "Direccion";
            // 
            // txtnombreDocente
            // 
            this.txtnombreDocente.Location = new System.Drawing.Point(77, 138);
            this.txtnombreDocente.Name = "txtnombreDocente";
            this.txtnombreDocente.Size = new System.Drawing.Size(207, 26);
            this.txtnombreDocente.TabIndex = 2;
            // 
            // lblnombreDocente
            // 
            this.lblnombreDocente.AutoSize = true;
            this.lblnombreDocente.Location = new System.Drawing.Point(6, 138);
            this.lblnombreDocente.Name = "lblnombreDocente";
            this.lblnombreDocente.Size = new System.Drawing.Size(65, 20);
            this.lblnombreDocente.TabIndex = 3;
            this.lblnombreDocente.Text = "Nombre";
            // 
            // txtcodigoDocente
            // 
            this.txtcodigoDocente.Location = new System.Drawing.Point(63, 83);
            this.txtcodigoDocente.Name = "txtcodigoDocente";
            this.txtcodigoDocente.Size = new System.Drawing.Size(175, 26);
            this.txtcodigoDocente.TabIndex = 1;
            // 
            // lblcodigoDocente
            // 
            this.lblcodigoDocente.AutoSize = true;
            this.lblcodigoDocente.Location = new System.Drawing.Point(6, 83);
            this.lblcodigoDocente.Name = "lblcodigoDocente";
            this.lblcodigoDocente.Size = new System.Drawing.Size(56, 20);
            this.lblcodigoDocente.TabIndex = 1;
            this.lblcodigoDocente.Text = "codigo";
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 585);
            this.Controls.Add(this.grbbusquedaDocente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbnavegacionDocente);
            this.Controls.Add(this.grbdatosDocente);
            this.Name = "frmDocente";
            this.Text = "frmDocente";
            this.Load += new System.EventHandler(this.frmDocente_Load);
            this.grbbusquedaDocente.ResumeLayout(false);
            this.grbbusquedaDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grbnavegacionDocente.ResumeLayout(false);
            this.grbnavegacionDocente.PerformLayout();
            this.grbdatosDocente.ResumeLayout(false);
            this.grbdatosDocente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbbusquedaDocente;
        private System.Windows.Forms.DataGridView grdDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.TextBox txtbuscarDocente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnmodificarDocente;
        private System.Windows.Forms.Button btnagregarDocente;
        private System.Windows.Forms.GroupBox grbnavegacionDocente;
        private System.Windows.Forms.Label lblCantReg;
        private System.Windows.Forms.Button btnultimoDocente;
        private System.Windows.Forms.Button btnsiguienteDocente;
        private System.Windows.Forms.Button btnanteriorDocente;
        private System.Windows.Forms.Button btnprimerDocente;
        private System.Windows.Forms.GroupBox grbdatosDocente;
        private System.Windows.Forms.Label lblidDocente;
        private System.Windows.Forms.TextBox txttelefonoDocente;
        private System.Windows.Forms.Label lbltelefonoDocente;
        private System.Windows.Forms.TextBox txtdireccionDocente;
        private System.Windows.Forms.Label lbldireccionDocente;
        private System.Windows.Forms.TextBox txtnombreDocente;
        private System.Windows.Forms.Label lblnombreDocente;
        private System.Windows.Forms.TextBox txtcodigoDocente;
        private System.Windows.Forms.Label lblcodigoDocente;
    }
}