using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zenitel.Connect.Wamp.Sdk
{
    public partial class LoggingWindow : Form
    {
 
        /***********************************************************************************************************************/
        public LoggingWindow()
        /***********************************************************************************************************************/
        {
            InitializeComponent();

            //Remove "Exit"-button. Closing the logging window is done from main window
            this.ControlBox = false;
        }

        private delegate void addToLogCallBack(string txt);

        /***********************************************************************************************************************/
        public void addToLog(string txt)
        /***********************************************************************************************************************/
        {
            if (!this.lbx_Logger.IsDisposed)
            {
                if (this.lbx_Logger.InvokeRequired)
                {
                    addToLogCallBack callBack = new addToLogCallBack(addToLog);
                    this.Invoke(callBack, new object[] { txt });
                }
                else
                {
                    lbx_Logger.Items.Add(txt);
                    lbx_Logger.SelectedIndex = lbx_Logger.Items.Count - 1;
                }
            }
        }


        /***********************************************************************************************************************/
        public void ClearWindow()
        /***********************************************************************************************************************/
        {
            lbx_Logger.Items.Clear();
        }
    }
}
