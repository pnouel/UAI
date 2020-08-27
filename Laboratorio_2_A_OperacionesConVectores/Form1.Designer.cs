namespace Laboratorio_2_A_OperacionesConVectores
{
    partial class OperacionesVectores
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
            this.btnCarga = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnCopoar = new System.Windows.Forms.Button();
            this.btnLimites = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(132, 12);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(75, 23);
            this.btnCarga.TabIndex = 0;
            this.btnCarga.Text = "Carga";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(79, 156);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnCopoar
            // 
            this.btnCopoar.Location = new System.Drawing.Point(181, 156);
            this.btnCopoar.Name = "btnCopoar";
            this.btnCopoar.Size = new System.Drawing.Size(75, 23);
            this.btnCopoar.TabIndex = 2;
            this.btnCopoar.Text = "Copiar";
            this.btnCopoar.UseVisualStyleBackColor = true;
            this.btnCopoar.Click += new System.EventHandler(this.btnCopoar_Click);
            // 
            // btnLimites
            // 
            this.btnLimites.Location = new System.Drawing.Point(79, 202);
            this.btnLimites.Name = "btnLimites";
            this.btnLimites.Size = new System.Drawing.Size(75, 23);
            this.btnLimites.TabIndex = 3;
            this.btnLimites.Text = "Limites";
            this.btnLimites.UseVisualStyleBackColor = true;
            this.btnLimites.Click += new System.EventHandler(this.btnLimites_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(181, 202);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(75, 23);
            this.btnBinario.TabIndex = 4;
            this.btnBinario.Text = "Bueq Binaria";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(132, 242);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 82);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // OperacionesVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 287);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnLimites);
            this.Controls.Add(this.btnCopoar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnCarga);
            this.Name = "OperacionesVectores";
            this.Text = "Operaciones con Vectores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnCopoar;
        private System.Windows.Forms.Button btnLimites;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox listBox1;
    }
}

