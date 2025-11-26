namespace prj_2167_2281
{
    partial class Home
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
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.txtUserTel = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxReserv = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.dataReserv = new System.Windows.Forms.DataGridView();
            this.groupBoxSite = new System.Windows.Forms.GroupBox();
            this.dataSite = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            this.groupBoxReserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataReserv)).BeginInit();
            this.groupBoxSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSite)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.dataUser);
            this.groupBoxUser.Controls.Add(this.txtUserTel);
            this.groupBoxUser.Controls.Add(this.txtUserName);
            this.groupBoxUser.Controls.Add(this.txtUserNum);
            this.groupBoxUser.Controls.Add(this.label3);
            this.groupBoxUser.Controls.Add(this.label2);
            this.groupBoxUser.Controls.Add(this.label1);
            this.groupBoxUser.Location = new System.Drawing.Point(537, 42);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(454, 258);
            this.groupBoxUser.TabIndex = 9;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "고객정보";
            // 
            // dataUser
            // 
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUser.Location = new System.Drawing.Point(6, 86);
            this.dataUser.Name = "dataUser";
            this.dataUser.RowHeadersWidth = 51;
            this.dataUser.RowTemplate.Height = 27;
            this.dataUser.Size = new System.Drawing.Size(442, 166);
            this.dataUser.TabIndex = 3;
            // 
            // txtUserTel
            // 
            this.txtUserTel.Location = new System.Drawing.Point(93, 55);
            this.txtUserTel.Name = "txtUserTel";
            this.txtUserTel.Size = new System.Drawing.Size(186, 25);
            this.txtUserTel.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(300, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(107, 25);
            this.txtUserName.TabIndex = 4;
            // 
            // txtUserNum
            // 
            this.txtUserNum.Location = new System.Drawing.Point(93, 24);
            this.txtUserNum.Name = "txtUserNum";
            this.txtUserNum.Size = new System.Drawing.Size(107, 25);
            this.txtUserNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "전화번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "고객이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "고객번호";
            // 
            // groupBoxReserv
            // 
            this.groupBoxReserv.Controls.Add(this.btnDown);
            this.groupBoxReserv.Controls.Add(this.btnUp);
            this.groupBoxReserv.Controls.Add(this.dataReserv);
            this.groupBoxReserv.Location = new System.Drawing.Point(44, 174);
            this.groupBoxReserv.Name = "groupBoxReserv";
            this.groupBoxReserv.Size = new System.Drawing.Size(478, 396);
            this.groupBoxReserv.TabIndex = 10;
            this.groupBoxReserv.TabStop = false;
            this.groupBoxReserv.Text = "예약목록";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(101, 361);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(80, 25);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "내리기";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(10, 361);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(80, 25);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "올리기";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // dataReserv
            // 
            this.dataReserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReserv.Location = new System.Drawing.Point(6, 24);
            this.dataReserv.Name = "dataReserv";
            this.dataReserv.RowHeadersWidth = 51;
            this.dataReserv.RowTemplate.Height = 27;
            this.dataReserv.Size = new System.Drawing.Size(466, 331);
            this.dataReserv.TabIndex = 0;
            // 
            // groupBoxSite
            // 
            this.groupBoxSite.Controls.Add(this.dataSite);
            this.groupBoxSite.Location = new System.Drawing.Point(537, 306);
            this.groupBoxSite.Name = "groupBoxSite";
            this.groupBoxSite.Size = new System.Drawing.Size(454, 264);
            this.groupBoxSite.TabIndex = 10;
            this.groupBoxSite.TabStop = false;
            this.groupBoxSite.Text = "예약 옵션 내역";
            // 
            // dataSite
            // 
            this.dataSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSite.Location = new System.Drawing.Point(6, 24);
            this.dataSite.Name = "dataSite";
            this.dataSite.RowHeadersWidth = 51;
            this.dataSite.RowTemplate.Height = 27;
            this.dataSite.Size = new System.Drawing.Size(442, 230);
            this.dataSite.TabIndex = 6;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.button1);
            this.groupBoxSearch.Controls.Add(this.textBox1);
            this.groupBoxSearch.Controls.Add(this.dateTimePicker1);
            this.groupBoxSearch.Controls.Add(this.radioButton4);
            this.groupBoxSearch.Controls.Add(this.radioButton3);
            this.groupBoxSearch.Controls.Add(this.radioButton2);
            this.groupBoxSearch.Controls.Add(this.radioButton1);
            this.groupBoxSearch.Location = new System.Drawing.Point(44, 42);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(379, 126);
            this.groupBoxSearch.TabIndex = 10;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "검색";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 25);
            this.textBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(180, 62);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(88, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "사이트명";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(101, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "직원명";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "고객명";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "예약일";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 604);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxSite);
            this.Controls.Add(this.groupBoxReserv);
            this.Controls.Add(this.groupBoxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Home";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            this.groupBoxReserv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataReserv)).EndInit();
            this.groupBoxSite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSite)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.GroupBox groupBoxReserv;
        private System.Windows.Forms.GroupBox groupBoxSite;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.DataGridView dataReserv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserTel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserNum;
        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.DataGridView dataSite;
    }
}

