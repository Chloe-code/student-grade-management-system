namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.畢業初審ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.學年度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.畢業初審ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.電子履歷ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.畢業初審ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(252, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 畢業初審ToolStripMenuItem
            // 
            this.畢業初審ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.學年度ToolStripMenuItem,
            this.畢業初審ToolStripMenuItem1,
            this.電子履歷ToolStripMenuItem});
            this.畢業初審ToolStripMenuItem.Name = "畢業初審ToolStripMenuItem";
            this.畢業初審ToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.畢業初審ToolStripMenuItem.Text = "File";
            // 
            // 學年度ToolStripMenuItem
            // 
            this.學年度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.上ToolStripMenuItem,
            this.下ToolStripMenuItem});
            this.學年度ToolStripMenuItem.Name = "學年度ToolStripMenuItem";
            this.學年度ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.學年度ToolStripMenuItem.Text = "學年度";
            // 
            // 上ToolStripMenuItem
            // 
            this.上ToolStripMenuItem.Name = "上ToolStripMenuItem";
            this.上ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.上ToolStripMenuItem.Text = "108上";
            this.上ToolStripMenuItem.Click += new System.EventHandler(this.上ToolStripMenuItem_Click);
            // 
            // 下ToolStripMenuItem
            // 
            this.下ToolStripMenuItem.Name = "下ToolStripMenuItem";
            this.下ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.下ToolStripMenuItem.Text = "107下";
            this.下ToolStripMenuItem.Click += new System.EventHandler(this.下ToolStripMenuItem_Click);
            // 
            // 畢業初審ToolStripMenuItem1
            // 
            this.畢業初審ToolStripMenuItem1.Name = "畢業初審ToolStripMenuItem1";
            this.畢業初審ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.畢業初審ToolStripMenuItem1.Text = "畢業初審";
            this.畢業初審ToolStripMenuItem1.Click += new System.EventHandler(this.畢業初審ToolStripMenuItem1_Click);
            // 
            // 電子履歷ToolStripMenuItem
            // 
            this.電子履歷ToolStripMenuItem.Name = "電子履歷ToolStripMenuItem";
            this.電子履歷ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.電子履歷ToolStripMenuItem.Text = "電子履歷";
            this.電子履歷ToolStripMenuItem.Click += new System.EventHandler(this.電子履歷ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "我的課程";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Location = new System.Drawing.Point(0, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(195, 223);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(20, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(20, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(20, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(20, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 296);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 畢業初審ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 學年度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 畢業初審ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 電子履歷ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 下ToolStripMenuItem;

    }
}