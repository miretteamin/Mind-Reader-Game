namespace Mind_Reader
{
    partial class TheGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheGame));
            this.label1 = new System.Windows.Forms.Label();
            this.Yesbtn = new System.Windows.Forms.Button();
            this.Nobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 329);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Yesbtn
            // 
            this.Yesbtn.BackColor = System.Drawing.Color.Azure;
            this.Yesbtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Yesbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Yesbtn.Location = new System.Drawing.Point(79, 341);
            this.Yesbtn.Name = "Yesbtn";
            this.Yesbtn.Size = new System.Drawing.Size(77, 34);
            this.Yesbtn.TabIndex = 1;
            this.Yesbtn.Text = "Yes";
            this.Yesbtn.UseVisualStyleBackColor = false;
            this.Yesbtn.Click += new System.EventHandler(this.Yesbtn_Click);
            // 
            // Nobtn
            // 
            this.Nobtn.BackColor = System.Drawing.Color.Azure;
            this.Nobtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Nobtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Nobtn.Location = new System.Drawing.Point(297, 341);
            this.Nobtn.Name = "Nobtn";
            this.Nobtn.Size = new System.Drawing.Size(77, 34);
            this.Nobtn.TabIndex = 2;
            this.Nobtn.Text = "No";
            this.Nobtn.UseVisualStyleBackColor = false;
            this.Nobtn.Click += new System.EventHandler(this.Nobtn_Click);
            // 
            // TheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(449, 382);
            this.Controls.Add(this.Nobtn);
            this.Controls.Add(this.Yesbtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mind Reader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TheGame_FormClosed);
            this.Load += new System.EventHandler(this.TheGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Yesbtn;
        private System.Windows.Forms.Button Nobtn;
    }
}