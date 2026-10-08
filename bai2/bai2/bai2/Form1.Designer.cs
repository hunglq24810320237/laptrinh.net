namespace bai2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Label lblTicketId;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.Label lblRequester;
        private System.Windows.Forms.TextBox txtRequester;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox grpPriority;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.CheckBox cbDesktop;
        private System.Windows.Forms.CheckBox cbLaptop;
        private System.Windows.Forms.CheckBox cbPrinter;
        private System.Windows.Forms.CheckBox cbPhone;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.txtTicketId = new System.Windows.Forms.TextBox();
            this.lblRequester = new System.Windows.Forms.Label();
            this.txtRequester = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.grpPriority = new System.Windows.Forms.GroupBox();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblDevices = new System.Windows.Forms.Label();
            this.cbDesktop = new System.Windows.Forms.CheckBox();
            this.cbLaptop = new System.Windows.Forms.CheckBox();
            this.cbPrinter = new System.Windows.Forms.CheckBox();
            this.cbPhone = new System.Windows.Forms.CheckBox();
            this.picError = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpPriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicketId
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Location = new System.Drawing.Point(12, 15);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(62, 15);
            this.lblTicketId.TabIndex = 0;
            this.lblTicketId.Text = "Mã phiếu:";
            // 
            // txtTicketId
            // 
            this.txtTicketId.Location = new System.Drawing.Point(110, 12);
            this.txtTicketId.Name = "txtTicketId";
            this.txtTicketId.Size = new System.Drawing.Size(200, 23);
            this.txtTicketId.TabIndex = 1;
            // 
            // lblRequester
            // 
            this.lblRequester.AutoSize = true;
            this.lblRequester.Location = new System.Drawing.Point(12, 50);
            this.lblRequester.Name = "lblRequester";
            this.lblRequester.Size = new System.Drawing.Size(92, 15);
            this.lblRequester.TabIndex = 2;
            this.lblRequester.Text = "Người yêu cầu:";
            // 
            // txtRequester
            // 
            this.txtRequester.Location = new System.Drawing.Point(110, 47);
            this.txtRequester.Name = "txtRequester";
            this.txtRequester.Size = new System.Drawing.Size(200, 23);
            this.txtRequester.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 86);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 15);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Ngày ghi nhận:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(110, 82);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.TabIndex = 5;
            // 
            // grpPriority
            // 
            this.grpPriority.Controls.Add(this.rbLow);
            this.grpPriority.Controls.Add(this.rbNormal);
            this.grpPriority.Controls.Add(this.rbHigh);
            this.grpPriority.Location = new System.Drawing.Point(12, 120);
            this.grpPriority.Name = "grpPriority";
            this.grpPriority.Size = new System.Drawing.Size(298, 55);
            this.grpPriority.TabIndex = 6;
            this.grpPriority.TabStop = false;
            this.grpPriority.Text = "Mức độ ưu tiên";
            // 
            // rbLow
            // 
            this.rbLow.AutoSize = true;
            this.rbLow.Location = new System.Drawing.Point(10, 22);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(42, 19);
            this.rbLow.TabIndex = 0;
            this.rbLow.TabStop = true;
            this.rbLow.Text = "Thấp";
            this.rbLow.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(110, 22);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(78, 19);
            this.rbNormal.TabIndex = 1;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Trung bình";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Location = new System.Drawing.Point(210, 22);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(63, 19);
            this.rbHigh.TabIndex = 2;
            this.rbHigh.TabStop = true;
            this.rbHigh.Text = "Khẩn cấp";
            this.rbHigh.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 190);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(84, 15);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Loại sự cố:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Phần cứng",
            "Phần mềm",
            "Mạng",
            "Tài khoản"});
            this.cmbType.Location = new System.Drawing.Point(110, 186);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 23);
            this.cmbType.TabIndex = 8;
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.Location = new System.Drawing.Point(12, 225);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(100, 15);
            this.lblDevices.TabIndex = 9;
            this.lblDevices.Text = "Thiết bị ảnh hưởng:";
            // 
            // cbDesktop
            // 
            this.cbDesktop.AutoSize = true;
            this.cbDesktop.Location = new System.Drawing.Point(20, 250);
            this.cbDesktop.Name = "cbDesktop";
            this.cbDesktop.Size = new System.Drawing.Size(95, 19);
            this.cbDesktop.TabIndex = 10;
            this.cbDesktop.Text = "Máy tính bàn";
            this.cbDesktop.UseVisualStyleBackColor = true;
            // 
            // cbLaptop
            // 
            this.cbLaptop.AutoSize = true;
            this.cbLaptop.Location = new System.Drawing.Point(130, 250);
            this.cbLaptop.Name = "cbLaptop";
            this.cbLaptop.Size = new System.Drawing.Size(63, 19);
            this.cbLaptop.TabIndex = 11;
            this.cbLaptop.Text = "Laptop";
            this.cbLaptop.UseVisualStyleBackColor = true;
            // 
            // cbPrinter
            // 
            this.cbPrinter.AutoSize = true;
            this.cbPrinter.Location = new System.Drawing.Point(220, 250);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(63, 19);
            this.cbPrinter.TabIndex = 12;
            this.cbPrinter.Text = "Máy in";
            this.cbPrinter.UseVisualStyleBackColor = true;
            // 
            // cbPhone
            // 
            this.cbPhone.AutoSize = true;
            this.cbPhone.Location = new System.Drawing.Point(310, 250);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(78, 19);
            this.cbPhone.TabIndex = 13;
            this.cbPhone.Text = "Điện thoại";
            this.cbPhone.UseVisualStyleBackColor = true;
            // 
            // picError
            // 
            this.picError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picError.Location = new System.Drawing.Point(350, 12);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(420, 300);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picError.TabIndex = 14;
            this.picError.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(350, 325);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(120, 25);
            this.btnLoadImage.TabIndex = 15;
            this.btnLoadImage.Text = "Tải ảnh lỗi";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(650, 330);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 30);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Gửi yêu cầu";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(510, 330);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 30);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Nhập lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.picError);
            this.Controls.Add(this.cbPhone);
            this.Controls.Add(this.cbPrinter);
            this.Controls.Add(this.cbLaptop);
            this.Controls.Add(this.cbDesktop);
            this.Controls.Add(this.lblDevices);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.grpPriority);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtRequester);
            this.Controls.Add(this.lblRequester);
            this.Controls.Add(this.txtTicketId);
            this.Controls.Add(this.lblTicketId);
            this.Name = "Form1";
            this.Text = "IT Support Ticket";
            this.grpPriority.ResumeLayout(false);
            this.grpPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
