
namespace ConverTiempo1
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
            this.txt1CantidadTiem = new System.Windows.Forms.TextBox();
            this.txt2Resultado = new System.Windows.Forms.TextBox();
            this.cbo1ConvertirTiem = new System.Windows.Forms.ComboBox();
            this.cbo2ConvertidoTiem = new System.Windows.Forms.ComboBox();
            this.bt1onvertir = new System.Windows.Forms.Button();
            this.btn2Salir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convertir de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equivale a:";
            // 
            // txt1CantidadTiem
            // 
            this.txt1CantidadTiem.Location = new System.Drawing.Point(235, 118);
            this.txt1CantidadTiem.Name = "txt1CantidadTiem";
            this.txt1CantidadTiem.Size = new System.Drawing.Size(100, 26);
            this.txt1CantidadTiem.TabIndex = 4;
            // 
            // txt2Resultado
            // 
            this.txt2Resultado.Location = new System.Drawing.Point(235, 320);
            this.txt2Resultado.Name = "txt2Resultado";
            this.txt2Resultado.Size = new System.Drawing.Size(100, 26);
            this.txt2Resultado.TabIndex = 5;
            // 
            // cbo1ConvertirTiem
            // 
            this.cbo1ConvertirTiem.FormattingEnabled = true;
            this.cbo1ConvertirTiem.Items.AddRange(new object[] {
            "Minuto",
            "Hora",
            "Día",
            "Semana",
            "Mes",
            "Año",
            "Década",
            "Siglo",
            "Segundo",
            "Milisegundo"});
            this.cbo1ConvertirTiem.Location = new System.Drawing.Point(198, 215);
            this.cbo1ConvertirTiem.Name = "cbo1ConvertirTiem";
            this.cbo1ConvertirTiem.Size = new System.Drawing.Size(198, 28);
            this.cbo1ConvertirTiem.TabIndex = 6;
            // 
            // cbo2ConvertidoTiem
            // 
            this.cbo2ConvertidoTiem.FormattingEnabled = true;
            this.cbo2ConvertidoTiem.Items.AddRange(new object[] {
            "Minuto",
            "Hora",
            "Día",
            "Semana",
            "Mes",
            "Año",
            "Década",
            "Siglo",
            "Segundo",
            "Milisegundo"});
            this.cbo2ConvertidoTiem.Location = new System.Drawing.Point(487, 215);
            this.cbo2ConvertidoTiem.Name = "cbo2ConvertidoTiem";
            this.cbo2ConvertidoTiem.Size = new System.Drawing.Size(200, 28);
            this.cbo2ConvertidoTiem.TabIndex = 7;
            // 
            // bt1onvertir
            // 
            this.bt1onvertir.Location = new System.Drawing.Point(170, 387);
            this.bt1onvertir.Name = "bt1onvertir";
            this.bt1onvertir.Size = new System.Drawing.Size(136, 66);
            this.bt1onvertir.TabIndex = 8;
            this.bt1onvertir.Text = "Convertir";
            this.bt1onvertir.UseVisualStyleBackColor = true;
            this.bt1onvertir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2Salir
            // 
            this.btn2Salir.Location = new System.Drawing.Point(444, 399);
            this.btn2Salir.Name = "btn2Salir";
            this.btn2Salir.Size = new System.Drawing.Size(130, 54);
            this.btn2Salir.TabIndex = 9;
            this.btn2Salir.Text = "salir";
            this.btn2Salir.UseVisualStyleBackColor = true;
            this.btn2Salir.Click += new System.EventHandler(this.btn2Salir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "Conversor de tiempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 488);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn2Salir);
            this.Controls.Add(this.bt1onvertir);
            this.Controls.Add(this.cbo2ConvertidoTiem);
            this.Controls.Add(this.cbo1ConvertirTiem);
            this.Controls.Add(this.txt2Resultado);
            this.Controls.Add(this.txt1CantidadTiem);
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
        private System.Windows.Forms.TextBox txt1CantidadTiem;
        private System.Windows.Forms.TextBox txt2Resultado;
        private System.Windows.Forms.ComboBox cbo1ConvertirTiem;
        private System.Windows.Forms.ComboBox cbo2ConvertidoTiem;
        private System.Windows.Forms.Button bt1onvertir;
        private System.Windows.Forms.Button btn2Salir;
        private System.Windows.Forms.Label label5;
    }
}

