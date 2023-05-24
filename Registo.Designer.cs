namespace bengaleiro
{
    partial class Registo
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
            components = new System.ComponentModel.Container();
            btn_exit_r = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btn_exit_r
            // 
            btn_exit_r.Location = new Point(275, 167);
            btn_exit_r.Name = "btn_exit_r";
            btn_exit_r.Size = new Size(75, 23);
            btn_exit_r.TabIndex = 0;
            btn_exit_r.Text = "Voltar";
            btn_exit_r.UseVisualStyleBackColor = true;
            btn_exit_r.Click += btn_exit_r_Click;
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // Registo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 202);
            Controls.Add(btn_exit_r);
            Name = "Registo";
            Text = "Registo";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_exit_r;
        private BindingSource bindingSource1;
    }
}