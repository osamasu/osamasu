using System.Windows.Forms;

namespace My_Calculator_V2
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void LinkLB_Email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLB_Email.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:Osamataher306@Outlook.com");
        }

        private void LinkLB_LinkedIN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLB_LinkedIN.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/osama-thabit-mohammed");
        }

        private void linkLB_Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLB_Github.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/osamasu");
        }

        private void AboutForm_Load(object sender, System.EventArgs e)
        {

        }

        private void AboutForm_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
