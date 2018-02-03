using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private string _password;

        public FormSteganografia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (!openFileDialog("Immagine (*.bmp;*.tif;*.tiff;*.png)|*.bmp;*.tif;*.tiff;*.png;"))
            {
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
                decode();
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


        private void decode()
        {
            Steganografia.IDecoder decoder;
            decoder = _factory.MakeDecoder();

            Steganografia.Stego stego;
            stego = new Steganografia.Stego(decoder);

            //_password = "angylilli";
            _password = "r0b3rt0";

            try
            {
                stego.Decode(_pathFile, _password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.IO.Stream message;
            message = stego.DecodedFile;

            long length;
            length = message.Length;

            System.IO.StreamReader sr;
            sr = new System.IO.StreamReader(message, UnicodeEncoding.UTF32);

            int r;
            StringBuilder output;

            try
            {
                output = new System.Text.StringBuilder((int)length, (int)length);
                r = sr.Read();

                while (r != -1)
                {
                    //output.Append(Chr(r));
                    output.Append((char)r);
                    r = sr.Read();
                }

                Debug.WriteLine(output.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Return False
            }
            finally
            {
                sr.Close();
                stego.Dispose();
            }

        }


    }
}
