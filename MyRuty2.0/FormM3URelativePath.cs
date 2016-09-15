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
    public partial class FormM3URelativePath : MyFormsLibrary.FormDetail01
    {
        public FormM3URelativePath()
        {
            InitializeComponent();

            ucBrowseFileSystem1.init();
        }
    }
}
