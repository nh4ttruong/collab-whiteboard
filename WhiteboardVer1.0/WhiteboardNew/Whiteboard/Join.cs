using System;
using System.Windows.Forms;

namespace Whiteboard
{
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
        }

        private WorkSpace ws = new WorkSpace();
        
        private void joinARoom_Click(object sender, EventArgs e)
        {
            this.Close();
            ws.Show();
        }
    }
}
