namespace Tutorial_CSharp_WinForm
{
    partial class Form1
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
            this.lblMyLabel = new System.Windows.Forms.Label();
            this.txtMyTextbox = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClickMe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMsgBoxTitle = new System.Windows.Forms.Button();
            this.btnMsgBoxIcon = new System.Windows.Forms.Button();
            this.btnMsgBoxButtons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMyLabel
            // 
            this.lblMyLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyLabel.Location = new System.Drawing.Point(12, 9);
            this.lblMyLabel.Name = "lblMyLabel";
            this.lblMyLabel.Size = new System.Drawing.Size(734, 61);
            this.lblMyLabel.TabIndex = 0;
            this.lblMyLabel.Text = "This is my First App";
            this.lblMyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMyLabel.Click += new System.EventHandler(this.lblMyLabel_clicked);
            // 
            // txtMyTextbox
            // 
            this.txtMyTextbox.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyTextbox.Location = new System.Drawing.Point(18, 88);
            this.txtMyTextbox.Name = "txtMyTextbox";
            this.txtMyTextbox.Size = new System.Drawing.Size(728, 81);
            this.txtMyTextbox.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(190, 175);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(177, 47);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_clicked);
            // 
            // btnHide
            // 
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.Black;
            this.btnHide.Location = new System.Drawing.Point(190, 228);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(177, 47);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "Hide Text";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_clicked);
            // 
            // btnShow
            // 
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(410, 228);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(177, 47);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Text";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_clicked);
            // 
            // btnClickMe
            // 
            this.btnClickMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClickMe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickMe.ForeColor = System.Drawing.Color.Black;
            this.btnClickMe.Location = new System.Drawing.Point(18, 342);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(266, 47);
            this.btnClickMe.TabIndex = 5;
            this.btnClickMe.Text = "Click me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_clicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 61);
            this.label1.TabIndex = 6;
            this.label1.Text = "Showing of MessageBox";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMsgBoxTitle
            // 
            this.btnMsgBoxTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsgBoxTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsgBoxTitle.ForeColor = System.Drawing.Color.Black;
            this.btnMsgBoxTitle.Location = new System.Drawing.Point(18, 395);
            this.btnMsgBoxTitle.Name = "btnMsgBoxTitle";
            this.btnMsgBoxTitle.Size = new System.Drawing.Size(266, 47);
            this.btnMsgBoxTitle.TabIndex = 7;
            this.btnMsgBoxTitle.Text = "Click me (with title)";
            this.btnMsgBoxTitle.UseVisualStyleBackColor = true;
            this.btnMsgBoxTitle.Click += new System.EventHandler(this.btnMsgBoxTitle_Click);
            // 
            // btnMsgBoxIcon
            // 
            this.btnMsgBoxIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsgBoxIcon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsgBoxIcon.ForeColor = System.Drawing.Color.Black;
            this.btnMsgBoxIcon.Location = new System.Drawing.Point(321, 395);
            this.btnMsgBoxIcon.Name = "btnMsgBoxIcon";
            this.btnMsgBoxIcon.Size = new System.Drawing.Size(266, 47);
            this.btnMsgBoxIcon.TabIndex = 8;
            this.btnMsgBoxIcon.Text = "Click me (with icon)";
            this.btnMsgBoxIcon.UseVisualStyleBackColor = true;
            this.btnMsgBoxIcon.Click += new System.EventHandler(this.btnMsgBoxIcon_Click);
            // 
            // btnMsgBoxButtons
            // 
            this.btnMsgBoxButtons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsgBoxButtons.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsgBoxButtons.ForeColor = System.Drawing.Color.Black;
            this.btnMsgBoxButtons.Location = new System.Drawing.Point(321, 342);
            this.btnMsgBoxButtons.Name = "btnMsgBoxButtons";
            this.btnMsgBoxButtons.Size = new System.Drawing.Size(266, 47);
            this.btnMsgBoxButtons.TabIndex = 9;
            this.btnMsgBoxButtons.Text = "Click me (with buttons)";
            this.btnMsgBoxButtons.UseVisualStyleBackColor = true;
            this.btnMsgBoxButtons.Click += new System.EventHandler(this.btnMsgBoxButtons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(758, 547);
            this.Controls.Add(this.btnMsgBoxButtons);
            this.Controls.Add(this.btnMsgBoxIcon);
            this.Controls.Add(this.btnMsgBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClickMe);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMyTextbox);
            this.Controls.Add(this.lblMyLabel);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My First Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyLabel;
        private System.Windows.Forms.TextBox txtMyTextbox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMsgBoxTitle;
        private System.Windows.Forms.Button btnMsgBoxIcon;
        private System.Windows.Forms.Button btnMsgBoxButtons;
    }
}

