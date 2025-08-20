
namespace ConversorMoneda2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1CantidadVol = new System.Windows.Forms.TextBox();
            this.cbo1ConvertirVol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo2ConvertidoVol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt2ResultadoVol = new System.Windows.Forms.TextBox();
            this.btn1ConvertirVol = new System.Windows.Forms.Button();
            this.btn2SalirVol = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convertir de:";
            // 
            // txt1CantidadVol
            // 
            this.txt1CantidadVol.Location = new System.Drawing.Point(204, 117);
            this.txt1CantidadVol.Name = "txt1CantidadVol";
            this.txt1CantidadVol.Size = new System.Drawing.Size(130, 26);
            this.txt1CantidadVol.TabIndex = 2;
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
            "Pie cúbico",
            ""});
            this.cbo1ConvertirVol.Location = new System.Drawing.Point(154, 191);
            this.cbo1ConvertirVol.Name = "cbo1ConvertirVol";
            this.cbo1ConvertirVol.Size = new System.Drawing.Size(130, 28);
            this.cbo1ConvertirVol.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "A:";
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
            this.cbo2ConvertidoVol.Location = new System.Drawing.Point(395, 194);
            this.cbo2ConvertidoVol.Name = "cbo2ConvertidoVol";
            this.cbo2ConvertidoVol.Size = new System.Drawing.Size(133, 28);
            this.cbo2ConvertidoVol.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Equivalencia:";
            // 
            // txt2ResultadoVol
            // 
            this.txt2ResultadoVol.Location = new System.Drawing.Point(312, 307);
            this.txt2ResultadoVol.Name = "txt2ResultadoVol";
            this.txt2ResultadoVol.Size = new System.Drawing.Size(147, 26);
            this.txt2ResultadoVol.TabIndex = 7;
            // 
            // btn1ConvertirVol
            // 
            this.btn1ConvertirVol.Location = new System.Drawing.Point(114, 377);
            this.btn1ConvertirVol.Name = "btn1ConvertirVol";
            this.btn1ConvertirVol.Size = new System.Drawing.Size(119, 65);
            this.btn1ConvertirVol.TabIndex = 8;
            this.btn1ConvertirVol.Text = "Convertir";
            this.btn1ConvertirVol.UseVisualStyleBackColor = true;
            this.btn1ConvertirVol.Click += new System.EventHandler(this.btn1Convertir_Click);
            // 
            // btn2SalirVol
            // 
            this.btn2SalirVol.Location = new System.Drawing.Point(419, 398);
            this.btn2SalirVol.Name = "btn2SalirVol";
            this.btn2SalirVol.Size = new System.Drawing.Size(93, 44);
            this.btn2SalirVol.TabIndex = 9;
            this.btn2SalirVol.Text = "Salir";
            this.btn2SalirVol.UseVisualStyleBackColor = true;
            this.btn2SalirVol.Click += new System.EventHandler(this.btn2Salir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Conversor de Volumen";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 530);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn2SalirVol);
            this.Controls.Add(this.btn1ConvertirVol);
            this.Controls.Add(this.txt2ResultadoVol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo2ConvertidoVol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo1ConvertirVol);
            this.Controls.Add(this.txt1CantidadVol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1CantidadVol;
        private System.Windows.Forms.ComboBox cbo1ConvertirVol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo2ConvertidoVol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt2ResultadoVol;
        private System.Windows.Forms.Button btn1ConvertirVol;
        private System.Windows.Forms.Button btn2SalirVol;
        private System.Windows.Forms.Label label5;
    }
}