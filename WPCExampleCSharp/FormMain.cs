using System;
using System.Windows.Forms;

namespace WPCExampleCSharp
{
    public partial class FormMain : Form
    {
        private WPC.WindowsPowerControl WinPowerControl = new WPC.WindowsPowerControl();
        private bool returnedResult;

        public FormMain()
        {
            InitializeComponent();
            ComboBoxForceOption.SelectedIndex = 0;
        }

        private void ButtonShutdown_Click(object sender, System.EventArgs e)
        {
            //WinPowerControl.Shutdown() //Parameterless call
            returnedResult = WinPowerControl.Shutdown(GetSelectedForceType());
            WriteReturnedResult();
        }

        private void ButtonPowerOff_Click(object sender, System.EventArgs e)
        {
            //WinPowerControl.PowerOff() //Parameterless call
            returnedResult = WinPowerControl.PowerOff(GetSelectedForceType());
            WriteReturnedResult();
        }

        private void ButtonRestart_Click(object sender, System.EventArgs e)
        {
            //WinPowerControl.Restart() //Parameterless call
            returnedResult = WinPowerControl.Restart(GetSelectedForceType());
            WriteReturnedResult();
        }

        private void ButtonLogOff_Click(object sender, System.EventArgs e)
        {
            //WinPowerControl.LogOff() //Parameterless call
            returnedResult = WinPowerControl.LogOff(GetSelectedForceType());
            WriteReturnedResult();
        }

        private void ButtonCheckSupport_Click(object sender, System.EventArgs e)
        {
            bool sleepSupported;
            bool hibernateSupported;

            sleepSupported = WinPowerControl.SleepSupported;
            hibernateSupported = WinPowerControl.HibernateSupported;

            ButtonSleep.Enabled = sleepSupported;
            ButtonHibernate.Enabled = hibernateSupported;

            if (sleepSupported)
            {
                LabelSleepInfo.Text = "Sleep is supported by this system";
            }

            else
            {
                LabelSleepInfo.Text = "Sleep is not supported by this system";
            }

            if (hibernateSupported)
            {
                LabelHibernateInfo.Text = "Hibernate is supported by this system";
            }
            else
            {
                LabelHibernateInfo.Text = "Hibernate is not supported by this system";
            }

            MessageBox.Show("Sleep Status: " + LabelSleepInfo.Text + Environment.NewLine + "Hibernate Status: " + LabelHibernateInfo.Text, "Suspend Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSleep_Click(object sender, System.EventArgs e)
        {
            if (WinPowerControl.SleepSupported)
            {
                //WinPowerControl.Sleep() //Parameterless call
                returnedResult = WinPowerControl.Sleep(CheckBoxForceSuspend.Checked);
            }
            else
            {
                returnedResult = false;
                MessageBox.Show("Sleep is not supported by this system", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            WriteReturnedResult();
        }

        private void ButtonHibernate_Click(object sender, System.EventArgs e)
        {
            if (WinPowerControl.HibernateSupported)
            {
                //WinPowerControl.Hibernate() //Parameterless call
                returnedResult = WinPowerControl.Hibernate(CheckBoxForceSuspend.Checked);
            }
            else
            {
                returnedResult = false;
                MessageBox.Show("Hibernate is not supported by this system", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            WriteReturnedResult();
        }

        private void ButtonLock_Click(object sender, System.EventArgs e)
        {
            returnedResult = WinPowerControl.Lock();
            WriteReturnedResult();
        }


        private WPC.Core.ShutdownCore.ForceType GetSelectedForceType()
        {
            WPC.Core.ShutdownCore.ForceType ForceType;
            ForceType = (WPC.Core.ShutdownCore.ForceType)ComboBoxForceOption.SelectedIndex;
            return ForceType;
        }

        private void WriteReturnedResult()
        {
            TextBoxResult.Text = returnedResult.ToString();
        }

    }
}
