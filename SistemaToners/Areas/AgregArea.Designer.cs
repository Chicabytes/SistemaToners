
namespace SistemaToners.Areas
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
            this.label2 = new System.Windows.Forms.Label();
            this.numPuesto = new System.Windows.Forms.Label();
            this.nuevoNPuesto = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombrArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nArea
            // 
            this.nArea.FormattingEnabled = true;
            this.nArea.Location = new System.Drawing.Point(124, 56);
            this.nArea.Name = "nArea";
            this.nArea.Size = new System.Drawing.Size(115, 23);
            this.nArea.Sorted = true;
            this.nArea.TabIndex = 1;
            // 
            // nombArea
            // 
            this.nombArea.AutoSize = true;
            this.nombArea.Location = new System.Drawing.Point(12, 59);
            this.nombArea.Name = "nombArea";
            this.nombArea.Size = new System.Drawing.Size(31, 15);
            this.nombArea.TabIndex = 1;
            this.nombArea.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(-2, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "---------------------------------------------------";
            // 
            // numPuesto
            // 
            this.numPuesto.AutoSize = true;
            this.numPuesto.Location = new System.Drawing.Point(12, 88);
            this.numPuesto.Name = "numPuesto";
            this.numPuesto.Size = new System.Drawing.Size(106, 15);
            this.numPuesto.TabIndex = 5;
            this.numPuesto.Text = "Numero de Puesto";
            // 
            // nuevoNPuesto
            // 
            this.nuevoNPuesto.Location = new System.Drawing.Point(124, 85);
            this.nuevoNPuesto.Name = "nuevoNPuesto";
            this.nuevoNPuesto.Size = new System.Drawing.Size(115, 23);
            this.nuevoNPuesto.TabIndex = 6;
            this.nuevoNPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuevoNPuesto_KeyPress);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(93, 114);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(12, 114);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Area";
            // 
            // nombrArea
            // 
            this.nombrArea.Location = new System.Drawing.Point(124, 7);
            this.nombrArea.Name = "nombrArea";
            this.nombrArea.Size = new System.Drawing.Size(115, 23);
            this.nombrArea.TabIndex = 0;
            this.nombrArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombrArea_KeyPress);
            // 
            // AgregArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 152);
            this.Controls.Add(this.nombrArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.nuevoNPuesto);
            this.Controls.Add(this.numPuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombArea);
            this.Controls.Add(this.nArea);
            this.Name = "AgregArea";
            this.Text = "Agregar";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgregArea_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nArea;
        private System.Windows.Forms.Label nombArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numPuesto;
        private System.Windows.Forms.TextBox nuevoNPuesto;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox nombreArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombrArea;
    }
}