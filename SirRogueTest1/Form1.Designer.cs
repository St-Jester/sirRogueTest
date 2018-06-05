namespace SirRogueTest1
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
            this.components = new System.ComponentModel.Container();
            this.PlayerAvatar = new System.Windows.Forms.PictureBox();
            this.HpLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.StaminaLabel = new System.Windows.Forms.Label();
            this.DamageLabel = new System.Windows.Forms.Label();
            this.TestBonus = new System.Windows.Forms.Button();
            this.TavernButton = new System.Windows.Forms.Button();
            this.StartQuestButton = new System.Windows.Forms.Button();
            this.ItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ItemNameTEMPLabel = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.TavernTimer = new System.Windows.Forms.Timer(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.PlayerAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerAvatar
            // 
            this.PlayerAvatar.Location = new System.Drawing.Point(7, 23);
            this.PlayerAvatar.Name = "PlayerAvatar";
            this.PlayerAvatar.Size = new System.Drawing.Size(73, 138);
            this.PlayerAvatar.TabIndex = 0;
            this.PlayerAvatar.TabStop = false;
            // 
            // HpLabel
            // 
            this.HpLabel.AutoSize = true;
            this.HpLabel.Location = new System.Drawing.Point(113, 61);
            this.HpLabel.Name = "HpLabel";
            this.HpLabel.Size = new System.Drawing.Size(22, 23);
            this.HpLabel.TabIndex = 1;
            this.HpLabel.Text = "Hp";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(7, 194);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(180, 185);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // StaminaLabel
            // 
            this.StaminaLabel.AutoSize = true;
            this.StaminaLabel.Location = new System.Drawing.Point(113, 84);
            this.StaminaLabel.Name = "StaminaLabel";
            this.StaminaLabel.Size = new System.Drawing.Size(45, 23);
            this.StaminaLabel.TabIndex = 1;
            this.StaminaLabel.Text = "Stamina";
            // 
            // DamageLabel
            // 
            this.DamageLabel.AutoSize = true;
            this.DamageLabel.Location = new System.Drawing.Point(113, 107);
            this.DamageLabel.Name = "DamageLabel";
            this.DamageLabel.Size = new System.Drawing.Size(44, 23);
            this.DamageLabel.TabIndex = 1;
            this.DamageLabel.Text = "Damage";
            // 
            // TestBonus
            // 
            this.TestBonus.Location = new System.Drawing.Point(329, 226);
            this.TestBonus.Name = "TestBonus";
            this.TestBonus.Size = new System.Drawing.Size(64, 29);
            this.TestBonus.TabIndex = 4;
            this.TestBonus.Text = "BonusButton";
            this.TestBonus.UseVisualStyleBackColor = true;
            this.TestBonus.Click += new System.EventHandler(this.TestBonus_Click);
            // 
            // TavernButton
            // 
            this.TavernButton.Location = new System.Drawing.Point(254, 32);
            this.TavernButton.Name = "TavernButton";
            this.TavernButton.Size = new System.Drawing.Size(53, 43);
            this.TavernButton.TabIndex = 5;
            this.TavernButton.Text = "Tavern";
            this.TavernButton.UseVisualStyleBackColor = true;
            this.TavernButton.Click += new System.EventHandler(this.TavernButton_Click);
            // 
            // StartQuestButton
            // 
            this.StartQuestButton.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.StartQuestButton.Location = new System.Drawing.Point(189, 32);
            this.StartQuestButton.Margin = new System.Windows.Forms.Padding(0);
            this.StartQuestButton.Name = "StartQuestButton";
            this.StartQuestButton.Size = new System.Drawing.Size(59, 52);
            this.StartQuestButton.TabIndex = 3;
            this.StartQuestButton.Text = "Get Quest";
            this.StartQuestButton.UseVisualStyleBackColor = true;
            this.StartQuestButton.Click += new System.EventHandler(this.StartQuestButton_Click);
            // 
            // ItemButton
            // 
            this.ItemButton.Location = new System.Drawing.Point(254, 167);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(74, 29);
            this.ItemButton.TabIndex = 3;
            this.ItemButton.Text = "Get Item";
            this.ItemButton.UseVisualStyleBackColor = true;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(349, 167);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(74, 33);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ItemNameTEMPLabel
            // 
            this.ItemNameTEMPLabel.AutoSize = true;
            this.ItemNameTEMPLabel.Location = new System.Drawing.Point(112, 138);
            this.ItemNameTEMPLabel.Name = "ItemNameTEMPLabel";
            this.ItemNameTEMPLabel.Size = new System.Drawing.Size(75, 23);
            this.ItemNameTEMPLabel.TabIndex = 1;
            this.ItemNameTEMPLabel.Text = "ItemNameTEMP";
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Location = new System.Drawing.Point(345, 47);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(37, 23);
            this.MoneyLabel.TabIndex = 6;
            this.MoneyLabel.Text = "Money";
            // 
            // TavernTimer
            // 
            this.TavernTimer.Interval = 2000;
            this.TavernTimer.Tick += new System.EventHandler(this.TavernTimer_Tick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Text";
            this.columnHeader2.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 407);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.TavernButton);
            this.Controls.Add(this.TestBonus);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.ItemButton);
            this.Controls.Add(this.StartQuestButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ItemNameTEMPLabel);
            this.Controls.Add(this.DamageLabel);
            this.Controls.Add(this.StaminaLabel);
            this.Controls.Add(this.HpLabel);
            this.Controls.Add(this.PlayerAvatar);
            this.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "SirRogue";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerAvatar;
        private System.Windows.Forms.Label HpLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label StaminaLabel;
        private System.Windows.Forms.Label DamageLabel;
        private System.Windows.Forms.Button TestBonus;
        private System.Windows.Forms.Button TavernButton;
        private System.Windows.Forms.Button StartQuestButton;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Label ItemNameTEMPLabel;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Timer TavernTimer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

