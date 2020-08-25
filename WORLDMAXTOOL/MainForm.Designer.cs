namespace WORLDMAXTOOL
{
    partial class MainForm
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
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.panelData = new System.Windows.Forms.Panel();
            this.numAvatar = new System.Windows.Forms.NumericUpDown();
            this.btnSerial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentMileage = new System.Windows.Forms.TextBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentMission = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCurrentLand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToolCRC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAMCRC = new System.Windows.Forms.TextBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.groupCheat = new System.Windows.Forms.GroupBox();
            this.ckRootinia = new System.Windows.Forms.CheckBox();
            this.ckPortal = new System.Windows.Forms.CheckBox();
            this.ckClear = new System.Windows.Forms.CheckBox();
            this.ckPath = new System.Windows.Forms.CheckBox();
            this.btnMission = new System.Windows.Forms.Button();
            this.ckMileage = new System.Windows.Forms.CheckBox();
            this.ckBarrier = new System.Windows.Forms.CheckBox();
            this.ckItem = new System.Windows.Forms.CheckBox();
            this.ckPandonus = new System.Windows.Forms.CheckBox();
            this.ckPhantomia = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupItem = new System.Windows.Forms.GroupBox();
            this.ck30Time = new System.Windows.Forms.CheckBox();
            this.ckBGAOFF = new System.Windows.Forms.CheckBox();
            this.ckShield = new System.Windows.Forms.CheckBox();
            this.groupInfo.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.groupCheat.SuspendLayout();
            this.groupItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.panelData);
            this.groupInfo.Controls.Add(this.btnPick);
            this.groupInfo.Location = new System.Drawing.Point(13, 13);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(326, 291);
            this.groupInfo.TabIndex = 0;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "My Info";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.numAvatar);
            this.panelData.Controls.Add(this.btnSerial);
            this.panelData.Controls.Add(this.label1);
            this.panelData.Controls.Add(this.txtCurrentMileage);
            this.panelData.Controls.Add(this.picAvatar);
            this.panelData.Controls.Add(this.label8);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Controls.Add(this.txtCurrentMission);
            this.panelData.Controls.Add(this.txtName);
            this.panelData.Controls.Add(this.txtCurrentLand);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.label7);
            this.panelData.Controls.Add(this.txtSerial);
            this.panelData.Controls.Add(this.label6);
            this.panelData.Controls.Add(this.label4);
            this.panelData.Controls.Add(this.txtToolCRC);
            this.panelData.Controls.Add(this.label5);
            this.panelData.Controls.Add(this.txtAMCRC);
            this.panelData.Enabled = false;
            this.panelData.Location = new System.Drawing.Point(6, 51);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(314, 236);
            this.panelData.TabIndex = 17;
            // 
            // numAvatar
            // 
            this.numAvatar.Location = new System.Drawing.Point(57, 4);
            this.numAvatar.Maximum = new decimal(new int[] {
            216,
            0,
            0,
            0});
            this.numAvatar.Name = "numAvatar";
            this.numAvatar.Size = new System.Drawing.Size(54, 20);
            this.numAvatar.TabIndex = 18;
            this.numAvatar.ValueChanged += new System.EventHandler(this.numAvatar_ValueChanged);
            // 
            // btnSerial
            // 
            this.btnSerial.Location = new System.Drawing.Point(281, 52);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(20, 20);
            this.btnSerial.TabIndex = 17;
            this.btnSerial.Text = "?";
            this.btnSerial.UseVisualStyleBackColor = true;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avatar";
            // 
            // txtCurrentMileage
            // 
            this.txtCurrentMileage.Location = new System.Drawing.Point(107, 204);
            this.txtCurrentMileage.Name = "txtCurrentMileage";
            this.txtCurrentMileage.ReadOnly = true;
            this.txtCurrentMileage.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentMileage.TabIndex = 16;
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(15, 25);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(96, 96);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Current Mileage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtCurrentMission
            // 
            this.txtCurrentMission.Location = new System.Drawing.Point(107, 180);
            this.txtCurrentMission.Name = "txtCurrentMission";
            this.txtCurrentMission.ReadOnly = true;
            this.txtCurrentMission.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentMission.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 25);
            this.txtName.MaxLength = 8;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtCurrentLand
            // 
            this.txtCurrentLand.Location = new System.Drawing.Point(107, 156);
            this.txtCurrentLand.Name = "txtCurrentLand";
            this.txtCurrentLand.ReadOnly = true;
            this.txtCurrentLand.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentLand.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "CurrentMission";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(162, 52);
            this.txtSerial.MaxLength = 24;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(117, 20);
            this.txtSerial.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CurrentLand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Andamiro CRC";
            // 
            // txtToolCRC
            // 
            this.txtToolCRC.Location = new System.Drawing.Point(204, 105);
            this.txtToolCRC.Name = "txtToolCRC";
            this.txtToolCRC.ReadOnly = true;
            this.txtToolCRC.Size = new System.Drawing.Size(100, 20);
            this.txtToolCRC.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ReHash CRC";
            // 
            // txtAMCRC
            // 
            this.txtAMCRC.Location = new System.Drawing.Point(204, 78);
            this.txtAMCRC.Name = "txtAMCRC";
            this.txtAMCRC.ReadOnly = true;
            this.txtAMCRC.Size = new System.Drawing.Size(100, 20);
            this.txtAMCRC.TabIndex = 9;
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(18, 22);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 6;
            this.btnPick.Text = "Pick Data";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // groupCheat
            // 
            this.groupCheat.Controls.Add(this.ckRootinia);
            this.groupCheat.Controls.Add(this.ckPortal);
            this.groupCheat.Controls.Add(this.ckClear);
            this.groupCheat.Controls.Add(this.ckPath);
            this.groupCheat.Controls.Add(this.btnMission);
            this.groupCheat.Controls.Add(this.ckMileage);
            this.groupCheat.Controls.Add(this.ckBarrier);
            this.groupCheat.Controls.Add(this.ckItem);
            this.groupCheat.Controls.Add(this.ckPandonus);
            this.groupCheat.Controls.Add(this.ckPhantomia);
            this.groupCheat.Enabled = false;
            this.groupCheat.Location = new System.Drawing.Point(345, 13);
            this.groupCheat.Name = "groupCheat";
            this.groupCheat.Size = new System.Drawing.Size(267, 291);
            this.groupCheat.TabIndex = 1;
            this.groupCheat.TabStop = false;
            this.groupCheat.Text = "Cheat Info";
            // 
            // ckRootinia
            // 
            this.ckRootinia.AutoSize = true;
            this.ckRootinia.Location = new System.Drawing.Point(16, 157);
            this.ckRootinia.Name = "ckRootinia";
            this.ckRootinia.Size = new System.Drawing.Size(186, 17);
            this.ckRootinia.TabIndex = 9;
            this.ckRootinia.Text = "Go back rootinia!(one time check)";
            this.ckRootinia.UseVisualStyleBackColor = true;
            this.ckRootinia.CheckedChanged += new System.EventHandler(this.CkRootinia_CheckedChanged);
            // 
            // ckPortal
            // 
            this.ckPortal.AutoSize = true;
            this.ckPortal.Location = new System.Drawing.Point(16, 134);
            this.ckPortal.Name = "ckPortal";
            this.ckPortal.Size = new System.Drawing.Size(175, 17);
            this.ckPortal.TabIndex = 8;
            this.ckPortal.Text = "All Portal Open(one time check)";
            this.ckPortal.UseVisualStyleBackColor = true;
            this.ckPortal.CheckedChanged += new System.EventHandler(this.ckPortal_CheckedChanged);
            // 
            // ckClear
            // 
            this.ckClear.AutoSize = true;
            this.ckClear.Location = new System.Drawing.Point(16, 231);
            this.ckClear.Name = "ckClear";
            this.ckClear.Size = new System.Drawing.Size(181, 17);
            this.ckClear.TabIndex = 7;
            this.ckClear.Text = "All Mission Clear(one time check)";
            this.ckClear.UseVisualStyleBackColor = true;
            this.ckClear.CheckedChanged += new System.EventHandler(this.ckClear_CheckedChanged);
            // 
            // ckPath
            // 
            this.ckPath.AutoSize = true;
            this.ckPath.Location = new System.Drawing.Point(16, 208);
            this.ckPath.Name = "ckPath";
            this.ckPath.Size = new System.Drawing.Size(179, 17);
            this.ckPath.TabIndex = 6;
            this.ckPath.Text = "All Mission Path(one time check)";
            this.ckPath.UseVisualStyleBackColor = true;
            this.ckPath.CheckedChanged += new System.EventHandler(this.ckPath_CheckedChanged);
            // 
            // btnMission
            // 
            this.btnMission.Location = new System.Drawing.Point(16, 255);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(135, 23);
            this.btnMission.TabIndex = 5;
            this.btnMission.Text = "Review Mission >>>>";
            this.btnMission.UseVisualStyleBackColor = true;
            this.btnMission.Click += new System.EventHandler(this.btnMission_Click);
            // 
            // ckMileage
            // 
            this.ckMileage.AutoSize = true;
            this.ckMileage.Location = new System.Drawing.Point(16, 111);
            this.ckMileage.Name = "ckMileage";
            this.ckMileage.Size = new System.Drawing.Size(175, 17);
            this.ckMileage.TabIndex = 4;
            this.ckMileage.Text = "99999 Mileage(one time check)";
            this.ckMileage.UseVisualStyleBackColor = true;
            this.ckMileage.CheckedChanged += new System.EventHandler(this.ckMileage_CheckedChanged);
            // 
            // ckBarrier
            // 
            this.ckBarrier.AutoSize = true;
            this.ckBarrier.Location = new System.Drawing.Point(16, 88);
            this.ckBarrier.Name = "ckBarrier";
            this.ckBarrier.Size = new System.Drawing.Size(149, 17);
            this.ckBarrier.TabIndex = 3;
            this.ckBarrier.Text = "All Barrier(one time check)";
            this.ckBarrier.UseVisualStyleBackColor = true;
            this.ckBarrier.CheckedChanged += new System.EventHandler(this.ckBarrier_CheckedChanged);
            // 
            // ckItem
            // 
            this.ckItem.AutoSize = true;
            this.ckItem.Location = new System.Drawing.Point(16, 65);
            this.ckItem.Name = "ckItem";
            this.ckItem.Size = new System.Drawing.Size(169, 17);
            this.ckItem.TabIndex = 2;
            this.ckItem.Text = "All Arrow Item(one time check)";
            this.ckItem.UseVisualStyleBackColor = true;
            this.ckItem.CheckedChanged += new System.EventHandler(this.ckItem_CheckedChanged);
            // 
            // ckPandonus
            // 
            this.ckPandonus.AutoSize = true;
            this.ckPandonus.Location = new System.Drawing.Point(16, 42);
            this.ckPandonus.Name = "ckPandonus";
            this.ckPandonus.Size = new System.Drawing.Size(109, 17);
            this.ckPandonus.TabIndex = 1;
            this.ckPandonus.Text = "Pandonus Switch";
            this.ckPandonus.UseVisualStyleBackColor = true;
            // 
            // ckPhantomia
            // 
            this.ckPhantomia.AutoSize = true;
            this.ckPhantomia.Location = new System.Drawing.Point(16, 19);
            this.ckPhantomia.Name = "ckPhantomia";
            this.ckPhantomia.Size = new System.Drawing.Size(111, 17);
            this.ckPhantomia.TabIndex = 0;
            this.ckPhantomia.Text = "Phantomia Switch";
            this.ckPhantomia.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(345, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(267, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Profile";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupItem
            // 
            this.groupItem.Controls.Add(this.ckShield);
            this.groupItem.Controls.Add(this.ckBGAOFF);
            this.groupItem.Controls.Add(this.ck30Time);
            this.groupItem.Enabled = false;
            this.groupItem.Location = new System.Drawing.Point(13, 310);
            this.groupItem.Name = "groupItem";
            this.groupItem.Size = new System.Drawing.Size(326, 65);
            this.groupItem.TabIndex = 3;
            this.groupItem.TabStop = false;
            this.groupItem.Text = "Item";
            // 
            // ck30Time
            // 
            this.ck30Time.AutoSize = true;
            this.ck30Time.Location = new System.Drawing.Point(143, 41);
            this.ck30Time.Name = "ck30Time";
            this.ck30Time.Size = new System.Drawing.Size(70, 17);
            this.ck30Time.TabIndex = 10;
            this.ck30Time.Text = "+30 Time";
            this.ck30Time.UseVisualStyleBackColor = true;
            // 
            // ckBGAOFF
            // 
            this.ckBGAOFF.AutoSize = true;
            this.ckBGAOFF.Location = new System.Drawing.Point(23, 41);
            this.ckBGAOFF.Name = "ckBGAOFF";
            this.ckBGAOFF.Size = new System.Drawing.Size(113, 17);
            this.ckBGAOFF.TabIndex = 11;
            this.ckBGAOFF.Text = "BGA OFF(for ever)";
            this.ckBGAOFF.UseVisualStyleBackColor = true;
            // 
            // ckShield
            // 
            this.ckShield.AutoSize = true;
            this.ckShield.Location = new System.Drawing.Point(143, 18);
            this.ckShield.Name = "ckShield";
            this.ckShield.Size = new System.Drawing.Size(97, 17);
            this.ckShield.TabIndex = 12;
            this.ckShield.Text = "Shield(for ever)";
            this.ckShield.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 387);
            this.Controls.Add(this.groupItem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupCheat);
            this.Controls.Add(this.groupInfo);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupInfo.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.groupCheat.ResumeLayout(false);
            this.groupCheat.PerformLayout();
            this.groupItem.ResumeLayout(false);
            this.groupItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToolCRC;
        private System.Windows.Forms.TextBox txtAMCRC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentMission;
        private System.Windows.Forms.TextBox txtCurrentLand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurrentMileage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupCheat;
        private System.Windows.Forms.Button btnMission;
        private System.Windows.Forms.CheckBox ckMileage;
        private System.Windows.Forms.CheckBox ckBarrier;
        private System.Windows.Forms.CheckBox ckItem;
        private System.Windows.Forms.CheckBox ckPandonus;
        private System.Windows.Forms.CheckBox ckPhantomia;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ckClear;
        private System.Windows.Forms.CheckBox ckPath;
        private System.Windows.Forms.CheckBox ckPortal;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.NumericUpDown numAvatar;
        private System.Windows.Forms.CheckBox ckRootinia;
        private System.Windows.Forms.GroupBox groupItem;
        private System.Windows.Forms.CheckBox ck30Time;
        private System.Windows.Forms.CheckBox ckShield;
        private System.Windows.Forms.CheckBox ckBGAOFF;
    }
}

