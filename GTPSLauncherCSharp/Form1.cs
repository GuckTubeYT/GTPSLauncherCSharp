/*
 * GTPSLauncherCSharp By GuckTube YT
 * Dont forget to subcribe GuckTube YT
 * Please, dont change this Owner name to your name
 * this app is for not sell, this app is for free for all who download this Source Code
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace GTPSLauncherCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts", false);
            tw.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp. ");
            tw.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp. ");
            tw.WriteLine("# ");
            tw.WriteLine("# This is a sample HOSTS file used by Microsoft TCP/IP for Windows. ");
            tw.WriteLine("# ");
            tw.WriteLine("# This file contains the mappings of IP addresses to host names. Each ");
            tw.WriteLine("# entry should be kept on an individual line. The IP address should ");
            tw.WriteLine("# be placed in the first column followed by the corresponding host name. ");
            tw.WriteLine("# The IP address and the host name should be separated by at least one ");
            tw.WriteLine("# space. ");
            tw.WriteLine("# ");
            tw.WriteLine("# Additionally, comments (such as these) may be inserted on individual ");
            tw.WriteLine("# lines or following the machine name denoted by a '#' symbol. ");
            tw.WriteLine("# ");
            tw.WriteLine("# For example: ");
            tw.WriteLine("# ");
            tw.WriteLine("#      102.54.94.97     rhino.acme.com          # source server ");
            tw.WriteLine("#       38.25.63.10     x.acme.com              # x client host ");
            tw.WriteLine("");
            tw.WriteLine("# localhost name resolution is handled within DNS itself. ");
            tw.WriteLine("#      127.0.0.1       localhost ");
            tw.WriteLine("#      ::1             localhost ");
            tw.WriteLine(" ");
            tw.WriteLine("YourGTPSIP growtopia1.com");
            tw.WriteLine("YOURGTPSIP growtopia2.com");
            tw.Close();
            label1.Text = "GTPS Is Turn ON";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts", false);
            tw.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp. ");
            tw.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp. ");
            tw.WriteLine("# ");
            tw.WriteLine("# This is a sample HOSTS file used by Microsoft TCP/IP for Windows. ");
            tw.WriteLine("# ");
            tw.WriteLine("# This file contains the mappings of IP addresses to host names. Each ");
            tw.WriteLine("# entry should be kept on an individual line. The IP address should ");
            tw.WriteLine("# be placed in the first column followed by the corresponding host name. ");
            tw.WriteLine("# The IP address and the host name should be separated by at least one ");
            tw.WriteLine("# space. ");
            tw.WriteLine("# ");
            tw.WriteLine("# Additionally, comments (such as these) may be inserted on individual ");
            tw.WriteLine("# lines or following the machine name denoted by a '#' symbol. ");
            tw.WriteLine("# ");
            tw.WriteLine("# For example: ");
            tw.WriteLine("# ");
            tw.WriteLine("#      102.54.94.97     rhino.acme.com          # source server ");
            tw.WriteLine("#       38.25.63.10     x.acme.com              # x client host ");
            tw.WriteLine("");
            tw.WriteLine("# localhost name resolution is handled within DNS itself. ");
            tw.WriteLine("#      127.0.0.1       localhost ");
            tw.WriteLine("#      ::1             localhost ");
            tw.WriteLine(" ");
            tw.Close();
            label1.Text = "KXPS Is Turn OFF";
        }
    }
}

