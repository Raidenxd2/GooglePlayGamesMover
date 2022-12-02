namespace GooglePlayGamesMover
{
    partial class Options
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
            this.createLI = new System.Windows.Forms.CheckBox();
            this.moveUD = new System.Windows.Forms.CheckBox();
            this.doneBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createLI
            // 
            this.createLI.AutoSize = true;
            this.createLI.Location = new System.Drawing.Point(13, 13);
            this.createLI.Name = "createLI";
            this.createLI.Size = new System.Drawing.Size(122, 17);
            this.createLI.TabIndex = 0;
            this.createLI.Text = "Create Local Install";
            this.createLI.UseVisualStyleBackColor = true;
            // 
            // moveUD
            // 
            this.moveUD.AutoSize = true;
            this.moveUD.Location = new System.Drawing.Point(13, 37);
            this.moveUD.Name = "moveUD";
            this.moveUD.Size = new System.Drawing.Size(268, 17);
            this.moveUD.TabIndex = 1;
            this.moveUD.Text = "Move User Data (DELETES ANDROID USERDATA)";
            this.moveUD.UseVisualStyleBackColor = true;
            // 
            // doneBTN
            // 
            this.doneBTN.Location = new System.Drawing.Point(13, 415);
            this.doneBTN.Name = "doneBTN";
            this.doneBTN.Size = new System.Drawing.Size(75, 23);
            this.doneBTN.TabIndex = 2;
            this.doneBTN.Text = "Done";
            this.doneBTN.UseVisualStyleBackColor = true;
            this.doneBTN.Click += new System.EventHandler(this.doneBTN_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doneBTN);
            this.Controls.Add(this.moveUD);
            this.Controls.Add(this.createLI);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox createLI;
        private System.Windows.Forms.CheckBox moveUD;
        private System.Windows.Forms.Button doneBTN;
    }
}