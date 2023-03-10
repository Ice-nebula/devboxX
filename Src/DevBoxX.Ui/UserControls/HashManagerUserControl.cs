using DevBoxX.Core.Enums;
using DevBoxX.Core.Interfaces;
using DevBoxX.Core.Services.HashServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevBoxX.Ui.UserControls
{
    public partial class HashManagerUserControl : UserControl
    {
private IHasherService _hasherService { get; set; }
        public HashManagerUserControl()
        {
            InitializeComponent();
            _hasherService = new Md5Service();
        }

        private void HashManagerUserControl_Load(object sender, EventArgs e)
        {
            cbxHashAlgorithm.DataSource = Enum.GetValues(typeof(HashServiceType));
            cbxHashAlgorithm.SelectedIndex = 0;
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbxText.Text) == true)
                {
                    MessageBox.Show("text can not be empty");
                    return;
                } //end if
                if (_hasherService == null)
                {
                    MessageBox.Show("please select a hash algorithm first.");
                    return;
                } //end if
                var result = _hasherService.Hash(tbxText.Text);
                tbxResult.Text = result;

            }//end try
            catch (ArgumentNullException x)
            {
                MessageBox.Show(x.Message);
            } //end catch
        }

        private void cbxHashAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectHashType = cbxHashAlgorithm.SelectedItem.ToString();
            var hashType =(HashServiceType) Enum.Parse(typeof(HashServiceType), selectHashType);
            if (hashType == HashServiceType.Md5 && _hasherService is Md5Service == false)
            {
                _hasherService = new Md5Service();
            } //end if
            else if (hashType == HashServiceType.Sha256 && _hasherService is Sha256Service == false)
            {
                _hasherService = new Sha256Service();
            } //end if
        }
    }
}
