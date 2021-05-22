
namespace Savas_Desktop
{
    partial class ana_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ana_form));
            this.bilgi_panel = new System.Windows.Forms.Panel();
            this.skor_label = new System.Windows.Forms.Label();
            this.sure_label = new System.Windows.Forms.Label();
            this.bilgi_label = new System.Windows.Forms.Label();
            this.ucaksavar_panel = new System.Windows.Forms.Panel();
            this.savas_alani_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bilgi_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgi_panel
            // 
            this.bilgi_panel.BackColor = System.Drawing.Color.SteelBlue;
            this.bilgi_panel.Controls.Add(this.label3);
            this.bilgi_panel.Controls.Add(this.label2);
            this.bilgi_panel.Controls.Add(this.skor_label);
            this.bilgi_panel.Controls.Add(this.sure_label);
            this.bilgi_panel.Controls.Add(this.bilgi_label);
            this.bilgi_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgi_panel.Location = new System.Drawing.Point(0, 0);
            this.bilgi_panel.Name = "bilgi_panel";
            this.bilgi_panel.Size = new System.Drawing.Size(959, 113);
            this.bilgi_panel.TabIndex = 0;
            // 
            // skor_label
            // 
            this.skor_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skor_label.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skor_label.ForeColor = System.Drawing.Color.White;
            this.skor_label.Location = new System.Drawing.Point(811, 4);
            this.skor_label.Name = "skor_label";
            this.skor_label.Size = new System.Drawing.Size(109, 54);
            this.skor_label.TabIndex = 2;
            this.skor_label.Text = "0";
            this.skor_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sure_label
            // 
            this.sure_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sure_label.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sure_label.ForeColor = System.Drawing.Color.White;
            this.sure_label.Location = new System.Drawing.Point(798, 59);
            this.sure_label.Name = "sure_label";
            this.sure_label.Size = new System.Drawing.Size(149, 54);
            this.sure_label.TabIndex = 1;
            this.sure_label.Text = "0:00";
            this.sure_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bilgi_label
            // 
            this.bilgi_label.AutoSize = true;
            this.bilgi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgi_label.ForeColor = System.Drawing.Color.AliceBlue;
            this.bilgi_label.Location = new System.Drawing.Point(12, 18);
            this.bilgi_label.Name = "bilgi_label";
            this.bilgi_label.Size = new System.Drawing.Size(632, 78);
            this.bilgi_label.TabIndex = 0;
            this.bilgi_label.Text = "Oyunu başlatmak için ENTER tuşuna basın.\r\nUçaksavarı hareket ettirmek için SAĞ/SO" +
    "L yön tuşlarını kullanın.\r\nAteş etmek için BOŞLUK tuşunu kullanın.";
            // 
            // ucaksavar_panel
            // 
            this.ucaksavar_panel.BackColor = System.Drawing.Color.Teal;
            this.ucaksavar_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucaksavar_panel.Location = new System.Drawing.Point(0, 585);
            this.ucaksavar_panel.Name = "ucaksavar_panel";
            this.ucaksavar_panel.Size = new System.Drawing.Size(959, 79);
            this.ucaksavar_panel.TabIndex = 1;
            // 
            // savas_alani_panel
            // 
            this.savas_alani_panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.savas_alani_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savas_alani_panel.Location = new System.Drawing.Point(0, 113);
            this.savas_alani_panel.Name = "savas_alani_panel";
            this.savas_alani_panel.Size = new System.Drawing.Size(959, 472);
            this.savas_alani_panel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(640, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "SKOR:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(640, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "SÜRE:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ana_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 664);
            this.Controls.Add(this.savas_alani_panel);
            this.Controls.Add(this.ucaksavar_panel);
            this.Controls.Add(this.bilgi_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ana_form";
            this.Text = "Savaş Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ana_form_KeyDown);
            this.bilgi_panel.ResumeLayout(false);
            this.bilgi_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgi_panel;
        private System.Windows.Forms.Label sure_label;
        private System.Windows.Forms.Label bilgi_label;
        private System.Windows.Forms.Panel ucaksavar_panel;
        private System.Windows.Forms.Panel savas_alani_panel;
        private System.Windows.Forms.Label skor_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

