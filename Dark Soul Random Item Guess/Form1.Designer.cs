namespace Dark_Soul_Random_Item_Guess
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
            this.PBItemDisplay = new System.Windows.Forms.PictureBox();
            this.RBWeapons = new System.Windows.Forms.RadioButton();
            this.RBArmor = new System.Windows.Forms.RadioButton();
            this.RBRings = new System.Windows.Forms.RadioButton();
            this.RBMagic = new System.Windows.Forms.RadioButton();
            this.RBConsumeable = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.RBGestures = new System.Windows.Forms.RadioButton();
            this.LaItemName = new System.Windows.Forms.Label();
            this.RTBHowToGetText = new System.Windows.Forms.RichTextBox();
            this.RBViewName = new System.Windows.Forms.RadioButton();
            this.BuShowData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBItemDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // PBItemDisplay
            // 
            this.PBItemDisplay.Location = new System.Drawing.Point(535, 38);
            this.PBItemDisplay.Name = "PBItemDisplay";
            this.PBItemDisplay.Size = new System.Drawing.Size(256, 256);
            this.PBItemDisplay.TabIndex = 0;
            this.PBItemDisplay.TabStop = false;
            // 
            // RBWeapons
            // 
            this.RBWeapons.AutoSize = true;
            this.RBWeapons.ForeColor = System.Drawing.Color.White;
            this.RBWeapons.Location = new System.Drawing.Point(30, 38);
            this.RBWeapons.Name = "RBWeapons";
            this.RBWeapons.Size = new System.Drawing.Size(89, 21);
            this.RBWeapons.TabIndex = 1;
            this.RBWeapons.TabStop = true;
            this.RBWeapons.Text = "Weapons";
            this.RBWeapons.UseVisualStyleBackColor = true;
            // 
            // RBArmor
            // 
            this.RBArmor.AutoSize = true;
            this.RBArmor.ForeColor = System.Drawing.Color.White;
            this.RBArmor.Location = new System.Drawing.Point(30, 66);
            this.RBArmor.Name = "RBArmor";
            this.RBArmor.Size = new System.Drawing.Size(67, 21);
            this.RBArmor.TabIndex = 2;
            this.RBArmor.TabStop = true;
            this.RBArmor.Text = "Armor";
            this.RBArmor.UseVisualStyleBackColor = true;
            // 
            // RBRings
            // 
            this.RBRings.AutoSize = true;
            this.RBRings.ForeColor = System.Drawing.Color.White;
            this.RBRings.Location = new System.Drawing.Point(30, 94);
            this.RBRings.Name = "RBRings";
            this.RBRings.Size = new System.Drawing.Size(65, 21);
            this.RBRings.TabIndex = 3;
            this.RBRings.TabStop = true;
            this.RBRings.Text = "Rings";
            this.RBRings.UseVisualStyleBackColor = true;
            // 
            // RBMagic
            // 
            this.RBMagic.AutoSize = true;
            this.RBMagic.ForeColor = System.Drawing.Color.White;
            this.RBMagic.Location = new System.Drawing.Point(30, 122);
            this.RBMagic.Name = "RBMagic";
            this.RBMagic.Size = new System.Drawing.Size(66, 21);
            this.RBMagic.TabIndex = 4;
            this.RBMagic.TabStop = true;
            this.RBMagic.Text = "Magic";
            this.RBMagic.UseVisualStyleBackColor = true;
            // 
            // RBConsumeable
            // 
            this.RBConsumeable.AutoSize = true;
            this.RBConsumeable.ForeColor = System.Drawing.Color.White;
            this.RBConsumeable.Location = new System.Drawing.Point(30, 149);
            this.RBConsumeable.Name = "RBConsumeable";
            this.RBConsumeable.Size = new System.Drawing.Size(115, 21);
            this.RBConsumeable.TabIndex = 5;
            this.RBConsumeable.TabStop = true;
            this.RBConsumeable.Text = "Consumeable";
            this.RBConsumeable.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RBGestures
            // 
            this.RBGestures.AutoSize = true;
            this.RBGestures.ForeColor = System.Drawing.Color.White;
            this.RBGestures.Location = new System.Drawing.Point(30, 177);
            this.RBGestures.Name = "RBGestures";
            this.RBGestures.Size = new System.Drawing.Size(95, 21);
            this.RBGestures.TabIndex = 7;
            this.RBGestures.TabStop = true;
            this.RBGestures.Text = "Gesutures";
            this.RBGestures.UseVisualStyleBackColor = true;
            // 
            // LaItemName
            // 
            this.LaItemName.AutoSize = true;
            this.LaItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaItemName.ForeColor = System.Drawing.Color.White;
            this.LaItemName.Location = new System.Drawing.Point(245, 85);
            this.LaItemName.Name = "LaItemName";
            this.LaItemName.Size = new System.Drawing.Size(77, 29);
            this.LaItemName.TabIndex = 9;
            this.LaItemName.Text = "name";
            // 
            // RTBHowToGetText
            // 
            this.RTBHowToGetText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.RTBHowToGetText.ForeColor = System.Drawing.Color.White;
            this.RTBHowToGetText.Location = new System.Drawing.Point(250, 117);
            this.RTBHowToGetText.Name = "RTBHowToGetText";
            this.RTBHowToGetText.ReadOnly = true;
            this.RTBHowToGetText.Size = new System.Drawing.Size(183, 191);
            this.RTBHowToGetText.TabIndex = 10;
            this.RTBHowToGetText.Text = "";
            // 
            // RBViewName
            // 
            this.RBViewName.AutoSize = true;
            this.RBViewName.ForeColor = System.Drawing.Color.White;
            this.RBViewName.Location = new System.Drawing.Point(30, 213);
            this.RBViewName.Name = "RBViewName";
            this.RBViewName.Size = new System.Drawing.Size(140, 21);
            this.RBViewName.TabIndex = 11;
            this.RBViewName.TabStop = true;
            this.RBViewName.Text = "View name on roll";
            this.RBViewName.UseVisualStyleBackColor = true;
            // 
            // BuShowData
            // 
            this.BuShowData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BuShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuShowData.ForeColor = System.Drawing.Color.White;
            this.BuShowData.Location = new System.Drawing.Point(250, 23);
            this.BuShowData.Name = "BuShowData";
            this.BuShowData.Size = new System.Drawing.Size(120, 45);
            this.BuShowData.TabIndex = 12;
            this.BuShowData.Text = "Show";
            this.BuShowData.UseVisualStyleBackColor = false;
            this.BuShowData.Click += new System.EventHandler(this.BuShowData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.BuShowData);
            this.Controls.Add(this.RBViewName);
            this.Controls.Add(this.RTBHowToGetText);
            this.Controls.Add(this.LaItemName);
            this.Controls.Add(this.RBGestures);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RBConsumeable);
            this.Controls.Add(this.RBMagic);
            this.Controls.Add(this.RBRings);
            this.Controls.Add(this.RBArmor);
            this.Controls.Add(this.RBWeapons);
            this.Controls.Add(this.PBItemDisplay);
            this.Name = "Form1";
            this.Text = "DS 1 Rng Item";
            ((System.ComponentModel.ISupportInitialize)(this.PBItemDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBItemDisplay;
        private System.Windows.Forms.RadioButton RBWeapons;
        private System.Windows.Forms.RadioButton RBArmor;
        private System.Windows.Forms.RadioButton RBRings;
        private System.Windows.Forms.RadioButton RBMagic;
        private System.Windows.Forms.RadioButton RBConsumeable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RBGestures;
        private System.Windows.Forms.Label LaItemName;
        private System.Windows.Forms.RichTextBox RTBHowToGetText;
        private System.Windows.Forms.RadioButton RBViewName;
        private System.Windows.Forms.Button BuShowData;
    }
}

