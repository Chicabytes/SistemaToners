
namespace SistemaToners
{
    partial class ListaToners
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
            this.Exoprtar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Exoprtar
            // 
            this.Exoprtar.Location = new System.Drawing.Point(12, 412);
            this.Exoprtar.Name = "Exoprtar";
            this.Exoprtar.Size = new System.Drawing.Size(75, 23);
            this.Exoprtar.TabIndex = 1;
            this.Exoprtar.Text = "Exportar";
            this.Exoprtar.UseVisualStyleBackColor = true;
            this.Exoprtar.Click += new System.EventHandler(this.Exoprtar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(93, 412);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "xlsx";
            this.saveFile.Title = "Lista Toners";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 394);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ListaToners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 447);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Exoprtar);
            this.Name = "ListaToners";
            this.Text = "Lista de Toners";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exoprtar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ListView listView1;
    }
}