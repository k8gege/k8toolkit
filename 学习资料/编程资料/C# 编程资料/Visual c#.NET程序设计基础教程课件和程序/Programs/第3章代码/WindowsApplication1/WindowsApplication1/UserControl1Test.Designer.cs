namespace WindowsApplication1
{
    partial class UserControl1Test
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1Test));
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnChaXun = new System.Windows.Forms.Button();
            this.btnZhuanZhang = new System.Windows.Forms.Button();
            this.btnPayOut = new System.Windows.Forms.Button();
            this.btnPayIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(183, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 108;
            this.label1.Text = "请选择您需要的操作。";
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnQuit.Location = new System.Drawing.Point(550, 380);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(139, 36);
            this.btnQuit.TabIndex = 107;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnChaXun
            // 
            this.btnChaXun.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnChaXun.Location = new System.Drawing.Point(550, 260);
            this.btnChaXun.Name = "btnChaXun";
            this.btnChaXun.Size = new System.Drawing.Size(139, 36);
            this.btnChaXun.TabIndex = 106;
            this.btnChaXun.Text = "查询";
            this.btnChaXun.UseVisualStyleBackColor = true;
            // 
            // btnZhuanZhang
            // 
            this.btnZhuanZhang.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnZhuanZhang.Location = new System.Drawing.Point(1, 380);
            this.btnZhuanZhang.Name = "btnZhuanZhang";
            this.btnZhuanZhang.Size = new System.Drawing.Size(139, 36);
            this.btnZhuanZhang.TabIndex = 105;
            this.btnZhuanZhang.Text = "转账";
            this.btnZhuanZhang.UseVisualStyleBackColor = true;
            // 
            // btnPayOut
            // 
            this.btnPayOut.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnPayOut.Location = new System.Drawing.Point(1, 260);
            this.btnPayOut.Name = "btnPayOut";
            this.btnPayOut.Size = new System.Drawing.Size(139, 36);
            this.btnPayOut.TabIndex = 104;
            this.btnPayOut.Text = "取款";
            this.btnPayOut.UseVisualStyleBackColor = true;
            // 
            // btnPayIn
            // 
            this.btnPayIn.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnPayIn.Location = new System.Drawing.Point(1, 154);
            this.btnPayIn.Name = "btnPayIn";
            this.btnPayIn.Size = new System.Drawing.Size(139, 36);
            this.btnPayIn.TabIndex = 103;
            this.btnPayIn.Text = "存款";
            this.btnPayIn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 479);
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl1Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnChaXun);
            this.Controls.Add(this.btnZhuanZhang);
            this.Controls.Add(this.btnPayOut);
            this.Controls.Add(this.btnPayIn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1Test";
            this.Size = new System.Drawing.Size(689, 479);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnChaXun;
        private System.Windows.Forms.Button btnZhuanZhang;
        private System.Windows.Forms.Button btnPayOut;
        private System.Windows.Forms.Button btnPayIn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
