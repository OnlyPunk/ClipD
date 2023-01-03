using System.Windows.Forms;

namespace ClipCheck
{
    public partial class ClipD : Form
    {
        int passedChecks = 0; //Stores passed checks

        System.Windows.Forms.Timer timer;
        int functionIndex = 0;
        private void startTests(object sender, EventArgs e)
        {
            switch (functionIndex)
            {
                //Run functions
                case 0:
                    bitcoin();
                    break;
                case 1:
                    litecoin();
                    break;
                case 2:
                    ethereum();
                    break;
                case 3:
                    monero();
                    break;
                case 4:
                    nano();
                    break;
                case 5:
                    dogeFunction();
                    break;
                case 6:
                    cardano();
                    break;
                case 7:
                    polkadot();
                    break;
                default:
                    // Reset the function index and stop the timer
                    functionIndex = 0;
                    timer.Stop();
                    break;
            }

            functionIndex++;
        }
        public ClipD()
        {
            InitializeComponent();

            //Make window the perfect size so pass/fail stats aren't visible.
            this.Size = new System.Drawing.Size(168, 181);

            //Timer for running tests initialized here
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1250;  // 1.25 seconds
            timer.Tick += startTests;
            timer.Start();
        }

        public void bitcoin()
        {
            //Sets clipboard to a bitcoin address
            Clipboard.SetText("bc1qt4ujf6ne52457ye3v7un4pu2y4t0pvx9gnj585");
            //Sets the current clipboard to a variable called clip to later check
            string clip = Clipboard.GetText();
            //Checks if the clipboard matches the tested address
            if (clip == "bc1qt4ujf6ne52457ye3v7un4pu2y4t0pvx9gnj585")
            {
                //Set text of btc to "Secure"
                btc.Text = "Secure";
                //Set color of btc to green
                btc.ForeColor = Color.Green;
                //Set btc to bold
                btc.Font = new Font(btc.Font, FontStyle.Bold);
                //add 1 to passedChecks
                passedChecks++;
            }
            else
            {
                btc.Text = "Not Secure";
                //Set color of btc to red
                btc.ForeColor = Color.Red;
                //Set btc to bold
                btc.Font = new Font(btc.Font, FontStyle.Bold);
            }
        }

        public void litecoin()
        {
            //Sets clipboard to a litecoin address
            Clipboard.SetText("LUkbnLJbQN28QesB4u9A6XmAAtnvnfTDDC");
            //Sets the current clipboard to a variable called clip to later check
            string clip = Clipboard.GetText();
            //Checks if the clipboard matches the tested address
            if (clip == "LUkbnLJbQN28QesB4u9A6XmAAtnvnfTDDC")
            {
                //Set text of ltc to "Secure"
                ltc.Text = "Secure";
                //Set color of ltc to green
                ltc.ForeColor = Color.Green;
                //Set ltc to bold
                ltc.Font = new Font(ltc.Font, FontStyle.Bold);
                //add 1 to passedChecks
                passedChecks++;
            }
            else
            {
                ltc.Text = "Not Secure";
                //Set color of ltc to red
                ltc.ForeColor = Color.Red;
                //Set ltc to bold
                ltc.Font = new Font(ltc.Font, FontStyle.Bold);
            }
        }

        public void ethereum()
        {
            //Sets clipboard to a ethereum address
            Clipboard.SetText("0x64618B7B502a84CBC52a8E0c51D1E52CE413048A");
            //Sets the current clipboard to a variable called clip to later check
            string clip = Clipboard.GetText();
            //Checks if the clipboard matches the tested address
            if (clip == "0x64618B7B502a84CBC52a8E0c51D1E52CE413048A")
            {
                //Set text of eth to "Secure"
                eth.Text = "Secure";
                //Set color of eth to green
                eth.ForeColor = Color.Green;
                //Set eth to bold
                eth.Font = new Font(eth.Font, FontStyle.Bold);
                //add 1 to passedChecks
                passedChecks++;
            }
            else
            {
                eth.Text = "Not Secure";
                //Set color of eth to red
                eth.ForeColor = Color.Red;
                //Set eth to bold
                eth.Font = new Font(eth.Font, FontStyle.Bold);
            }
        }

        public void monero()
        {
            //Sets clipboard to a monero address
            Clipboard.SetText("4B2F4N2562qWD5Ytkczgjx1jCqYtAW3Tz5EC4E4d5dipJpKzVg9py1WHDgkGRGCKtpJDvBfYQAW6E3b4XvaN2WKATUB2LxF");
            //Sets the current clipboard to a variable called clip to later check
            string clip = Clipboard.GetText();
            //Checks if the clipboard matches the tested address
            if (clip == "4B2F4N2562qWD5Ytkczgjx1jCqYtAW3Tz5EC4E4d5dipJpKzVg9py1WHDgkGRGCKtpJDvBfYQAW6E3b4XvaN2WKATUB2LxF")
            {
                //Set text of xmr to "Secure"
                xmr.Text = "Secure";
                //Set color of xmr to green
                xmr.ForeColor = Color.Green;
                //Set xmr to bold
                xmr.Font = new Font(xmr.Font, FontStyle.Bold);
                //add 1 to passedChecks
                passedChecks++;
            }
            else
            {
                xmr.Text = "Not Secure";
                //Set color of xmr to red
                xmr.ForeColor = Color.Red;
                //Set xmr to bold
                xmr.Font = new Font(xmr.Font, FontStyle.Bold);
            }
        }

