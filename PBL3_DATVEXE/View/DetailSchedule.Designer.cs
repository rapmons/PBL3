
namespace PBL3_DATVEXE.View
{
    partial class DetailSchedule
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.But_chon = new System.Windows.Forms.Button();
            this.But_trove = new System.Windows.Forms.Button();
            this.But_xemchitiet = new System.Windows.Forms.Button();
            this.But_sapXep = new System.Windows.Forms.Button();
            this.cbbsapXep = new System.Windows.Forms.ComboBox();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.datagridview1);
            this.gb1.Location = new System.Drawing.Point(44, 38);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(849, 323);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Các chuyến xe bạn muốn tìm kiếm";
            // 
            // datagridview1
            // 
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.datagridview1.Location = new System.Drawing.Point(32, 47);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.ReadOnly = true;
            this.datagridview1.RowHeadersWidth = 62;
            this.datagridview1.RowTemplate.Height = 28;
            this.datagridview1.Size = new System.Drawing.Size(786, 254);
            this.datagridview1.TabIndex = 0;
            // 
            // But_chon
            // 
            this.But_chon.Location = new System.Drawing.Point(196, 393);
            this.But_chon.Name = "But_chon";
            this.But_chon.Size = new System.Drawing.Size(97, 33);
            this.But_chon.TabIndex = 1;
            this.But_chon.Text = "Chọn";
            this.But_chon.UseVisualStyleBackColor = true;
            this.But_chon.Click += new System.EventHandler(this.But_chon_Click);
            // 
            // But_trove
            // 
            this.But_trove.Location = new System.Drawing.Point(76, 393);
            this.But_trove.Name = "But_trove";
            this.But_trove.Size = new System.Drawing.Size(88, 33);
            this.But_trove.TabIndex = 2;
            this.But_trove.Text = "Trở về";
            this.But_trove.UseVisualStyleBackColor = true;
            // 
            // But_xemchitiet
            // 
            this.But_xemchitiet.Location = new System.Drawing.Point(338, 393);
            this.But_xemchitiet.Name = "But_xemchitiet";
            this.But_xemchitiet.Size = new System.Drawing.Size(116, 33);
            this.But_xemchitiet.TabIndex = 3;
            this.But_xemchitiet.Text = "Xem chi tiết";
            this.But_xemchitiet.UseVisualStyleBackColor = true;
            // 
            // But_sapXep
            // 
            this.But_sapXep.Location = new System.Drawing.Point(535, 393);
            this.But_sapXep.Name = "But_sapXep";
            this.But_sapXep.Size = new System.Drawing.Size(88, 33);
            this.But_sapXep.TabIndex = 4;
            this.But_sapXep.Text = "Sắp xếp";
            this.But_sapXep.UseVisualStyleBackColor = true;
            this.But_sapXep.Click += new System.EventHandler(this.But_sapXep_Click);
            // 
            // cbbsapXep
            // 
            this.cbbsapXep.FormattingEnabled = true;
            this.cbbsapXep.Location = new System.Drawing.Point(654, 398);
            this.cbbsapXep.Name = "cbbsapXep";
            this.cbbsapXep.Size = new System.Drawing.Size(178, 28);
            this.cbbsapXep.TabIndex = 5;
            // 
            // DetailSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 451);
            this.Controls.Add(this.cbbsapXep);
            this.Controls.Add(this.But_sapXep);
            this.Controls.Add(this.But_xemchitiet);
            this.Controls.Add(this.But_trove);
            this.Controls.Add(this.But_chon);
            this.Controls.Add(this.gb1);
            this.Name = "DetailSchedule";
            this.Text = "DetailSchedule";
            this.Load += new System.EventHandler(this.DetailSchedule_Load);
            this.gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.Button But_chon;
        private System.Windows.Forms.Button But_trove;
        private System.Windows.Forms.Button But_xemchitiet;
        private System.Windows.Forms.Button But_sapXep;
        private System.Windows.Forms.ComboBox cbbsapXep;
    }
}