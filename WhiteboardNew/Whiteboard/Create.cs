using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Whiteboard
{
    public partial class Create : Form
    {
        string Source_code = "";
        List<string> Data_code = new List<string>();
        bool flag_code = true;
        public Create()
        {
            InitializeComponent();
        }

        private WorkSpace ws = new WorkSpace();

        public delegate void delPassData(String str, String Text);

        private void createARoom_Click(object sender, EventArgs e)
        {            
            this.Close();
            
            String code = "";
            String source = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            Random rd = new Random();
            int index;
            while (flag_code)
            {
                code = "";
                for (int i = 0; i < 6; i++)
                {
                    index = rd.Next(0, source.Length);
                    code += source[index];
                }
                if (!Data_code.Contains(code))
                {
                    flag_code = false;
                    Data_code.Add(code);
                }
            }
            Source_code = code;          
            delPassData del = new delPassData(ws.funData);
            del(code, textBox1.Text);
            ws.Show();
        }
    }
}
