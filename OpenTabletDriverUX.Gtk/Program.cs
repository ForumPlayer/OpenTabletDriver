﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Eto.Forms;
using Eto.GtkSharp.Drawing;
using TabletDriverLib.Contracts;

namespace OpenTabletDriverUX.Gtk
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new Application(Eto.Platforms.Gtk).Run(new MainForm());
        }
    }
}
