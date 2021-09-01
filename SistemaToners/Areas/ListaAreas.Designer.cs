
namespace SistemaToners.Areas
{
    partial class ListaAreas
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
            this.ListArea = new System.Windows.Forms.ListBox();
            this.AgreArea = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.BoxBuscar = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListArea
            // 
            this.ListArea.FormattingEnabled = true;
            this.ListArea.ItemHeight = 15;
            this.ListArea.Location = new System.Drawing.Point(12, 42);
            this.ListArea.Name = "ListArea";
            this.ListArea.Size = new System.Drawing.Size(249, 349);
            this.ListArea.TabIndex = 0;
            // 
            // AgreArea
            // 
            this.AgreArea.Location = new System.Drawing.Point(267, 42);
            this.AgreArea.Name = "AgreArea";
            this.AgreArea.Size = new System.Drawing.Size(75, 23);
            this.AgreArea.TabIndex = 1;
            this.AgreArea.Text = "Agregar";
            this.AgreArea.UseVisualStyleBackColor = true;
            this.AgreArea.Click += new System.EventHandler(this.AgreArea_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(267, 100);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 2;
            this.Export.Text = "Exportar";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(267, 129);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(267, 71);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 4;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // BoxBuscar
            // 
            this.BoxBuscar.Location = new System.Drawing.Point(12, 12);
            this.BoxBuscar.Name = "BoxBuscar";
            this.BoxBuscar.Size = new System.Drawing.Size(249, 23);
            this.BoxBuscar.TabIndex = 5;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(267, 11);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 6;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // ListaAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 407);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.BoxBuscar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.AgreArea);
            this.Controls.Add(this.ListArea);
            this.Name = "ListaAreas";
            this.Text = "Lista de Areas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListArea;
        private System.Windows.Forms.Button AgreArea;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.TextBox BoxBuscar;
        private System.Windows.Forms.Button Buscar;
    }
}