using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using BLNotifications.Properties;

namespace BLNotifications
{
    public partial class BitNotifier : Form
    {
        private bool lcdEnabled = false;
        public int connection = DMcLgLCD.LGLCD_INVALID_CONNECTION;
        public int device = DMcLgLCD.LGLCD_INVALID_DEVICE;
        public int deviceType = DMcLgLCD.LGLCD_INVALID_DEVICE;

        private Bitmap LCD;
        private uint buttons = 0;
        private int config = 0;
        private int cnt = 0;

        private enum SenderTypes
        {
            USD, 
            BTC, 
            Spend,
            Fees
        }

        public BitNotifier()
        {
            InitializeComponent();

            //additional handlers for the calculator screen.
            txtCalcBtc.KeyPress += txtCalcBtc_KeyPress;
            txtCalcBtc.LostFocus += txtCalcBtc_LostFocus;
            txtCalcUSD.KeyPress += txtCalcUSD_KeyPress;
            txtCalcUSD.LostFocus += txtCalcUsd_LostFocus;
            txtCalcSpend.KeyPress += txtCalcSpend_KeyPress;
            txtCalcSpend.LostFocus += txtCalcSpend_LostFocus;
            cmbCalcFees.SelectedIndexChanged += smbCalcFees_SelectedIndexChanged;
            cmbCalcFees.SelectedIndex = 0;
        }

        public void CallBackFunction(object sender, EventArgs e)
        {

            Invoke((MethodInvoker)delegate{
                lblMtGoxAvg.Text = notifications.Instance.MtGoxAvg;
                lblMtGoxBuy.Text = notifications.Instance.MtGoxBuy;
                lblMtGoxHigh.Text = notifications.Instance.MtGoxHigh;
                lblMtGoxLast.Text = notifications.Instance.MtGoxLast;
                notifyIcon1.Text = notifications.Instance.MtGoxLast;
                lblMtGoxLow.Text = notifications.Instance.MtGoxLow;
                lblMtGoxSell.Text = notifications.Instance.MtGoxSell;
                lblMtGoxVol.Text = notifications.Instance.MtGoxVol;

                if (notifications.Instance.ResponseGood)
                {
                    notifyIcon1.Icon = Resources.startIcon;
                    Icon = Resources.startIcon;

                    lblMtGoxAvg.ForeColor = Color.Black;
                    lblMtGoxBuy.ForeColor = Color.Black;
                    lblMtGoxHigh.ForeColor = Color.Black;
                    lblMtGoxLast.ForeColor = Color.Black;
                    lblMtGoxLow.ForeColor = Color.Black;
                    lblMtGoxSell.ForeColor = Color.Black;
                    lblMtGoxVol.ForeColor = Color.Black;
                }
                else
                {
                    notifyIcon1.Icon = Resources.disconnectedIcon;
                    Icon = Resources.disconnectedIcon;
                    lblMtGoxAvg.ForeColor = Color.DarkRed;
                    lblMtGoxBuy.ForeColor = Color.DarkRed;
                    lblMtGoxHigh.ForeColor = Color.DarkRed;
                    lblMtGoxLast.ForeColor = Color.DarkRed;
                    lblMtGoxLow.ForeColor = Color.DarkRed;
                    lblMtGoxSell.ForeColor = Color.DarkRed;
                    lblMtGoxVol.ForeColor = Color.DarkRed;
                    notifyIcon1.Text += Resources.MtGoxFailed;
                }
            });

            if (lcdEnabled)
            {
                UpdateLCD();
            }

        }

        private void Invis(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                ShowInTaskbar = false;
            }
        }

