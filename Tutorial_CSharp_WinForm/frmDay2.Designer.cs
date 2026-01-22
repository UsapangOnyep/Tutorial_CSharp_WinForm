namespace Tutorial_CSharp_WinForm
{
    partial class frmDay2
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCounterPlus1 = new System.Windows.Forms.Button();
            this.btnMethodVariable = new System.Windows.Forms.Button();
            this.btnNewSubmit = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCallVar = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnConversion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(83, 110);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(171, 36);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Show Current Value";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCounterPlus1
            // 
            this.btnCounterPlus1.Location = new System.Drawing.Point(83, 68);
            this.btnCounterPlus1.Name = "btnCounterPlus1";
            this.btnCounterPlus1.Size = new System.Drawing.Size(171, 36);
            this.btnCounterPlus1.TabIndex = 1;
            this.btnCounterPlus1.Text = "counter + 1";
            this.btnCounterPlus1.UseVisualStyleBackColor = true;
            this.btnCounterPlus1.Click += new System.EventHandler(this.btnCounterPlus1_Click);
            // 
            // btnMethodVariable
            // 
            this.btnMethodVariable.Location = new System.Drawing.Point(83, 26);
            this.btnMethodVariable.Name = "btnMethodVariable";
            this.btnMethodVariable.Size = new System.Drawing.Size(171, 36);
            this.btnMethodVariable.TabIndex = 2;
            this.btnMethodVariable.Text = "METHOD | counter";
            this.btnMethodVariable.UseVisualStyleBackColor = true;
            this.btnMethodVariable.Click += new System.EventHandler(this.btnMethodVariable_Click);
            // 
            // btnNewSubmit
            // 
            this.btnNewSubmit.Location = new System.Drawing.Point(84, 243);
            this.btnNewSubmit.Name = "btnNewSubmit";
            this.btnNewSubmit.Size = new System.Drawing.Size(78, 32);
            this.btnNewSubmit.TabIndex = 3;
            this.btnNewSubmit.Text = "save text";
            this.btnNewSubmit.UseVisualStyleBackColor = true;
            this.btnNewSubmit.Click += new System.EventHandler(this.btnNewSubmit_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(84, 211);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(171, 26);
            this.txtInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(129, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input Text";
            // 
            // btnCallVar
            // 
            this.btnCallVar.Location = new System.Drawing.Point(177, 243);
            this.btnCallVar.Name = "btnCallVar";
            this.btnCallVar.Size = new System.Drawing.Size(78, 32);
            this.btnCallVar.TabIndex = 6;
            this.btnCallVar.Text = "call variable";
            this.btnCallVar.UseVisualStyleBackColor = true;
            this.btnCallVar.Click += new System.EventHandler(this.btnCallVar_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(84, 317);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(170, 32);
            this.btnSubstring.TabIndex = 7;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(85, 431);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(170, 32);
            this.btnConversion.TabIndex = 8;
            this.btnConversion.Text = "Conversion";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // frmDay2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 475);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnCallVar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnNewSubmit);
            this.Controls.Add(this.btnMethodVariable);
            this.Controls.Add(this.btnCounterPlus1);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmDay2";
            this.Text = "frmDay2";
            this.Load += new System.EventHandler(this.frmDay2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCounterPlus1;
        private System.Windows.Forms.Button btnMethodVariable;
        private System.Windows.Forms.Button btnNewSubmit;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCallVar;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnConversion;
    }
}