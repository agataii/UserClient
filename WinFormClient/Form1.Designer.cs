namespace WinFormClient
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
            this._listView = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.email = new System.Windows.Forms.ColumnHeader();
            this.BDate = new System.Windows.Forms.ColumnHeader();
            this._loadButton = new System.Windows.Forms.Button();
            this._postButton = new System.Windows.Forms.Button();
            this._inputName = new System.Windows.Forms.TextBox();
            this._inputEmail = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this._inputPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _listView
            // 
            this._listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.email,
            this.BDate});
            this._listView.Location = new System.Drawing.Point(12, 12);
            this._listView.Name = "_listView";
            this._listView.Size = new System.Drawing.Size(338, 399);
            this._listView.TabIndex = 0;
            this._listView.UseCompatibleStateImageBehavior = false;
            this._listView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "Имя";
            // 
            // email
            // 
            this.email.Text = "Эл. почта";
            this.email.Width = 100;
            // 
            // BDate
            // 
            this.BDate.Text = "Дата рождения";
            this.BDate.Width = 100;
            // 
            // _loadButton
            // 
            this._loadButton.Location = new System.Drawing.Point(367, 12);
            this._loadButton.Name = "_loadButton";
            this._loadButton.Size = new System.Drawing.Size(130, 39);
            this._loadButton.TabIndex = 1;
            this._loadButton.Text = "ЗАГРУЗИТЬ";
            this._loadButton.UseVisualStyleBackColor = true;
            this._loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // _postButton
            // 
            this._postButton.Location = new System.Drawing.Point(367, 367);
            this._postButton.Name = "_postButton";
            this._postButton.Size = new System.Drawing.Size(130, 44);
            this._postButton.TabIndex = 2;
            this._postButton.Text = "ОТПРАВИТЬ";
            this._postButton.UseVisualStyleBackColor = true;
            this._postButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // _inputName
            // 
            this._inputName.Location = new System.Drawing.Point(367, 249);
            this._inputName.Name = "_inputName";
            this._inputName.PlaceholderText = "Введите имя";
            this._inputName.Size = new System.Drawing.Size(130, 23);
            this._inputName.TabIndex = 3;
            // 
            // _inputEmail
            // 
            this._inputEmail.Location = new System.Drawing.Point(367, 278);
            this._inputEmail.Name = "_inputEmail";
            this._inputEmail.PlaceholderText = "Введите эл. почту";
            this._inputEmail.Size = new System.Drawing.Size(130, 23);
            this._inputEmail.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(367, 336);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // _inputPassword
            // 
            this._inputPassword.Location = new System.Drawing.Point(367, 307);
            this._inputPassword.Name = "_inputPassword";
            this._inputPassword.PlaceholderText = "Введите пароль";
            this._inputPassword.Size = new System.Drawing.Size(130, 23);
            this._inputPassword.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this._inputPassword);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this._inputEmail);
            this.Controls.Add(this._inputName);
            this.Controls.Add(this._postButton);
            this.Controls.Add(this._loadButton);
            this.Controls.Add(this._listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView _listView;
        private Button _loadButton;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader email;
        private ColumnHeader BDate;
        private Button _postButton;
        private TextBox _inputName;
        private TextBox _inputEmail;
        private DateTimePicker dateTimePicker1;
        private TextBox _inputPassword;
    }
}