        private void Vis(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void Quit(object sender, EventArgs e)
        {
            Close();
        }

        private void Notification_Resize(object sender, EventArgs e)
        {
            Invis(sender, e);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Vis(sender, e);
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vis(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Quit(sender, e);
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            notifications.Instance.PropertyChanged += CallBackFunction;

            if (DMcLgLCD.ERROR_SUCCESS == DMcLgLCD.LcdInit())
            {
                lcdEnabled = true;
                EnableLCDKeyboardSupport();
            }
        }

        private void EnableLCDKeyboardSupport()
        {
            connection = DMcLgLCD.LcdConnectEx("BilldLabs Notifier", 0, 0);
            if (DMcLgLCD.LGLCD_INVALID_CONNECTION != connection)
            {
                device = DMcLgLCD.LcdOpenByType(connection, DMcLgLCD.LGLCD_DEVICE_QVGA);

                if (DMcLgLCD.LGLCD_INVALID_DEVICE == device)
                {
                    device =DMcLgLCD.LcdOpenByType(connection, DMcLgLCD.LGLCD_DEVICE_BW);
                    if (DMcLgLCD.LGLCD_INVALID_DEVICE != device)
                    {
                        deviceType = DMcLgLCD.LGLCD_DEVICE_BW;
                    }
                }
                else
                {
                    deviceType = DMcLgLCD.LGLCD_DEVICE_QVGA;
                }

                if (DMcLgLCD.LGLCD_DEVICE_BW == deviceType)
                {
                    LCD = new Bitmap(160, 43);
                    Graphics g = Graphics.FromImage(LCD);
                    g.Clear(Color.White);
                    var sFont = new Font("Arial", 21, FontStyle.Regular);
                    g.DrawString("BilldLabs", sFont, Brushes.Black, 15, 5);

                    g.Dispose();

                    DMcLgLCD.LcdUpdateBitmap(device, LCD.GetHbitmap(), DMcLgLCD.LGLCD_DEVICE_BW);
                    DMcLgLCD.LcdSetAsLCDForegroundApp(device, DMcLgLCD.LGLCD_FORE_YES);
                }
                else
                {
                    LCD = new Bitmap(320, 240);
                    Graphics g = Graphics.FromImage(LCD);
                    g.Clear(Color.White);

                    var sFont = new Font("Arial", 42, FontStyle.Regular);
                    g.DrawString("BilldLabs", sFont, Brushes.Blue, 0, 0);
                    g.Dispose();
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                    DMcLgLCD.LcdUpdateBitmap(device, LCD.GetHbitmap(), DMcLgLCD.LGLCD_DEVICE_QVGA);
                    DMcLgLCD.LcdSetAsLCDForegroundApp(device, DMcLgLCD.LGLCD_FORE_YES);
                }

                if (deviceType > 0)
                {
                    DMcLgLCD.LcdSetConfigCallback(CfgCallback);
                }
            }
        }

        private void CfgCallback(int cfgConnection)
        {
            config = cfgConnection;
        }

        private void UpdateLCD()
        {
            Font sFont;

            Graphics g = Graphics.FromImage(LCD);
            g.Clear(Color.White);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            if(DMcLgLCD.LGLCD_DEVICE_BW == deviceType)
                sFont = new Font("Arial", 7, FontStyle.Regular);
            else
                sFont = new Font("Arial", 14, FontStyle.Regular);

            //TODO: implement buttons here.

            string line1 = "Ask: " + notifications.Instance.MtGoxBuy.Substring(0, 7) + "\t Bid: " + notifications.Instance.MtGoxSell.Substring(0, 7);
            string line2 = "Avg: " + notifications.Instance.MtGoxAvg.Substring(0, 7) + "\t Last: " + notifications.Instance.MtGoxLast.Substring(0, 7);
            string line3 = "Server did not respond.";

            if (DMcLgLCD.LGLCD_DEVICE_BW == deviceType)
            {
                g.DrawString(line1, sFont, SystemBrushes.WindowText, 0, 0);
                g.DrawString(line2, sFont, Brushes.Black, 0, 10);
                if (!notifications.Instance.ResponseGood)
                {
                    g.DrawString(line3,sFont,Brushes.Black,0,30);
                }
                DMcLgLCD.LcdUpdateBitmap(device, LCD.GetHbitmap(), DMcLgLCD.LGLCD_DEVICE_BW);
            }
            else
            {
                g.DrawString(line1, sFont, Brushes.Black, 0, 0);
                g.DrawString(line2, sFont, Brushes.Black, 0, 15);
                if (!notifications.Instance.ResponseGood)
                {
                    g.DrawString(line3,sFont,Brushes.Black,0,35);
                }
                DMcLgLCD.LcdUpdateBitmap(device, LCD.GetHbitmap(), DMcLgLCD.LGLCD_DEVICE_QVGA);
            }
            sFont.Dispose();
            g.Dispose();
        }


        private void viewWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.billdlabs.com/?cat=10");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1N7A7StTKAV7HivYyTKUsNCsKjPAihPMgV");
        }



        //This is the logic for the calculator tab.

        //This function makes sure only a digit or a single decimal is entered.
        private bool numericValidator(object sender, KeyPressEventArgs e)
        {
            bool result = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                result = true;
            }

