﻿namespace bengaleiro
{
    partial class Segundo
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
            btn_reg = new Button();
            btn_ex = new Button();
            SuspendLayout();
            // 
            // btn_reg
            // 
            btn_reg.Location = new Point(37, 40);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(124, 26);
            btn_reg.TabIndex = 0;
            btn_reg.Text = "Registo";
            btn_reg.UseVisualStyleBackColor = true;
            btn_reg.Click += btn_reg_Click;
            // 
            // btn_ex
            // 
            btn_ex.Location = new Point(37, 113);
            btn_ex.Name = "btn_ex";
            btn_ex.Size = new Size(124, 23);
            btn_ex.TabIndex = 1;
            btn_ex.Text = "Saida";
            btn_ex.UseVisualStyleBackColor = true;
            btn_ex.Click += btn_ex_Click;
            // 
            // Segundo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 188);
            Controls.Add(btn_ex);
            Controls.Add(btn_reg);
            Name = "Segundo";
            Text = "Novo";
            Load += Segundo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_reg;
        private Button btn_ex;
    }
}