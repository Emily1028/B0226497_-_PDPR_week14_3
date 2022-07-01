
namespace B0226497_段昱如_PDPR_week14_3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnRENT = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "B0226497_段昱如_PDPR_week14_3";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Items.AddRange(new object[] {
            "噩兆",
            "緣來大飯店",
            "無間對決",
            "355：諜影特攻",
            "極速快遞",
            "電影版：昨日的美食",
            "劇場版：DEEMO",
            "死間行動",
            "五眼聯盟",
            "緊急迫降",
            "驅魔學院",
            "犯罪都市2",
            "真的好想贏一場"});
            this.listBox1.Location = new System.Drawing.Point(58, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 303);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 23;
            this.listBox2.Location = new System.Drawing.Point(498, 170);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(226, 303);
            this.listBox2.TabIndex = 2;
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(332, 263);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(118, 39);
            this.btnCANCEL.TabIndex = 3;
            this.btnCANCEL.Text = "取消";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnRENT
            // 
            this.btnRENT.Location = new System.Drawing.Point(332, 170);
            this.btnRENT.Name = "btnRENT";
            this.btnRENT.Size = new System.Drawing.Size(118, 39);
            this.btnRENT.TabIndex = 4;
            this.btnRENT.Text = "租DVD";
            this.btnRENT.UseVisualStyleBackColor = true;
            this.btnRENT.Click += new System.EventHandler(this.btnRENT_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(332, 422);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(118, 39);
            this.btnEXIT.TabIndex = 5;
            this.btnEXIT.Text = "結束";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "DVD清單";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "出租清單";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnRENT);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "B0226497_段昱如_PDPR_week14_3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnRENT;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

