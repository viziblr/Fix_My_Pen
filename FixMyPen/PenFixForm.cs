using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PenFix
{
    public partial class PenFixForm : Form
    {
        public PenFixForm()
        {
            InitializeComponent();
            this.refresh_settings();
        }

        private void refresh_settings()
        {
            this.textBox_status.Clear();

            var lines = new List<string>();

            lines.Add(string.Format("Dynamic Feedback user policy -> {0}",
                                    BoolToEnabled(!this.dynfeed_user.GetInt(0).ToBool())));
            lines.Add(string.Format("Dynamic Feedback machine policy -> {0}",
                                    BoolToEnabled(!this.dynfeed_machine.GetInt(0).ToBool())));

            lines.Add(string.Format("Tablet PC Input Panel user policy -> {0}",
                                    BoolToEnabled(!this.tabinputpanel_user.GetInt(0).ToBool())));
            lines.Add(string.Format("Tablet PC Input Panel machine policy -> {0}",
                                    BoolToEnabled(!this.tabinputpanel_machine.GetInt(0).ToBool())));

            lines.Add(string.Format("Tablet PC Icon by Text Box user policy -> {0}",
                                    BoolToEnabled(!this.iptarget_user.GetInt(0).ToBool())));
            lines.Add(string.Format("Tablet PC Icon by Text Box machine policy -> {0}",
                                    BoolToEnabled(!this.iptarget_machine.GetInt(0).ToBool())));

            lines.Add(string.Format("Flicks user policy -> {0}", BoolToEnabled(!this.flicks_user.GetInt(0).ToBool())));
            lines.Add(string.Format("Flicks machine policy -> {0}",
                                    BoolToEnabled(!this.flicks_machine.GetInt(0).ToBool())));

            lines.Add(string.Format("Press and hold user setting -> {0}",
                                    BoolToEnabled(this.holdmode_machine.GetInt(1) != 3)));

            this.textBox_status.Text = string.Join("\r\n", lines);
        }

        private void buttonrefresh_Click(object sender, EventArgs e)
        {
            this.refresh_settings();
        }

        private static string tabpc_pol_path = @"Software\Policies\Microsoft\TabletPC";
        private static string turnoffpenfeedback = "TurnOffPenFeedback";

        private static string tableetinputpanel_pos = @"software\policies\microsoft\TabletTip\1.7";
        private static string DisableEdgeTarget = @"DisableEdgeTarget";
        private static string HideIPTIPTarget = @"HideIPTIPTarget";

        private static RegistryKey hkcu = Microsoft.Win32.Registry.CurrentUser;
        private static RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;

        private Setting dynfeed_user = new Setting(hkcu, tabpc_pol_path, turnoffpenfeedback);
        private Setting dynfeed_machine = new Setting(hklm, tabpc_pol_path, turnoffpenfeedback);
        private Setting tabinputpanel_user = new Setting(hkcu, tableetinputpanel_pos, DisableEdgeTarget);
        private Setting tabinputpanel_machine = new Setting(hklm, tableetinputpanel_pos, DisableEdgeTarget);
        private Setting iptarget_user = new Setting(hkcu, tableetinputpanel_pos, HideIPTIPTarget);
        private Setting iptarget_machine = new Setting(hklm, tableetinputpanel_pos, HideIPTIPTarget);
    
        private Setting flicks_user = new Setting(hkcu, tabpc_pol_path, "PreventFlicks");
        private Setting flicks_machine = new Setting(hklm, tabpc_pol_path, "PreventFlicks");
        private Setting holdmode_machine = new Setting(hkcu, @"SOFTWARE\Microsoft\Wisp\Pen\SysEventParameters", "HoldMode");


        private void button_make_bad(object sender, EventArgs e)
        {
            // Delete all the policy values
            this.dynfeed_user.Remove();
            this.dynfeed_machine.Remove();
            this.tabinputpanel_user.Remove();
            this.tabinputpanel_machine.Remove();
            this.iptarget_user.Remove();
            this.iptarget_machine.Remove();
            this.flicks_user.Remove();
            this.flicks_machine.Remove();

            // hold mose is not a policy setting and generally exists, so just set it back to what was presumably its initial value
            this.holdmode_machine.SetInt(1);

            this.refresh_settings();
        }

        private void button_make_good(object sender, EventArgs e)
        {
            this.dynfeed_user.SetInt(1);
            this.dynfeed_machine.SetInt(1);
            this.tabinputpanel_user.SetInt(1);
            this.tabinputpanel_machine.SetInt(1);
            this.iptarget_user.SetInt(1);
            this.iptarget_machine.SetInt(1);
            this.holdmode_machine.SetInt(3);
            this.flicks_user.SetInt(1);
            this.flicks_machine.SetInt(1);

            this.refresh_settings();
        }

        public string BoolToEnabled(bool v)
        {
            return v ? "Enabled (BAD)" : "Disabled (GOOD)";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://viziblr.com/news/2011/8/13/fix-my-pen-makes-your-wacom-tablet-just-work-on-windows-7.html");
        }
    }
}