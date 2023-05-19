namespace RestoranDemo
{
    partial class frmMenu
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
            btnMasaSiparis = new Button();
            btnRezervasyon = new Button();
            btnPaketServis = new Button();
            btnMusteriler = new Button();
            btnKasa = new Button();
            btnMutfak = new Button();
            btnRaporlar = new Button();
            SuspendLayout();
            // 
            // btnMasaSiparis
            // 
            btnMasaSiparis.BackgroundImage = Properties.Resources.istockphoto_1218084938_170667a;
            btnMasaSiparis.BackgroundImageLayout = ImageLayout.Stretch;
            btnMasaSiparis.Cursor = Cursors.No;
            btnMasaSiparis.FlatStyle = FlatStyle.Popup;
            btnMasaSiparis.Location = new Point(12, 80);
            btnMasaSiparis.Name = "btnMasaSiparis";
            btnMasaSiparis.Size = new Size(469, 171);
            btnMasaSiparis.TabIndex = 0;
            btnMasaSiparis.UseVisualStyleBackColor = true;
            // 
            // btnRezervasyon
            // 
            btnRezervasyon.BackgroundImage = Properties.Resources._2907544;
            btnRezervasyon.BackgroundImageLayout = ImageLayout.Stretch;
            btnRezervasyon.FlatStyle = FlatStyle.Popup;
            btnRezervasyon.Location = new Point(502, 80);
            btnRezervasyon.Name = "btnRezervasyon";
            btnRezervasyon.Size = new Size(214, 171);
            btnRezervasyon.TabIndex = 0;
            btnRezervasyon.UseVisualStyleBackColor = true;
            // 
            // btnPaketServis
            // 
            btnPaketServis.BackgroundImage = Properties.Resources.paketservis;
            btnPaketServis.BackgroundImageLayout = ImageLayout.Stretch;
            btnPaketServis.FlatStyle = FlatStyle.Popup;
            btnPaketServis.Location = new Point(768, 80);
            btnPaketServis.Name = "btnPaketServis";
            btnPaketServis.Size = new Size(203, 171);
            btnPaketServis.TabIndex = 0;
            btnPaketServis.UseVisualStyleBackColor = true;
            // 
            // btnMusteriler
            // 
            btnMusteriler.BackgroundImage = Properties.Resources._153_1538896_community_icon_transparent_background_png_download_transparent_transparent;
            btnMusteriler.BackgroundImageLayout = ImageLayout.Stretch;
            btnMusteriler.FlatStyle = FlatStyle.Popup;
            btnMusteriler.Location = new Point(12, 275);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(212, 171);
            btnMusteriler.TabIndex = 0;
            btnMusteriler.UseVisualStyleBackColor = true;
            // 
            // btnKasa
            // 
            btnKasa.BackgroundImage = Properties.Resources.image_processing20200423_30831_gikyrq;
            btnKasa.BackgroundImageLayout = ImageLayout.Stretch;
            btnKasa.FlatStyle = FlatStyle.Popup;
            btnKasa.Location = new Point(269, 275);
            btnKasa.Name = "btnKasa";
            btnKasa.Size = new Size(212, 171);
            btnKasa.TabIndex = 0;
            btnKasa.UseVisualStyleBackColor = true;
            // 
            // btnMutfak
            // 
            btnMutfak.BackgroundImage = Properties.Resources.gg;
            btnMutfak.BackgroundImageLayout = ImageLayout.Center;
            btnMutfak.FlatStyle = FlatStyle.Popup;
            btnMutfak.Location = new Point(502, 275);
            btnMutfak.Name = "btnMutfak";
            btnMutfak.Size = new Size(469, 171);
            btnMutfak.TabIndex = 0;
            btnMutfak.UseVisualStyleBackColor = true;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackgroundImage = Properties.Resources.zyro_image;
            btnRaporlar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRaporlar.FlatStyle = FlatStyle.Popup;
            btnRaporlar.Location = new Point(12, 464);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(212, 171);
            btnRaporlar.TabIndex = 0;
            btnRaporlar.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 779);
            Controls.Add(btnPaketServis);
            Controls.Add(btnKasa);
            Controls.Add(btnRaporlar);
            Controls.Add(btnMusteriler);
            Controls.Add(btnRezervasyon);
            Controls.Add(btnMutfak);
            Controls.Add(btnMasaSiparis);
            Name = "frmMenu";
            Text = "frmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMasaSiparis;
        private Button btnRezervasyon;
        private Button btnPaketServis;
        private Button btnMusteriler;
        private Button btnKasa;
        private Button btnMutfak;
        private Button btnRaporlar;
    }
}