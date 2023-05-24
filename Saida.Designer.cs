namespace bengaleiro
{
    partial class Saida
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
            btn_exit_s = new Button();
            SuspendLayout();
            // 
            // btn_exit_s
            // 
            btn_exit_s.Location = new Point(90, 312);
            btn_exit_s.Name = "btn_exit_s";
            btn_exit_s.Size = new Size(75, 23);
            btn_exit_s.TabIndex = 1;
            btn_exit_s.Text = "Voltar";
            btn_exit_s.UseVisualStyleBackColor = true;
            btn_exit_s.Click += btn_exit_s_Click;
            // 
            // Saida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_exit_s);
            Name = "Saida";
            Text = "Saida";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_exit_s;
    }
}