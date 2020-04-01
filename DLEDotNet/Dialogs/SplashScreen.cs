﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLEDotNet.Dialogs
{
    public partial class SplashScreen : Form
    {
        private const uint WM_MOUSEACTIVATE = 0x21;
        private const uint MA_ACTIVATE = 1;
        private const uint MA_ACTIVATEANDEAT = 2;

        public SplashScreen()
        {
            InitializeComponent();
        }

        protected override bool ShowWithoutActivation => true;
        private void CloseSplash(object sender, EventArgs e) => this.Close();

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.CenterToParent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_MOUSEACTIVATE && m.Result == (IntPtr)MA_ACTIVATEANDEAT)
                m.Result = (IntPtr)MA_ACTIVATE;
        }
    }
}
