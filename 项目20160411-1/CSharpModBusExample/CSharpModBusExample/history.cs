using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpModBusExample
{

    public partial class history : Form
    {
        DB db = new DB();
        public history()
        {
            InitializeComponent();
            DataSet myDs = new DataSet();
            dataGridView1.DataSource = db.GetDataSetStr("select * from ordernew_info", "ordernew_info");
        }
    }
}
