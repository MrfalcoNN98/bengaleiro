namespace bengaleiro
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
            btn_add = new Button();
            btn_remove = new Button();
            lb_itens = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(21, 145);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 1;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(113, 145);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(75, 23);
            btn_remove.TabIndex = 2;
            btn_remove.Text = "Remover";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // lb_itens
            // 
            lb_itens.FormattingEnabled = true;
            lb_itens.ItemHeight = 15;
            lb_itens.Items.AddRange(new object[] { "Casaco", "Mala", "Telemovel", "Carteira", "Sapatos", "Chaves" });
            lb_itens.Location = new Point(218, 45);
            lb_itens.Name = "lb_itens";
            lb_itens.Size = new Size(120, 94);
            lb_itens.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 270);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 94);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // Segundo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lb_itens);
            Controls.Add(btn_remove);
            Controls.Add(btn_add);
            Name = "Segundo";
            Text = "Novo";
            Load += Segundo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_add;
        private Button btn_remove;
        private ListBox lb_itens;
        private Label label1;
        private TextBox textBox1;
    }
}