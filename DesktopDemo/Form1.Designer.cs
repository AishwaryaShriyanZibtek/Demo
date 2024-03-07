namespace DesktopDemo
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
            firstName = new Label();
            fName = new TextBox();
            Submit = new Button();
            lName = new TextBox();
            lastName = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            getAllBtn = new Button();
            OutputBox = new RichTextBox();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(12, 9);
            firstName.Name = "firstName";
            firstName.Size = new Size(64, 15);
            firstName.TabIndex = 0;
            firstName.Text = "First Name";
            // 
            // fName
            // 
            fName.Location = new Point(82, 6);
            fName.Name = "fName";
            fName.Size = new Size(143, 23);
            fName.TabIndex = 1;
            // 
            // Submit
            // 
            Submit.Location = new Point(119, 130);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 2;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // lName
            // 
            lName.Location = new Point(82, 49);
            lName.Name = "lName";
            lName.Size = new Size(143, 23);
            lName.TabIndex = 4;
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(13, 52);
            lastName.Name = "lastName";
            lastName.Size = new Size(63, 15);
            lastName.TabIndex = 3;
            lastName.Text = "Last Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(82, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 92);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // getAllBtn
            // 
            getAllBtn.Location = new Point(342, 172);
            getAllBtn.Name = "getAllBtn";
            getAllBtn.Size = new Size(75, 23);
            getAllBtn.TabIndex = 7;
            getAllBtn.Text = "GetAll";
            getAllBtn.UseVisualStyleBackColor = true;
            getAllBtn.Click += getAllBtn_Click;
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(48, 201);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(679, 212);
            OutputBox.TabIndex = 8;
            OutputBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputBox);
            Controls.Add(getAllBtn);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(lName);
            Controls.Add(lastName);
            Controls.Add(Submit);
            Controls.Add(fName);
            Controls.Add(firstName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label firstName;
        private TextBox fName;
        private Button Submit;
        private TextBox lName;
        private Label lastName;
        private TextBox textBox3;
        private Label label3;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Button getAllBtn;
        private RichTextBox OutputBox;
    }
}