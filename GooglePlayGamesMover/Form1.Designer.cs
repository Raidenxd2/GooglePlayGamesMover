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
            this.openFD = new System.Windows.Forms.FolderBrowserDialog();
            this.startBTN = new MaterialSkin.Controls.MaterialButton();
            this.versionText = new MaterialSkin.Controls.MaterialLabel();
            this.statusText = new MaterialSkin.Controls.MaterialLabel();
            this.createLIt = new MaterialSkin.Controls.MaterialCheckbox();
            this.moveUDt = new MaterialSkin.Controls.MaterialCheckbox();
            this.fromTB = new MaterialSkin.Controls.MaterialTextBox();
            this.toTB = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.browseBTN = new MaterialSkin.Controls.MaterialButton();
            this.darkmodeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // openFD
            // 
            this.openFD.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // startBTN
            // 
            this.startBTN.AutoSize = false;
            this.startBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startBTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.startBTN.Depth = 0;
            this.startBTN.HighEmphasis = true;
            this.startBTN.Icon = null;
            this.startBTN.Location = new System.Drawing.Point(7, 417);
            this.startBTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.startBTN.Name = "startBTN";
            this.startBTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.startBTN.Size = new System.Drawing.Size(681, 36);
            this.startBTN.TabIndex = 12;
            this.startBTN.Text = "Start";
            this.startBTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startBTN.UseAccentColor = false;
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click_1);
            // 
            // versionText
            // 
            this.versionText.AutoSize = true;
            this.versionText.Depth = 0;
            this.versionText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.versionText.Location = new System.Drawing.Point(641, 392);
            this.versionText.MouseState = MaterialSkin.MouseState.HOVER;
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(46, 19);
            this.versionText.TabIndex = 13;
            this.versionText.Text = "V1.1.0";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Depth = 0;
            this.statusText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statusText.Location = new System.Drawing.Point(7, 392);
            this.statusText.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(47, 19);
            this.statusText.TabIndex = 14;
            this.statusText.Text = "Status";
            // 
            // createLIt
            // 
            this.createLIt.AutoSize = true;
            this.createLIt.Depth = 0;
            this.createLIt.Location = new System.Drawing.Point(7, 243);
            this.createLIt.Margin = new System.Windows.Forms.Padding(0);
            this.createLIt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.createLIt.MouseState = MaterialSkin.MouseState.HOVER;
            this.createLIt.Name = "createLIt";
            this.createLIt.ReadOnly = false;
            this.createLIt.Ripple = true;
            this.createLIt.Size = new System.Drawing.Size(256, 37);
            this.createLIt.TabIndex = 15;
            this.createLIt.Text = "Create Local Install (no update)";
            this.createLIt.UseVisualStyleBackColor = true;
            // 
            // moveUDt
            // 
            this.moveUDt.AutoSize = true;
            this.moveUDt.Depth = 0;
            this.moveUDt.Location = new System.Drawing.Point(7, 280);
            this.moveUDt.Margin = new System.Windows.Forms.Padding(0);
            this.moveUDt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.moveUDt.MouseState = MaterialSkin.MouseState.HOVER;
            this.moveUDt.Name = "moveUDt";
            this.moveUDt.ReadOnly = false;
            this.moveUDt.Ripple = true;
            this.moveUDt.Size = new System.Drawing.Size(413, 37);
            this.moveUDt.TabIndex = 16;
            this.moveUDt.Text = "Move User Data (MAY DELETE ANDROID USERDATA)";
            this.moveUDt.UseVisualStyleBackColor = true;
            this.moveUDt.CheckedChanged += new System.EventHandler(this.moveUDt_CheckedChanged_1);
            // 
            // fromTB
            // 
            this.fromTB.AnimateReadOnly = false;
            this.fromTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fromTB.Depth = 0;
            this.fromTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromTB.LeadingIcon = null;
            this.fromTB.Location = new System.Drawing.Point(7, 115);
            this.fromTB.MaxLength = 50;
            this.fromTB.MouseState = MaterialSkin.MouseState.OUT;
            this.fromTB.Multiline = false;
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(680, 50);
            this.fromTB.TabIndex = 17;
            this.fromTB.Text = "C:\\Program Files\\Google\\Play Games\\";
            this.fromTB.TrailingIcon = null;
            // 
            // toTB
            // 
            this.toTB.AnimateReadOnly = false;
            this.toTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toTB.Depth = 0;
            this.toTB.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toTB.LeadingIcon = null;
            this.toTB.Location = new System.Drawing.Point(7, 190);
            this.toTB.MaxLength = 50;
            this.toTB.MouseState = MaterialSkin.MouseState.OUT;
            this.toTB.Multiline = false;
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(632, 50);
            this.toTB.TabIndex = 18;
            this.toTB.Text = "D:\\Play Games\\";
            this.toTB.TrailingIcon = null;
            this.toTB.TextChanged += new System.EventHandler(this.toTB_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(7, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(207, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Google Play Games Directory";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(7, 168);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "Move to";
            // 
            // browseBTN
            // 
            this.browseBTN.AutoSize = false;
            this.browseBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseBTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.browseBTN.Depth = 0;
            this.browseBTN.HighEmphasis = true;
            this.browseBTN.Icon = null;
            this.browseBTN.Location = new System.Drawing.Point(630, 190);
            this.browseBTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.browseBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseBTN.Name = "browseBTN";
            this.browseBTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.browseBTN.Size = new System.Drawing.Size(57, 50);
            this.browseBTN.TabIndex = 21;
            this.browseBTN.Text = "...";
            this.browseBTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.browseBTN.UseAccentColor = false;
            this.browseBTN.UseVisualStyleBackColor = true;
            this.browseBTN.Click += new System.EventHandler(this.browseBTN_Click_1);
            // 
            // darkmodeSwitch
            // 
            this.darkmodeSwitch.AutoSize = true;
            this.darkmodeSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.darkmodeSwitch.Depth = 0;
            this.darkmodeSwitch.Location = new System.Drawing.Point(558, 64);
            this.darkmodeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.darkmodeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.darkmodeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkmodeSwitch.Name = "darkmodeSwitch";
            this.darkmodeSwitch.Ripple = true;
            this.darkmodeSwitch.Size = new System.Drawing.Size(135, 37);
            this.darkmodeSwitch.TabIndex = 22;
            this.darkmodeSwitch.Text = "Dark mode";
            this.darkmodeSwitch.UseVisualStyleBackColor = false;
            this.darkmodeSwitch.CheckedChanged += new System.EventHandler(this.darkmodeSwitch_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 501);
            this.Controls.Add(this.darkmodeSwitch);
            this.Controls.Add(this.browseBTN);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.toTB);
            this.Controls.Add(this.fromTB);
            this.Controls.Add(this.moveUDt);
            this.Controls.Add(this.createLIt);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.startBTN);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Google Play Games Mover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog openFD;
        private MaterialSkin.Controls.MaterialButton startBTN;
        private MaterialSkin.Controls.MaterialLabel versionText;
        private MaterialSkin.Controls.MaterialLabel statusText;
        private MaterialSkin.Controls.MaterialCheckbox createLIt;
        private MaterialSkin.Controls.MaterialCheckbox moveUDt;
        private MaterialSkin.Controls.MaterialTextBox fromTB;
        private MaterialSkin.Controls.MaterialTextBox toTB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton browseBTN;
        private MaterialSkin.Controls.MaterialSwitch darkmodeSwitch;
    }
}

