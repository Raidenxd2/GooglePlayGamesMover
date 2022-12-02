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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startBTN = new System.Windows.Forms.Button();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toTB = new System.Windows.Forms.TextBox();
            this.moveUDt = new System.Windows.Forms.CheckBox();
            this.createLIt = new System.Windows.Forms.CheckBox();
            this.statusText = new System.Windows.Forms.Label();
            this.browseBTN = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBTN
            // 
            this.startBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.Location = new System.Drawing.Point(12, 415);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(776, 23);
            this.startBTN.TabIndex = 0;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // fromTB
            // 
            this.fromTB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTB.Location = new System.Drawing.Point(15, 22);
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
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Google Play Games Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Move to";
            // 
            // toTB
            // 
            this.toTB.Location = new System.Drawing.Point(12, 65);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(776, 22);
            this.toTB.TabIndex = 6;
            this.toTB.Text = "D:\\Play Games\\";
            // 
            // moveUDt
            // 
            this.moveUDt.AutoSize = true;
            this.moveUDt.Location = new System.Drawing.Point(12, 117);
            this.moveUDt.Name = "moveUDt";
            this.moveUDt.Size = new System.Drawing.Size(268, 17);
            this.moveUDt.TabIndex = 8;
            this.moveUDt.Text = "Move User Data (DELETES ANDROID USERDATA)";
            this.moveUDt.UseVisualStyleBackColor = true;
            this.moveUDt.CheckedChanged += new System.EventHandler(this.moveUDt_CheckedChanged);
            // 
            // createLIt
            // 
            this.createLIt.AutoSize = true;
            this.createLIt.Location = new System.Drawing.Point(12, 93);
            this.createLIt.Name = "createLIt";
            this.createLIt.Size = new System.Drawing.Size(185, 17);
            this.createLIt.TabIndex = 7;
            this.createLIt.Text = "Create Local Install (no update)";
            this.createLIt.UseVisualStyleBackColor = true;
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(12, 399);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(39, 13);
            this.statusText.TabIndex = 9;
            this.statusText.Text = "Status";
            // 
            // browseBTN
            // 
            this.browseBTN.Location = new System.Drawing.Point(757, 65);
            this.browseBTN.Name = "browseBTN";
            this.browseBTN.Size = new System.Drawing.Size(34, 23);
            this.browseBTN.TabIndex = 10;
            this.browseBTN.Text = "...";
            this.browseBTN.UseVisualStyleBackColor = true;
            this.browseBTN.Click += new System.EventHandler(this.browseBTN_Click);
            // 
            // openFD
            // 
            this.openFD.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "v1.0.1-release";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.browseBTN);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.moveUDt);
            this.Controls.Add(this.createLIt);
            this.Controls.Add(this.toTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromTB);
            this.Controls.Add(this.startBTN);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Google Play Games Mover";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toTB;
        private System.Windows.Forms.CheckBox moveUDt;
        private System.Windows.Forms.CheckBox createLIt;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Button browseBTN;
        private System.Windows.Forms.FolderBrowserDialog openFD;
        private System.Windows.Forms.Label label3;
    }
}

