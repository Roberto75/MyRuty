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
    public partial class FormSteganografia : Form
    {
        private Steganografia.PicFactory _factory = new Steganografia.PicFactory();
        private string _pathFile;

        public FormSteganografia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
           if (! openFileDialog("Immagine (*.bmp;*.tif;*.tiff;*.png)|*.bmp;*.tif;*.tiff;*.png;")) {
                return;
            }
        }


        private bool openFileDialog(String filter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select image";
            dialog.Filter = filter;
            dialog.Multiselect = false;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                _pathFile = dialog.FileName;
                return true;
            }

            /*
            Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Select image"
        OpenFileDialog1.Filter = filter
        OpenFileDialog1.Multiselect = False
        'OpenFileDialog1.InitialDirectory = Application.ExecutablePath
        'OpenFileDialog1.FileName = "source.xls"

        If(OpenFileDialog1.ShowDialog(tabPageMain) = Windows.Forms.DialogResult.OK) Then
           _pathFile = OpenFileDialog1.FileName
            _addTitleToHeader("File:", _pathFile)
            Application.DoEvents()
            Return True
        End If

        Return False*/

            return false;
        }




    }
}
