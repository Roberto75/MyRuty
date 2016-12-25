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
            listView1.Columns.Add("",30);
            listView1.Columns.Add("Name",250);
            listView1.Columns.Add("Extension",100);
            listView1.Columns.Add("Length",200);
            listView1.Columns.Add("CreationTime",150);
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fd.ShowDialog(this) == DialogResult.OK)
            {
                Debug.WriteLine(fd.SelectedPath);
                processFolder(new DirectoryInfo(fd.SelectedPath));
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

            foreach (FileInfo fi in folder.EnumerateFiles("*.nef", SearchOption.TopDirectoryOnly))
            {
                //Debug.WriteLine(fi.Name);

                //string temp = fi.Name.Replace(".nef", ".jpg");

                string temp = fi.Name.Substring(0, fi.Name.Length - 4);


                FileInfo fileJpg = new FileInfo(fi.Directory.FullName + Path.DirectorySeparatorChar + temp + ".jpg");

               

                if (fileJpg.Exists)
                {
                    Debug.WriteLine("To be deleted: " + fileJpg.Name );


                    ListViewItem newItem = new ListViewItem();
                    //newItem.Text = fileJpg.Name;
                    //newItem.Tag = fileJpg;

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

    }
}