            return result;
        }

        //This function does the math and displays the results. As well as it can.
        private void UpdateTotals(int sender)
        {
            //we need to know the value of at least two fields to do math.
            var validNumbers = 0;
            const string defaultString = "0.00";
            var values = new List<KeyValuePair<int, decimal>>();
            var usersValues = new string[] {txtCalcUSD.Text, txtCalcBtc.Text, txtCalcSpend.Text};
            int x = 0;
            foreach (var usersValue in usersValues)
            {
                if (!string.IsNullOrEmpty(usersValue))
                {
                    if (usersValue != defaultString)
                    {
                        validNumbers++;
                    }
                    decimal temp;
                    decimal.TryParse(usersValue, out temp);
                    values.Add(new KeyValuePair<int, decimal>(x,temp));
                }
                x++;
            }

            //check to see if there's work to do. If not, we gtfo.
            if (validNumbers <= 1 || (values.FirstOrDefault(c => c.Key == sender).Value <= 0&& sender != (int)SenderTypes.Fees)) return;

            var btc = 0.0m;
            var dollar = 0.0m;
            var spend = 0.0m;
            var feePer = 0.0m;
            var feeBtc = 0.0m;
            var feeDollar = 0.0m;
            var totalDollar = 0.0m;
            var totalBtc = 0.0m;
            var breakSell = 0.0m;
            var breakShort = 0.0m;


            decimal.TryParse(cmbCalcFees.Text, out feePer);

            foreach (var keyValuePair in values)
            {
                switch (keyValuePair.Key)
                {
                    case (int)SenderTypes.BTC:
                        btc = keyValuePair.Value;
                        break;
                    case (int)SenderTypes.USD:
                        dollar = keyValuePair.Value;
                        break;
                    case (int)SenderTypes.Spend:
                        spend = keyValuePair.Value;
                        break;
                }
            }

            switch (sender)
            {
                case (int)SenderTypes.BTC:
                    if (dollar>0)
                    {
                        spend = dollar*btc;
                    }
                    else
                    {
                        dollar = spend/btc;
                    }
                    break;
                case (int) SenderTypes.Spend:
                    if (dollar>0)
                    {
                        btc = spend/dollar;
                    }
                    else
                    {
                        dollar = btc*spend;
                    }
                    break;
                case(int)SenderTypes.USD:
                    if (btc>0)
                    {
                        spend = dollar*btc;
                    }
                    else
                    {
                        btc = spend/dollar;
                    }
                    break;
            }

            //all of the core values are now calculated. Lets' add 'em up.
            feeBtc = btc*feePer*.01m;
            feeDollar = spend*feePer*.01m;
            totalBtc = (spend/dollar)-feeBtc;
            totalDollar = (btc*dollar) - feeDollar;
            breakSell = (dollar*(1m + feePer*.01m))/(1m - feePer*.01m);
            breakShort = dollar*(1m - feePer*.01m)/(1m + feePer*.01m);

            txtCalcUSD.Text = dollar.ToString(CultureInfo.InvariantCulture);
            txtCalcBtc.Text = btc.ToString(CultureInfo.InvariantCulture);
            txtCalcSpend.Text = spend.ToString(CultureInfo.InvariantCulture);

            txtCalcBFees.Text = feeBtc.ToString(CultureInfo.InvariantCulture) + Resources.BTC;
            txtCalcUFees.Text = Resources.dollarsign + feeDollar.ToString(CultureInfo.InvariantCulture);
            txtCalcBtcTotal.Text = totalBtc.ToString(CultureInfo.InvariantCulture) + Resources.BTC;
            txtCalcDollarTotal.Text = Resources.dollarsign + totalDollar.ToString(CultureInfo.InvariantCulture);
            txtCalcBreakSell.Text = Resources.dollarsign + breakSell.ToString(CultureInfo.InvariantCulture);
            txtCalcBreakShort.Text = Resources.dollarsign + breakShort.ToString(CultureInfo.InvariantCulture);
        }

        private void txtCalcBtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = numericValidator(sender, e);
        }

        private void txtCalcBtc_LostFocus(object sender, EventArgs e)
        {
            UpdateTotals((int) SenderTypes.BTC);
        }

        private void txtCalcUSD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = numericValidator(sender, e);
        }

        private void txtCalcUsd_LostFocus(object sender, EventArgs e)
        {
            UpdateTotals((int) SenderTypes.USD);
        }

        private void txtCalcSpend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = numericValidator(sender, e);
        }
        private void txtCalcSpend_LostFocus(object sender, EventArgs e)
        {
            UpdateTotals((int) SenderTypes.Spend);
        }

        private void chkCalcLatest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCalcLatest.Checked)
            {
                txtCalcUSD.Enabled = false;
                txtCalcUSD.Text = notifications.Instance.MtGoxLastDec.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                txtCalcUSD.Enabled = true;
            }
        }

        private void smbCalcFees_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals((int)SenderTypes.Fees);
        }
    }
}
