namespace Practica
{
    partial class ListofCharities
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListofCharities));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(128, 15);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(360, 35);
            label1.TabIndex = 1;
            label1.Text = "MARATHON SKILLS 2016";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 59);
            this.panel1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.Location = new System.Drawing.Point(10, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(116, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Список благотворительных организаций";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(777, 72);
            this.label3.TabIndex = 12;
            this.label3.Text = "Это - список всех благотворительных учреждений, которые поддерживаются в\r\nMaratho" +
    "n Skills 2016. Спасибо за помощь, вы поддерживаете их, спонсируя \r\nбегунов!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(10, 173);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(778, 234);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 73;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 623;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arise-logo.png");
            this.imageList1.Images.SetKeyName(1, "aves-do-brazil-logo.png");
            this.imageList1.Images.SetKeyName(2, "clara-santos-oliveira-institute-logo.png");
            this.imageList1.Images.SetKeyName(3, "conquer-cancer-brazil.png");
            this.imageList1.Images.SetKeyName(4, "diabetes-brazil-logo.png");
            this.imageList1.Images.SetKeyName(5, "heart-health-sao-paulo-logo.png");
            this.imageList1.Images.SetKeyName(6, "human-rights-centre-logo.png");
            this.imageList1.Images.SetKeyName(7, "oxfam-international-logo.png");
            this.imageList1.Images.SetKeyName(8, "querstadtein-logo.png");
            this.imageList1.Images.SetKeyName(9, "save-the-children-fund-logo.png");
            this.imageList1.Images.SetKeyName(10, "stay-pumped-logo.png");
            this.imageList1.Images.SetKeyName(11, "the-red-cross-logo.png");
            this.imageList1.Images.SetKeyName(12, "upbeat-logo.png");
            this.imageList1.Images.SetKeyName(13, "wwsm-rescue-logo.png");
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.Location = new System.Drawing.Point(-1, 410);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(805, 37);
            this.lblTime.TabIndex = 77;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ListofCharities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "ListofCharities";
            this.Text = "Form13";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}