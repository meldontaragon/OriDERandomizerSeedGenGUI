using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace OriRandoSeedGeneratorGUI
{
    public partial class SeedGen : Form
    {
        public SeedGen()
        {
            InitializeComponent();
            DisableCheckBoxes();
        }

        //start of radio buttom group
        #region RadioButton
        private void rb_casual_CheckedChanged(object sender, EventArgs e)
        {
            cb_casual.Checked = true;

            cb_speed.Checked = false;
            cb_lure.Checked = false;
            cb_dboost.Checked = false;
            cb_dbash.Checked = false;
            cb_challenge.Checked = false;
            cb_timed.Checked = false;
            cb_hard_dboost.Checked = false;
            cb_hard_lure.Checked = false;
            cb_glitched.Checked = false;
            cb_softlock.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            DisableCheckBoxes();
        }

        private void rb_normal_CheckedChanged(object sender, EventArgs e)
        {
            cb_casual.Checked = true;

            cb_speed.Checked = true;
            cb_lure.Checked = true;

            cb_dboost.Checked = false;

            cb_dbash.Checked = false;
            cb_challenge.Checked = false;
            cb_timed.Checked = false;
            cb_hard_dboost.Checked = false;
            cb_hard_lure.Checked = false;
            cb_glitched.Checked = false;
            cb_softlock.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            DisableCheckBoxes();
        }

        private void rb_dboost_CheckedChanged(object sender, EventArgs e)
        {
            cb_casual.Checked = true;

            cb_speed.Checked = true;
            cb_lure.Checked = true;

            cb_dboost.Checked = true;

            cb_dbash.Checked = false;
            cb_challenge.Checked = false;
            cb_timed.Checked = false;
            cb_hard_dboost.Checked = false;
            cb_hard_lure.Checked = false;
            cb_glitched.Checked = false;
            cb_softlock.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            DisableCheckBoxes();
        }

        private void rb_hard_CheckedChanged(object sender, EventArgs e)
        {
            cb_casual.Checked = true;

            cb_speed.Checked = true;
            cb_lure.Checked = true;

            cb_dboost.Checked = true;

            cb_dbash.Checked = true;
            cb_challenge.Checked = true;

            cb_timed.Checked = false;
            cb_hard_dboost.Checked = false;
            cb_hard_lure.Checked = false;
            cb_glitched.Checked = false;

            cb_softlock.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            DisableCheckBoxes();
        }

        private void rb_masochist_CheckedChanged(object sender, EventArgs e)
        {
            cb_casual.Checked = true;

            cb_speed.Checked = true;
            cb_lure.Checked = true;

            cb_dboost.Checked = true;

            cb_dbash.Checked = true;
            cb_challenge.Checked = true;

            cb_timed.Checked = true;
            cb_hard_dboost.Checked = true;
            cb_hard_lure.Checked = true;

            cb_glitched.Checked = false;

            cb_softlock.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            DisableCheckBoxes();
        }

        private void rb_glitched_CheckedChanged(object sender, EventArgs e)
        {
            cb_casual.Checked = true;

            cb_speed.Checked = true;
            cb_lure.Checked = true;

            cb_dboost.Checked = true;

            cb_dbash.Checked = true;
            cb_challenge.Checked = true;

            cb_timed.Checked = true;
            cb_hard_dboost.Checked = true;
            cb_hard_lure.Checked = true;

            cb_glitched.Checked = true;

            cb_softlock.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            DisableCheckBoxes();
        }

        private void rb_custom_CheckedChanged(object sender, EventArgs e)
        {
            EnableCheckBoxes();
        }
        #endregion
        // end of radio button group

        #region CheckBox
        private void cb_speed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_lure_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_dboost_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_dbash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_mapstone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_plants_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_challenge_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_timed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_hard_lure_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_hard_dboost_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_ability_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_extra_pickups_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_softlock_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        void DisableCheckBoxes()
        {
            cb_casual.Enabled = false;

            cb_speed.Enabled = false;
            cb_lure.Enabled = false;
            cb_dboost.Enabled = false;
            cb_dbash.Enabled = false;

            cb_challenge.Enabled = false;
            cb_timed.Enabled = false;
            cb_hard_dboost.Enabled = false;
            cb_hard_lure.Enabled = false;

            cb_glitched.Enabled = false;
            cb_softlock.Enabled = false;

            cb_mapstone.Enabled = false;
            cb_plants.Enabled = false;
            cb_extra_pickups.Enabled = false;
        }

        void EnableCheckBoxes()
        {
            cb_casual.Enabled = false;

            cb_speed.Enabled = true;
            cb_lure.Enabled = true;
            cb_dboost.Enabled = true;
            cb_dbash.Enabled = true;

            cb_challenge.Enabled = true;
            cb_timed.Enabled = true;
            cb_hard_dboost.Enabled = true;
            cb_hard_lure.Enabled = true;

            cb_glitched.Enabled = true;
            cb_softlock.Enabled = false;

            cb_mapstone.Enabled = false;
            cb_plants.Enabled = false;
            cb_extra_pickups.Enabled = false;
        }


        private void button_generate_Click(object sender, EventArgs e)
        {
            ulong seed_number;
            if (ulong.TryParse(text_seed_input.Text, out seed_number) == false)
            {
                seed_number = 0;
            }

            MessageBox.Show("Generating seed with value: " + seed_number, "Generating Seed...");
            if (cb_spoiler.Checked == true)
                generate_spoiler(seed_number);
            else
                generate_seed(seed_number);
        }

        //this only generates a seed (without any spoiler)
        private void generate_seed(ulong seed)
        {

        }

        //this generates a spoiler along with a seed
        private void generate_spoiler(ulong seed)
        {

        }

        #region SampleCode
        private void run_cmd()
        {

            string fileName = @"C:\sample_script.py";

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(@"C:\Python27\python.exe", fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            Console.WriteLine(output);

            Console.ReadLine();

        }
        #endregion  
    }
}
