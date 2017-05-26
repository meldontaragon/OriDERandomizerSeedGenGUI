namespace OriRandoSeedGeneratorGUI
{
    partial class SeedGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeedGen));
            this.cb_speed = new System.Windows.Forms.CheckBox();
            this.cb_lure = new System.Windows.Forms.CheckBox();
            this.cb_dboost = new System.Windows.Forms.CheckBox();
            this.cb_dbash = new System.Windows.Forms.CheckBox();
            this.cb_extended = new System.Windows.Forms.CheckBox();
            this.cb_timed = new System.Windows.Forms.CheckBox();
            this.cb_hard_lure = new System.Windows.Forms.CheckBox();
            this.cb_hard_dboost = new System.Windows.Forms.CheckBox();
            this.cb_glitched = new System.Windows.Forms.CheckBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.rb_casual = new System.Windows.Forms.RadioButton();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.rb_dboost = new System.Windows.Forms.RadioButton();
            this.rb_extend = new System.Windows.Forms.RadioButton();
            this.rb_hard = new System.Windows.Forms.RadioButton();
            this.rb_ohko = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_custom = new System.Windows.Forms.RadioButton();
            this.cb_mapstone = new System.Windows.Forms.CheckBox();
            this.cb_extra_pickups = new System.Windows.Forms.CheckBox();
            this.cb_plants = new System.Windows.Forms.CheckBox();
            this.rb_0xp = new System.Windows.Forms.RadioButton();
            this.rb_glitched = new System.Windows.Forms.RadioButton();
            this.cb_light_dboost = new System.Windows.Forms.CheckBox();
            this.cb_cdash = new System.Windows.Forms.CheckBox();
            this.cb_ext_dboost = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_hard = new System.Windows.Forms.CheckBox();
            this.cb_0xp = new System.Windows.Forms.CheckBox();
            this.cb_ohko = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric_seed_number = new System.Windows.Forms.NumericUpDown();
            this.numeric_seed_count = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.folder_browser = new System.Windows.Forms.FolderBrowserDialog();
            this.button_select_folder = new System.Windows.Forms.Button();
            this.text_box_directory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_seed_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_seed_count)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_speed
            // 
            this.cb_speed.AutoSize = true;
            this.cb_speed.Location = new System.Drawing.Point(164, 127);
            this.cb_speed.Name = "cb_speed";
            this.cb_speed.Size = new System.Drawing.Size(57, 17);
            this.cb_speed.TabIndex = 1;
            this.cb_speed.Text = "Speed";
            this.cb_speed.UseVisualStyleBackColor = true;
            // 
            // cb_lure
            // 
            this.cb_lure.AutoSize = true;
            this.cb_lure.Location = new System.Drawing.Point(164, 150);
            this.cb_lure.Name = "cb_lure";
            this.cb_lure.Size = new System.Drawing.Size(47, 17);
            this.cb_lure.TabIndex = 2;
            this.cb_lure.Text = "Lure";
            this.cb_lure.UseVisualStyleBackColor = true;
            // 
            // cb_dboost
            // 
            this.cb_dboost.AutoSize = true;
            this.cb_dboost.Location = new System.Drawing.Point(164, 173);
            this.cb_dboost.Name = "cb_dboost";
            this.cb_dboost.Size = new System.Drawing.Size(96, 17);
            this.cb_dboost.TabIndex = 3;
            this.cb_dboost.Text = "Damage Boost";
            this.cb_dboost.UseVisualStyleBackColor = true;
            // 
            // cb_dbash
            // 
            this.cb_dbash.AutoSize = true;
            this.cb_dbash.Location = new System.Drawing.Point(164, 196);
            this.cb_dbash.Name = "cb_dbash";
            this.cb_dbash.Size = new System.Drawing.Size(87, 17);
            this.cb_dbash.TabIndex = 4;
            this.cb_dbash.Text = "Double Bash";
            this.cb_dbash.UseVisualStyleBackColor = true;
            // 
            // cb_extended
            // 
            this.cb_extended.AutoSize = true;
            this.cb_extended.Location = new System.Drawing.Point(304, 104);
            this.cb_extended.Name = "cb_extended";
            this.cb_extended.Size = new System.Drawing.Size(71, 17);
            this.cb_extended.TabIndex = 5;
            this.cb_extended.Text = "Extended";
            this.cb_extended.UseVisualStyleBackColor = true;
            // 
            // cb_timed
            // 
            this.cb_timed.AutoSize = true;
            this.cb_timed.Location = new System.Drawing.Point(304, 150);
            this.cb_timed.Name = "cb_timed";
            this.cb_timed.Size = new System.Drawing.Size(84, 17);
            this.cb_timed.TabIndex = 6;
            this.cb_timed.Text = "Timed Level";
            this.cb_timed.UseVisualStyleBackColor = true;
            // 
            // cb_hard_lure
            // 
            this.cb_hard_lure.AutoSize = true;
            this.cb_hard_lure.Location = new System.Drawing.Point(304, 173);
            this.cb_hard_lure.Name = "cb_hard_lure";
            this.cb_hard_lure.Size = new System.Drawing.Size(73, 17);
            this.cb_hard_lure.TabIndex = 7;
            this.cb_hard_lure.Text = "Hard Lure";
            this.cb_hard_lure.UseVisualStyleBackColor = true;
            // 
            // cb_hard_dboost
            // 
            this.cb_hard_dboost.AutoSize = true;
            this.cb_hard_dboost.Location = new System.Drawing.Point(304, 195);
            this.cb_hard_dboost.Name = "cb_hard_dboost";
            this.cb_hard_dboost.Size = new System.Drawing.Size(122, 17);
            this.cb_hard_dboost.TabIndex = 8;
            this.cb_hard_dboost.Text = "Hard Damage Boost";
            this.cb_hard_dboost.UseVisualStyleBackColor = true;
            // 
            // cb_glitched
            // 
            this.cb_glitched.AutoSize = true;
            this.cb_glitched.Location = new System.Drawing.Point(304, 218);
            this.cb_glitched.Name = "cb_glitched";
            this.cb_glitched.Size = new System.Drawing.Size(65, 17);
            this.cb_glitched.TabIndex = 9;
            this.cb_glitched.Text = "Glitched";
            this.cb_glitched.UseVisualStyleBackColor = true;
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(342, 12);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(87, 23);
            this.button_generate.TabIndex = 11;
            this.button_generate.Text = "Generate Seed";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // rb_casual
            // 
            this.rb_casual.AutoSize = true;
            this.rb_casual.Checked = true;
            this.rb_casual.Location = new System.Drawing.Point(15, 103);
            this.rb_casual.Name = "rb_casual";
            this.rb_casual.Size = new System.Drawing.Size(57, 17);
            this.rb_casual.TabIndex = 12;
            this.rb_casual.TabStop = true;
            this.rb_casual.Text = "Casual";
            this.rb_casual.UseVisualStyleBackColor = true;
            this.rb_casual.CheckedChanged += new System.EventHandler(this.rb_casual_CheckedChanged);
            // 
            // rb_normal
            // 
            this.rb_normal.AutoSize = true;
            this.rb_normal.Location = new System.Drawing.Point(15, 126);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(58, 17);
            this.rb_normal.TabIndex = 13;
            this.rb_normal.Text = "Normal";
            this.rb_normal.UseVisualStyleBackColor = true;
            this.rb_normal.CheckedChanged += new System.EventHandler(this.rb_normal_CheckedChanged);
            // 
            // rb_dboost
            // 
            this.rb_dboost.AutoSize = true;
            this.rb_dboost.Location = new System.Drawing.Point(15, 149);
            this.rb_dboost.Name = "rb_dboost";
            this.rb_dboost.Size = new System.Drawing.Size(95, 17);
            this.rb_dboost.TabIndex = 14;
            this.rb_dboost.Text = "Damage Boost";
            this.rb_dboost.UseVisualStyleBackColor = true;
            this.rb_dboost.CheckedChanged += new System.EventHandler(this.rb_dboost_CheckedChanged);
            // 
            // rb_extend
            // 
            this.rb_extend.AutoSize = true;
            this.rb_extend.Location = new System.Drawing.Point(15, 172);
            this.rb_extend.Name = "rb_extend";
            this.rb_extend.Size = new System.Drawing.Size(70, 17);
            this.rb_extend.TabIndex = 15;
            this.rb_extend.Text = "Extended";
            this.rb_extend.UseVisualStyleBackColor = true;
            this.rb_extend.CheckedChanged += new System.EventHandler(this.rb_extend_CheckedChanged);
            // 
            // rb_hard
            // 
            this.rb_hard.AutoSize = true;
            this.rb_hard.Location = new System.Drawing.Point(15, 195);
            this.rb_hard.Name = "rb_hard";
            this.rb_hard.Size = new System.Drawing.Size(48, 17);
            this.rb_hard.TabIndex = 16;
            this.rb_hard.Text = "Hard";
            this.rb_hard.UseVisualStyleBackColor = true;
            this.rb_hard.CheckedChanged += new System.EventHandler(this.rb_hard_CheckedChanged);
            // 
            // rb_ohko
            // 
            this.rb_ohko.AutoSize = true;
            this.rb_ohko.Location = new System.Drawing.Point(15, 218);
            this.rb_ohko.Name = "rb_ohko";
            this.rb_ohko.Size = new System.Drawing.Size(56, 17);
            this.rb_ohko.TabIndex = 17;
            this.rb_ohko.Text = "OHKO";
            this.rb_ohko.UseVisualStyleBackColor = true;
            this.rb_ohko.CheckedChanged += new System.EventHandler(this.rb_ohko_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seed Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Logic Groups";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Logic Choices";
            // 
            // rb_custom
            // 
            this.rb_custom.AutoSize = true;
            this.rb_custom.Location = new System.Drawing.Point(15, 287);
            this.rb_custom.Name = "rb_custom";
            this.rb_custom.Size = new System.Drawing.Size(60, 17);
            this.rb_custom.TabIndex = 24;
            this.rb_custom.Text = "Custom";
            this.rb_custom.UseVisualStyleBackColor = true;
            this.rb_custom.CheckedChanged += new System.EventHandler(this.rb_custom_CheckedChanged);
            // 
            // cb_mapstone
            // 
            this.cb_mapstone.AutoSize = true;
            this.cb_mapstone.Checked = true;
            this.cb_mapstone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_mapstone.Enabled = false;
            this.cb_mapstone.Location = new System.Drawing.Point(164, 310);
            this.cb_mapstone.Name = "cb_mapstone";
            this.cb_mapstone.Size = new System.Drawing.Size(83, 17);
            this.cb_mapstone.TabIndex = 25;
            this.cb_mapstone.Text = "Map Stones";
            this.cb_mapstone.UseVisualStyleBackColor = true;
            // 
            // cb_extra_pickups
            // 
            this.cb_extra_pickups.AutoSize = true;
            this.cb_extra_pickups.Checked = true;
            this.cb_extra_pickups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_extra_pickups.Enabled = false;
            this.cb_extra_pickups.Location = new System.Drawing.Point(164, 287);
            this.cb_extra_pickups.Name = "cb_extra_pickups";
            this.cb_extra_pickups.Size = new System.Drawing.Size(91, 17);
            this.cb_extra_pickups.TabIndex = 26;
            this.cb_extra_pickups.Text = "Extra Pickups";
            this.cb_extra_pickups.UseVisualStyleBackColor = true;
            // 
            // cb_plants
            // 
            this.cb_plants.AutoSize = true;
            this.cb_plants.Checked = true;
            this.cb_plants.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_plants.Enabled = false;
            this.cb_plants.Location = new System.Drawing.Point(164, 264);
            this.cb_plants.Name = "cb_plants";
            this.cb_plants.Size = new System.Drawing.Size(96, 17);
            this.cb_plants.TabIndex = 27;
            this.cb_plants.Text = "Petrified Plants";
            this.cb_plants.UseVisualStyleBackColor = true;
            // 
            // rb_0xp
            // 
            this.rb_0xp.AutoSize = true;
            this.rb_0xp.Location = new System.Drawing.Point(15, 241);
            this.rb_0xp.Name = "rb_0xp";
            this.rb_0xp.Size = new System.Drawing.Size(64, 17);
            this.rb_0xp.TabIndex = 29;
            this.rb_0xp.Text = "Zero XP";
            this.rb_0xp.UseVisualStyleBackColor = true;
            this.rb_0xp.CheckedChanged += new System.EventHandler(this.rb_0xp_CheckedChanged);
            // 
            // rb_glitched
            // 
            this.rb_glitched.AutoSize = true;
            this.rb_glitched.Location = new System.Drawing.Point(15, 264);
            this.rb_glitched.Name = "rb_glitched";
            this.rb_glitched.Size = new System.Drawing.Size(64, 17);
            this.rb_glitched.TabIndex = 30;
            this.rb_glitched.Text = "Glitched";
            this.rb_glitched.UseVisualStyleBackColor = true;
            this.rb_glitched.CheckedChanged += new System.EventHandler(this.rb_glitched_CheckedChanged);
            // 
            // cb_light_dboost
            // 
            this.cb_light_dboost.AutoSize = true;
            this.cb_light_dboost.Checked = true;
            this.cb_light_dboost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_light_dboost.Location = new System.Drawing.Point(164, 104);
            this.cb_light_dboost.Name = "cb_light_dboost";
            this.cb_light_dboost.Size = new System.Drawing.Size(122, 17);
            this.cb_light_dboost.TabIndex = 31;
            this.cb_light_dboost.Text = "Light Damage Boost";
            this.cb_light_dboost.UseVisualStyleBackColor = true;
            // 
            // cb_cdash
            // 
            this.cb_cdash.AutoSize = true;
            this.cb_cdash.Location = new System.Drawing.Point(164, 219);
            this.cb_cdash.Name = "cb_cdash";
            this.cb_cdash.Size = new System.Drawing.Size(88, 17);
            this.cb_cdash.TabIndex = 32;
            this.cb_cdash.Text = "Charge Dash";
            this.cb_cdash.UseVisualStyleBackColor = true;
            // 
            // cb_ext_dboost
            // 
            this.cb_ext_dboost.AutoSize = true;
            this.cb_ext_dboost.Location = new System.Drawing.Point(304, 127);
            this.cb_ext_dboost.Name = "cb_ext_dboost";
            this.cb_ext_dboost.Size = new System.Drawing.Size(144, 17);
            this.cb_ext_dboost.TabIndex = 33;
            this.cb_ext_dboost.Text = "Extended Damage Boost";
            this.cb_ext_dboost.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Pickup Options";
            // 
            // cb_hard
            // 
            this.cb_hard.AutoSize = true;
            this.cb_hard.Enabled = false;
            this.cb_hard.Location = new System.Drawing.Point(304, 264);
            this.cb_hard.Name = "cb_hard";
            this.cb_hard.Size = new System.Drawing.Size(49, 17);
            this.cb_hard.TabIndex = 35;
            this.cb_hard.Text = "Hard";
            this.cb_hard.UseVisualStyleBackColor = true;
            // 
            // cb_0xp
            // 
            this.cb_0xp.AutoSize = true;
            this.cb_0xp.Enabled = false;
            this.cb_0xp.Location = new System.Drawing.Point(304, 310);
            this.cb_0xp.Name = "cb_0xp";
            this.cb_0xp.Size = new System.Drawing.Size(65, 17);
            this.cb_0xp.TabIndex = 36;
            this.cb_0xp.Text = "Zero XP";
            this.cb_0xp.UseVisualStyleBackColor = true;
            // 
            // cb_ohko
            // 
            this.cb_ohko.AutoSize = true;
            this.cb_ohko.Enabled = false;
            this.cb_ohko.Location = new System.Drawing.Point(304, 287);
            this.cb_ohko.Name = "cb_ohko";
            this.cb_ohko.Size = new System.Drawing.Size(57, 17);
            this.cb_ohko.TabIndex = 37;
            this.cb_ohko.Text = "OHKO";
            this.cb_ohko.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Challenge Options";
            // 
            // numeric_seed_number
            // 
            this.numeric_seed_number.Location = new System.Drawing.Point(90, 12);
            this.numeric_seed_number.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numeric_seed_number.Name = "numeric_seed_number";
            this.numeric_seed_number.Size = new System.Drawing.Size(121, 20);
            this.numeric_seed_number.TabIndex = 39;
            // 
            // numeric_seed_count
            // 
            this.numeric_seed_count.Location = new System.Drawing.Point(286, 12);
            this.numeric_seed_count.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_seed_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_seed_count.Name = "numeric_seed_count";
            this.numeric_seed_count.Size = new System.Drawing.Size(50, 20);
            this.numeric_seed_count.TabIndex = 40;
            this.numeric_seed_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Seed Count";
            // 
            // button_select_folder
            // 
            this.button_select_folder.Location = new System.Drawing.Point(342, 47);
            this.button_select_folder.Name = "button_select_folder";
            this.button_select_folder.Size = new System.Drawing.Size(87, 23);
            this.button_select_folder.TabIndex = 42;
            this.button_select_folder.Text = "Select Folder";
            this.button_select_folder.UseVisualStyleBackColor = true;
            this.button_select_folder.Click += new System.EventHandler(this.button_select_folder_Click);
            // 
            // text_box_directory
            // 
            this.text_box_directory.Location = new System.Drawing.Point(15, 40);
            this.text_box_directory.Multiline = true;
            this.text_box_directory.Name = "text_box_directory";
            this.text_box_directory.ReadOnly = true;
            this.text_box_directory.Size = new System.Drawing.Size(321, 36);
            this.text_box_directory.TabIndex = 43;
            // 
            // SeedGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 341);
            this.Controls.Add(this.text_box_directory);
            this.Controls.Add(this.button_select_folder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeric_seed_count);
            this.Controls.Add(this.numeric_seed_number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_ohko);
            this.Controls.Add(this.cb_0xp);
            this.Controls.Add(this.cb_hard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_ext_dboost);
            this.Controls.Add(this.cb_cdash);
            this.Controls.Add(this.cb_light_dboost);
            this.Controls.Add(this.rb_glitched);
            this.Controls.Add(this.rb_0xp);
            this.Controls.Add(this.cb_plants);
            this.Controls.Add(this.cb_extra_pickups);
            this.Controls.Add(this.cb_mapstone);
            this.Controls.Add(this.rb_custom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_ohko);
            this.Controls.Add(this.rb_hard);
            this.Controls.Add(this.rb_extend);
            this.Controls.Add(this.rb_dboost);
            this.Controls.Add(this.rb_normal);
            this.Controls.Add(this.rb_casual);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.cb_glitched);
            this.Controls.Add(this.cb_hard_dboost);
            this.Controls.Add(this.cb_hard_lure);
            this.Controls.Add(this.cb_timed);
            this.Controls.Add(this.cb_extended);
            this.Controls.Add(this.cb_dbash);
            this.Controls.Add(this.cb_dboost);
            this.Controls.Add(this.cb_lure);
            this.Controls.Add(this.cb_speed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(469, 380);
            this.MinimumSize = new System.Drawing.Size(469, 380);
            this.Name = "SeedGen";
            this.Text = "Ori DE Rando: Seed Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_seed_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_seed_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cb_speed;
        private System.Windows.Forms.CheckBox cb_lure;
        private System.Windows.Forms.CheckBox cb_dboost;
        private System.Windows.Forms.CheckBox cb_dbash;
        private System.Windows.Forms.CheckBox cb_extended;
        private System.Windows.Forms.CheckBox cb_timed;
        private System.Windows.Forms.CheckBox cb_hard_lure;
        private System.Windows.Forms.CheckBox cb_hard_dboost;
        private System.Windows.Forms.CheckBox cb_glitched;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.RadioButton rb_casual;
        private System.Windows.Forms.RadioButton rb_normal;
        private System.Windows.Forms.RadioButton rb_dboost;
        private System.Windows.Forms.RadioButton rb_extend;
        private System.Windows.Forms.RadioButton rb_hard;
        private System.Windows.Forms.RadioButton rb_ohko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_custom;
        private System.Windows.Forms.CheckBox cb_mapstone;
        private System.Windows.Forms.CheckBox cb_extra_pickups;
        private System.Windows.Forms.CheckBox cb_plants;
        private System.Windows.Forms.RadioButton rb_0xp;
        private System.Windows.Forms.RadioButton rb_glitched;
        private System.Windows.Forms.CheckBox cb_light_dboost;
        private System.Windows.Forms.CheckBox cb_cdash;
        private System.Windows.Forms.CheckBox cb_ext_dboost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_hard;
        private System.Windows.Forms.CheckBox cb_0xp;
        private System.Windows.Forms.CheckBox cb_ohko;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numeric_seed_number;
        private System.Windows.Forms.NumericUpDown numeric_seed_count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folder_browser;
        private System.Windows.Forms.Button button_select_folder;
        private System.Windows.Forms.TextBox text_box_directory;
    }
}

