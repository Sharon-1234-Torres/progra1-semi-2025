
namespace ConverAlmacenamiento1
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
            this.txt1CantidadAlma = new System.Windows.Forms.TextBox();
            this.txt2ResultadoAlma = new System.Windows.Forms.TextBox();
            this.cbo1ConvertirAlma = new System.Windows.Forms.ComboBox();
            this.cbo2ConvertidoAlma = new System.Windows.Forms.ComboBox();
            this.btn1Convertir = new System.Windows.Forms.Button();
            this.btn2Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Almacenamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convertir de:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Equivalencia:";
            // 
            // txt1CantidadAlma
            // 
            this.txt1CantidadAlma.Location = new System.Drawing.Point(217, 125);
            this.txt1CantidadAlma.Name = "txt1CantidadAlma";
            this.txt1CantidadAlma.Size = new System.Drawing.Size(223, 26);
            this.txt1CantidadAlma.TabIndex = 5;
            // 
            // txt2ResultadoAlma
            // 
            this.txt2ResultadoAlma.Location = new System.Drawing.Point(296, 277);
            this.txt2ResultadoAlma.Name = "txt2ResultadoAlma";
            this.txt2ResultadoAlma.Size = new System.Drawing.Size(271, 26);
            this.txt2ResultadoAlma.TabIndex = 6;
            // 
            // cbo1ConvertirAlma
            // 
            this.cbo1ConvertirAlma.FormattingEnabled = true;
            this.cbo1ConvertirAlma.Items.AddRange(new object[] {
            "Byte",
            "Kilobyte",
            "Megabyte",
            "Gigabyte",
            "Terabyte",
            "Petabyte",
            "Bit",
            "Kilobit",
            "Kibibit",
            "Megabit"});
            this.cbo1ConvertirAlma.Location = new System.Drawing.Point(183, 192);
            this.cbo1ConvertirAlma.Name = "cbo1ConvertirAlma";
            this.cbo1ConvertirAlma.Size = new System.Drawing.Size(155, 28);
            this.cbo1ConvertirAlma.TabIndex = 7;
            // 
            // cbo2ConvertidoAlma
            // 
            this.cbo2ConvertidoAlma.FormattingEnabled = true;
            this.cbo2ConvertidoAlma.Items.AddRange(new object[] {
            "Byte",
            "Kilobyte",
            "Megabyte",
            "Gigabyte",
            "Terabyte",
            "Petabyte",
            "Bit",
            "Kilobit",
            "Kibibit",
            "Megabit"});
            this.cbo2ConvertidoAlma.Location = new System.Drawing.Point(446, 192);
            this.cbo2ConvertidoAlma.Name = "cbo2ConvertidoAlma";
            this.cbo2ConvertidoAlma.Size = new System.Drawing.Size(145, 28);
            this.cbo2ConvertidoAlma.TabIndex = 8;
            // 
            // btn1Convertir
            // 
            this.btn1Convertir.Location = new System.Drawing.Point(156, 342);
            this.btn1Convertir.Name = "btn1Convertir";
            this.btn1Convertir.Size = new System.Drawing.Size(141, 67);
            this.btn1Convertir.TabIndex = 9;
            this.btn1Convertir.Text = "Convertir";
            this.btn1Convertir.UseVisualStyleBackColor = true;
            this.btn1Convertir.Click += new System.EventHandler(this.btn1Convertir_Click);
            // 
            // btn2Salir
            // 
            this.btn2Salir.Location = new System.Drawing.Point(429, 352);
            this.btn2Salir.Name = "btn2Salir";
            this.btn2Salir.Size = new System.Drawing.Size(123, 57);
            this.btn2Salir.TabIndex = 10;
            this.btn2Salir.Text = "Salir";
            this.btn2Salir.UseVisualStyleBackColor = true;
            this.btn2Salir.Click += new System.EventHandler(this.btn2Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 470);
            this.Controls.Add(this.btn2Salir);
            this.Controls.Add(this.btn1Convertir);
            this.Controls.Add(this.cbo2ConvertidoAlma);
            this.Controls.Add(this.cbo1ConvertirAlma);
            this.Controls.Add(this.txt2ResultadoAlma);
            this.Controls.Add(this.txt1CantidadAlma);
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
        private System.Windows.Forms.TextBox txt1CantidadAlma;
        private System.Windows.Forms.TextBox txt2ResultadoAlma;
        private System.Windows.Forms.ComboBox cbo1ConvertirAlma;
        private System.Windows.Forms.ComboBox cbo2ConvertidoAlma;
        private System.Windows.Forms.Button btn1Convertir;
        private System.Windows.Forms.Button btn2Salir;
    }
}

