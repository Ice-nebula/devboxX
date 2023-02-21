using DevBoxX.Core;
using DevBoxX.Ui.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevBoxX.Ui.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Array serviceType = Enum.GetValues(typeof(ServiceType));
            lvToolsList.DataSource = serviceType;
        }

        private void lvToolsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvToolsList.SelectedValue == null) return;
            string selectedValue = lvToolsList.SelectedValue.ToString();
            ServiceType selectServiceType = (ServiceType)Enum.Parse(typeof(ServiceType), selectedValue);
            if (selectServiceType == ServiceType.HashManager)
            {
                var hashManager = new HashManagerUserControl();
                hashManager.Dock = DockStyle.Fill;
                plTools.Controls.Add(hashManager);
            } //end if
        }
    }
}
