namespace CourseRegistration.UI.Forms.Admin
{
    partial class QLLopHocPhan
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
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.txtGiangVien = new System.Windows.Forms.TextBox();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.txtMaLHP = new System.Windows.Forms.TextBox();
            this.lblMaLHP = new System.Windows.Forms.Label();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dgvLopHocPhan = new System.Windows.Forms.DataGridView();
            this.gbInfo.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.txtSiSo);
            this.gbInfo.Controls.Add(this.lblSiSo);
            this.gbInfo.Controls.Add(this.txtGiangVien);
            this.gbInfo.Controls.Add(this.lblGiangVien);
            this.gbInfo.Controls.Add(this.txtMonHoc);
            this.gbInfo.Controls.Add(this.lblMonHoc);
            this.gbInfo.Controls.Add(this.txtMaLHP);
            this.gbInfo.Controls.Add(this.lblMaLHP);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(876, 90);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin Lớp học phần";
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(590, 55);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(250, 22);
            this.txtSiSo.TabIndex = 7;
            // 
            // lblSiSo
            // 
            this.lblSiSo.AutoSize = true;
            this.lblSiSo.Location = new System.Drawing.Point(500, 58);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(39, 16);
            this.lblSiSo.TabIndex = 6;
            this.lblSiSo.Text = "Sĩ số:";
            // 
            // txtGiangVien
            // 
            this.txtGiangVien.Location = new System.Drawing.Point(120, 55);
            this.txtGiangVien.Name = "txtGiangVien";
            this.txtGiangVien.Size = new System.Drawing.Size(250, 22);
            this.txtGiangVien.TabIndex = 5;
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Location = new System.Drawing.Point(20, 58);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(74, 16);
            this.lblGiangVien.TabIndex = 4;
            this.lblGiangVien.Text = "Giảng viên:";
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Location = new System.Drawing.Point(590, 25);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(250, 22);
            this.txtMonHoc.TabIndex = 3;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(500, 28);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(61, 16);
            this.lblMonHoc.TabIndex = 2;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // txtMaLHP
            // 
            this.txtMaLHP.Location = new System.Drawing.Point(120, 25);
            this.txtMaLHP.Name = "txtMaLHP";
            this.txtMaLHP.Size = new System.Drawing.Size(250, 22);
            this.txtMaLHP.TabIndex = 1;
            // 
            // lblMaLHP
            // 
            this.lblMaLHP.AutoSize = true;
            this.lblMaLHP.Location = new System.Drawing.Point(20, 28);
            this.lblMaLHP.Name = "lblMaLHP";
            this.lblMaLHP.Size = new System.Drawing.Size(60, 16);
            this.lblMaLHP.TabIndex = 0;
            this.lblMaLHP.Text = "Mã LHP:";
            // 
            // gbAction
            // 
            this.gbAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAction.Controls.Add(this.btnSave);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(385, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
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
            this.gbData.Controls.Add(this.dgvLopHocPhan);
            this.gbData.Location = new System.Drawing.Point(12, 174);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(876, 334);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            this.gbData.Text = "Danh sách Lớp học phần";
            // 
            // dgvLopHocPhan
            // 
            this.dgvLopHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLopHocPhan.Location = new System.Drawing.Point(3, 18);
            this.dgvLopHocPhan.Name = "dgvLopHocPhan";
            this.dgvLopHocPhan.RowHeadersWidth = 51;
            this.dgvLopHocPhan.RowTemplate.Height = 24;
            this.dgvLopHocPhan.Size = new System.Drawing.Size(870, 313);
            this.dgvLopHocPhan.TabIndex = 0;
            // 
            // QLLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.gbInfo);
            this.Name = "QLLopHocPhan";
            this.Text = "Quản lý Lớp học phần";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbAction.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Label lblSiSo;
        private System.Windows.Forms.TextBox txtGiangVien;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.TextBox txtMaLHP;
        private System.Windows.Forms.Label lblMaLHP;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvLopHocPhan;
    }
}