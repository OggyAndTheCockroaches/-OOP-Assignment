using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.pdf.parser;

namespace dynamic_timetable
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            Thread th = new Thread(new ThreadStart(splashcreen));
            th.Start();
            Thread.Sleep(50);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            InitializeComponent();
            th.Abort();
            FirstGrid();
        }
        private void FirstGrid()
        {
            DataTable temp = new DataTable();
            for(int i = 1; i <= 16; i++)
            {
                DataRow row = temp.NewRow();
                temp.Rows.Add(row);
            }
            TimetablegridControl.DataSource = temp;
        }
        private void splashcreen()
        {
            Application.Run(new StartupForm());
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barEditItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barEditItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStaticItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TimetableGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TimetablegridControl_Click(object sender, EventArgs e)
        {

        }

        private void barEditItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void PhraseBox_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FormatGroup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UploadButton_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileInfo info = new FileInfo(path);
                while (info.Extension != ".pdf")
                {
                    MessageBox.Show("Please upload a pdf file.", "Incorrect file type!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (openFileDialog1.ShowDialog() == DialogResult.Cancel) break;
                    else {
                        path = openFileDialog1.FileName;
                        info = new FileInfo(path);
                    }
                }
                UploadLabel.Text = path;
                AdvanceTab.Show();
                Weekdaydrop.ShowPopup();
            }
        }

        private void FormatButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AdvanceTab.Show();
        }

        private void Period_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
