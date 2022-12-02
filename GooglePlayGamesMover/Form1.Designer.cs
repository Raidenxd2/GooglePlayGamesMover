namespace GooglePlayGamesMover
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
            this.startBTN = new System.Windows.Forms.Button();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.optionsBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startBTN
            // 
            this.startBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.Location = new System.Drawing.Point(12, 415);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(75, 23);
            this.startBTN.TabIndex = 0;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // fromTB
            // 
            this.fromTB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTB.Location = new System.Drawing.Point(12, 24);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(776, 22);
            this.fromTB.TabIndex = 1;
            this.fromTB.Text = "C:\\Program Files\\Google\\Play Games\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(93, 415);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(614, 23);
            this.progressBar.TabIndex = 3;
            // 
            // optionsBTN
            // 
            this.optionsBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsBTN.Location = new System.Drawing.Point(713, 415);
            this.optionsBTN.Name = "optionsBTN";
            this.optionsBTN.Size = new System.Drawing.Size(75, 23);
            this.optionsBTN.TabIndex = 4;
            this.optionsBTN.Text = "Options";
            this.optionsBTN.UseVisualStyleBackColor = true;
            this.optionsBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // toTB
            // 
            this.toTB.Location = new System.Drawing.Point(12, 65);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(776, 22);
            this.toTB.TabIndex = 6;
            this.toTB.Text = "D:\\Play Games\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optionsBTN);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromTB);
            this.Controls.Add(this.startBTN);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Google Play Games Mover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button optionsBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toTB;
    }
}

