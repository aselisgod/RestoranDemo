namespace RestoranDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            txtSifre = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(350, 530);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(350, 580);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(217, 27);
            txtSifre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(350, 629);
            button1.Name = "button1";
            button1.Size = new Size(94, 46);
            button1.TabIndex = 2;
            button1.Text = "Giris\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(490, 629);
            button2.Name = "button2";
            button2.Size = new Size(77, 46);
            button2.TabIndex = 3;
            button2.Text = "Çıkış\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 530);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(190, 580);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 5;
            label2.Text = "Şifre :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.STAR_CHEF_Corporate_logo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(929, 687);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSifre);
            Controls.Add(comboBox1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += frmGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox txtSifre;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}