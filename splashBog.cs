using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace GesObras
{
    public partial class splashBog : Form
    {
        private delegate void ProgressDelegate(int progress);
        private ProgressDelegate del;
       

        public splashBog()
        {
            InitializeComponent();
            this.progressBar1.Maximum = 100;
            del = this.UpdateProgressInternal;



        }
        public int Progress
        {
            get
            {
                return this.progressBar1.Value;
            }
            set
            {
                this.progressBar1.Value = value;
            }
        }
        private void UpdateProgressInternal(int progress)
        {
            if (this.Handle == null)
            {
                return;
            }
            this.progressBar1.Value = progress;
        }
        public void UpdateProgress(int progress)
        {
            this.Invoke(del, progress);
        }
    }
}
