using System.Windows.Forms;
using Aspose.Cells;
using System.IO;
using System;

namespace Ods_to_Pdf
{
    public partial class Form1 : Form
    {

        static class GolbalVariable
        {
            public static string InputFilename, TemplateFilename, OutputFilename;
            public static int FileIndex;
            public static string Datatype = "";

        }
        public Form1()
        {
            InitializeComponent();
        }

        public void InsertData(string filename, string InputFilename)
        {
            OdsLoadOptions loadOptions = new OdsLoadOptions();
            Workbook workbook = new Workbook(filename, loadOptions);
            Worksheet worksheet = workbook.Worksheets[1];
            Cell cell = worksheet.Cells["B11"];
            cell.PutValue("Prasanna");
        }
        public void SaveData(string OutputPathname, Workbook workbook)
        {
            //string outputPath = "D:\\C#\\output.pdf";                                      //Todo: Name the File path To save
            if (OutputPathname != null)
            {
                workbook.Save(OutputPathname, SaveFormat.Pdf);
            }
            else
            {
                MessageBox.Show("Unable to Save");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string outputfile = openFileDialog1.FileName;
                GolbalVariable.TemplateFilename = openFileDialog1.FileName;
                OdsLoadOptions loadOptions = new OdsLoadOptions();
                Workbook workbook = new Workbook(filename, loadOptions);
                Worksheet worksheet = workbook.Worksheets[1];

                // Save as PDF
                //string outputPath = "D:\\C#\\output.pdf";
                //workbook.Save(outputPath, SaveFormat.Pdf);
            }
            else
            {
                MessageBox.Show("Unable to Print");
            }

            /*try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = openFileDialog1.FileName;
                    string odsFilePath = openFileDialog1.SafeFileName;
                    FilenameOutput.Text = folderPath;
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    // Specify the directory name you want to create on the desktop
                    string directoryName = "Output - " + odsFilePath;

                    // Combine the desktop path with the directory name
                    string newDirectoryPath = Path.Combine(desktopPath, directoryName);
                    try
                    {
                        Directory.CreateDirectory(newDirectoryPath);
                        try
                        {
                            string pdfFilePath = newDirectoryPath;
                            Console.Write(pdfFilePath);

                            OdsToPdfConverter converter = new OdsToPdfConverter();
                            converter.ConvertOdsToPdf(odsFilePath, pdfFilePath);

                            MessageBox.Show("Sucessfull Create");
                        }
                        catch {
                            MessageBox.Show("Unable to Create the PDF");

                        }
                    }
                    catch {
                        MessageBox.Show("Unable to Create a File");
                    }

                }
            }
            catch {
                MessageBox.Show("Unable to Open File");
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            try
            {
                Console.WriteLine(GolbalVariable.InputFilename);
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    string InputFilename = openFileDialog2.FileName;



                }
                else
                {
                    MessageBox.Show("Unable to Print");
                }
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GolbalVariable.TemplateFilename != null && GolbalVariable.InputFilename !=null)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                MessageBox.Show("Unable to Create a File");
            }
        }
    }
}