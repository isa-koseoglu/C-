namespace Pipe_Connection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pipeName2_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.send1_btn = new System.Windows.Forms.Button();
            this.request1_btn = new System.Windows.Forms.Button();
            this.message1_txt = new System.Windows.Forms.TextBox();
            this.listPipe1_listbox = new System.Windows.Forms.ListBox();
            this.pipeName1_txt = new System.Windows.Forms.TextBox();
            this.body_panel = new System.Windows.Forms.Panel();
            this.header_panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.body_panel.SuspendLayout();
            this.header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.header_panel);
            this.groupBox1.Controls.Add(this.body_panel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pipe";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Communication";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Request";
            // 
            // pipeName2_txt
            // 
            this.pipeName2_txt.Location = new System.Drawing.Point(145, 27);
            this.pipeName2_txt.Name = "pipeName2_txt";
            this.pipeName2_txt.Size = new System.Drawing.Size(123, 23);
            this.pipeName2_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Response";
            // 
            // send1_btn
            // 
            this.send1_btn.BackColor = System.Drawing.Color.Lime;
            this.send1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send1_btn.Location = new System.Drawing.Point(200, 16);
            this.send1_btn.Name = "send1_btn";
            this.send1_btn.Size = new System.Drawing.Size(70, 23);
            this.send1_btn.TabIndex = 4;
            this.send1_btn.Text = "Send";
            this.send1_btn.UseVisualStyleBackColor = false;
            this.send1_btn.Click += new System.EventHandler(this.send1_btn_Click);
            // 
            // request1_btn
            // 
            this.request1_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.request1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.request1_btn.Location = new System.Drawing.Point(48, 61);
            this.request1_btn.Name = "request1_btn";
            this.request1_btn.Size = new System.Drawing.Size(160, 27);
            this.request1_btn.TabIndex = 1;
            this.request1_btn.Text = "Request";
            this.request1_btn.UseVisualStyleBackColor = false;
            this.request1_btn.Click += new System.EventHandler(this.request1_btn_Click);
            // 
            // message1_txt
            // 
            this.message1_txt.Location = new System.Drawing.Point(9, 16);
            this.message1_txt.Name = "message1_txt";
            this.message1_txt.Size = new System.Drawing.Size(185, 23);
            this.message1_txt.TabIndex = 3;
            // 
            // listPipe1_listbox
            // 
            this.listPipe1_listbox.FormattingEnabled = true;
            this.listPipe1_listbox.ItemHeight = 15;
            this.listPipe1_listbox.Location = new System.Drawing.Point(7, 45);
            this.listPipe1_listbox.Name = "listPipe1_listbox";
            this.listPipe1_listbox.Size = new System.Drawing.Size(261, 124);
            this.listPipe1_listbox.TabIndex = 2;
            // 
            // pipeName1_txt
            // 
            this.pipeName1_txt.Location = new System.Drawing.Point(7, 27);
            this.pipeName1_txt.Name = "pipeName1_txt";
            this.pipeName1_txt.Size = new System.Drawing.Size(119, 23);
            this.pipeName1_txt.TabIndex = 0;
            // 
            // body_panel
            // 
            this.body_panel.Controls.Add(this.listPipe1_listbox);
            this.body_panel.Controls.Add(this.message1_txt);
            this.body_panel.Controls.Add(this.send1_btn);
            this.body_panel.Location = new System.Drawing.Point(3, 169);
            this.body_panel.Name = "body_panel";
            this.body_panel.Size = new System.Drawing.Size(278, 175);
            this.body_panel.TabIndex = 9;
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.pipeName1_txt);
            this.header_panel.Controls.Add(this.label1);
            this.header_panel.Controls.Add(this.pipeName2_txt);
            this.header_panel.Controls.Add(this.label2);
            this.header_panel.Controls.Add(this.request1_btn);
            this.header_panel.Location = new System.Drawing.Point(3, 68);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(278, 95);
            this.header_panel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 360);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.body_panel.ResumeLayout(false);
            this.body_panel.PerformLayout();
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox pipeName1_txt;
        private Button request1_btn;
        private Button send1_btn;
        private TextBox message1_txt;
        private ListBox listPipe1_listbox;
        private Label label3;
        private Label label2;
        private TextBox pipeName2_txt;
        private Label label1;
        private Panel header_panel;
        private Panel body_panel;
    }
}