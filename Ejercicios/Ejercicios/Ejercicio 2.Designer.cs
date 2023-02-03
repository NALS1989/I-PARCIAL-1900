namespace Ejercicios
{
    partial class Ejercicio_2
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
            this.components = new System.ComponentModel.Container();
            this.calcularbutton1 = new System.Windows.Forms.Button();
            this.Numero2textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OperacionesComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Resultadolabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // calcularbutton1
            // 
            this.calcularbutton1.Location = new System.Drawing.Point(291, 273);
            this.calcularbutton1.Name = "calcularbutton1";
            this.calcularbutton1.Size = new System.Drawing.Size(219, 68);
            this.calcularbutton1.TabIndex = 9;
            this.calcularbutton1.Text = "CALCULAR";
            this.calcularbutton1.UseVisualStyleBackColor = true;
            this.calcularbutton1.Click += new System.EventHandler(this.calcularbutton1_Click);
            // 
            // Numero2textBox2
            // 
            this.Numero2textBox2.Location = new System.Drawing.Point(291, 124);
            this.Numero2textBox2.Name = "Numero2textBox2";
            this.Numero2textBox2.Size = new System.Drawing.Size(219, 22);
            this.Numero2textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero 2";
            // 
            // Numero1textBox1
            // 
            this.Numero1textBox1.Location = new System.Drawing.Point(291, 26);
            this.Numero1textBox1.Name = "Numero1textBox1";
            this.Numero1textBox1.Size = new System.Drawing.Size(219, 22);
            this.Numero1textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero 1";
            // 
            // OperacionesComboBox
            // 
            this.OperacionesComboBox.FormattingEnabled = true;
            this.OperacionesComboBox.Items.AddRange(new object[] {
            "Suma",
            "Resta ",
            "Multiplicacion ",
            "Division"});
            this.OperacionesComboBox.Location = new System.Drawing.Point(291, 196);
            this.OperacionesComboBox.Name = "OperacionesComboBox";
            this.OperacionesComboBox.Size = new System.Drawing.Size(219, 24);
            this.OperacionesComboBox.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Resultadolabel3
            // 
            this.Resultadolabel3.AutoSize = true;
            this.Resultadolabel3.Location = new System.Drawing.Point(537, 203);
            this.Resultadolabel3.Name = "Resultadolabel3";
            this.Resultadolabel3.Size = new System.Drawing.Size(44, 16);
            this.Resultadolabel3.TabIndex = 11;
            this.Resultadolabel3.Text = "label3";
            // 
            // Ejercicio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultadolabel3);
            this.Controls.Add(this.OperacionesComboBox);
            this.Controls.Add(this.calcularbutton1);
            this.Controls.Add(this.Numero2textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero1textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio_2";
            this.Text = "Ejercicio_2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularbutton1;
        private System.Windows.Forms.TextBox Numero2textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OperacionesComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Resultadolabel3;
    }
}