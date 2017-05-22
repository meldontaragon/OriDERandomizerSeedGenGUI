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
            this.cb_casual = new System.Windows.Forms.CheckBox();
            this.cb_speed = new System.Windows.Forms.CheckBox();
            this.cb_lure = new System.Windows.Forms.CheckBox();
            this.cb_dboost = new System.Windows.Forms.CheckBox();
            this.cb_dbash = new System.Windows.Forms.CheckBox();
            this.cb_challenge = new System.Windows.Forms.CheckBox();
            this.cb_timed = new System.Windows.Forms.CheckBox();
            this.cb_hard_lure = new System.Windows.Forms.CheckBox();
            this.cb_hard_dboost = new System.Windows.Forms.CheckBox();
            this.cb_glitched = new System.Windows.Forms.CheckBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.rb_casual = new System.Windows.Forms.RadioButton();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.rb_dboost = new System.Windows.Forms.RadioButton();
            this.rb_hard = new System.Windows.Forms.RadioButton();
            this.rb_masochist = new System.Windows.Forms.RadioButton();
            this.rb_glitched = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.text_seed_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_custom = new System.Windows.Forms.RadioButton();
            this.cb_mapstone = new System.Windows.Forms.CheckBox();
            this.cb_extra_pickups = new System.Windows.Forms.CheckBox();
            this.cb_plants = new System.Windows.Forms.CheckBox();
            this.cb_softlock = new System.Windows.Forms.CheckBox();
            this.cb_spoiler = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_casual
            // 
            this.cb_casual.AutoSize = true;
            this.cb_casual.Checked = true;
            this.cb_casual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_casual.Enabled = false;
            this.cb_casual.Location = new System.Drawing.Point(160, 63);
            this.cb_casual.Name = "cb_casual";
            this.cb_casual.Size = new System.Drawing.Size(58, 17);
            this.cb_casual.TabIndex = 0;
            this.cb_casual.Text = "Casual";
            this.cb_casual.UseVisualStyleBackColor = true;
            // 
            // cb_speed
            // 
            this.cb_speed.AutoSize = true;
            this.cb_speed.Location = new System.Drawing.Point(160, 87);
            this.cb_speed.Name = "cb_speed";
            this.cb_speed.Size = new System.Drawing.Size(57, 17);
            this.cb_speed.TabIndex = 1;
            this.cb_speed.Text = "Speed";
            this.cb_speed.UseVisualStyleBackColor = true;
            this.cb_speed.CheckedChanged += new System.EventHandler(this.cb_speed_CheckedChanged);
            // 
            // cb_lure
            // 
            this.cb_lure.AutoSize = true;
            this.cb_lure.Location = new System.Drawing.Point(160, 110);
            this.cb_lure.Name = "cb_lure";
            this.cb_lure.Size = new System.Drawing.Size(47, 17);
            this.cb_lure.TabIndex = 2;
            this.cb_lure.Text = "Lure";
            this.cb_lure.UseVisualStyleBackColor = true;
            this.cb_lure.CheckedChanged += new System.EventHandler(this.cb_lure_CheckedChanged);
            // 
            // cb_dboost
            // 
            this.cb_dboost.AutoSize = true;
            this.cb_dboost.Location = new System.Drawing.Point(160, 133);
            this.cb_dboost.Name = "cb_dboost";
            this.cb_dboost.Size = new System.Drawing.Size(96, 17);
            this.cb_dboost.TabIndex = 3;
            this.cb_dboost.Text = "Damage Boost";
            this.cb_dboost.UseVisualStyleBackColor = true;
            this.cb_dboost.CheckedChanged += new System.EventHandler(this.cb_dboost_CheckedChanged);
            // 
            // cb_dbash
            // 
            this.cb_dbash.AutoSize = true;
            this.cb_dbash.Location = new System.Drawing.Point(160, 156);
            this.cb_dbash.Name = "cb_dbash";
            this.cb_dbash.Size = new System.Drawing.Size(87, 17);
            this.cb_dbash.TabIndex = 4;
            this.cb_dbash.Text = "Double Bash";
            this.cb_dbash.UseVisualStyleBackColor = true;
            this.cb_dbash.CheckedChanged += new System.EventHandler(this.cb_dbash_CheckedChanged);
            // 
            // cb_challenge
            // 
            this.cb_challenge.AutoSize = true;
            this.cb_challenge.Location = new System.Drawing.Point(262, 63);
            this.cb_challenge.Name = "cb_challenge";
            this.cb_challenge.Size = new System.Drawing.Size(73, 17);
            this.cb_challenge.TabIndex = 5;
            this.cb_challenge.Text = "Challenge";
            this.cb_challenge.UseVisualStyleBackColor = true;
            this.cb_challenge.CheckedChanged += new System.EventHandler(this.cb_challenge_CheckedChanged);
            // 
            // cb_timed
            // 
            this.cb_timed.AutoSize = true;
            this.cb_timed.Location = new System.Drawing.Point(262, 86);
            this.cb_timed.Name = "cb_timed";
            this.cb_timed.Size = new System.Drawing.Size(84, 17);
            this.cb_timed.TabIndex = 6;
            this.cb_timed.Text = "Timed Level";
            this.cb_timed.UseVisualStyleBackColor = true;
            this.cb_timed.CheckedChanged += new System.EventHandler(this.cb_timed_CheckedChanged);
            // 
            // cb_hard_lure
            // 
            this.cb_hard_lure.AutoSize = true;
            this.cb_hard_lure.Location = new System.Drawing.Point(262, 109);
            this.cb_hard_lure.Name = "cb_hard_lure";
            this.cb_hard_lure.Size = new System.Drawing.Size(73, 17);
            this.cb_hard_lure.TabIndex = 7;
            this.cb_hard_lure.Text = "Hard Lure";
            this.cb_hard_lure.UseVisualStyleBackColor = true;
            this.cb_hard_lure.CheckedChanged += new System.EventHandler(this.cb_hard_lure_CheckedChanged);
            // 
            // cb_hard_dboost
            // 
            this.cb_hard_dboost.AutoSize = true;
            this.cb_hard_dboost.Location = new System.Drawing.Point(262, 133);
            this.cb_hard_dboost.Name = "cb_hard_dboost";
            this.cb_hard_dboost.Size = new System.Drawing.Size(122, 17);
            this.cb_hard_dboost.TabIndex = 8;
            this.cb_hard_dboost.Text = "Hard Damage Boost";
            this.cb_hard_dboost.UseVisualStyleBackColor = true;
            this.cb_hard_dboost.CheckedChanged += new System.EventHandler(this.cb_hard_dboost_CheckedChanged);
            // 
            // cb_glitched
            // 
            this.cb_glitched.AutoSize = true;
            this.cb_glitched.Location = new System.Drawing.Point(262, 156);
            this.cb_glitched.Name = "cb_glitched";
            this.cb_glitched.Size = new System.Drawing.Size(65, 17);
            this.cb_glitched.TabIndex = 9;
            this.cb_glitched.Text = "Glitched";
            this.cb_glitched.UseVisualStyleBackColor = true;
            this.cb_glitched.CheckedChanged += new System.EventHandler(this.cb_ability_CheckedChanged);
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(201, 4);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(75, 23);
            this.button_generate.TabIndex = 11;
            this.button_generate.Text = "Generate Seed";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // rb_casual
            // 
            this.rb_casual.AutoSize = true;
            this.rb_casual.Checked = true;
            this.rb_casual.Location = new System.Drawing.Point(12, 63);
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
            this.rb_normal.Location = new System.Drawing.Point(12, 86);
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
            this.rb_dboost.Location = new System.Drawing.Point(12, 109);
            this.rb_dboost.Name = "rb_dboost";
            this.rb_dboost.Size = new System.Drawing.Size(95, 17);
            this.rb_dboost.TabIndex = 14;
            this.rb_dboost.Text = "Damage Boost";
            this.rb_dboost.UseVisualStyleBackColor = true;
            this.rb_dboost.CheckedChanged += new System.EventHandler(this.rb_dboost_CheckedChanged);
            // 
            // rb_hard
            // 
            this.rb_hard.AutoSize = true;
            this.rb_hard.Location = new System.Drawing.Point(12, 132);
            this.rb_hard.Name = "rb_hard";
            this.rb_hard.Size = new System.Drawing.Size(48, 17);
            this.rb_hard.TabIndex = 15;
            this.rb_hard.Text = "Hard";
            this.rb_hard.UseVisualStyleBackColor = true;
            this.rb_hard.CheckedChanged += new System.EventHandler(this.rb_hard_CheckedChanged);
            // 
            // rb_masochist
            // 
            this.rb_masochist.AutoSize = true;
            this.rb_masochist.Location = new System.Drawing.Point(12, 155);
            this.rb_masochist.Name = "rb_masochist";
            this.rb_masochist.Size = new System.Drawing.Size(73, 17);
            this.rb_masochist.TabIndex = 16;
            this.rb_masochist.Text = "Masochist";
            this.rb_masochist.UseVisualStyleBackColor = true;
            this.rb_masochist.CheckedChanged += new System.EventHandler(this.rb_masochist_CheckedChanged);
            // 
            // rb_glitched
            // 
            this.rb_glitched.AutoSize = true;
            this.rb_glitched.Location = new System.Drawing.Point(12, 178);
            this.rb_glitched.Name = "rb_glitched";
            this.rb_glitched.Size = new System.Drawing.Size(64, 17);
            this.rb_glitched.TabIndex = 17;
            this.rb_glitched.Text = "Glitched";
            this.rb_glitched.UseVisualStyleBackColor = true;
            this.rb_glitched.CheckedChanged += new System.EventHandler(this.rb_glitched_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seed Number";
            // 
            // text_seed_input
            // 
            this.text_seed_input.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.text_seed_input.Location = new System.Drawing.Point(90, 6);
            this.text_seed_input.MaxLength = 10;
            this.text_seed_input.Name = "text_seed_input";
            this.text_seed_input.Size = new System.Drawing.Size(100, 20);
            this.text_seed_input.TabIndex = 20;
            this.text_seed_input.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Logic Groups";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Logic Choices";
            // 
            // rb_custom
            // 
            this.rb_custom.AutoSize = true;
            this.rb_custom.Location = new System.Drawing.Point(12, 201);
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
            this.cb_mapstone.Location = new System.Drawing.Point(160, 179);
            this.cb_mapstone.Name = "cb_mapstone";
            this.cb_mapstone.Size = new System.Drawing.Size(83, 17);
            this.cb_mapstone.TabIndex = 25;
            this.cb_mapstone.Text = "Map Stones";
            this.cb_mapstone.UseVisualStyleBackColor = true;
            this.cb_mapstone.CheckedChanged += new System.EventHandler(this.cb_mapstone_CheckedChanged);
            // 
            // cb_extra_pickups
            // 
            this.cb_extra_pickups.AutoSize = true;
            this.cb_extra_pickups.Checked = true;
            this.cb_extra_pickups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_extra_pickups.Enabled = false;
            this.cb_extra_pickups.Location = new System.Drawing.Point(262, 202);
            this.cb_extra_pickups.Name = "cb_extra_pickups";
            this.cb_extra_pickups.Size = new System.Drawing.Size(91, 17);
            this.cb_extra_pickups.TabIndex = 26;
            this.cb_extra_pickups.Text = "Extra Pickups";
            this.cb_extra_pickups.UseVisualStyleBackColor = true;
            this.cb_extra_pickups.CheckedChanged += new System.EventHandler(this.cb_extra_pickups_CheckedChanged);
            // 
            // cb_plants
            // 
            this.cb_plants.AutoSize = true;
            this.cb_plants.Checked = true;
            this.cb_plants.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_plants.Enabled = false;
            this.cb_plants.Location = new System.Drawing.Point(160, 202);
            this.cb_plants.Name = "cb_plants";
            this.cb_plants.Size = new System.Drawing.Size(96, 17);
            this.cb_plants.TabIndex = 27;
            this.cb_plants.Text = "Petrified Plants";
            this.cb_plants.UseVisualStyleBackColor = true;
            this.cb_plants.CheckedChanged += new System.EventHandler(this.cb_plants_CheckedChanged);
            // 
            // cb_softlock
            // 
            this.cb_softlock.AutoSize = true;
            this.cb_softlock.Enabled = false;
            this.cb_softlock.Location = new System.Drawing.Point(262, 179);
            this.cb_softlock.Name = "cb_softlock";
            this.cb_softlock.Size = new System.Drawing.Size(70, 17);
            this.cb_softlock.TabIndex = 28;
            this.cb_softlock.Text = "Softlocks";
            this.cb_softlock.UseVisualStyleBackColor = true;
            this.cb_softlock.CheckedChanged += new System.EventHandler(this.cb_softlock_CheckedChanged);
            // 
            // cb_spoiler
            // 
            this.cb_spoiler.AutoSize = true;
            this.cb_spoiler.Checked = true;
            this.cb_spoiler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_spoiler.Location = new System.Drawing.Point(282, 8);
            this.cb_spoiler.Name = "cb_spoiler";
            this.cb_spoiler.Size = new System.Drawing.Size(105, 17);
            this.cb_spoiler.TabIndex = 29;
            this.cb_spoiler.Text = "Generate Spoiler";
            this.cb_spoiler.UseVisualStyleBackColor = true;
            // 
            // SeedGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 235);
            this.Controls.Add(this.cb_spoiler);
            this.Controls.Add(this.cb_softlock);
            this.Controls.Add(this.cb_plants);
            this.Controls.Add(this.cb_extra_pickups);
            this.Controls.Add(this.cb_mapstone);
            this.Controls.Add(this.rb_custom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_seed_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_glitched);
            this.Controls.Add(this.rb_masochist);
            this.Controls.Add(this.rb_hard);
            this.Controls.Add(this.rb_dboost);
            this.Controls.Add(this.rb_normal);
            this.Controls.Add(this.rb_casual);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.cb_glitched);
            this.Controls.Add(this.cb_hard_dboost);
            this.Controls.Add(this.cb_hard_lure);
            this.Controls.Add(this.cb_timed);
            this.Controls.Add(this.cb_challenge);
            this.Controls.Add(this.cb_dbash);
            this.Controls.Add(this.cb_dboost);
            this.Controls.Add(this.cb_lure);
            this.Controls.Add(this.cb_speed);
            this.Controls.Add(this.cb_casual);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 274);
            this.MinimumSize = new System.Drawing.Size(415, 274);
            this.Name = "SeedGen";
            this.Text = "Ori DE: Seed Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_casual;
        private System.Windows.Forms.CheckBox cb_speed;
        private System.Windows.Forms.CheckBox cb_lure;
        private System.Windows.Forms.CheckBox cb_dboost;
        private System.Windows.Forms.CheckBox cb_dbash;
        private System.Windows.Forms.CheckBox cb_challenge;
        private System.Windows.Forms.CheckBox cb_timed;
        private System.Windows.Forms.CheckBox cb_hard_lure;
        private System.Windows.Forms.CheckBox cb_hard_dboost;
        private System.Windows.Forms.CheckBox cb_glitched;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.RadioButton rb_casual;
        private System.Windows.Forms.RadioButton rb_normal;
        private System.Windows.Forms.RadioButton rb_dboost;
        private System.Windows.Forms.RadioButton rb_hard;
        private System.Windows.Forms.RadioButton rb_masochist;
        private System.Windows.Forms.RadioButton rb_glitched;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_seed_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_custom;
        private System.Windows.Forms.CheckBox cb_mapstone;
        private System.Windows.Forms.CheckBox cb_extra_pickups;
        private System.Windows.Forms.CheckBox cb_plants;
        private System.Windows.Forms.CheckBox cb_softlock;
        private System.Windows.Forms.CheckBox cb_spoiler;
    }
}

