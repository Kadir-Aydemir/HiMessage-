using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiMessage.Forms
{
    public partial class SETTING2 : Form
    {
        public SETTING2()
        {
            InitializeComponent();
        }

        private void swtshowincoming_Click(object sender, EventArgs e)
        {
            Settings1.Default.showincoming = Convert.ToBoolean(swtshowincoming.Value);
            Settings1.Default.Save();
        }

        private void swtshowoutgoing_Click(object sender, EventArgs e)
        {
            Settings1.Default.showoutgoing = Convert.ToBoolean(swtshowoutgoing.Value);
            Settings1.Default.Save();
        }

        private void swtshowonline_Click(object sender, EventArgs e)
        {
            Settings1.Default.showonline = Convert.ToBoolean(swtshowonline.Value);
            Settings1.Default.Save();
        }

        private void swtshowannouncement_Click(object sender, EventArgs e)
        {
            Settings1.Default.showannouncement = Convert.ToBoolean(swtshowannouncement.Value);
            Settings1.Default.Save();
        }

        private void swtnotifyincoming_Click(object sender, EventArgs e)
        {
            Settings1.Default.inboxnotify = Convert.ToBoolean(swtnotifyincoming.Value);
            Settings1.Default.Save();
        }

        private void swtnotifyannouncement_Click(object sender, EventArgs e)
        {
            Settings1.Default.announcementnotify = Convert.ToBoolean(swtnotifyannouncement.Value);
            Settings1.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            swtshowincoming.Value = Settings1.Default.showincoming;
            swtshowoutgoing.Value = Settings1.Default.showoutgoing;
            swtshowonline.Value = Settings1.Default.showonline;
            swtshowannouncement.Value = Settings1.Default.showannouncement;
            swtnotifyincoming.Value = Settings1.Default.inboxnotify;
            swtnotifyannouncement.Value = Settings1.Default.announcementnotify;
        }

        private void SETTING2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
