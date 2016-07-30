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
using System.Net;
using System.Data.SqlClient;
using System.Collections;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml;
using DevExpress.XtraWaitForm;

namespace MayHoc
{
    public partial class Sosanhcau : UserControl
    {
        #region

        private string relativePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private string processedString01, processedString02;
        private DocumentCollection docCollection;
        private ProcessStartInfo processInfo; // ProcessStartInfo
        private Process process; // process
        private string Commamd;
        private XmlDocument xmlDocument;
        private XmlNodeList nodeList;
        private int countNode;
        private float similarity;
        #endregion
        public Sosanhcau()
        {
           
            InitializeComponent();
            progressPanel1.Visible = false;
            docCollection = new DocumentCollection() {DocumentList = new List<string>()};
                // initializing DocumentCollection to get two setences
        }
        private  async void btsosanh_Click(object sender, EventArgs e) // compare button
        {
            progressPanel1.Visible = true;
            await Task.Run(new Action(processStence));
            //processStence();
            txtcau1.Text = processedString01;// populate string to textbox after tokenize
            txtcau2.Text = processedString02;// populate this string to textbox
            lbKetQua.Text = "Kết quả: " + similarity.ToString();
            progressPanel1.Visible = false;

        }
        
        private void chonfile()
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Text txt|*.txt| File doc|*.docx|All file|*.*";
            openfile.Title = "Chọn file";
            openfile.InitialDirectory = @"C:\Users\Zorro\OneDrive\BÁO CÁO\Báo cáo năm 3";// edit later
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = openfile.FileName;
                txtContent.Text = File.ReadAllText(txtDuongDan.Text);
            }

        }

        private void bttachcau_Click(object sender, EventArgs e)
        {
            listViewEx1.Items.Clear();

            if (txtContent.Text == "")
            {
                DialogResult diar = MessageBox.Show("Chưa có dữ liệu, bạn có muốn chọn file đã lưu?", "Thông báo!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diar == DialogResult.Yes)
                {
                    chonfile();
                }
            }

            if (txtContent.Text == "")
                MessageBox.Show("Lỗi chưa có dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Tách đoạn văn thành các câu
            if (listViewEx1.Items.Count == 0)
            {
                // add_listview();
                string vanban = txtContent.Text.ToString();
                string[] chuoi = vanban.Split('.', '?', '!', ';', '\n');
                // tách câu với các kí tự ngăn cách câu
                // ArrayList archuoi = new ArrayList();'
                int j = 0;
                for (int i = 0; i < chuoi.Length; i++)
                {
                    if (chuoi[i] != " " && chuoi[i] != "/" && chuoi[i] != null)
                    {
                        j++;
                        chuoi[i] = chuoi[i].Trim();

                        ListViewItem a = new ListViewItem(j.ToString());
                        ListViewItem.ListViewSubItem b = new ListViewItem.ListViewSubItem(a, chuoi[i]);
                        a.SubItems.Add(b);
                        listViewEx1.Items.Add(a);
                    }
                }
            }
        }

        private void btcau1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewEx1.SelectedIndices.Count; i++)
            {
                if (listViewEx1.SelectedItems[i].Selected)
                {
                    txtcau1.Text = listViewEx1.SelectedItems[i].SubItems[1].Text;

                }
            }
        }

        private void btcau2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewEx1.SelectedIndices.Count; i++)
            {
                if (listViewEx1.SelectedItems[i].Selected)
                {
                    txtcau2.Text = listViewEx1.SelectedItems[i].SubItems[1].Text;
                }
            }
        }

        private void bthuy_Click(object sender, EventArgs e)//  cancel button
        {
            if (txtContent.Text != "")
            {
                DialogResult dalog = MessageBox.Show("Bạn có thật sự muốn xóa bản ghi này?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dalog == DialogResult.Yes)
                {
                    txtContent.Text = "";
                    txtDuongDan.Text = "";
                }
            }

        }
        
        private void btnExit_Click(object sender, EventArgs e)// exit button
        {

            DialogResult dar = MessageBox.Show("Bạn có muốn đóng chương trình?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dar == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btchonfile_Click(object sender, EventArgs e)// choose file button
        {
            chonfile();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)// refresh button
        {
            lbKetQua.Text ="Kết quả: ";
            docCollection.DocumentList.Clear();
            txtcau1.Text = "";
            txtcau2.Text = "";
            processedString01 = "";
            processedString02 = "";
        }


        public void processStence()
        {
            //Button So Sánh
            if (txtcau1.Text == "" || txtcau2.Text == "")
            {
                MessageBox.Show("Chưa đủ dữ liệu để so sánh.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.IO.File.WriteAllText(relativePath + "\\vn.hus.nlp.tagger-4.2.0-bin\\inputFirstSentence.txt",
                txtcau1.Text);
            System.IO.File.WriteAllText(relativePath + "\\vn.hus.nlp.tagger-4.2.0-bin\\inputSecondSentence.txt",
                txtcau2.Text);
            xmlDocument = new XmlDocument();
            Commamd = "vnTagger.bat -i inputFirstSentence.txt -o outputFirstSentence.txt -u"; // command
            processInfo = new ProcessStartInfo("cmd.exe", "/c " + Commamd); // initialize 
            processInfo.WorkingDirectory = relativePath + "\\vn.hus.nlp.tagger-4.2.0-bin";
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = true;
            process = Process.Start(processInfo);
            process.WaitForExit();
            //----process xml file to get a standard string
            xmlDocument.Load(relativePath + "\\vn.hus.nlp.tagger-4.2.0-bin\\outputFirstSentence.txt");
            nodeList = xmlDocument.GetElementsByTagName("w");
            countNode = nodeList.Count;
            for (int i = 0; i < countNode; i++)
            {
                if (!InvalidChacracterHandler.isInvalidChar(nodeList[i].InnerText) &&
                    !StopWordsHandler.IsStotpWord(nodeList[i].InnerText))
                {
                    processedString01 += nodeList[i].InnerText + " ";
                }
                else
                {
                    continue;
                }
            }
          
            // tokenize the sencond sentence
            Commamd = "vnTagger.bat -i inputSecondSentence.txt -o outputSecondSentence.txt -u"; // command
            processInfo = new ProcessStartInfo("cmd.exe", "/c " + Commamd); // initialize 
            processInfo.WorkingDirectory = relativePath + "\\vn.hus.nlp.tagger-4.2.0-bin";
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = true;
            process = Process.Start(processInfo);
            process.WaitForExit();
            //----- process xml file to get a standard string
            xmlDocument.Load(relativePath + "\\vn.hus.nlp.tagger-4.2.0-bin\\outputSecondSentence.txt");
            nodeList = xmlDocument.GetElementsByTagName("w");
            countNode = nodeList.Count;
            for (int i = 0; i < countNode; i++)
            {
                if (!InvalidChacracterHandler.isInvalidChar(nodeList[i].InnerText) &&
                    !StopWordsHandler.IsStotpWord(nodeList[i].InnerText))
                {
                    processedString02 += nodeList[i].InnerText + " ";
                }
                else
                {
                    continue;
                }
            }
            
            docCollection.DocumentList.Add(processedString01);// add to documentlist
            docCollection.DocumentList.Add(processedString02);
            //--------
            List<DocumentVector> vSpace = VectorSpaceModel.ProcessDocumentCollection(docCollection);
            similarity = SimilarityMatrics.FindCosineSimilarity(vSpace[0].VectorSpace, vSpace[1].VectorSpace);
            
            // want to watch visually value, uncomment the flowing statement :)))
            //Console.WriteLine("so chuoi thu duoc la: {0}", docCollection.DocumentList.Count);
            //progressPanel01.Visible = false;
            // these the flowing states just used to display console
            //Console.WriteLine("vecto thu nhat");
            //foreach (var a in vSpace[0].VectorSpace)
            //{
            //    Console.Write("{0}  ", a);
            //}
            //Console.WriteLine("\nvecto thu hai");
            //foreach (var a in vSpace[1].VectorSpace)
            //{
            //    Console.Write("{0}   ", a);
            //}
            //Console.WriteLine("\ncac cau vua nhap vao la");
            //foreach (var doc in docCollection.DocumentList)
            //{
            //    Console.WriteLine(doc);
            //}
        }

       
    }
  
}
