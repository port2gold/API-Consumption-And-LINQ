namespace Author
{
    partial class FormMajor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMajor));
            this.buttonSubmission = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.buttonComment = new System.Windows.Forms.Button();
            this.buttonDate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonclear = new System.Windows.Forms.Button();
            this.Authors = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSubmission
            // 
            this.buttonSubmission.BackColor = System.Drawing.Color.Gray;
            this.buttonSubmission.Location = new System.Drawing.Point(38, 117);
            this.buttonSubmission.Name = "buttonSubmission";
            this.buttonSubmission.Size = new System.Drawing.Size(275, 58);
            this.buttonSubmission.TabIndex = 0;
            this.buttonSubmission.Text = "Authors By Submission Count";
            this.buttonSubmission.UseVisualStyleBackColor = false;
            this.buttonSubmission.Click += new System.EventHandler(this.buttonSubmission_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Submission Count Threshold";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(485, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result View";
            // 
            // buttonComment
            // 
            this.buttonComment.BackColor = System.Drawing.Color.Gray;
            this.buttonComment.Location = new System.Drawing.Point(38, 181);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(275, 58);
            this.buttonComment.TabIndex = 0;
            this.buttonComment.Text = "Authors By Comment Count";
            this.buttonComment.UseVisualStyleBackColor = false;
            this.buttonComment.Click += new System.EventHandler(this.buttonCommentClick);
            // 
            // buttonDate
            // 
            this.buttonDate.BackColor = System.Drawing.Color.Gray;
            this.buttonDate.Location = new System.Drawing.Point(38, 245);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(275, 58);
            this.buttonDate.TabIndex = 0;
            this.buttonDate.Text = "Author By Record Date";
            this.buttonDate.UseVisualStyleBackColor = false;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 5;
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.Color.Gray;
            this.buttonclear.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonclear.Location = new System.Drawing.Point(387, 434);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(275, 47);
            this.buttonclear.TabIndex = 6;
            this.buttonclear.Text = "Clear Result";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // Authors
            // 
            this.Authors.BackColor = System.Drawing.Color.FloralWhite;
            this.Authors.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Authors.FormattingEnabled = true;
            this.Authors.ItemHeight = 24;
            this.Authors.Location = new System.Drawing.Point(349, 63);
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(360, 364);
            this.Authors.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 319);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(262, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "API FETCH AND LINQ";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(155, 400);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(158, 27);
            this.textBoxDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(102, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Record Date Threshold";
            // 
            // FormMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Authors);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMajor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.ListBox Authors;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label4;
    }
}

