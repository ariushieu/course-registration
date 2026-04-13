namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    partial class QLPhongHoc
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dgvPhongHoc = new System.Windows.Forms.DataGridView();
            this.gbInfo.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.txtSucChua);
            this.gbInfo.Controls.Add(this.lblSucChua);
            this.gbInfo.Controls.Add(this.txtLoaiPhong);
            this.gbInfo.Controls.Add(this.lblLoaiPhong);
            this.gbInfo.Controls.Add(this.txtTenPhong);
            this.gbInfo.Controls.Add(this.lblTenPhong);
            this.gbInfo.Controls.Add(this.txtMaPhong);
            this.gbInfo.Controls.Add(this.lblMaPhong);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(876, 90);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin Phòng học";
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(590, 55);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(250, 22);
            this.txtSucChua.TabIndex = 7;
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Location = new System.Drawing.Point(500, 58);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(66, 16);
            this.lblSucChua.TabIndex = 6;
            this.lblSucChua.Text = "Sức chứa:";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(120, 55);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(250, 22);
            this.txtLoaiPhong.TabIndex = 5;
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Location = new System.Drawing.Point(20, 58);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(77, 16);
            this.lblLoaiPhong.TabIndex = 4;
            this.lblLoaiPhong.Text = "Loại phòng:";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(590, 25);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(250, 22);
            this.txtTenPhong.TabIndex = 3;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(500, 28);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(75, 16);
            this.lblTenPhong.TabIndex = 2;
            this.lblTenPhong.Text = "Tên phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(120, 25);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(250, 22);
            this.txtMaPhong.TabIndex = 1;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(20, 28);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(70, 16);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // gbAction
            // 
            this.gbAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAction.Controls.Add(this.btnDelete);
            this.gbAction.Controls.Add(this.btnEdit);
            this.gbAction.Controls.Add(this.btnAdd);
            this.gbAction.Location = new System.Drawing.Point(12, 108);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(876, 60);
            this.gbAction.TabIndex = 1;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Chức năng";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(135, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // gbData
            // 
            this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbData.Controls.Add(this.dgvPhongHoc);
            this.gbData.Location = new System.Drawing.Point(12, 174);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(876, 334);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            this.gbData.Text = "Danh sách Phòng học";
            // 
            // dgvPhongHoc
            // 
            this.dgvPhongHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongHoc.Location = new System.Drawing.Point(3, 18);
            this.dgvPhongHoc.Name = "dgvPhongHoc";
            this.dgvPhongHoc.RowHeadersWidth = 51;
            this.dgvPhongHoc.RowTemplate.Height = 24;
            this.dgvPhongHoc.Size = new System.Drawing.Size(870, 313);
            this.dgvPhongHoc.TabIndex = 0;
            // 
            // QLPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.gbInfo);
            this.Name = "QLPhongHoc";
            this.Text = "Quản lý Phòng học";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbAction.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongHoc)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvPhongHoc;
    }
}