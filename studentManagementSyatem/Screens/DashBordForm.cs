﻿using studentManagementSyatem.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManagementSyatem.Screens
{
    public partial class DashBordForm : TemplateForm
    {
        public DashBordForm()
        {
            InitializeComponent();
        }

        private void DashBordForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewStudentToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
