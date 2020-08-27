namespace Cronometro
{
    partial class Cronometro
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
            this.btnComezar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnComezar
            // 
            this.btnComezar.Location = new System.Drawing.Point(35, 150);
            this.btnComezar.Name = "btnComezar";
            this.btnComezar.Size = new System.Drawing.Size(75, 23);
            this.btnComezar.TabIndex = 0;
            this.btnComezar.Text = "Comenzar";
            this.btnComezar.UseVisualStyleBackColor = true;
            this.btnComezar.Click += new System.EventHandler(this.btnComezar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(130, 150);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 1;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(224, 150);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(75, 23);
            this.btnInicializar.TabIndex = 2;
            this.btnInicializar.Text = "Incializar";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometro.Location = new System.Drawing.Point(89, 48);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(0, 46);
            this.lblCronometro.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 212);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnComezar);
            this.Name = "Cronometro";
            this.Text = "Cronometro";
            this.Load += new System.EventHandler(this.Cronometro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComezar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Timer timer1;
    }
}

