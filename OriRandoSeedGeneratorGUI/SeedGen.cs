﻿using System;
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
            text_box_directory.Text = Application.StartupPath.ToString();
        }

        //start of radio buttom group
        #region RadioButton
        private void rb_casual_CheckedChanged(object sender, EventArgs e)
        {
            cb_light_dboost.Checked = true;
            cb_speed.Checked = false;
            cb_lure.Checked = false;
            cb_dboost.Checked = false;
            cb_dbash.Checked = false;
            cb_cdash.Checked = false;

            cb_extended.Checked = false;
            cb_ext_dboost.Checked = false;
            cb_timed.Checked = false;
            cb_hard_lure.Checked = false;
            cb_hard_dboost.Checked = false;
            cb_glitched.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            cb_hard.Checked = false;
            cb_ohko.Checked = false;
            cb_0xp.Checked = false;

            DisableCheckBoxes();
        }

        private void rb_normal_CheckedChanged(object sender, EventArgs e)
        {
            cb_light_dboost.Checked = true;
            cb_speed.Checked = true;
            cb_lure.Checked = true;
            cb_dboost.Checked = false;
            cb_dbash.Checked = false;
            cb_cdash.Checked = false;

            cb_extended.Checked = false;
            cb_ext_dboost.Checked = false;
            cb_timed.Checked = false;
            cb_hard_lure.Checked = false;
            cb_hard_dboost.Checked = false;
            cb_glitched.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            cb_hard.Checked = false;
            cb_ohko.Checked = false;
            cb_0xp.Checked = false;

            DisableCheckBoxes();
        }

        private void rb_dboost_CheckedChanged(object sender, EventArgs e)
        {
            cb_light_dboost.Checked = true;
            cb_speed.Checked = true;
            cb_lure.Checked = true;
            cb_dboost.Checked = true;
            cb_dbash.Checked = false;
            cb_cdash.Checked = false;

            cb_extended.Checked = false;
            cb_ext_dboost.Checked = false;
            cb_timed.Checked = false;
            cb_hard_lure.Checked = false;
            cb_hard_dboost.Checked = false;
            cb_glitched.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            cb_hard.Checked = false;
            cb_ohko.Checked = false;
            cb_0xp.Checked = false;

            DisableCheckBoxes();
        }

        private void rb_extend_CheckedChanged(object sender, EventArgs e)
        {
            cb_light_dboost.Checked = true;
            cb_speed.Checked = true;
            cb_lure.Checked = true;
            cb_dboost.Checked = true;
            cb_dbash.Checked = true;
            cb_cdash.Checked = true;

            cb_extended.Checked = true;
            cb_ext_dboost.Checked = true;
            cb_timed.Checked = false;
            cb_hard_lure.Checked = false;
            cb_hard_dboost.Checked = false;
            cb_glitched.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            cb_hard.Checked = false;
            cb_ohko.Checked = false;
            cb_0xp.Checked = false;

            DisableCheckBoxes();
        }

        private void rb_hard_CheckedChanged(object sender, EventArgs e)
        {
            cb_light_dboost.Checked = true;
            cb_speed.Checked = true;
            cb_lure.Checked = true;
            cb_dboost.Checked = false;
            cb_dbash.Checked = true;
            cb_cdash.Checked = true;

            cb_extended.Checked = true;
            cb_ext_dboost.Checked = false;
            cb_timed.Checked = false;
            cb_hard_lure.Checked = false;
            cb_hard_dboost.Checked = false;
            cb_glitched.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            cb_hard.Checked = true;
            cb_ohko.Checked = false;
            cb_0xp.Checked = false;

            DisableCheckBoxes();
        }

        private void rb_ohko_CheckedChanged(object sender, EventArgs e)
        {
            cb_light_dboost.Checked = false;
            cb_speed.Checked = true;
            cb_lure.Checked = true;
            cb_dboost.Checked = false;
            cb_dbash.Checked = true;
            cb_cdash.Checked = true;

            cb_extended.Checked = true;
            cb_ext_dboost.Checked = false;
            cb_timed.Checked = false;
            cb_hard_lure.Checked = false;
            cb_hard_dboost.Checked = false;
            cb_glitched.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            cb_hard.Checked = false;
            cb_ohko.Checked = true;
            cb_0xp.Checked = false;

            DisableCheckBoxes();
        }

        private void rb_0xp_CheckedChanged(object sender, EventArgs e)
        {
            cb_light_dboost.Checked = true;
            cb_speed.Checked = true;
            cb_lure.Checked = true;
            cb_dboost.Checked = false;
            cb_dbash.Checked = false;
            cb_cdash.Checked = false;

            cb_extended.Checked = false;
            cb_ext_dboost.Checked = false;
            cb_timed.Checked = false;
            cb_hard_lure.Checked = false;
            cb_hard_dboost.Checked = false;
            cb_glitched.Checked = false;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            cb_hard.Checked = false;
            cb_ohko.Checked = false;
            cb_0xp.Checked = true;

            DisableCheckBoxes();
        }

        private void rb_glitched_CheckedChanged(object sender, EventArgs e)
        {
            cb_light_dboost.Checked = true;
            cb_speed.Checked = true;
            cb_lure.Checked = true;
            cb_dboost.Checked = true;
            cb_dbash.Checked = true;
            cb_cdash.Checked = true;

            cb_extended.Checked = true;
            cb_ext_dboost.Checked = true;
            cb_timed.Checked = true;
            cb_hard_lure.Checked = true;
            cb_hard_dboost.Checked = true;
            cb_glitched.Checked = true;

            cb_extra_pickups.Checked = true;
            cb_plants.Checked = true;
            cb_mapstone.Checked = true;

            cb_hard.Checked = false;
            cb_ohko.Checked = false;
            cb_0xp.Checked = false;

            DisableCheckBoxes();
        }

        private void rb_custom_CheckedChanged(object sender, EventArgs e)
        {
            EnableCheckBoxes();
        }
        #endregion
        // end of radio button group

        private void DisableCheckBoxes()
        {
            cb_light_dboost.Enabled = false;
            cb_speed.Enabled = false;
            cb_lure.Enabled = false;
            cb_dboost.Enabled = false;
            cb_dbash.Enabled = false;
            cb_cdash.Enabled = false;

            cb_extended.Enabled = false;
            cb_ext_dboost.Enabled = false;
            cb_timed.Enabled = false;
            cb_hard_dboost.Enabled = false;
            cb_hard_lure.Enabled = false;
            cb_glitched.Enabled = false;

            cb_mapstone.Enabled = false;
            cb_plants.Enabled = false;
            cb_extra_pickups.Enabled = false;

            cb_hard.Enabled = false;
            cb_ohko.Enabled = false;
            cb_0xp.Enabled = false;
        }

        private void EnableCheckBoxes()
        {
            cb_light_dboost.Enabled = true;
            cb_speed.Enabled = true;
            cb_lure.Enabled = true;
            cb_dboost.Enabled = true;
            cb_dbash.Enabled = true;
            cb_cdash.Enabled = true;

            cb_extended.Enabled = true;
            cb_ext_dboost.Enabled = true;
            cb_timed.Enabled = true;
            cb_hard_dboost.Enabled = true;
            cb_hard_lure.Enabled = true;
            cb_glitched.Enabled = true;

            cb_mapstone.Enabled = false;
            cb_plants.Enabled = true;
            cb_extra_pickups.Enabled = true;

            cb_hard.Enabled = true;
            cb_ohko.Enabled = true;
            cb_0xp.Enabled = true;
        }
        
        private void button_generate_Click(object sender, EventArgs e)
        {
            generate_seed();
        }

        //this only generates a seed (with a spoiler)
        private void generate_seed()
        {
            string python_call, string_logic, string_options, string_seed;
            string move_rando;
            string move_spoiler;

            //python_call = "/C python seed_generator.py /b ";
            python_call = "python seed_generator.py ";
            string_logic = generate_logic_string();
            string_options = generate_options_string();
            string_seed = generate_seed_string();

            python_call += string_logic + string_options + string_seed;

            move_rando = "move randomizer*.dat " + text_box_directory.Text.ToString() + "/";
            move_spoiler = "move spoiler* " + text_box_directory.Text.ToString() + "/";

            MessageBox.Show(python_call, "Python Command Line");

            Process proc = new Process();
            ProcessStartInfo start_info = new ProcessStartInfo();

            start_info.WindowStyle = ProcessWindowStyle.Normal;
            start_info.FileName = "cmd.exe";
            start_info.RedirectStandardInput = true;
            start_info.RedirectStandardOutput = true;

            start_info.UseShellExecute = false;

            proc.StartInfo = start_info;

            proc.Start();

            proc.StandardInput.WriteLine(python_call);
            proc.StandardInput.Flush();


            proc.StandardInput.WriteLine(move_rando);
            proc.StandardInput.Flush();

            proc.StandardInput.WriteLine(move_spoiler);
            proc.StandardInput.Flush();

            proc.StandardInput.Close();
            proc.WaitForExit();
        }
        
        private string generate_logic_string()
        {
            string logic_call = "";
            // figure out which logic grouping to use
            if (rb_casual.Checked)
            {
                logic_call = "--logic casual ";
            }
            else if (rb_normal.Checked)
            {
                logic_call = "--logic normal ";
            }
            else if (rb_dboost.Checked)
            {
                logic_call = "--logic dboost ";
            }
            else if (rb_extend.Checked)
            {
                logic_call = "--logic extended ";
            }
            else if (rb_hard.Checked)
            {
                logic_call = "--logic hard ";
            }
            else if (rb_ohko.Checked)
            {
                logic_call = "--logic ohko ";
            }
            else if (rb_0xp.Checked)
            {
                logic_call = "--logic 0xp ";
            }
            else if (rb_glitched.Checked)
            {
                logic_call = "--logic glitched ";
            }
            else if (rb_normal.Checked)
            {
                logic_call = "--custom-logic normal";

                // get the custom logic options
                if (cb_light_dboost.Checked)
                {
                    logic_call += ",dboost-light";
                }
                if (cb_speed.Checked)
                {
                    logic_call += ",speed";
                }
                if (cb_lure.Checked)
                {
                    logic_call += ",lure";
                }
                if (cb_dboost.Checked)
                {
                    logic_call += ",dboost";
                }
                if (cb_dbash.Checked)
                {
                    logic_call += ",dbash";
                }
                if (cb_cdash.Checked)
                {
                    logic_call += ",cdash";
                }

                if (cb_extended.Checked)
                {
                    logic_call += ",extended";
                }
                if (cb_ext_dboost.Checked)
                {
                    logic_call += ",extended-damage";
                }
                if (cb_timed.Checked)
                {
                    logic_call += ",timed-level";
                }
                if (cb_hard_lure.Checked)
                {
                    logic_call += ",lure-hard";
                }
                if (cb_hard_dboost.Checked)
                {
                    logic_call += ",dboost-hard";
                }
                if (cb_glitched.Checked)
                {
                    logic_call += ",glitched";
                }
                logic_call += " ";
            }
            return logic_call;
        }
        private string generate_options_string()
        {
            string options_call = "";

            if (!(cb_plants.Checked))
            {
                options_call += "--noplants ";
            }
            if (!(cb_extra_pickups.Checked))
            {
                options_call += "--nobonus ";
            }

            if (cb_hard.Checked)
            {
                options_call += "--hard ";
            }
            if (cb_ohko.Checked)
            {
                options_call += "--ohko ";
            }
            if (cb_0xp.Checked)
            {
                options_call += "--zeroxp ";
            }

            return options_call;
        }
        private string generate_seed_string()
        {
            string seed_call;

            seed_call = "--seed " + numeric_seed_number.Value.ToString() + " --count " + numeric_seed_count.Value.ToString();
            return seed_call;
        }

        private void button_select_folder_Click(object sender, EventArgs e)
        {
            string old = text_box_directory.Text.ToString();

            folder_browser.ShowDialog();
            text_box_directory.Text = folder_browser.SelectedPath.ToString();

            if (text_box_directory.Text == "")
            {
                text_box_directory.Text = old;
            }
        }
    }
}

