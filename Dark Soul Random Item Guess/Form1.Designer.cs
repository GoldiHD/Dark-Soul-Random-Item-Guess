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
            this.button1 = new System.Windows.Forms.Button();
            this.LaItemName = new System.Windows.Forms.Label();
            this.RTBHowToGetText = new System.Windows.Forms.RichTextBox();
            this.BuShowData = new System.Windows.Forms.Button();
            this.CBWeapons = new System.Windows.Forms.CheckBox();
            this.CBArmors = new System.Windows.Forms.CheckBox();
            this.CBMagics = new System.Windows.Forms.CheckBox();
            this.CBRings = new System.Windows.Forms.CheckBox();
            this.CBConsumables = new System.Windows.Forms.CheckBox();
            this.CBGestures = new System.Windows.Forms.CheckBox();
            this.CBShowData = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBItemDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // PBItemDisplay
            // 
            this.PBItemDisplay.Location = new System.Drawing.Point(371, 31);
            this.PBItemDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PBItemDisplay.Name = "PBItemDisplay";
            this.PBItemDisplay.Size = new System.Drawing.Size(192, 208);
            this.PBItemDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBItemDisplay.TabIndex = 0;
            this.PBItemDisplay.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LaItemName
            // 
            this.LaItemName.AutoSize = true;
            this.LaItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaItemName.ForeColor = System.Drawing.Color.White;
            this.LaItemName.Location = new System.Drawing.Point(184, 69);
            this.LaItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LaItemName.Name = "LaItemName";
            this.LaItemName.Size = new System.Drawing.Size(61, 25);
            this.LaItemName.TabIndex = 9;
            this.LaItemName.Text = "name";
            // 
            // RTBHowToGetText
            // 
            this.RTBHowToGetText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.RTBHowToGetText.ForeColor = System.Drawing.Color.White;
            this.RTBHowToGetText.Location = new System.Drawing.Point(188, 95);
            this.RTBHowToGetText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RTBHowToGetText.Name = "RTBHowToGetText";
            this.RTBHowToGetText.ReadOnly = true;
            this.RTBHowToGetText.Size = new System.Drawing.Size(138, 156);
            this.RTBHowToGetText.TabIndex = 10;
            this.RTBHowToGetText.Text = "";
            // 
            // BuShowData
            // 
            this.BuShowData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BuShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuShowData.ForeColor = System.Drawing.Color.White;
            this.BuShowData.Location = new System.Drawing.Point(188, 19);
            this.BuShowData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuShowData.Name = "BuShowData";
            this.BuShowData.Size = new System.Drawing.Size(90, 37);
            this.BuShowData.TabIndex = 12;
            this.BuShowData.Text = "Show";
            this.BuShowData.UseVisualStyleBackColor = false;
            this.BuShowData.Click += new System.EventHandler(this.BuShowData_Click);
            // 
            // CBWeapons
            // 
            this.CBWeapons.AutoSize = true;
            this.CBWeapons.ForeColor = System.Drawing.Color.White;
            this.CBWeapons.Location = new System.Drawing.Point(22, 19);
            this.CBWeapons.Name = "CBWeapons";
            this.CBWeapons.Size = new System.Drawing.Size(72, 17);
            this.CBWeapons.TabIndex = 13;
            this.CBWeapons.Text = "Weapons";
            this.CBWeapons.UseVisualStyleBackColor = true;
            // 
            // CBArmors
            // 
            this.CBArmors.AutoSize = true;
            this.CBArmors.ForeColor = System.Drawing.Color.White;
            this.CBArmors.Location = new System.Drawing.Point(22, 42);
            this.CBArmors.Name = "CBArmors";
            this.CBArmors.Size = new System.Drawing.Size(64, 17);
            this.CBArmors.TabIndex = 14;
            this.CBArmors.Text = "Armours";
            this.CBArmors.UseVisualStyleBackColor = true;
            // 
            // CBMagics
            // 
            this.CBMagics.AutoSize = true;
            this.CBMagics.ForeColor = System.Drawing.Color.White;
            this.CBMagics.Location = new System.Drawing.Point(22, 65);
            this.CBMagics.Name = "CBMagics";
            this.CBMagics.Size = new System.Drawing.Size(60, 17);
            this.CBMagics.TabIndex = 15;
            this.CBMagics.Text = "Magics";
            this.CBMagics.UseVisualStyleBackColor = true;
            // 
            // CBRings
            // 
            this.CBRings.AutoSize = true;
            this.CBRings.ForeColor = System.Drawing.Color.White;
            this.CBRings.Location = new System.Drawing.Point(22, 88);
            this.CBRings.Name = "CBRings";
            this.CBRings.Size = new System.Drawing.Size(53, 17);
            this.CBRings.TabIndex = 16;
            this.CBRings.Text = "Rings";
            this.CBRings.UseVisualStyleBackColor = true;
            // 
            // CBConsumables
            // 
            this.CBConsumables.AutoSize = true;
            this.CBConsumables.ForeColor = System.Drawing.Color.White;
            this.CBConsumables.Location = new System.Drawing.Point(22, 111);
            this.CBConsumables.Name = "CBConsumables";
            this.CBConsumables.Size = new System.Drawing.Size(89, 17);
            this.CBConsumables.TabIndex = 17;
            this.CBConsumables.Text = "Consumables";
            this.CBConsumables.UseVisualStyleBackColor = true;
            // 
            // CBGestures
            // 
            this.CBGestures.AutoSize = true;
            this.CBGestures.ForeColor = System.Drawing.Color.White;
            this.CBGestures.Location = new System.Drawing.Point(22, 134);
            this.CBGestures.Name = "CBGestures";
            this.CBGestures.Size = new System.Drawing.Size(68, 17);
            this.CBGestures.TabIndex = 18;
            this.CBGestures.Text = "Gestures";
            this.CBGestures.UseVisualStyleBackColor = true;
            // 
            // CBShowData
            // 
            this.CBShowData.AutoSize = true;
            this.CBShowData.ForeColor = System.Drawing.Color.White;
            this.CBShowData.Location = new System.Drawing.Point(22, 180);
            this.CBShowData.Name = "CBShowData";
            this.CBShowData.Size = new System.Drawing.Size(113, 17);
            this.CBShowData.TabIndex = 19;
            this.CBShowData.Text = "Show name on roll";
            this.CBShowData.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(600, 257);
            this.Controls.Add(this.CBShowData);
            this.Controls.Add(this.CBGestures);
            this.Controls.Add(this.CBConsumables);
            this.Controls.Add(this.CBRings);
            this.Controls.Add(this.CBMagics);
            this.Controls.Add(this.CBArmors);
            this.Controls.Add(this.CBWeapons);
            this.Controls.Add(this.BuShowData);
            this.Controls.Add(this.RTBHowToGetText);
            this.Controls.Add(this.LaItemName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PBItemDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "DS 1 Rng Item";
            ((System.ComponentModel.ISupportInitialize)(this.PBItemDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBItemDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LaItemName;
        private System.Windows.Forms.RichTextBox RTBHowToGetText;
        private System.Windows.Forms.Button BuShowData;
        private System.Windows.Forms.CheckBox CBWeapons;
        private System.Windows.Forms.CheckBox CBArmors;
        private System.Windows.Forms.CheckBox CBMagics;
        private System.Windows.Forms.CheckBox CBRings;
        private System.Windows.Forms.CheckBox CBConsumables;
        private System.Windows.Forms.CheckBox CBGestures;
        private System.Windows.Forms.CheckBox CBShowData;
    }
}

