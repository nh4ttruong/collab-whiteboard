using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Whiteboard
{
    public partial class Create : Form
    {
        string code = "";
        public Create()
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

        private WorkSpace ws = new WorkSpace();
        private Server sr = new Server();

        public delegate void delPassData(string str, string Text, string port);
        public delegate void tranPassData( String port);


        private void createARoom_Click(object sender, EventArgs e)
        {            
            this.Close();
            Random rd = new Random();
            int index = rd.Next(0, 5);
            MyCode i = List_code[index];
            code = i.Code;
            tranPassData tran = new tranPassData(sr.tranData);
            tran(i.Port);
            delPassData del = new delPassData(ws.funData);
            del(code, Name.Text, i.Port);
            ws.Show();
        }
        
    }
}
