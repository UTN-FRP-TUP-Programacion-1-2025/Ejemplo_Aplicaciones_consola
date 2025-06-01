namespace Ejemplo4
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            label1 = new Label();
            tbNota = new TextBox();
            groupBox2 = new GroupBox();
            lbPromedio = new Label();
            label2 = new Label();
            btnCalcularMostrarPromedio = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbNota);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(408, 153);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese la nota de un alumno";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(123, 104);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(158, 41);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 21);
            label1.TabIndex = 1;
            label1.Text = "Ingrese a continuación la nota:";
            // 
            // tbNota
            // 
            tbNota.Location = new Point(252, 55);
            tbNota.Margin = new Padding(4);
            tbNota.Name = "tbNota";
            tbNota.Size = new Size(127, 29);
            tbNota.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbPromedio);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnCalcularMostrarPromedio);
            groupBox2.Location = new Point(13, 174);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(408, 208);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mostrar promedio de las notas cargadas";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.BackColor = SystemColors.ActiveCaption;
            lbPromedio.Location = new Point(253, 69);
            lbPromedio.Margin = new Padding(4, 0, 4, 0);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(91, 21);
            lbPromedio.TabIndex = 3;
            lbPromedio.Text = "lbPromedio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 21);
            label2.TabIndex = 2;
            label2.Text = "El promedio resultante es:";
            // 
            // btnCalcularMostrarPromedio
            // 
            btnCalcularMostrarPromedio.Location = new Point(123, 131);
            btnCalcularMostrarPromedio.Margin = new Padding(4);
            btnCalcularMostrarPromedio.Name = "btnCalcularMostrarPromedio";
            btnCalcularMostrarPromedio.Size = new Size(158, 57);
            btnCalcularMostrarPromedio.TabIndex = 0;
            btnCalcularMostrarPromedio.Text = "Calcular y Mostrar Promedio";
            btnCalcularMostrarPromedio.UseVisualStyleBackColor = true;
            btnCalcularMostrarPromedio.Click += btnCalcularMostrarPromedio_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 389);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mostrar promedio de las notas cargadas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrar;
        private Label label1;
        private TextBox tbNota;
        private GroupBox groupBox2;
        private Label lbPromedio;
        private Label label2;
        private Button btnCalcularMostrarPromedio;
    }
}
