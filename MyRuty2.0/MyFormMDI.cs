using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class MyFormMDI : MyFormsLibrary.FormMDI
    {
        public MyFormMDI()
        {
            InitializeComponent();

            initMenuTop();
        }


        private void initMenuTop()
        {

            System.Windows.Forms.ToolStripMenuItem menuTopItem;
            
            menuTopItem = new System.Windows.Forms.ToolStripMenuItem();
            menuTopItem.Text = "M3U";
            this.MenuStripTop.Items.Add(menuTopItem);


            System.Windows.Forms.ToolStripMenuItem dropDownItem;
            dropDownItem = new System.Windows.Forms.ToolStripMenuItem();
            dropDownItem.Text = "Relative path";
            dropDownItem.Click += M3U_relativePath;

            menuTopItem.DropDownItems.Add (dropDownItem);




            menuTopItem = new System.Windows.Forms.ToolStripMenuItem();
            menuTopItem.Text = "Seganografia";
            menuTopItem.Click += steganografiaOnClick;
            this.MenuStripTop.Items.Add(menuTopItem);


            menuTopItem = new System.Windows.Forms.ToolStripMenuItem();
            menuTopItem.Text = "Row remove JPG";
            menuTopItem.Click += RawRemoveJpgOnClick;
            this.MenuStripTop.Items.Add(menuTopItem);



            //this.open1ToolStripMenuItem.Name = "open1ToolStripMenuItem";
            //this.open1ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            //this.open1ToolStripMenuItem.Text = "open 1";
            //// 
            // open11ToolStripMenuItem
            // 
            //this.open11ToolStripMenuItem.Name = "open11ToolStripMenuItem";
            //this.open11ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            //this.open11ToolStripMenuItem.Text = "open 11";
            //this.open11ToolStripMenuItem.Click += new System.EventHandler(this.open11ToolStripMenuItem_Click);
        }


        void M3U_relativePath(object sender, EventArgs e)
        {
            FormM3URelativePath f = new FormM3URelativePath();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        void steganografiaOnClick(object sender, EventArgs e)
        {
            FormSteganografia f = new FormSteganografia();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }


        void RawRemoveJpgOnClick(object sender, EventArgs e)
        {
            FormRawRemoveJPG f = new FormRawRemoveJPG();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }


    }
}
