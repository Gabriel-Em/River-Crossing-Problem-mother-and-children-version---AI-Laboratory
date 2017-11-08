namespace ProblemaTraversariiRaului
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.picCopil1D = new System.Windows.Forms.PictureBox();
            this.picParinteD = new System.Windows.Forms.PictureBox();
            this.picCopil2D = new System.Windows.Forms.PictureBox();
            this.picBarca = new System.Windows.Forms.PictureBox();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnGBFS = new System.Windows.Forms.Button();
            this.listCopil2S = new System.Windows.Forms.ListBox();
            this.listCopil1S = new System.Windows.Forms.ListBox();
            this.listParinteS = new System.Windows.Forms.ListBox();
            this.listCopil2D = new System.Windows.Forms.ListBox();
            this.listCopil1D = new System.Windows.Forms.ListBox();
            this.listParinteD = new System.Windows.Forms.ListBox();
            this.listBarca1 = new System.Windows.Forms.ListBox();
            this.lblMalStang = new System.Windows.Forms.Label();
            this.lblMalDrept = new System.Windows.Forms.Label();
            this.lblBarca = new System.Windows.Forms.Label();
            this.btnStartAnimatie = new System.Windows.Forms.Button();
            this.picParinteS = new System.Windows.Forms.PictureBox();
            this.picCopil2S = new System.Windows.Forms.PictureBox();
            this.picCopil1S = new System.Windows.Forms.PictureBox();
            this.listDirectie = new System.Windows.Forms.ListBox();
            this.listBarca2 = new System.Windows.Forms.ListBox();
            this.timerBarca = new System.Windows.Forms.Timer(this.components);
            this.timerAnimatie = new System.Windows.Forms.Timer(this.components);
            this.lblDirectie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCopil1D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParinteD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopil2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParinteS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopil2S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopil1S)).BeginInit();
            this.SuspendLayout();
            // 
            // picCopil1D
            // 
            this.picCopil1D.BackColor = System.Drawing.Color.Transparent;
            this.picCopil1D.BackgroundImage = global::ProblemaTraversariiRaului.Properties.Resources.Copil;
            this.picCopil1D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picCopil1D.Location = new System.Drawing.Point(847, 300);
            this.picCopil1D.Name = "picCopil1D";
            this.picCopil1D.Size = new System.Drawing.Size(47, 84);
            this.picCopil1D.TabIndex = 0;
            this.picCopil1D.TabStop = false;
            // 
            // picParinteD
            // 
            this.picParinteD.BackColor = System.Drawing.Color.Transparent;
            this.picParinteD.BackgroundImage = global::ProblemaTraversariiRaului.Properties.Resources.Parinte;
            this.picParinteD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picParinteD.Location = new System.Drawing.Point(775, 244);
            this.picParinteD.Name = "picParinteD";
            this.picParinteD.Size = new System.Drawing.Size(66, 140);
            this.picParinteD.TabIndex = 1;
            this.picParinteD.TabStop = false;
            // 
            // picCopil2D
            // 
            this.picCopil2D.BackColor = System.Drawing.Color.Transparent;
            this.picCopil2D.BackgroundImage = global::ProblemaTraversariiRaului.Properties.Resources.Copil;
            this.picCopil2D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picCopil2D.Location = new System.Drawing.Point(901, 300);
            this.picCopil2D.Name = "picCopil2D";
            this.picCopil2D.Size = new System.Drawing.Size(47, 84);
            this.picCopil2D.TabIndex = 2;
            this.picCopil2D.TabStop = false;
            // 
            // picBarca
            // 
            this.picBarca.BackColor = System.Drawing.Color.Transparent;
            this.picBarca.BackgroundImage = global::ProblemaTraversariiRaului.Properties.Resources.Barca_goala;
            this.picBarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBarca.Location = new System.Drawing.Point(585, 300);
            this.picBarca.Name = "picBarca";
            this.picBarca.Size = new System.Drawing.Size(184, 150);
            this.picBarca.TabIndex = 3;
            this.picBarca.TabStop = false;
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.Transparent;
            this.btnBFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBFS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBFS.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFS.Location = new System.Drawing.Point(16, 183);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(149, 48);
            this.btnBFS.TabIndex = 4;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = false;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // btnGBFS
            // 
            this.btnGBFS.BackColor = System.Drawing.Color.Transparent;
            this.btnGBFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGBFS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGBFS.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGBFS.Location = new System.Drawing.Point(171, 183);
            this.btnGBFS.Name = "btnGBFS";
            this.btnGBFS.Size = new System.Drawing.Size(160, 48);
            this.btnGBFS.TabIndex = 5;
            this.btnGBFS.Text = "GBFS";
            this.btnGBFS.UseVisualStyleBackColor = false;
            this.btnGBFS.Click += new System.EventHandler(this.btnGBFS_Click);
            // 
            // listCopil2S
            // 
            this.listCopil2S.BackColor = System.Drawing.Color.Azure;
            this.listCopil2S.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCopil2S.FormattingEnabled = true;
            this.listCopil2S.ItemHeight = 17;
            this.listCopil2S.Location = new System.Drawing.Point(16, 36);
            this.listCopil2S.Name = "listCopil2S";
            this.listCopil2S.Size = new System.Drawing.Size(101, 140);
            this.listCopil2S.TabIndex = 8;
            this.listCopil2S.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listCopil1S
            // 
            this.listCopil1S.BackColor = System.Drawing.Color.Lavender;
            this.listCopil1S.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCopil1S.FormattingEnabled = true;
            this.listCopil1S.ItemHeight = 17;
            this.listCopil1S.Location = new System.Drawing.Point(123, 36);
            this.listCopil1S.Name = "listCopil1S";
            this.listCopil1S.Size = new System.Drawing.Size(101, 140);
            this.listCopil1S.TabIndex = 9;
            this.listCopil1S.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listParinteS
            // 
            this.listParinteS.BackColor = System.Drawing.Color.Azure;
            this.listParinteS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listParinteS.FormattingEnabled = true;
            this.listParinteS.ItemHeight = 17;
            this.listParinteS.Location = new System.Drawing.Point(230, 36);
            this.listParinteS.Name = "listParinteS";
            this.listParinteS.Size = new System.Drawing.Size(101, 140);
            this.listParinteS.TabIndex = 10;
            this.listParinteS.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listCopil2D
            // 
            this.listCopil2D.BackColor = System.Drawing.Color.Azure;
            this.listCopil2D.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCopil2D.FormattingEnabled = true;
            this.listCopil2D.ItemHeight = 17;
            this.listCopil2D.Location = new System.Drawing.Point(846, 36);
            this.listCopil2D.Name = "listCopil2D";
            this.listCopil2D.Size = new System.Drawing.Size(101, 140);
            this.listCopil2D.TabIndex = 13;
            this.listCopil2D.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listCopil1D
            // 
            this.listCopil1D.BackColor = System.Drawing.Color.Lavender;
            this.listCopil1D.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCopil1D.FormattingEnabled = true;
            this.listCopil1D.ItemHeight = 17;
            this.listCopil1D.Location = new System.Drawing.Point(739, 36);
            this.listCopil1D.Name = "listCopil1D";
            this.listCopil1D.Size = new System.Drawing.Size(101, 140);
            this.listCopil1D.TabIndex = 12;
            this.listCopil1D.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listParinteD
            // 
            this.listParinteD.BackColor = System.Drawing.Color.Azure;
            this.listParinteD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listParinteD.FormattingEnabled = true;
            this.listParinteD.ItemHeight = 17;
            this.listParinteD.Location = new System.Drawing.Point(632, 36);
            this.listParinteD.Name = "listParinteD";
            this.listParinteD.Size = new System.Drawing.Size(101, 140);
            this.listParinteD.TabIndex = 11;
            this.listParinteD.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listBarca1
            // 
            this.listBarca1.BackColor = System.Drawing.Color.Lavender;
            this.listBarca1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBarca1.FormattingEnabled = true;
            this.listBarca1.ItemHeight = 17;
            this.listBarca1.Location = new System.Drawing.Point(365, 36);
            this.listBarca1.Name = "listBarca1";
            this.listBarca1.Size = new System.Drawing.Size(88, 140);
            this.listBarca1.TabIndex = 14;
            this.listBarca1.Click += new System.EventHandler(this.listBox_Click);
            // 
            // lblMalStang
            // 
            this.lblMalStang.AutoSize = true;
            this.lblMalStang.BackColor = System.Drawing.Color.Transparent;
            this.lblMalStang.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalStang.Location = new System.Drawing.Point(109, 3);
            this.lblMalStang.Name = "lblMalStang";
            this.lblMalStang.Size = new System.Drawing.Size(129, 30);
            this.lblMalStang.TabIndex = 15;
            this.lblMalStang.Text = "Malul stang";
            // 
            // lblMalDrept
            // 
            this.lblMalDrept.AutoSize = true;
            this.lblMalDrept.BackColor = System.Drawing.Color.Transparent;
            this.lblMalDrept.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalDrept.Location = new System.Drawing.Point(723, 3);
            this.lblMalDrept.Name = "lblMalDrept";
            this.lblMalDrept.Size = new System.Drawing.Size(128, 30);
            this.lblMalDrept.TabIndex = 16;
            this.lblMalDrept.Text = "Malul drept";
            // 
            // lblBarca
            // 
            this.lblBarca.AutoSize = true;
            this.lblBarca.BackColor = System.Drawing.Color.Transparent;
            this.lblBarca.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarca.Location = new System.Drawing.Point(425, 3);
            this.lblBarca.Name = "lblBarca";
            this.lblBarca.Size = new System.Drawing.Size(66, 30);
            this.lblBarca.TabIndex = 17;
            this.lblBarca.Text = "Barca";
            // 
            // btnStartAnimatie
            // 
            this.btnStartAnimatie.BackColor = System.Drawing.Color.Transparent;
            this.btnStartAnimatie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartAnimatie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartAnimatie.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAnimatie.Location = new System.Drawing.Point(632, 183);
            this.btnStartAnimatie.Name = "btnStartAnimatie";
            this.btnStartAnimatie.Size = new System.Drawing.Size(315, 48);
            this.btnStartAnimatie.TabIndex = 18;
            this.btnStartAnimatie.Text = "Start Animatie";
            this.btnStartAnimatie.UseVisualStyleBackColor = false;
            this.btnStartAnimatie.Click += new System.EventHandler(this.btnStartAnimatie_Click);
            // 
            // picParinteS
            // 
            this.picParinteS.BackColor = System.Drawing.Color.Transparent;
            this.picParinteS.BackgroundImage = global::ProblemaTraversariiRaului.Properties.Resources.Parinte;
            this.picParinteS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picParinteS.Location = new System.Drawing.Point(118, 244);
            this.picParinteS.Name = "picParinteS";
            this.picParinteS.Size = new System.Drawing.Size(66, 140);
            this.picParinteS.TabIndex = 20;
            this.picParinteS.TabStop = false;
            this.picParinteS.Visible = false;
            // 
            // picCopil2S
            // 
            this.picCopil2S.BackColor = System.Drawing.Color.Transparent;
            this.picCopil2S.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCopil2S.BackgroundImage")));
            this.picCopil2S.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picCopil2S.Location = new System.Drawing.Point(12, 300);
            this.picCopil2S.Name = "picCopil2S";
            this.picCopil2S.Size = new System.Drawing.Size(47, 84);
            this.picCopil2S.TabIndex = 21;
            this.picCopil2S.TabStop = false;
            this.picCopil2S.Visible = false;
            // 
            // picCopil1S
            // 
            this.picCopil1S.BackColor = System.Drawing.Color.Transparent;
            this.picCopil1S.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCopil1S.BackgroundImage")));
            this.picCopil1S.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picCopil1S.Location = new System.Drawing.Point(65, 300);
            this.picCopil1S.Name = "picCopil1S";
            this.picCopil1S.Size = new System.Drawing.Size(47, 84);
            this.picCopil1S.TabIndex = 19;
            this.picCopil1S.TabStop = false;
            this.picCopil1S.Visible = false;
            // 
            // listDirectie
            // 
            this.listDirectie.BackColor = System.Drawing.Color.Lavender;
            this.listDirectie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDirectie.FormattingEnabled = true;
            this.listDirectie.ItemHeight = 17;
            this.listDirectie.Location = new System.Drawing.Point(552, 36);
            this.listDirectie.Name = "listDirectie";
            this.listDirectie.Size = new System.Drawing.Size(43, 140);
            this.listDirectie.TabIndex = 22;
            this.listDirectie.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listBarca2
            // 
            this.listBarca2.BackColor = System.Drawing.Color.Azure;
            this.listBarca2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBarca2.FormattingEnabled = true;
            this.listBarca2.ItemHeight = 17;
            this.listBarca2.Location = new System.Drawing.Point(458, 36);
            this.listBarca2.Name = "listBarca2";
            this.listBarca2.Size = new System.Drawing.Size(88, 140);
            this.listBarca2.TabIndex = 23;
            this.listBarca2.Click += new System.EventHandler(this.listBox_Click);
            // 
            // timerBarca
            // 
            this.timerBarca.Interval = 50;
            this.timerBarca.Tick += new System.EventHandler(this.timerBarca_Tick);
            // 
            // timerAnimatie
            // 
            this.timerAnimatie.Tick += new System.EventHandler(this.timerAnimatie_Tick);
            // 
            // lblDirectie
            // 
            this.lblDirectie.AutoSize = true;
            this.lblDirectie.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectie.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectie.Location = new System.Drawing.Point(529, 3);
            this.lblDirectie.Name = "lblDirectie";
            this.lblDirectie.Size = new System.Drawing.Size(88, 30);
            this.lblDirectie.TabIndex = 24;
            this.lblDirectie.Text = "Directie";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProblemaTraversariiRaului.Properties.Resources.Maluri;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.lblDirectie);
            this.Controls.Add(this.listBarca2);
            this.Controls.Add(this.listDirectie);
            this.Controls.Add(this.picParinteS);
            this.Controls.Add(this.picCopil2S);
            this.Controls.Add(this.picCopil1S);
            this.Controls.Add(this.btnStartAnimatie);
            this.Controls.Add(this.lblBarca);
            this.Controls.Add(this.lblMalDrept);
            this.Controls.Add(this.lblMalStang);
            this.Controls.Add(this.listBarca1);
            this.Controls.Add(this.listCopil2D);
            this.Controls.Add(this.listCopil1D);
            this.Controls.Add(this.listParinteD);
            this.Controls.Add(this.listParinteS);
            this.Controls.Add(this.listCopil1S);
            this.Controls.Add(this.listCopil2S);
            this.Controls.Add(this.btnGBFS);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.picBarca);
            this.Controls.Add(this.picParinteD);
            this.Controls.Add(this.picCopil2D);
            this.Controls.Add(this.picCopil1D);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "IA - Lab 2.8 - Problema traversarii raului";
            ((System.ComponentModel.ISupportInitialize)(this.picCopil1D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParinteD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopil2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParinteS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopil2S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCopil1S)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCopil1D;
        private System.Windows.Forms.PictureBox picParinteD;
        private System.Windows.Forms.PictureBox picCopil2D;
        private System.Windows.Forms.PictureBox picBarca;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnGBFS;
        private System.Windows.Forms.ListBox listCopil2S;
        private System.Windows.Forms.ListBox listCopil1S;
        private System.Windows.Forms.ListBox listParinteS;
        private System.Windows.Forms.ListBox listCopil2D;
        private System.Windows.Forms.ListBox listCopil1D;
        private System.Windows.Forms.ListBox listParinteD;
        private System.Windows.Forms.ListBox listBarca1;
        private System.Windows.Forms.Label lblMalStang;
        private System.Windows.Forms.Label lblMalDrept;
        private System.Windows.Forms.Label lblBarca;
        private System.Windows.Forms.Button btnStartAnimatie;
        private System.Windows.Forms.PictureBox picParinteS;
        private System.Windows.Forms.PictureBox picCopil2S;
        private System.Windows.Forms.PictureBox picCopil1S;
        private System.Windows.Forms.ListBox listDirectie;
        private System.Windows.Forms.ListBox listBarca2;
        private System.Windows.Forms.Timer timerBarca;
        private System.Windows.Forms.Timer timerAnimatie;
        private System.Windows.Forms.Label lblDirectie;
    }
}

