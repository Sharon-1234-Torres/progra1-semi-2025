
namespace Prueba1Conver
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
            this.lbl1Cantidad = new System.Windows.Forms.Label();
            this.txt1Cantidad = new System.Windows.Forms.TextBox();
            this.bttn1Convertir = new System.Windows.Forms.Button();
            this.lbl2Resultado = new System.Windows.Forms.Label();
            this.grb1Opciones = new System.Windows.Forms.GroupBox();
            this.rdo1Dolar = new System.Windows.Forms.RadioButton();
            this.rdo2Lempira = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdo4Euro = new System.Windows.Forms.RadioButton();
            this.rdo5Quetzal = new System.Windows.Forms.RadioButton();
            this.rdo6Libra = new System.Windows.Forms.RadioButton();
            this.grb1Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1Cantidad
            // 
            this.lbl1Cantidad.AutoSize = true;
            this.lbl1Cantidad.Location = new System.Drawing.Point(56, 66);
            this.lbl1Cantidad.Name = "lbl1Cantidad";
            this.lbl1Cantidad.Size = new System.Drawing.Size(132, 20);
            this.lbl1Cantidad.TabIndex = 0;
            this.lbl1Cantidad.Text = "Ingrese cantidad:";
            this.lbl1Cantidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt1Cantidad
            // 
            this.txt1Cantidad.Location = new System.Drawing.Point(205, 66);
            this.txt1Cantidad.Name = "txt1Cantidad";
            this.txt1Cantidad.Size = new System.Drawing.Size(128, 26);
            this.txt1Cantidad.TabIndex = 1;
            // 
            // bttn1Convertir
            // 
            this.bttn1Convertir.Location = new System.Drawing.Point(205, 171);
            this.bttn1Convertir.Name = "bttn1Convertir";
            this.bttn1Convertir.Size = new System.Drawing.Size(158, 79);
            this.bttn1Convertir.TabIndex = 3;
            this.bttn1Convertir.Text = "Convertir";
            this.bttn1Convertir.UseVisualStyleBackColor = true;
            // 
            // lbl2Resultado
            // 
            this.lbl2Resultado.AutoSize = true;
            this.lbl2Resultado.Location = new System.Drawing.Point(56, 200);
            this.lbl2Resultado.Name = "lbl2Resultado";
            this.lbl2Resultado.Size = new System.Drawing.Size(82, 20);
            this.lbl2Resultado.TabIndex = 4;
            this.lbl2Resultado.Text = "Resultado";
            // 
            // grb1Opciones
            // 
            this.grb1Opciones.Controls.Add(this.rdo6Libra);
            this.grb1Opciones.Controls.Add(this.rdo5Quetzal);
            this.grb1Opciones.Controls.Add(this.rdo4Euro);
            this.grb1Opciones.Controls.Add(this.radioButton1);
            this.grb1Opciones.Controls.Add(this.rdo2Lempira);
            this.grb1Opciones.Controls.Add(this.rdo1Dolar);
            this.grb1Opciones.Location = new System.Drawing.Point(459, 44);
            this.grb1Opciones.Name = "grb1Opciones";
            this.grb1Opciones.Size = new System.Drawing.Size(277, 497);
            this.grb1Opciones.TabIndex = 5;
            this.grb1Opciones.TabStop = false;
            this.grb1Opciones.Text = "Opciones";
            // 
            // rdo1Dolar
            // 
            this.rdo1Dolar.AutoSize = true;
            this.rdo1Dolar.Location = new System.Drawing.Point(35, 50);
            this.rdo1Dolar.Name = "rdo1Dolar";
            this.rdo1Dolar.Size = new System.Drawing.Size(69, 24);
            this.rdo1Dolar.TabIndex = 0;
            this.rdo1Dolar.TabStop = true;
            this.rdo1Dolar.Text = "dolar";
            this.rdo1Dolar.UseVisualStyleBackColor = true;
            // 
            // rdo2Lempira
            // 
            this.rdo2Lempira.AutoSize = true;
            this.rdo2Lempira.Location = new System.Drawing.Point(35, 108);
            this.rdo2Lempira.Name = "rdo2Lempira";
            this.rdo2Lempira.Size = new System.Drawing.Size(91, 24);
            this.rdo2Lempira.TabIndex = 1;
            this.rdo2Lempira.TabStop = true;
            this.rdo2Lempira.Text = "Lempira";
            this.rdo2Lempira.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 173);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Peso";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdo4Euro
            // 
            this.rdo4Euro.AutoSize = true;
            this.rdo4Euro.Location = new System.Drawing.Point(35, 244);
            this.rdo4Euro.Name = "rdo4Euro";
            this.rdo4Euro.Size = new System.Drawing.Size(68, 24);
            this.rdo4Euro.TabIndex = 3;
            this.rdo4Euro.TabStop = true;
            this.rdo4Euro.Text = "Euro";
            this.rdo4Euro.UseVisualStyleBackColor = true;
            // 
            // rdo5Quetzal
            // 
            this.rdo5Quetzal.AutoSize = true;
            this.rdo5Quetzal.Location = new System.Drawing.Point(35, 314);
            this.rdo5Quetzal.Name = "rdo5Quetzal";
            this.rdo5Quetzal.Size = new System.Drawing.Size(89, 24);
            this.rdo5Quetzal.TabIndex = 4;
            this.rdo5Quetzal.TabStop = true;
            this.rdo5Quetzal.Text = "Quetzal";
            this.rdo5Quetzal.UseVisualStyleBackColor = true;
            // 
            // rdo6Libra
            // 
            this.rdo6Libra.AutoSize = true;
            this.rdo6Libra.Location = new System.Drawing.Point(35, 390);
            this.rdo6Libra.Name = "rdo6Libra";
            this.rdo6Libra.Size = new System.Drawing.Size(69, 24);
            this.rdo6Libra.TabIndex = 5;
            this.rdo6Libra.TabStop = true;
            this.rdo6Libra.Text = "Libra";
            this.rdo6Libra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 581);
            this.Controls.Add(this.grb1Opciones);
            this.Controls.Add(this.lbl2Resultado);
            this.Controls.Add(this.bttn1Convertir);
            this.Controls.Add(this.txt1Cantidad);
            this.Controls.Add(this.lbl1Cantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grb1Opciones.ResumeLayout(false);
            this.grb1Opciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1Cantidad;
        private System.Windows.Forms.TextBox txt1Cantidad;
        private System.Windows.Forms.Button bttn1Convertir;
        private System.Windows.Forms.Label lbl2Resultado;
        private System.Windows.Forms.GroupBox grb1Opciones;
        private System.Windows.Forms.RadioButton rdo6Libra;
        private System.Windows.Forms.RadioButton rdo5Quetzal;
        private System.Windows.Forms.RadioButton rdo4Euro;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdo2Lempira;
        private System.Windows.Forms.RadioButton rdo1Dolar;
    }
}

