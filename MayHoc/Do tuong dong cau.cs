using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace MayHoc
{
    public partial class Form3 : DevComponents.DotNetBar.OfficeForm
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new Sosanhcau());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new Sosanhcau());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            panel1.Controls.Add(new ThongTin());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new CaiDat());
        }

       
    }
    
}