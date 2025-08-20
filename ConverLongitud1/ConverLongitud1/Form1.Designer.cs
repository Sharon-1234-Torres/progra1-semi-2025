
namespace ConverLongitud1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt1CantidadLong = new System.Windows.Forms.TextBox();
            this.txt2Resultado = new System.Windows.Forms.TextBox();
            this.cbo1ConvertirLong = new System.Windows.Forms.ComboBox();
            this.cbo2ConvertidoLong = new System.Windows.Forms.ComboBox();
            this.btn1Convertir = new System.Windows.Forms.Button();
            this.btn2Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Longitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convertir de:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Equivale a:";
            // 
            // txt1CantidadLong
            // 
            this.txt1CantidadLong.Location = new System.Drawing.Point(265, 116);
            this.txt1CantidadLong.Name = "txt1CantidadLong";
            this.txt1CantidadLong.Size = new System.Drawing.Size(100, 26);
            this.txt1CantidadLong.TabIndex = 5;
            // 
            // txt2Resultado
            // 
            this.txt2Resultado.Location = new System.Drawing.Point(214, 272);
            this.txt2Resultado.Name = "txt2Resultado";
            this.txt2Resultado.Size = new System.Drawing.Size(315, 26);
            this.txt2Resultado.TabIndex = 6;
            // 
            // cbo1ConvertirLong
            // 
            this.cbo1ConvertirLong.FormattingEnabled = true;
            this.cbo1ConvertirLong.Items.AddRange(new object[] {
            "Kilómetro",
            "Metro",
            "Centrímetro",
            "Milímetro",
            "Micrómetro",
            "Nanómetro",
            "Milla",
            "Yarda",
            "Pie",
            "Pulgada"});
            this.cbo1ConvertirLong.Location = new System.Drawing.Point(210, 184);
            this.cbo1ConvertirLong.Name = "cbo1ConvertirLong";
            this.cbo1ConvertirLong.Size = new System.Drawing.Size(121, 28);
            this.cbo1ConvertirLong.TabIndex = 7;
            // 
            // cbo2ConvertidoLong
            // 
            this.cbo2ConvertidoLong.FormattingEnabled = true;
            this.cbo2ConvertidoLong.Items.AddRange(new object[] {
            "Kilómetro",
            "Metro",
            "Centrímetro",
            "Milímetro",
            "Micrómetro",
            "Nanómetro",
            "Milla",
            "Yarda",
            "Pie",
            "Pulgada"});
            this.cbo2ConvertidoLong.Location = new System.Drawing.Point(408, 184);
            this.cbo2ConvertidoLong.Name = "cbo2ConvertidoLong";
            this.cbo2ConvertidoLong.Size = new System.Drawing.Size(121, 28);
            this.cbo2ConvertidoLong.TabIndex = 8;
            // 
            // btn1Convertir
            // 
            this.btn1Convertir.Location = new System.Drawing.Point(174, 341);
            this.btn1Convertir.Name = "btn1Convertir";
            this.btn1Convertir.Size = new System.Drawing.Size(112, 58);
            this.btn1Convertir.TabIndex = 9;
            this.btn1Convertir.Text = "Convertir";
            this.btn1Convertir.UseVisualStyleBackColor = true;
            this.btn1Convertir.Click += new System.EventHandler(this.btn1Convertir_Click);
            // 
            // btn2Salir
            // 
            this.btn2Salir.Location = new System.Drawing.Point(424, 341);
            this.btn2Salir.Name = "btn2Salir";
            this.btn2Salir.Size = new System.Drawing.Size(105, 58);
            this.btn2Salir.TabIndex = 10;
            this.btn2Salir.Text = "Salir";
            this.btn2Salir.UseVisualStyleBackColor = true;
            this.btn2Salir.Click += new System.EventHandler(this.btn2Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2Salir);
            this.Controls.Add(this.btn1Convertir);
            this.Controls.Add(this.cbo2ConvertidoLong);
            this.Controls.Add(this.cbo1ConvertirLong);
            this.Controls.Add(this.txt2Resultado);
            this.Controls.Add(this.txt1CantidadLong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt1CantidadLong;
        private System.Windows.Forms.TextBox txt2Resultado;
        private System.Windows.Forms.ComboBox cbo1ConvertirLong;
        private System.Windows.Forms.ComboBox cbo2ConvertidoLong;
        private System.Windows.Forms.Button btn1Convertir;
        private System.Windows.Forms.Button btn2Salir;
    }
}

