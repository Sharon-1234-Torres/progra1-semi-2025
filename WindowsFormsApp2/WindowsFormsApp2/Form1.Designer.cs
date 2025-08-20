
namespace WindowsFormsApp2
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
            this.lbl1ConverDe = new System.Windows.Forms.Label();
            this.lbl2ConverA = new System.Windows.Forms.Label();
            this.lbl3Resultado = new System.Windows.Forms.Label();
            this.bttn1Convertir = new System.Windows.Forms.Button();
            this.cbo1ConverDe = new System.Windows.Forms.ComboBox();
            this.txt1Valor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1ConverDe
            // 
            this.lbl1ConverDe.AutoSize = true;
            this.lbl1ConverDe.Location = new System.Drawing.Point(52, 49);
            this.lbl1ConverDe.Name = "lbl1ConverDe";
            this.lbl1ConverDe.Size = new System.Drawing.Size(98, 20);
            this.lbl1ConverDe.TabIndex = 0;
            this.lbl1ConverDe.Text = "Convertir de:";
            // 
            // lbl2ConverA
            // 
            this.lbl2ConverA.AutoSize = true;
            this.lbl2ConverA.Location = new System.Drawing.Point(52, 101);
            this.lbl2ConverA.Name = "lbl2ConverA";
            this.lbl2ConverA.Size = new System.Drawing.Size(89, 20);
            this.lbl2ConverA.TabIndex = 1;
            this.lbl2ConverA.Text = "Convertir a:";
            // 
            // lbl3Resultado
            // 
            this.lbl3Resultado.AutoSize = true;
            this.lbl3Resultado.Location = new System.Drawing.Point(52, 220);
            this.lbl3Resultado.Name = "lbl3Resultado";
            this.lbl3Resultado.Size = new System.Drawing.Size(82, 20);
            this.lbl3Resultado.TabIndex = 2;
            this.lbl3Resultado.Text = "Resultado";
            // 
            // bttn1Convertir
            // 
            this.bttn1Convertir.Location = new System.Drawing.Point(207, 243);
            this.bttn1Convertir.Name = "bttn1Convertir";
            this.bttn1Convertir.Size = new System.Drawing.Size(127, 67);
            this.bttn1Convertir.TabIndex = 3;
            this.bttn1Convertir.Text = "Convertir";
            this.bttn1Convertir.UseVisualStyleBackColor = true;
            this.bttn1Convertir.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbo1ConverDe
            // 
            this.cbo1ConverDe.FormattingEnabled = true;
            this.cbo1ConverDe.Items.AddRange(new object[] {
            "Tonelada",
            "Kilogramo",
            "Gramo",
            "Miligramo",
            "Microgramo",
            "ToneladaLarga",
            "ToneladaCorta",
            "Stone",
            "Libra",
            "Onza"});
            this.cbo1ConverDe.Location = new System.Drawing.Point(161, 101);
            this.cbo1ConverDe.Name = "cbo1ConverDe";
            this.cbo1ConverDe.Size = new System.Drawing.Size(213, 28);
            this.cbo1ConverDe.TabIndex = 4;
            this.cbo1ConverDe.SelectedIndexChanged += new System.EventHandler(this.cbo1ConverDe_SelectedIndexChanged);
            // 
            // txt1Valor
            // 
            this.txt1Valor.Location = new System.Drawing.Point(161, 49);
            this.txt1Valor.Name = "txt1Valor";
            this.txt1Valor.Size = new System.Drawing.Size(213, 26);
            this.txt1Valor.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt1Valor);
            this.Controls.Add(this.cbo1ConverDe);
            this.Controls.Add(this.bttn1Convertir);
            this.Controls.Add(this.lbl3Resultado);
            this.Controls.Add(this.lbl2ConverA);
            this.Controls.Add(this.lbl1ConverDe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1ConverDe;
        private System.Windows.Forms.Label lbl2ConverA;
        private System.Windows.Forms.Label lbl3Resultado;
        private System.Windows.Forms.Button bttn1Convertir;
        private System.Windows.Forms.ComboBox cbo1ConverDe;
        private System.Windows.Forms.TextBox txt1Valor;
    }
}

