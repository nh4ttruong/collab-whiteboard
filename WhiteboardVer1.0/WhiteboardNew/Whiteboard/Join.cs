using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Whiteboard
{
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
        }
        struct MyCode
        {
            public String Code;
            public String Port;
            public MyCode(String Code, String Port)
            {
                this.Code = Code;
                this.Port = Port;
            }
        }
        static List<MyCode> List_code = new List<MyCode>()
        {
            new MyCode("yV3zB7","9900"),
            new MyCode("uKz1vn","9901"),
            new MyCode("keOH2t","9902"),
            new MyCode("APgkfk","9903"),
            new MyCode("0xdXja","9904"),
            new MyCode("5GVokO","9905"),

        };
        static String FindPort(List<MyCode> List, String a)
        {
            foreach (MyCode c in List_code)
            {
                if (c.Code == a)
                    return c.Port;
            }
            return null;
        }
        private WorkSpace ws = new WorkSpace();
        /*private Server sr = new Server();*/

        public delegate void delPassData(String str, String Text, String port);
        /*public delegate void tranPassData(String port);*/

        private void joinARoom_Click(object sender, EventArgs e)
        {
            
            String port = FindPort(List_code, Code.Text);
            if(port != null)
            {
                /*tranPassData tran = new tranPassData(sr.tranData);
                tran(port);
                sr.Show();*/
                delPassData del = new delPassData(ws.funData);
                del(Code.Text, Name.Text, port);              
                ws.Show();
                this.Close();
                
            }   
            else
            {
                MessageBox.Show("Wrong code!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
