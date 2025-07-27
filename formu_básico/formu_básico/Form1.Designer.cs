
namespace formu_básico
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
            this.lbl1Nombre = new System.Windows.Forms.Label();
            this.lbl2MsjPrevio = new System.Windows.Forms.Label();
            this.txt1Nombre = new System.Windows.Forms.TextBox();
            this.btn1Saludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1Nombre
            // 
            this.lbl1Nombre.AutoSize = true;
            this.lbl1Nombre.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Nombre.Location = new System.Drawing.Point(68, 55);
            this.lbl1Nombre.Name = "lbl1Nombre";
            this.lbl1Nombre.Size = new System.Drawing.Size(99, 27);
            this.lbl1Nombre.TabIndex = 0;
            this.lbl1Nombre.Text = "Nombre:\r\n";
            // 
            // lbl2MsjPrevio
            // 
            this.lbl2MsjPrevio.AutoSize = true;
            this.lbl2MsjPrevio.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2MsjPrevio.Location = new System.Drawing.Point(160, 274);
            this.lbl2MsjPrevio.Name = "lbl2MsjPrevio";
            this.lbl2MsjPrevio.Size = new System.Drawing.Size(372, 27);
            this.lbl2MsjPrevio.TabIndex = 1;
            this.lbl2MsjPrevio.Text = "Su mensaje ingresado aparecerá aquí";
            // 
            // txt1Nombre
            // 
            this.txt1Nombre.Location = new System.Drawing.Point(173, 55);
            this.txt1Nombre.Name = "txt1Nombre";
            this.txt1Nombre.Size = new System.Drawing.Size(258, 26);
            this.txt1Nombre.TabIndex = 2;
            this.txt1Nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn1Saludar
            // 
            this.btn1Saludar.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Saludar.Location = new System.Drawing.Point(207, 134);
            this.btn1Saludar.Name = "btn1Saludar";
            this.btn1Saludar.Size = new System.Drawing.Size(179, 91);
            this.btn1Saludar.TabIndex = 3;
            this.btn1Saludar.Text = "Saludar";
            this.btn1Saludar.UseVisualStyleBackColor = true;
            this.btn1Saludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 463);
            this.Controls.Add(this.btn1Saludar);
            this.Controls.Add(this.txt1Nombre);
            this.Controls.Add(this.lbl2MsjPrevio);
            this.Controls.Add(this.lbl1Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1Nombre;
        private System.Windows.Forms.Label lbl2MsjPrevio;
        private System.Windows.Forms.TextBox txt1Nombre;
        private System.Windows.Forms.Button btn1Saludar;
    }
}

