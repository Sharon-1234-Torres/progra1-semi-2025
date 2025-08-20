
namespace ConverVolumen1
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
            this.txt1CantidadVol = new System.Windows.Forms.TextBox();
            this.cbo1ConvertirVol = new System.Windows.Forms.ComboBox();
            this.cbo2ConvertidoVol = new System.Windows.Forms.ComboBox();
            this.btn1ConvertirVol = new System.Windows.Forms.Button();
            this.btn2ConvertirVol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt2ResultadoVol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convertir de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "A:";
            // 
            // txt1CantidadVol
            // 
            this.txt1CantidadVol.Location = new System.Drawing.Point(211, 125);
            this.txt1CantidadVol.Name = "txt1CantidadVol";
            this.txt1CantidadVol.Size = new System.Drawing.Size(202, 26);
            this.txt1CantidadVol.TabIndex = 3;
            // 
            // cbo1ConvertirVol
            // 
            this.cbo1ConvertirVol.FormattingEnabled = true;
            this.cbo1ConvertirVol.Items.AddRange(new object[] {
            "Litro",
            "Mililitro",
            "Galón imperial",
            "Cuarto imperial",
            "Pinta imperial",
            "Taza imperial",
            "Onza líquida imperial",
            "Cucharada imperial",
            "Cucharadita imperial",
            "Pie cúbico"});
            this.cbo1ConvertirVol.Location = new System.Drawing.Point(191, 191);
            this.cbo1ConvertirVol.Name = "cbo1ConvertirVol";
            this.cbo1ConvertirVol.Size = new System.Drawing.Size(204, 28);
            this.cbo1ConvertirVol.TabIndex = 4;
            // 
            // cbo2ConvertidoVol
            // 
            this.cbo2ConvertidoVol.FormattingEnabled = true;
            this.cbo2ConvertidoVol.Items.AddRange(new object[] {
            "Litro",
            "Mililitro",
            "Galón imperial",
            "Cuarto imperial",
            "Pinta imperial",
            "Taza imperial",
            "Onza líquida imperial",
            "Cucharada imperial",
            "Cucharadita imperial",
            "Pie cúbico"});
            this.cbo2ConvertidoVol.Location = new System.Drawing.Point(476, 194);
            this.cbo2ConvertidoVol.Name = "cbo2ConvertidoVol";
            this.cbo2ConvertidoVol.Size = new System.Drawing.Size(232, 28);
            this.cbo2ConvertidoVol.TabIndex = 5;
            // 
            // btn1ConvertirVol
            // 
            this.btn1ConvertirVol.Location = new System.Drawing.Point(152, 340);
            this.btn1ConvertirVol.Name = "btn1ConvertirVol";
            this.btn1ConvertirVol.Size = new System.Drawing.Size(107, 56);
            this.btn1ConvertirVol.TabIndex = 6;
            this.btn1ConvertirVol.Text = "Convertir";
            this.btn1ConvertirVol.UseVisualStyleBackColor = true;
            this.btn1ConvertirVol.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2ConvertirVol
            // 
            this.btn2ConvertirVol.Location = new System.Drawing.Point(466, 348);
            this.btn2ConvertirVol.Name = "btn2ConvertirVol";
            this.btn2ConvertirVol.Size = new System.Drawing.Size(119, 48);
            this.btn2ConvertirVol.TabIndex = 7;
            this.btn2ConvertirVol.Text = "Salir";
            this.btn2ConvertirVol.UseVisualStyleBackColor = true;
            this.btn2ConvertirVol.Click += new System.EventHandler(this.btn2ConvertirVol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Conversor de Volumen";
            // 
            // txt2ResultadoVol
            // 
            this.txt2ResultadoVol.Location = new System.Drawing.Point(339, 281);
            this.txt2ResultadoVol.Name = "txt2ResultadoVol";
            this.txt2ResultadoVol.Size = new System.Drawing.Size(218, 26);
            this.txt2ResultadoVol.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Equivale a:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt2ResultadoVol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn2ConvertirVol);
            this.Controls.Add(this.btn1ConvertirVol);
            this.Controls.Add(this.cbo2ConvertidoVol);
            this.Controls.Add(this.cbo1ConvertirVol);
            this.Controls.Add(this.txt1CantidadVol);
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
        private System.Windows.Forms.TextBox txt1CantidadVol;
        private System.Windows.Forms.ComboBox cbo1ConvertirVol;
        private System.Windows.Forms.ComboBox cbo2ConvertidoVol;
        private System.Windows.Forms.Button btn1ConvertirVol;
        private System.Windows.Forms.Button btn2ConvertirVol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt2ResultadoVol;
        private System.Windows.Forms.Label label5;
    }
}

