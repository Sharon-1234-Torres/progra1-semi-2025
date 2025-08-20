
namespace ConversorMoneda2
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
            this.cbo1Convertir = new System.Windows.Forms.ComboBox();
            this.btn1Convertir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo2Convertido = new System.Windows.Forms.ComboBox();
            this.btn2Salir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convertir de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Equivale a:";
            // 
            // txt1Cantidad
            // 
            this.txt1Cantidad.Location = new System.Drawing.Point(185, 114);
            this.txt1Cantidad.Name = "txt1Cantidad";
            this.txt1Cantidad.Size = new System.Drawing.Size(100, 26);
            this.txt1Cantidad.TabIndex = 3;
            // 
            // txt2Resultado
            // 
            this.txt2Resultado.Location = new System.Drawing.Point(340, 287);
            this.txt2Resultado.Name = "txt2Resultado";
            this.txt2Resultado.Size = new System.Drawing.Size(123, 26);
            this.txt2Resultado.TabIndex = 4;
            // 
            // cbo1Convertir
            // 
            this.cbo1Convertir.FormattingEnabled = true;
            this.cbo1Convertir.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzal",
            "Libras Esterlinas",
            "Yen Japones",
            "Colón Salvadoreño",
            "Lempira",
            "Peso Méxicano",
            "Córdoba",
            "Soles"});
            this.cbo1Convertir.Location = new System.Drawing.Point(185, 190);
            this.cbo1Convertir.Name = "cbo1Convertir";
            this.cbo1Convertir.Size = new System.Drawing.Size(121, 28);
            this.cbo1Convertir.TabIndex = 5;
            // 
            // btn1Convertir
            // 
            this.btn1Convertir.Location = new System.Drawing.Point(101, 384);
            this.btn1Convertir.Name = "btn1Convertir";
            this.btn1Convertir.Size = new System.Drawing.Size(145, 62);
            this.btn1Convertir.TabIndex = 6;
            this.btn1Convertir.Text = "Convertir";
            this.btn1Convertir.UseVisualStyleBackColor = true;
            this.btn1Convertir.Click += new System.EventHandler(this.btn1Convertir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "A:";
            // 
            // cbo2Convertido
            // 
            this.cbo2Convertido.FormattingEnabled = true;
            this.cbo2Convertido.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzal",
            "Libras Esterlinas",
            "Yen Japones",
            "Colón Salvadoreño",
            "Lempira",
            "Peso Méxicano",
            "Córdoba",
            "Soles"});
            this.cbo2Convertido.Location = new System.Drawing.Point(430, 190);
            this.cbo2Convertido.Name = "cbo2Convertido";
            this.cbo2Convertido.Size = new System.Drawing.Size(153, 28);
            this.cbo2Convertido.TabIndex = 8;
            // 
            // btn2Salir
            // 
            this.btn2Salir.Location = new System.Drawing.Point(473, 392);
            this.btn2Salir.Name = "btn2Salir";
            this.btn2Salir.Size = new System.Drawing.Size(100, 54);
            this.btn2Salir.TabIndex = 9;
            this.btn2Salir.Text = "Salir";
            this.btn2Salir.UseVisualStyleBackColor = true;
            this.btn2Salir.Click += new System.EventHandler(this.btn2Salir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Conversor de Monedas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn2Salir);
            this.Controls.Add(this.cbo2Convertido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn1Convertir);
            this.Controls.Add(this.cbo1Convertir);
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
        private System.Windows.Forms.ComboBox cbo1Convertir;
        private System.Windows.Forms.Button btn1Convertir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo2Convertido;
        private System.Windows.Forms.Button btn2Salir;
        private System.Windows.Forms.Label label5;
    }
}

