
namespace SistemaToners.Area
{
    partial class AgregArea
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
            this.nArea = new System.Windows.Forms.ComboBox();
            this.nombArea = new System.Windows.Forms.Label();
            this.numAreanuevo = new System.Windows.Forms.Label();
            this.nuevoNumArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPuesto = new System.Windows.Forms.Label();
            this.nuevoNPuesto = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nArea
            // 
            this.nArea.FormattingEnabled = true;
            this.nArea.Location = new System.Drawing.Point(124, 90);
            this.nArea.Name = "nArea";
            this.nArea.Size = new System.Drawing.Size(115, 23);
            this.nArea.TabIndex = 0;
            // 
            // nombArea
            // 
            this.nombArea.AutoSize = true;
            this.nombArea.Location = new System.Drawing.Point(12, 93);
            this.nombArea.Name = "nombArea";
            this.nombArea.Size = new System.Drawing.Size(31, 15);
            this.nombArea.TabIndex = 1;
            this.nombArea.Text = "Area";
            // 
            // numAreanuevo
            // 
            this.numAreanuevo.AutoSize = true;
            this.numAreanuevo.Location = new System.Drawing.Point(12, 12);
            this.numAreanuevo.Name = "numAreanuevo";
            this.numAreanuevo.Size = new System.Drawing.Size(132, 15);
            this.numAreanuevo.TabIndex = 2;
            this.numAreanuevo.Text = "Nuevo Numero de Area";
            // 
            // nuevoNumArea
            // 
            this.nuevoNumArea.Location = new System.Drawing.Point(150, 9);
            this.nuevoNumArea.Name = "nuevoNumArea";
            this.nuevoNumArea.Size = new System.Drawing.Size(89, 23);
            this.nuevoNumArea.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(-13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "---------------------------------------------------";
            // 
            // numPuesto
            // 
            this.numPuesto.AutoSize = true;
            this.numPuesto.Location = new System.Drawing.Point(12, 122);
            this.numPuesto.Name = "numPuesto";
            this.numPuesto.Size = new System.Drawing.Size(106, 15);
            this.numPuesto.TabIndex = 5;
            this.numPuesto.Text = "Numero de Puesto";
            // 
            // nuevoNPuesto
            // 
            this.nuevoNPuesto.Location = new System.Drawing.Point(124, 119);
            this.nuevoNPuesto.Name = "nuevoNPuesto";
            this.nuevoNPuesto.Size = new System.Drawing.Size(115, 23);
            this.nuevoNPuesto.TabIndex = 6;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(93, 148);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(12, 148);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 23);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Area";
            // 
            // AgregArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.nuevoNPuesto);
            this.Controls.Add(this.numPuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nuevoNumArea);
            this.Controls.Add(this.numAreanuevo);
            this.Controls.Add(this.nombArea);
            this.Controls.Add(this.nArea);
            this.Name = "AgregArea";
            this.Text = "Agregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nArea;
        private System.Windows.Forms.Label nombArea;
        private System.Windows.Forms.Label numAreanuevo;
        private System.Windows.Forms.TextBox nuevoNumArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numPuesto;
        private System.Windows.Forms.TextBox nuevoNPuesto;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}