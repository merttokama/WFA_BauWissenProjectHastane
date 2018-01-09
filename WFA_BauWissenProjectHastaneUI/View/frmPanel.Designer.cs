namespace WFA_BauWissenProjectHastaneUI
{
    partial class frmPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doktorlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşirelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuSistemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuÇıktısıPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.DosyaKayit = new System.Windows.Forms.SaveFileDialog();
            this.DosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorlarToolStripMenuItem,
            this.hemşirelerToolStripMenuItem,
            this.hastalarToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.randevuSistemiToolStripMenuItem,
            this.dosyaİşlemleriToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // doktorlarToolStripMenuItem
            // 
            resources.ApplyResources(this.doktorlarToolStripMenuItem, "doktorlarToolStripMenuItem");
            this.doktorlarToolStripMenuItem.Name = "doktorlarToolStripMenuItem";
            this.doktorlarToolStripMenuItem.Click += new System.EventHandler(this.doktorlarToolStripMenuItem_Click);
            // 
            // hemşirelerToolStripMenuItem
            // 
            resources.ApplyResources(this.hemşirelerToolStripMenuItem, "hemşirelerToolStripMenuItem");
            this.hemşirelerToolStripMenuItem.Name = "hemşirelerToolStripMenuItem";
            this.hemşirelerToolStripMenuItem.Click += new System.EventHandler(this.hemşirelerToolStripMenuItem_Click);
            // 
            // hastalarToolStripMenuItem
            // 
            resources.ApplyResources(this.hastalarToolStripMenuItem, "hastalarToolStripMenuItem");
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Click += new System.EventHandler(this.hastalarToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            resources.ApplyResources(this.personelToolStripMenuItem, "personelToolStripMenuItem");
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // randevuSistemiToolStripMenuItem
            // 
            this.randevuSistemiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuİşlemleriToolStripMenuItem,
            this.randevuÇıktısıPDFToolStripMenuItem});
            resources.ApplyResources(this.randevuSistemiToolStripMenuItem, "randevuSistemiToolStripMenuItem");
            this.randevuSistemiToolStripMenuItem.Name = "randevuSistemiToolStripMenuItem";
            // 
            // randevuİşlemleriToolStripMenuItem
            // 
            this.randevuİşlemleriToolStripMenuItem.Name = "randevuİşlemleriToolStripMenuItem";
            resources.ApplyResources(this.randevuİşlemleriToolStripMenuItem, "randevuİşlemleriToolStripMenuItem");
            this.randevuİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.randevuİşlemleriToolStripMenuItem_Click);
            // 
            // randevuÇıktısıPDFToolStripMenuItem
            // 
            this.randevuÇıktısıPDFToolStripMenuItem.Name = "randevuÇıktısıPDFToolStripMenuItem";
            resources.ApplyResources(this.randevuÇıktısıPDFToolStripMenuItem, "randevuÇıktısıPDFToolStripMenuItem");
            this.randevuÇıktısıPDFToolStripMenuItem.Click += new System.EventHandler(this.randevuÇıktısıPDFToolStripMenuItem_Click);
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            this.dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem});
            resources.ApplyResources(this.dosyaİşlemleriToolStripMenuItem, "dosyaİşlemleriToolStripMenuItem");
            this.dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içeriAktarToolStripMenuItem,
            this.dışarıAktarToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            resources.ApplyResources(this.xMLToolStripMenuItem, "xMLToolStripMenuItem");
            // 
            // içeriAktarToolStripMenuItem
            // 
            this.içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            resources.ApplyResources(this.içeriAktarToolStripMenuItem, "içeriAktarToolStripMenuItem");
            this.içeriAktarToolStripMenuItem.Click += new System.EventHandler(this.içeriAktarToolStripMenuItem_Click);
            // 
            // dışarıAktarToolStripMenuItem
            // 
            this.dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            resources.ApplyResources(this.dışarıAktarToolStripMenuItem, "dışarıAktarToolStripMenuItem");
            this.dışarıAktarToolStripMenuItem.Click += new System.EventHandler(this.dışarıAktarToolStripMenuItem_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içeriAktarToolStripMenuItem1,
            this.dışarıAktarToolStripMenuItem1});
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            resources.ApplyResources(this.jSONToolStripMenuItem, "jSONToolStripMenuItem");
            // 
            // içeriAktarToolStripMenuItem1
            // 
            this.içeriAktarToolStripMenuItem1.Name = "içeriAktarToolStripMenuItem1";
            resources.ApplyResources(this.içeriAktarToolStripMenuItem1, "içeriAktarToolStripMenuItem1");
            this.içeriAktarToolStripMenuItem1.Click += new System.EventHandler(this.içeriAktarToolStripMenuItem1_Click);
            // 
            // dışarıAktarToolStripMenuItem1
            // 
            this.dışarıAktarToolStripMenuItem1.Name = "dışarıAktarToolStripMenuItem1";
            resources.ApplyResources(this.dışarıAktarToolStripMenuItem1, "dışarıAktarToolStripMenuItem1");
            this.dışarıAktarToolStripMenuItem1.Click += new System.EventHandler(this.dışarıAktarToolStripMenuItem1_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.btnCikisYap, "btnCikisYap");
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // DosyaKayit
            // 
            this.DosyaKayit.FileName = "DosyaKayit";
            // 
            // DosyaAc
            // 
            this.DosyaAc.FileName = "DosyaAc";
            // 
            // frmPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::WFA_BauWissenProjectHastaneUI.Properties.Resources.slider_1;
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmPanel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem hemşirelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuSistemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem1;
        public System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.ToolStripMenuItem doktorlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuÇıktısıPDFToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog DosyaKayit;
        private System.Windows.Forms.OpenFileDialog DosyaAc;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}

