using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_InvHardware
{
    public class clsWaitWindow
    {
        waitForm waiting;
        Thread loadThread;

        public void Show()
        {
            loadThread = new Thread(new ThreadStart(LoadingProcess));
            loadThread.Start();
        }

        public void Show(Form parent)
        {
            loadThread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadThread.Start(parent);
        }

        public void Close()
        {
            if (waiting != null)
            {
                waiting.BeginInvoke(new System.Threading.ThreadStart(waiting.closeWaitForm));
                waiting = null;
                loadThread = null;
            }
        }

        private void LoadingProcess()
        {
            waiting = new waitForm();
            waiting.ShowDialog();
        }

        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            waiting = new waitForm(parent1);
            waiting.ShowDialog();
        }
    }
}
