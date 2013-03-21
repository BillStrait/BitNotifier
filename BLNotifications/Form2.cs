using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLNotifications
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(notifications.Instance.MtGoxSecret))
            {
                txtSecret.Text = notifications.Instance.MtGoxSecret;
            }
            if (!string.IsNullOrEmpty(notifications.Instance.MtGoxApiKey))
            {
                txtKey.Text = notifications.Instance.MtGoxApiKey;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            notifications.Instance.MtGoxApiKey = txtKey.Text;
            notifications.Instance.MtGoxSecret = txtSecret.Text;
            notifications.Instance.RefreshOrderHistory();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
