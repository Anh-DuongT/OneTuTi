namespace Client
{
    partial class Form1
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
            this.btnKeo = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtLuaChon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(241, 107);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(75, 23);
            this.btnKeo.TabIndex = 13;
            this.btnKeo.Text = "Keo";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(131, 107);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(75, 23);
            this.btnBua.TabIndex = 12;
            this.btnBua.Text = "Bua";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(31, 107);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(75, 23);
            this.btnBao.TabIndex = 11;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(131, 177);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(100, 20);
            this.txtKetQua.TabIndex = 10;
            // 
            // txtLuaChon
            // 
            this.txtLuaChon.Location = new System.Drawing.Point(131, 43);
            this.txtLuaChon.Name = "txtLuaChon";
            this.txtLuaChon.Size = new System.Drawing.Size(100, 20);
            this.txtLuaChon.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ket qua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lua chon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 263);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtLuaChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtLuaChon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

