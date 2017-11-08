namespace RiverCrossingProblem
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
            this.picChild1R = new System.Windows.Forms.PictureBox();
            this.picMomR = new System.Windows.Forms.PictureBox();
            this.picChild2R = new System.Windows.Forms.PictureBox();
            this.picBoat = new System.Windows.Forms.PictureBox();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnGBFS = new System.Windows.Forms.Button();
            this.listChild2L = new System.Windows.Forms.ListBox();
            this.listChild1L = new System.Windows.Forms.ListBox();
            this.listMomL = new System.Windows.Forms.ListBox();
            this.listChild2R = new System.Windows.Forms.ListBox();
            this.listChild1R = new System.Windows.Forms.ListBox();
            this.listMomR = new System.Windows.Forms.ListBox();
            this.listBoat1 = new System.Windows.Forms.ListBox();
            this.lblMalStang = new System.Windows.Forms.Label();
            this.lblMalDrept = new System.Windows.Forms.Label();
            this.lblBarca = new System.Windows.Forms.Label();
            this.btnStartAnimation = new System.Windows.Forms.Button();
            this.picMomL = new System.Windows.Forms.PictureBox();
            this.picChild2L = new System.Windows.Forms.PictureBox();
            this.picChild1L = new System.Windows.Forms.PictureBox();
            this.listDirection = new System.Windows.Forms.ListBox();
            this.listBoat2 = new System.Windows.Forms.ListBox();
            this.boatTimer = new System.Windows.Forms.Timer(this.components);
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.lblDirectie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picChild1R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMomR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChild2R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMomL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChild2L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChild1L)).BeginInit();
            this.SuspendLayout();
            // 
            // picChild1R
            // 
            this.picChild1R.BackColor = System.Drawing.Color.Transparent;
            this.picChild1R.BackgroundImage = global::RiverCrossingProblem.Properties.Resources.Child;
            this.picChild1R.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picChild1R.Location = new System.Drawing.Point(847, 300);
            this.picChild1R.Name = "picChild1R";
            this.picChild1R.Size = new System.Drawing.Size(47, 84);
            this.picChild1R.TabIndex = 0;
            this.picChild1R.TabStop = false;
            // 
            // picMomR
            // 
            this.picMomR.BackColor = System.Drawing.Color.Transparent;
            this.picMomR.BackgroundImage = global::RiverCrossingProblem.Properties.Resources.Mom;
            this.picMomR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMomR.Location = new System.Drawing.Point(775, 244);
            this.picMomR.Name = "picMomR";
            this.picMomR.Size = new System.Drawing.Size(66, 140);
            this.picMomR.TabIndex = 1;
            this.picMomR.TabStop = false;
            // 
            // picChild2R
            // 
            this.picChild2R.BackColor = System.Drawing.Color.Transparent;
            this.picChild2R.BackgroundImage = global::RiverCrossingProblem.Properties.Resources.Child;
            this.picChild2R.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picChild2R.Location = new System.Drawing.Point(901, 300);
            this.picChild2R.Name = "picChild2R";
            this.picChild2R.Size = new System.Drawing.Size(47, 84);
            this.picChild2R.TabIndex = 2;
            this.picChild2R.TabStop = false;
            // 
            // picBoat
            // 
            this.picBoat.BackColor = System.Drawing.Color.Transparent;
            this.picBoat.BackgroundImage = global::RiverCrossingProblem.Properties.Resources.Empty_Boat;
            this.picBoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoat.Location = new System.Drawing.Point(585, 300);
            this.picBoat.Name = "picBoat";
            this.picBoat.Size = new System.Drawing.Size(184, 150);
            this.picBoat.TabIndex = 3;
            this.picBoat.TabStop = false;
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
            // listChild2L
            // 
            this.listChild2L.BackColor = System.Drawing.Color.Azure;
            this.listChild2L.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listChild2L.FormattingEnabled = true;
            this.listChild2L.ItemHeight = 17;
            this.listChild2L.Location = new System.Drawing.Point(16, 36);
            this.listChild2L.Name = "listChild2L";
            this.listChild2L.Size = new System.Drawing.Size(101, 140);
            this.listChild2L.TabIndex = 8;
            this.listChild2L.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listChild1L
            // 
            this.listChild1L.BackColor = System.Drawing.Color.Lavender;
            this.listChild1L.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listChild1L.FormattingEnabled = true;
            this.listChild1L.ItemHeight = 17;
            this.listChild1L.Location = new System.Drawing.Point(123, 36);
            this.listChild1L.Name = "listChild1L";
            this.listChild1L.Size = new System.Drawing.Size(101, 140);
            this.listChild1L.TabIndex = 9;
            this.listChild1L.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listMomL
            // 
            this.listMomL.BackColor = System.Drawing.Color.Azure;
            this.listMomL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMomL.FormattingEnabled = true;
            this.listMomL.ItemHeight = 17;
            this.listMomL.Location = new System.Drawing.Point(230, 36);
            this.listMomL.Name = "listMomL";
            this.listMomL.Size = new System.Drawing.Size(101, 140);
            this.listMomL.TabIndex = 10;
            this.listMomL.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listChild2R
            // 
            this.listChild2R.BackColor = System.Drawing.Color.Azure;
            this.listChild2R.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listChild2R.FormattingEnabled = true;
            this.listChild2R.ItemHeight = 17;
            this.listChild2R.Location = new System.Drawing.Point(846, 36);
            this.listChild2R.Name = "listChild2R";
            this.listChild2R.Size = new System.Drawing.Size(101, 140);
            this.listChild2R.TabIndex = 13;
            this.listChild2R.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listChild1R
            // 
            this.listChild1R.BackColor = System.Drawing.Color.Lavender;
            this.listChild1R.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listChild1R.FormattingEnabled = true;
            this.listChild1R.ItemHeight = 17;
            this.listChild1R.Location = new System.Drawing.Point(739, 36);
            this.listChild1R.Name = "listChild1R";
            this.listChild1R.Size = new System.Drawing.Size(101, 140);
            this.listChild1R.TabIndex = 12;
            this.listChild1R.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listMomR
            // 
            this.listMomR.BackColor = System.Drawing.Color.Azure;
            this.listMomR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMomR.FormattingEnabled = true;
            this.listMomR.ItemHeight = 17;
            this.listMomR.Location = new System.Drawing.Point(632, 36);
            this.listMomR.Name = "listMomR";
            this.listMomR.Size = new System.Drawing.Size(101, 140);
            this.listMomR.TabIndex = 11;
            this.listMomR.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listBoat1
            // 
            this.listBoat1.BackColor = System.Drawing.Color.Lavender;
            this.listBoat1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoat1.FormattingEnabled = true;
            this.listBoat1.ItemHeight = 17;
            this.listBoat1.Location = new System.Drawing.Point(365, 36);
            this.listBoat1.Name = "listBoat1";
            this.listBoat1.Size = new System.Drawing.Size(88, 140);
            this.listBoat1.TabIndex = 14;
            this.listBoat1.Click += new System.EventHandler(this.listBox_Click);
            // 
            // lblMalStang
            // 
            this.lblMalStang.AutoSize = true;
            this.lblMalStang.BackColor = System.Drawing.Color.Transparent;
            this.lblMalStang.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalStang.Location = new System.Drawing.Point(124, 3);
            this.lblMalStang.Name = "lblMalStang";
            this.lblMalStang.Size = new System.Drawing.Size(99, 30);
            this.lblMalStang.TabIndex = 15;
            this.lblMalStang.Text = "Left Side";
            // 
            // lblMalDrept
            // 
            this.lblMalDrept.AutoSize = true;
            this.lblMalDrept.BackColor = System.Drawing.Color.Transparent;
            this.lblMalDrept.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalDrept.Location = new System.Drawing.Point(732, 3);
            this.lblMalDrept.Name = "lblMalDrept";
            this.lblMalDrept.Size = new System.Drawing.Size(115, 30);
            this.lblMalDrept.TabIndex = 16;
            this.lblMalDrept.Text = "Right Side";
            // 
            // lblBarca
            // 
            this.lblBarca.AutoSize = true;
            this.lblBarca.BackColor = System.Drawing.Color.Transparent;
            this.lblBarca.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarca.Location = new System.Drawing.Point(425, 3);
            this.lblBarca.Name = "lblBarca";
            this.lblBarca.Size = new System.Drawing.Size(58, 30);
            this.lblBarca.TabIndex = 17;
            this.lblBarca.Text = "Boat";
            // 
            // btnStartAnimation
            // 
            this.btnStartAnimation.BackColor = System.Drawing.Color.Transparent;
            this.btnStartAnimation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartAnimation.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAnimation.Location = new System.Drawing.Point(632, 183);
            this.btnStartAnimation.Name = "btnStartAnimation";
            this.btnStartAnimation.Size = new System.Drawing.Size(315, 48);
            this.btnStartAnimation.TabIndex = 18;
            this.btnStartAnimation.Text = "Start Animation";
            this.btnStartAnimation.UseVisualStyleBackColor = false;
            this.btnStartAnimation.Click += new System.EventHandler(this.btnStartAnimation_Click);
            // 
            // picMomL
            // 
            this.picMomL.BackColor = System.Drawing.Color.Transparent;
            this.picMomL.BackgroundImage = global::RiverCrossingProblem.Properties.Resources.Mom;
            this.picMomL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMomL.Location = new System.Drawing.Point(118, 244);
            this.picMomL.Name = "picMomL";
            this.picMomL.Size = new System.Drawing.Size(66, 140);
            this.picMomL.TabIndex = 20;
            this.picMomL.TabStop = false;
            this.picMomL.Visible = false;
            // 
            // picChild2L
            // 
            this.picChild2L.BackColor = System.Drawing.Color.Transparent;
            this.picChild2L.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picChild2L.BackgroundImage")));
            this.picChild2L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picChild2L.Location = new System.Drawing.Point(12, 300);
            this.picChild2L.Name = "picChild2L";
            this.picChild2L.Size = new System.Drawing.Size(47, 84);
            this.picChild2L.TabIndex = 21;
            this.picChild2L.TabStop = false;
            this.picChild2L.Visible = false;
            // 
            // picChild1L
            // 
            this.picChild1L.BackColor = System.Drawing.Color.Transparent;
            this.picChild1L.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picChild1L.BackgroundImage")));
            this.picChild1L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picChild1L.Location = new System.Drawing.Point(65, 300);
            this.picChild1L.Name = "picChild1L";
            this.picChild1L.Size = new System.Drawing.Size(47, 84);
            this.picChild1L.TabIndex = 19;
            this.picChild1L.TabStop = false;
            this.picChild1L.Visible = false;
            // 
            // listDirection
            // 
            this.listDirection.BackColor = System.Drawing.Color.Lavender;
            this.listDirection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDirection.FormattingEnabled = true;
            this.listDirection.ItemHeight = 17;
            this.listDirection.Location = new System.Drawing.Point(552, 36);
            this.listDirection.Name = "listDirection";
            this.listDirection.Size = new System.Drawing.Size(43, 140);
            this.listDirection.TabIndex = 22;
            this.listDirection.Click += new System.EventHandler(this.listBox_Click);
            // 
            // listBoat2
            // 
            this.listBoat2.BackColor = System.Drawing.Color.Azure;
            this.listBoat2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoat2.FormattingEnabled = true;
            this.listBoat2.ItemHeight = 17;
            this.listBoat2.Location = new System.Drawing.Point(458, 36);
            this.listBoat2.Name = "listBoat2";
            this.listBoat2.Size = new System.Drawing.Size(88, 140);
            this.listBoat2.TabIndex = 23;
            this.listBoat2.Click += new System.EventHandler(this.listBox_Click);
            // 
            // boatTimer
            // 
            this.boatTimer.Interval = 50;
            this.boatTimer.Tick += new System.EventHandler(this.timerBoat_Tick);
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.timerAnimatie_Tick);
            // 
            // lblDirectie
            // 
            this.lblDirectie.AutoSize = true;
            this.lblDirectie.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectie.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectie.Location = new System.Drawing.Point(529, 3);
            this.lblDirectie.Name = "lblDirectie";
            this.lblDirectie.Size = new System.Drawing.Size(103, 30);
            this.lblDirectie.TabIndex = 24;
            this.lblDirectie.Text = "Direction";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RiverCrossingProblem.Properties.Resources.Sides;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.lblDirectie);
            this.Controls.Add(this.listBoat2);
            this.Controls.Add(this.listDirection);
            this.Controls.Add(this.picMomL);
            this.Controls.Add(this.picChild2L);
            this.Controls.Add(this.picChild1L);
            this.Controls.Add(this.btnStartAnimation);
            this.Controls.Add(this.lblBarca);
            this.Controls.Add(this.lblMalDrept);
            this.Controls.Add(this.lblMalStang);
            this.Controls.Add(this.listBoat1);
            this.Controls.Add(this.listChild2R);
            this.Controls.Add(this.listChild1R);
            this.Controls.Add(this.listMomR);
            this.Controls.Add(this.listMomL);
            this.Controls.Add(this.listChild1L);
            this.Controls.Add(this.listChild2L);
            this.Controls.Add(this.btnGBFS);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.picBoat);
            this.Controls.Add(this.picMomR);
            this.Controls.Add(this.picChild2R);
            this.Controls.Add(this.picChild1R);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "AI - Lab 2.8 - River Crossing Problem";
            ((System.ComponentModel.ISupportInitialize)(this.picChild1R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMomR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChild2R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMomL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChild2L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChild1L)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picChild1R;
        private System.Windows.Forms.PictureBox picMomR;
        private System.Windows.Forms.PictureBox picChild2R;
        private System.Windows.Forms.PictureBox picBoat;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnGBFS;
        private System.Windows.Forms.ListBox listChild2L;
        private System.Windows.Forms.ListBox listChild1L;
        private System.Windows.Forms.ListBox listMomL;
        private System.Windows.Forms.ListBox listChild2R;
        private System.Windows.Forms.ListBox listChild1R;
        private System.Windows.Forms.ListBox listMomR;
        private System.Windows.Forms.ListBox listBoat1;
        private System.Windows.Forms.Label lblMalStang;
        private System.Windows.Forms.Label lblMalDrept;
        private System.Windows.Forms.Label lblBarca;
        private System.Windows.Forms.Button btnStartAnimation;
        private System.Windows.Forms.PictureBox picMomL;
        private System.Windows.Forms.PictureBox picChild2L;
        private System.Windows.Forms.PictureBox picChild1L;
        private System.Windows.Forms.ListBox listDirection;
        private System.Windows.Forms.ListBox listBoat2;
        private System.Windows.Forms.Timer boatTimer;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Label lblDirectie;
    }
}

