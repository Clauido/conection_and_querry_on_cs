﻿namespace Conexion_PostgresSQL
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
            this.btn_conction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_conction
            // 
            this.btn_conction.Location = new System.Drawing.Point(12, 12);
            this.btn_conction.Name = "btn_conction";
            this.btn_conction.Size = new System.Drawing.Size(120, 23);
            this.btn_conction.TabIndex = 0;
            this.btn_conction.Text = "Conectar a Postgres";
            this.btn_conction.UseVisualStyleBackColor = true;
            this.btn_conction.Click += new System.EventHandler(this.btn_conction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_conction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_conction;
    }
}

