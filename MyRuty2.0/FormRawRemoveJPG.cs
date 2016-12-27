using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class FormRawRemoveJPG : Form
    {
        public FormRawRemoveJPG()
        {
            InitializeComponent();

            init();
        }


        private void init()
        {
            // check bosk sulla colonna 0
            listView1.OwnerDraw = true;
            listView1.ColumnClick += ListView1_ColumnClick;
            listView1.DrawColumnHeader += ListView1_DrawColumnHeader;
            listView1.DrawItem += ListView1_DrawItem;
            listView1.DrawSubItem += ListView1_DrawSubItem;


            listView1.Columns.Add("", 30);
            listView1.Columns.Add("Folder", 250);
            listView1.Columns.Add("Name", 250);
            listView1.Columns.Add("Extension", 100);
            listView1.Columns.Add("Length", 200);
            listView1.Columns.Add("CreationTime", 150);

            lblFolder.Text = "";
            lblCount.Text = "";
        }



        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            //fd.RootFolder = Environment.SpecialFolder.Recent;
            if (fd.ShowDialog(this) == DialogResult.OK)
            {
                Debug.WriteLine(fd.SelectedPath);
                lblFolder.Text = fd.SelectedPath;

                bool esito = processFolder(new DirectoryInfo(fd.SelectedPath));

                if (esito)
                {
                    lblCount.Text = String.Format("Found: {0} ",  listView1.Items.Count);
                    //listView1.
                }
            }
        }


        private bool processFolder(DirectoryInfo folder)
        {
            if (!folder.Exists)
            {
                return false;
            }
            listView1.Items.Clear();


            List<FileInfo> toBeDeleted = new List<FileInfo>();

            SearchOption option = SearchOption.AllDirectories;
            if (chkTopDirectoryOnly.Checked)
            {
                option = SearchOption.TopDirectoryOnly;
            }

            foreach (FileInfo fi in folder.EnumerateFiles("*.nef", option))
            {
                //Debug.WriteLine(fi.Name);

                //string temp = fi.Name.Replace(".nef", ".jpg");

                string temp = fi.Name.Substring(0, fi.Name.Length - 4);


                FileInfo fileJpg = new FileInfo(fi.Directory.FullName + Path.DirectorySeparatorChar + temp + ".jpg");



                if (fileJpg.Exists)
                {
                    Debug.WriteLine("To be deleted: " + fileJpg.Name);


                    ListViewItem newItem = new ListViewItem();
                    //newItem.Text = fileJpg.Name;
                    newItem.Tag = fileJpg;
                    newItem.Checked = false;
                    newItem.SubItems.Add(fileJpg.DirectoryName);
                    newItem.SubItems.Add(fileJpg.Name);
                    newItem.SubItems.Add(fileJpg.Extension);
                    newItem.SubItems.Add(fileJpg.Length.ToString());
                    newItem.SubItems.Add(fileJpg.CreationTime.ToString());

                    listView1.Items.Add(newItem);

                    //toBeDeleted.Add(fileJpg);
                }

            }




            //            listView1.Items = toBeDeleted;

            return true;
        }








        #region "Disegnare la check box sulla colonna 0 "
        private void ListView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ListView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.DrawBackground();
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(e.Header.Tag);
                }
                catch (Exception)
                {
                }
                CheckBoxRenderer.DrawCheckBox(e.Graphics,
                    new Point(e.Bounds.Left + 4, e.Bounds.Top + 4),
                    value ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal :
                    System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(this.listView1.Columns[e.Column].Tag);
                }
                catch (Exception)
                {
                }
                this.listView1.Columns[e.Column].Tag = !value;

                foreach (ListViewItem item in this.listView1.Items)
                    item.Checked = !value;

                this.listView1.Invalidate();
            }
        }

        #endregion


    }
}
