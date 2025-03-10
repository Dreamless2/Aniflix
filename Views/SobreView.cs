﻿using System;
using Sunny.UI;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using Aniflix.Functions;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aniflix.Views
{
    public partial class SobreView : UIForm
    {
        public SobreView()
        {
            InitializeComponent();
        }

        private void uiLedLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SobreView_Load(object sender, EventArgs e)
        {
            LinkSite.Links.Add(0, 12, "https://www.themoviedb.org/");
        }

        private void LogoBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.themoviedb.org/");
        }

        private void LinkSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkData = e.Link?.LinkData as string;
            if (linkData != null)
            {
                Process.Start(linkData);
            }
            else
            {
                // Trate o caso em que o linkData é nulo
            }
        }
    }
}
