using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MayHoc
{
    public partial class CaiDat : UserControl
    {
        public CaiDat()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
        static OpenFileDialog openfile = new OpenFileDialog();

        private void buttonX2_Click(object sender, EventArgs e)
        {
            //ButtonChonFile
            //OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Text txt|*.txt| File doc|*.docx|All file|*.*";
            openfile.Title = "Chọn file";
            openfile.InitialDirectory = @"\MayHoc\bin\Debug\";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                groupbox2.Visible = true;

                txtTuDung.Text = openfile.FileName;
                txtTuDung.Enabled = false;
                txtContent.Text = File.ReadAllText(txtTuDung.Text);
            }
        }

        private void CaiDat_Load(object sender, EventArgs e)
        {
            groupbox2.Visible = false;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            //ButtonHuy
            groupbox2.Visible = false;
            txtContent.Text = "";
            txtTuDung.Text = "";
        }

        private void buttonX1_Click_2(object sender, EventArgs e)
        {
            //Button OK
            if (txtContent.Text != "")
            {
                FileStream fs;
                fs = new FileStream(@"input.txt", FileMode.Create);//Tạo file mới stopwords // Ví dụ

               // fs = new FileStream(@"\\vnStop - words.txt", FileMode.Create);//Tạo file mới stopwords
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);

                sWriter.WriteLine(txtContent.Text);
                sWriter.Flush();
                fs.Close();
                MessageBox.Show("Thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                groupbox2.Visible = false;
                txtContent.Text = "";
                txtTuDung.Text = "";
            }
        }
    }
}
