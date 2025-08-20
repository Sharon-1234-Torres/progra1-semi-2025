
namespace Prueba3Conver
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1Cantidad = new System.Windows.Forms.TextBox();
            this.txt2Resultado = new System.Windows.Forms.TextBox();
            this.cbo1Monedas = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convertir a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Equivale a:";
            // 
            // txt1Cantidad
            // 
            this.txt1Cantidad.Location = new System.Drawing.Point(194, 41);
            this.txt1Cantidad.Name = "txt1Cantidad";
            this.txt1Cantidad.Size = new System.Drawing.Size(100, 26);
            this.txt1Cantidad.TabIndex = 3;
            this.txt1Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2Resultado
            // 
            this.txt2Resultado.Location = new System.Drawing.Point(173, 189);
            this.txt2Resultado.Name = "txt2Resultado";
            this.txt2Resultado.Size = new System.Drawing.Size(100, 26);
            this.txt2Resultado.TabIndex = 4;
            this.txt2Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo1Monedas
            // 
            this.cbo1Monedas.FormattingEnabled = true;
            this.cbo1Monedas.Items.AddRange(new object[] {
            "Dólares",
            "Euros",
            "Quetzales",
            "Soles",
            "Libras Esterlinas",
            "Yen Japones",
            "Colon Salvadoreño",
            "Lempira",
            "Peso Mexicano",
            "Cordoba "});
            this.cbo1Monedas.Location = new System.Drawing.Point(173, 105);
            this.cbo1Monedas.Name = "cbo1Monedas";
            this.cbo1Monedas.Size = new System.Drawing.Size(121, 28);
            this.cbo1Monedas.TabIndex = 5;
            this.cbo1Monedas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(348, 195);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(51, 20);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.cbo1Monedas);
            this.Controls.Add(this.txt2Resultado);
            this.Controls.Add(this.txt1Cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1Cantidad;
        private System.Windows.Forms.TextBox txt2Resultado;
        private System.Windows.Forms.ComboBox cbo1Monedas;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

