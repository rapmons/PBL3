
namespace PBL3_DATVEXE.View
{
    partial class datVe
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
            this.lbTen = new System.Windows.Forms.Label();
            this.lbSoDT = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.But_xacnhan = new System.Windows.Forms.Button();
            this.But_xemthongtin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(118, 51);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(57, 20);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Họ tên";
            // 
            // lbSoDT
            // 
            this.lbSoDT.AutoSize = true;
            this.lbSoDT.Location = new System.Drawing.Point(118, 135);
            this.lbSoDT.Name = "lbSoDT";
            this.lbSoDT.Size = new System.Drawing.Size(102, 20);
            this.lbSoDT.TabIndex = 1;
            this.lbSoDT.Text = "Số diện thoại";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(118, 226);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(88, 20);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Thư điện tử";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(118, 311);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(64, 20);
            this.lbNote.TabIndex = 3;
            this.lbNote.Text = "Ghi chú";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(325, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(122, 170);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(325, 26);
            this.txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(325, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(122, 343);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(325, 26);
            this.txtNote.TabIndex = 7;
            // 
            // But_xacnhan
            // 
            this.But_xacnhan.Location = new System.Drawing.Point(310, 417);
            this.But_xacnhan.Name = "But_xacnhan";
            this.But_xacnhan.Size = new System.Drawing.Size(137, 34);
            this.But_xacnhan.TabIndex = 8;
            this.But_xacnhan.Text = "Xác nhận";
            this.But_xacnhan.UseVisualStyleBackColor = true;
            this.But_xacnhan.Click += new System.EventHandler(this.But_xacnhan_Click);
            // 
            // But_xemthongtin
            // 
            this.But_xemthongtin.Location = new System.Drawing.Point(122, 417);
            this.But_xemthongtin.Name = "But_xemthongtin";
            this.But_xemthongtin.Size = new System.Drawing.Size(148, 34);
            this.But_xemthongtin.TabIndex = 9;
            this.But_xemthongtin.Text = "Xem thông tin vé";
            this.But_xemthongtin.UseVisualStyleBackColor = true;
            // 
            // datVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 494);
            this.Controls.Add(this.But_xemthongtin);
            this.Controls.Add(this.But_xacnhan);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbSoDT);
            this.Controls.Add(this.lbTen);
            this.Name = "datVe";
            this.Text = "datVe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbSoDT;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button But_xacnhan;
        private System.Windows.Forms.Button But_xemthongtin;
    }
}