        public void nano()
        {
            //Sets clipboard to a nano address
            Clipboard.SetText("nano_1ripofytzqr5y7s79yxgeafcw9aqgkj9f7q4t5e66xnsy69prx1diwjcg36m");
            //Sets the current clipboard to a variable called clip to later check
            string clip = Clipboard.GetText();
            //Checks if the clipboard matches the tested address
            if (clip == "nano_1ripofytzqr5y7s79yxgeafcw9aqgkj9f7q4t5e66xnsy69prx1diwjcg36m")
            {
                //Set text of nano to "Secure"
                xno.Text = "Secure";
                //Set color of nano to green
                xno.ForeColor = Color.Green;
                //Set nano to bold
                xno.Font = new Font(xno.Font, FontStyle.Bold);
                //add 1 to passedChecks
                passedChecks++;
            }
            else
            {
                xno.Text = "Not Secure";
                //Set color of nano to red
                xno.ForeColor = Color.Red;
                //Set nano to bold
                xno.Font = new Font(xno.Font, FontStyle.Bold);
            }
        }

        public void dogeFunction()
        {
            //Sets clipboard to a doge address
            Clipboard.SetText("DFLcc2g54piV7mD7E59ZKzaGmMkhQwyvgC");
            //Sets the current clipboard to a variable called clip to later check
            string clip = Clipboard.GetText();
            //Checks if the clipboard matches the tested address
            if (clip == "DFLcc2g54piV7mD7E59ZKzaGmMkhQwyvgC")
            {
                //Set text of doge to "Secure"
                doge.Text = "Secure";
                //Set color of doge to green
                doge.ForeColor = Color.Green;
                //Set doge to bold
                doge.Font = new Font(doge.Font, FontStyle.Bold);
                //add 1 to passedChecks
                passedChecks++;
            }
            else
            {
                doge.Text = "Not Secure";
                //Set color of doge to red
                doge.ForeColor = Color.Red;
                //Set doge to bold
                doge.Font = new Font(doge.Font, FontStyle.Bold);
            }
        }

        public void cardano()
        {
            //Sets clipboard to a cardano address
            Clipboard.SetText("addr1q8ael9jprnq6fc03l656feg5anchea6ea6qu6z68nhyde2lmn7tyz8xp5nslrl4f5nj3fm830nm4nm5pe59508wgmj4s4trlyn");
            //Sets the current clipboard to a variable called clip to later check
            string clip = Clipboard.GetText();
            //Checks if the clipboard matches the tested address
            if (clip == "addr1q8ael9jprnq6fc03l656feg5anchea6ea6qu6z68nhyde2lmn7tyz8xp5nslrl4f5nj3fm830nm4nm5pe59508wgmj4s4trlyn")
            {
                //Set text of cardino to "Secure"
                cardino.Text = "Secure";
                //Set color of cardino to green
                cardino.ForeColor = Color.Green;
                //Set cardino to bold
                cardino.Font = new Font(cardino.Font, FontStyle.Bold);
                //add 1 to passedChecks
                passedChecks++;
            }
            else
            {
                cardino.Text = "Not Secure";
                //Set color of cardino to red
                cardino.ForeColor = Color.Red;
                //Set cardino to bold
                cardino.Font = new Font(cardino.Font, FontStyle.Bold);
            }
        }
        public void polkadot()
        {
            //Sets clipboard to a polkadot address
            Clipboard.SetText("13LM3EiT1uJgbEqymhBtgs1CGqdi3avZ34JZdWqLz63h2Mqb");
            //Sets the current clipboard to a variable called clip to later check
            string clip = Clipboard.GetText();
            //Checks if the clipboard matches the tested address
            if (clip == "13LM3EiT1uJgbEqymhBtgs1CGqdi3avZ34JZdWqLz63h2Mqb")
            {
                //Set text of polkadot to "Secure"
                dot.Text = "Secure";
                //Set color of polkadot to green
                dot.ForeColor = Color.Green;
                //Set polkadot to bold
                dot.Font = new Font(dot.Font, FontStyle.Bold);
                //add 1 to passedChecks
                passedChecks++;
            }
            else
            {
                dot.Text = "Not Secure";
                //Set color of polkadot to red
                dot.ForeColor = Color.Red;
                //Set polkadot to bold
                dot.Font = new Font(dot.Font, FontStyle.Bold);
            }
            //Resize the form so you can see the pass/fail stats
            this.Size = new System.Drawing.Size(168, 221);
            //Set the text for passed checks
            pass.Text = passedChecks.ToString();
            //Calculate failed checks
            int failed = 8 - passedChecks;
            //Set the text for failed checks
            fail.Text = failed.ToString();
        }
    }
}