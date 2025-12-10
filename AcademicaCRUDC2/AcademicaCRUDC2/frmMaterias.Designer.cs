namespace AcademicaCRUDC2
{
    partial class frmMaterias
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
            this.grbBusquedaMateria = new System.Windows.Forms.GroupBox();
            this.cboBuscarMaterias = new System.Windows.Forms.ComboBox();
            this.grdMaterias = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.grbEdicionMateria = new System.Windows.Forms.GroupBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosMateria = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.idMateria = new System.Windows.Forms.Label();
            this.lblUvMateria = new System.Windows.Forms.Label();
            this.txtUvMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.grbBusquedaMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).BeginInit();
            this.grbEdicionMateria.SuspendLayout();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbDatosMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaMateria
            // 
            this.grbBusquedaMateria.Controls.Add(this.cboBuscarMaterias);
            this.grbBusquedaMateria.Controls.Add(this.grdMaterias);
            this.grbBusquedaMateria.Controls.Add(this.txtBuscarMaterias);
            this.grbBusquedaMateria.Location = new System.Drawing.Point(594, 44);
            this.grbBusquedaMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBusquedaMateria.Name = "grbBusquedaMateria";
            this.grbBusquedaMateria.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBusquedaMateria.Size = new System.Drawing.Size(714, 423);
            this.grbBusquedaMateria.TabIndex = 11;
            this.grbBusquedaMateria.TabStop = false;
            this.grbBusquedaMateria.Text = "Busqueda Materias";
            // 
            // cboBuscarMaterias
            // 
            this.cboBuscarMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarMaterias.FormattingEnabled = true;
            this.cboBuscarMaterias.Items.AddRange(new object[] {
            "Codigo",
            "Materia"});
            this.cboBuscarMaterias.Location = new System.Drawing.Point(10, 43);
            this.cboBuscarMaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBuscarMaterias.Name = "cboBuscarMaterias";
            this.cboBuscarMaterias.Size = new System.Drawing.Size(163, 28);
            this.cboBuscarMaterias.TabIndex = 12;
            // 
            // grdMaterias
            // 
            this.grdMaterias.AllowUserToAddRows = false;
            this.grdMaterias.AllowUserToDeleteRows = false;
            this.grdMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion});
            this.grdMaterias.Location = new System.Drawing.Point(9, 83);
            this.grdMaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdMaterias.Name = "grdMaterias";
            this.grdMaterias.ReadOnly = true;
            this.grdMaterias.RowHeadersWidth = 62;
            this.grdMaterias.Size = new System.Drawing.Size(696, 331);
            this.grdMaterias.TabIndex = 11;
            this.grdMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMaterias_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "idMateria";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 150;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "uv";
            this.direccion.HeaderText = "UV";
            this.direccion.MinimumWidth = 8;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 150;
            // 
            // txtBuscarMaterias
            // 
            this.txtBuscarMaterias.Location = new System.Drawing.Point(184, 43);
            this.txtBuscarMaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.Size = new System.Drawing.Size(438, 26);
            this.txtBuscarMaterias.TabIndex = 10;
            this.txtBuscarMaterias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMaterias_KeyUp);
            // 
            // grbEdicionMateria
            // 
            this.grbEdicionMateria.Controls.Add(this.btnEliminarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnModificarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnAgregarMateria);
            this.grbEdicionMateria.Location = new System.Drawing.Point(434, 477);
            this.grbEdicionMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEdicionMateria.Name = "grbEdicionMateria";
            this.grbEdicionMateria.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEdicionMateria.Size = new System.Drawing.Size(514, 86);
            this.grbEdicionMateria.TabIndex = 10;
            this.grbEdicionMateria.TabStop = false;
            this.grbEdicionMateria.Text = "Edicion";
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.Location = new System.Drawing.Point(309, 23);
            this.btnEliminarMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(150, 57);
            this.btnEliminarMateria.TabIndex = 3;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(152, 22);
            this.btnModificarMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(158, 57);
            this.btnModificarMateria.TabIndex = 1;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.Location = new System.Drawing.Point(9, 23);
            this.btnAgregarMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(141, 57);
            this.btnAgregarMateria.TabIndex = 0;
            this.btnAgregarMateria.Text = "Nuevo";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // grbNavegacionMateria
            // 
            this.grbNavegacionMateria.Controls.Add(this.lblnRegistrosMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacionMateria.Location = new System.Drawing.Point(67, 477);
            this.grbNavegacionMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";
            this.grbNavegacionMateria.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNavegacionMateria.Size = new System.Drawing.Size(356, 86);
            this.grbNavegacionMateria.TabIndex = 9;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "Navegacion";
            // 
            // lblnRegistrosMateria
            // 
            this.lblnRegistrosMateria.AutoSize = true;
            this.lblnRegistrosMateria.Location = new System.Drawing.Point(111, 43);
            this.lblnRegistrosMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnRegistrosMateria.Name = "lblnRegistrosMateria";
            this.lblnRegistrosMateria.Size = new System.Drawing.Size(51, 20);
            this.lblnRegistrosMateria.TabIndex = 10;
            this.lblnRegistrosMateria.Text = "x de n";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMateria.Location = new System.Drawing.Point(272, 22);
            this.btnUltimoMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(50, 57);
            this.btnUltimoMateria.TabIndex = 3;
            this.btnUltimoMateria.Text = ">|";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            this.btnUltimoMateria.Click += new System.EventHandler(this.btnUltimoMateria_Click);
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.Location = new System.Drawing.Point(218, 22);
            this.btnSiguienteMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(50, 57);
            this.btnSiguienteMateria.TabIndex = 2;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.Location = new System.Drawing.Point(63, 22);
            this.btnAnteriorMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(50, 57);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnPrimeroMateria
            // 
            this.btnPrimeroMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMateria.Location = new System.Drawing.Point(9, 22);
            this.btnPrimeroMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Size = new System.Drawing.Size(50, 57);
            this.btnPrimeroMateria.TabIndex = 0;
            this.btnPrimeroMateria.Text = "|<";
            this.btnPrimeroMateria.UseVisualStyleBackColor = true;
            this.btnPrimeroMateria.Click += new System.EventHandler(this.btnPrimeroMateria_Click);
            // 
            // grbDatosMateria
            // 
            this.grbDatosMateria.Controls.Add(this.idMateria);
            this.grbDatosMateria.Controls.Add(this.lblUvMateria);
            this.grbDatosMateria.Controls.Add(this.txtUvMateria);
            this.grbDatosMateria.Controls.Add(this.lblNombreMateria);
            this.grbDatosMateria.Controls.Add(this.txtNombreMateria);
            this.grbDatosMateria.Controls.Add(this.lblCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.txtCodigoMateria);
            this.grbDatosMateria.Controls.Add(this.lblIdMateria);
            this.grbDatosMateria.Enabled = false;
            this.grbDatosMateria.Location = new System.Drawing.Point(66, 44);
            this.grbDatosMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbDatosMateria.Size = new System.Drawing.Size(519, 423);
            this.grbDatosMateria.TabIndex = 8;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "DATOS";
            // 
            // idMateria
            // 
            this.idMateria.AutoSize = true;
            this.idMateria.Location = new System.Drawing.Point(120, 58);
            this.idMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idMateria.Name = "idMateria";
            this.idMateria.Size = new System.Drawing.Size(51, 20);
            this.idMateria.TabIndex = 9;
            this.idMateria.Text = "label1";
            // 
            // lblUvMateria
            // 
            this.lblUvMateria.AutoSize = true;
            this.lblUvMateria.Location = new System.Drawing.Point(8, 242);
            this.lblUvMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUvMateria.Name = "lblUvMateria";
            this.lblUvMateria.Size = new System.Drawing.Size(103, 20);
            this.lblUvMateria.TabIndex = 6;
            this.lblUvMateria.Text = "DIRECCION:";
            // 
            // txtUvMateria
            // 
            this.txtUvMateria.Location = new System.Drawing.Point(120, 235);
            this.txtUvMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUvMateria.Name = "txtUvMateria";
            this.txtUvMateria.Size = new System.Drawing.Size(73, 26);
            this.txtUvMateria.TabIndex = 5;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Location = new System.Drawing.Point(26, 171);
            this.lblNombreMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(83, 20);
            this.lblNombreMateria.TabIndex = 4;
            this.lblNombreMateria.Text = "NOMBRE:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(133, 165);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(307, 26);
            this.txtNombreMateria.TabIndex = 3;
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Location = new System.Drawing.Point(33, 111);
            this.lblCodigoMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(78, 20);
            this.lblCodigoMateria.TabIndex = 2;
            this.lblCodigoMateria.Text = "CODIGO:";
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(120, 111);
            this.txtCodigoMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.Size = new System.Drawing.Size(148, 26);
            this.txtCodigoMateria.TabIndex = 1;
            // 
            // lblIdMateria
            // 
            this.lblIdMateria.AutoSize = true;
            this.lblIdMateria.Location = new System.Drawing.Point(80, 54);
            this.lblIdMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMateria.Name = "lblIdMateria";
            this.lblIdMateria.Size = new System.Drawing.Size(30, 20);
            this.lblIdMateria.TabIndex = 0;
            this.lblIdMateria.Text = "ID:";
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 720);
            this.Controls.Add(this.grbBusquedaMateria);
            this.Controls.Add(this.grbEdicionMateria);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Controls.Add(this.grbDatosMateria);
            this.Name = "frmMaterias";
            this.Text = "frmMaterias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            this.grbBusquedaMateria.ResumeLayout(false);
            this.grbBusquedaMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).EndInit();
            this.grbEdicionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaMateria;
        private System.Windows.Forms.ComboBox cboBuscarMaterias;
        private System.Windows.Forms.DataGridView grdMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.GroupBox grbEdicionMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.Label lblnRegistrosMateria;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.Label idMateria;
        private System.Windows.Forms.Label lblUvMateria;
        private System.Windows.Forms.TextBox txtUvMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.Label lblIdMateria;
    }
}