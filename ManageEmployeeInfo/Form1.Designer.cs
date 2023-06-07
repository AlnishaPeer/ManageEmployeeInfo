namespace ManageEmployeeInfo
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lbl_Id = new Label();
            lbl_Name = new Label();
            panel1 = new Panel();
            btn_Export = new Button();
            txt_Stat = new TextBox();
            btn_refresh = new Button();
            txt_Gender = new TextBox();
            txt_Response = new RichTextBox();
            dataGridView1 = new DataGridView();
            btn_SearchName = new Button();
            lbl_Message = new Label();
            btn_Page = new Button();
            lbl_Page = new Label();
            txt_Page = new TextBox();
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_Add = new Button();
            btn_SearchById = new Button();
            btn_GetAll = new Button();
            txt_Email = new TextBox();
            txt_Name = new TextBox();
            txt_EmpId = new TextBox();
            lbl_Status = new Label();
            lbl_Gender = new Label();
            lbl_Email = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(592, 21);
            label1.Name = "label1";
            label1.Size = new Size(305, 28);
            label1.TabIndex = 0;
            label1.Text = "Manage Employee Information";
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Id.Location = new Point(89, 72);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(95, 20);
            lbl_Id.TabIndex = 1;
            lbl_Id.Text = "Employee Id";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Name.Location = new Point(89, 116);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(51, 20);
            lbl_Name.TabIndex = 2;
            lbl_Name.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btn_Export);
            panel1.Controls.Add(txt_Stat);
            panel1.Controls.Add(btn_refresh);
            panel1.Controls.Add(txt_Gender);
            panel1.Controls.Add(txt_Response);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btn_SearchName);
            panel1.Controls.Add(lbl_Message);
            panel1.Controls.Add(btn_Page);
            panel1.Controls.Add(lbl_Page);
            panel1.Controls.Add(txt_Page);
            panel1.Controls.Add(btn_Delete);
            panel1.Controls.Add(btn_Update);
            panel1.Controls.Add(btn_Add);
            panel1.Controls.Add(btn_SearchById);
            panel1.Controls.Add(btn_GetAll);
            panel1.Controls.Add(txt_Email);
            panel1.Controls.Add(txt_Name);
            panel1.Controls.Add(txt_EmpId);
            panel1.Controls.Add(lbl_Status);
            panel1.Controls.Add(lbl_Gender);
            panel1.Controls.Add(lbl_Email);
            panel1.Controls.Add(lbl_Name);
            panel1.Controls.Add(lbl_Id);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 831);
            panel1.TabIndex = 3;
            // 
            // btn_Export
            // 
            btn_Export.Location = new Point(365, 689);
            btn_Export.Margin = new Padding(3, 4, 3, 4);
            btn_Export.Name = "btn_Export";
            btn_Export.Size = new Size(86, 31);
            btn_Export.TabIndex = 28;
            btn_Export.Text = "Export";
            btn_Export.UseVisualStyleBackColor = true;
            btn_Export.Click += btn_Export_Click;
            // 
            // txt_Stat
            // 
            txt_Stat.Location = new Point(256, 252);
            txt_Stat.Name = "txt_Stat";
            txt_Stat.Size = new Size(233, 27);
            txt_Stat.TabIndex = 27;           
            txt_Stat.Validating += txt_Stat_Validating;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(1221, 25);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(75, 27);
            btn_refresh.TabIndex = 4;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // txt_Gender
            // 
            txt_Gender.Location = new Point(256, 209);
            txt_Gender.Name = "txt_Gender";
            txt_Gender.Size = new Size(233, 27);
            txt_Gender.TabIndex = 26;
            txt_Gender.Validating += txt_Gender_Validating;
            // 
            // txt_Response
            // 
            txt_Response.Location = new Point(899, 325);
            txt_Response.Name = "txt_Response";
            txt_Response.Size = new Size(397, 304);
            txt_Response.TabIndex = 25;
            txt_Response.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(101, 325);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(642, 357);
            dataGridView1.TabIndex = 24;
            // 
            // btn_SearchName
            // 
            btn_SearchName.Location = new Point(797, 159);
            btn_SearchName.Name = "btn_SearchName";
            btn_SearchName.Size = new Size(136, 29);
            btn_SearchName.TabIndex = 23;
            btn_SearchName.Text = "Search By Name";
            btn_SearchName.UseVisualStyleBackColor = true;
            btn_SearchName.Click += btn_SearchName_Click;
            // 
            // lbl_Message
            // 
            lbl_Message.AutoSize = true;
            lbl_Message.Location = new Point(1020, 237);
            lbl_Message.Name = "lbl_Message";
            lbl_Message.Size = new Size(0, 20);
            lbl_Message.TabIndex = 22;
            // 
            // btn_Page
            // 
            btn_Page.Location = new Point(883, 233);
            btn_Page.Name = "btn_Page";
            btn_Page.Size = new Size(94, 29);
            btn_Page.TabIndex = 19;
            btn_Page.Text = "Go To";
            btn_Page.UseVisualStyleBackColor = true;
            btn_Page.Click += btn_Page_Click;
            // 
            // lbl_Page
            // 
            lbl_Page.AutoSize = true;
            lbl_Page.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Page.Location = new Point(649, 236);
            lbl_Page.Name = "lbl_Page";
            lbl_Page.Size = new Size(105, 20);
            lbl_Page.TabIndex = 18;
            lbl_Page.Text = "Page Number";
            // 
            // txt_Page
            // 
            txt_Page.Location = new Point(773, 233);
            txt_Page.Name = "txt_Page";
            txt_Page.Size = new Size(63, 27);
            txt_Page.TabIndex = 17;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(1181, 159);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 15;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(1066, 159);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 29);
            btn_Update.TabIndex = 14;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(951, 159);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 13;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_SearchById
            // 
            btn_SearchById.Location = new Point(667, 159);
            btn_SearchById.Name = "btn_SearchById";
            btn_SearchById.Size = new Size(111, 29);
            btn_SearchById.TabIndex = 12;
            btn_SearchById.Text = "Search By Id";
            btn_SearchById.UseVisualStyleBackColor = true;
            btn_SearchById.Click += btn_SearchById_Click;
            // 
            // btn_GetAll
            // 
            btn_GetAll.Location = new Point(516, 159);
            btn_GetAll.Name = "btn_GetAll";
            btn_GetAll.Size = new Size(131, 29);
            btn_GetAll.TabIndex = 11;
            btn_GetAll.Text = "Get All Details";
            btn_GetAll.UseVisualStyleBackColor = true;
            btn_GetAll.Click += btn_GetAll_Click;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(256, 165);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(233, 27);
            txt_Email.TabIndex = 8;
            txt_Email.Validating += txt_Email_Validating;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(256, 116);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(233, 27);
            txt_Name.TabIndex = 7;
            // 
            // txt_EmpId
            // 
            txt_EmpId.Location = new Point(256, 72);
            txt_EmpId.Name = "txt_EmpId";
            txt_EmpId.Size = new Size(233, 27);
            txt_EmpId.TabIndex = 6;
            txt_EmpId.KeyPress += txt_EmpId_KeyPress;
            // 
            // lbl_Status
            // 
            lbl_Status.AutoSize = true;
            lbl_Status.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Status.Location = new Point(89, 252);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size(53, 20);
            lbl_Status.TabIndex = 5;
            lbl_Status.Text = "Status";
            // 
            // lbl_Gender
            // 
            lbl_Gender.AutoSize = true;
            lbl_Gender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Gender.Location = new Point(89, 209);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(60, 20);
            lbl_Gender.TabIndex = 4;
            lbl_Gender.Text = "Gender";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Email.Location = new Point(89, 168);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(47, 20);
            lbl_Email.TabIndex = 3;
            lbl_Email.Text = "Email";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Manage Employee Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lbl_Id;
        private Label lbl_Name;
        private Panel panel1;
        private Label lbl_Status;
        private Label lbl_Gender;
        private Label lbl_Email;
        private TextBox txt_Status;
        private TextBox txt_Email;
        private TextBox txt_Name;
        private TextBox txt_EmpId;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Add;
        private Button btn_SearchById;
        private Button btn_GetAll;
        private Button btn_Page;
        private Label lbl_Page;
        private TextBox txt_Page;
        private ContextMenuStrip contextMenuStrip1;
        private Label lbl_Message;
        private Button btn_SearchName;
        private DataGridView dataGridView1;
        private RichTextBox txt_Response;
        private TextBox txt_Stat;
        private TextBox txt_Gender;
        private Button btn_refresh;
        private Button btn_Export;
    }
}