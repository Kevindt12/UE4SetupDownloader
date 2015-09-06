using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace UE4SetupInstaler
{


    public partial class Form1 : Form
    {
        // Public Variables
        public static String FilePath;
        public static string[] includeandexcludeFiels =       
        {
            "-exclude=IOS ", "-exclude=Linux64 ", "-include=Linux ", "-exclude=HTML5 ", "-exclude=Andriod ",
            "-exclude=WinRT ", "-exclude=OSX32 ", "-exclude=OSX64 ", "-include=VS2012 ", "-include=VS2013 ",
            "-include=VS2015 ", "-exclude=Mac "
         };

        

        public Form1()
        {
            
            InitializeComponent();
        }
        public void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

           

        }

        //Path selector and some error cheaks
        public void BtnPath_Click(object sender, EventArgs e)
        {

            // Open File Dialog to the file setup.bat to get the directiry

            FolderBrowserDialog fbd = new FolderBrowserDialog();         

            //Cheaking if the user has selected the right folder
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                // Geting the path of the setup.bat
                FilePath = fbd.SelectedPath;
            }

            // String to cheak if the files exists
            string GenerateProjectFilesbat = FilePath + "/GenerateProjectFiles.bat";

            string SetupbatPath = FilePath + "/setup.bat";

            // cheaking if the files exist if not then trow a error and disable the run button
            if (File.Exists(SetupbatPath) & File.Exists(GenerateProjectFilesbat))
            {
                BtnRun.Enabled = true;
            }

            else
            {
                MessageBox.Show("There were no Setup.bat Found or GenerateProjectFiles.bat Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnRun.Enabled = false;
            }
            

        }

            // Button run the files
        public  void BtnRun_Click(object sender, EventArgs e)
        {

            try {
                // cheaking if there was a visual studios soltion selected
                if (CBVS2012.Checked == false & CBVS2013.Checked == false & CBVS2015.Checked == false)
                {
                    MessageBox.Show("You need to select a visual studios solution ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    // isabeling the groep box os it cant be changed during use
                    groupBox1.Enabled = false;

                    // running the programs
                    ProcessStartInfo Setupbatrunner;
                    ProcessStartInfo GenerateProjectFilesbattrunner;
                    Process setupbatprocess;
                    Process GenerateProjectFilesbatprocess;

                    // running the Setup.bat and it extentions
                    Setupbatrunner = new ProcessStartInfo(FilePath + "\\Setup.bat",
                    includeandexcludeFiels[0] + includeandexcludeFiels[1] + includeandexcludeFiels[2] +
                    includeandexcludeFiels[3] + includeandexcludeFiels[4] + includeandexcludeFiels[5] +
                    includeandexcludeFiels[6] + includeandexcludeFiels[7] + includeandexcludeFiels[8] +
                    includeandexcludeFiels[9] + includeandexcludeFiels[10] + includeandexcludeFiels[11]);

                    // Starting the process and let it wait to exit
                    setupbatprocess = Process.Start(Setupbatrunner);
                    setupbatprocess.WaitForExit(150);

                    // running the GenerateProjectFiles.bat and its extantions
                    GenerateProjectFilesbattrunner = new ProcessStartInfo(FilePath + "\\GenerateProjectFiles.bat",
                    includeandexcludeFiels[0] + includeandexcludeFiels[1] + includeandexcludeFiels[2] +
                    includeandexcludeFiels[3] + includeandexcludeFiels[4] + includeandexcludeFiels[5] +
                    includeandexcludeFiels[6] + includeandexcludeFiels[7] + includeandexcludeFiels[8] +
                    includeandexcludeFiels[9] + includeandexcludeFiels[10] + includeandexcludeFiels[11]);

                    // starting the process and let it wait to exit
                    GenerateProjectFilesbatprocess = Process.Start(GenerateProjectFilesbattrunner);
                    GenerateProjectFilesbatprocess.WaitForExit(150);


                    // showing a message box saying that the operation is compleate
                    MessageBox.Show("Your instalation of the unreal engine is done", "Compleate", MessageBoxButtons.OK);
                    // reenabeling the groepbox for reuse
                    groupBox1.Enabled = true;
                }
            }
            catch
            // chacking for error's
            {
                MessageBox.Show("There was a error please repot this to the develepor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        /// //////////// Cheakbox To String array//////////////////////      
        //Lunix64
        public void CBLinux64_CheckedChanged(object sender, EventArgs e)
        {
            
           
            if (CBLinux64.Checked == true)
            {
                includeandexcludeFiels[1] = "-include=Linux64 ";
            }
            else
            {
                includeandexcludeFiels[1] = "-exclude=Linux64 ";
            }
        }
        //IOS
        private void CBIOS_CheckedChanged(object sender, EventArgs e)
        {
            if (CBIOS.Checked == true)
            {
                includeandexcludeFiels[0] = "-include=IOS ";
            }
            else
            {
                includeandexcludeFiels[0] = "-exclude=IOS ";
            }
        }
        //Linux32
        private void CBLinux32_CheckedChanged(object sender, EventArgs e)
        {
            if (CBLinux32.Checked == true)
            {
                includeandexcludeFiels[2] = "-include=Linux ";
            }
            else
            {
                includeandexcludeFiels[2] = "-exclude=Linux ";
            }
        }
        //HTML5
        private void CBHTML5_CheckedChanged(object sender, EventArgs e)
        {
            if (CBHTML5.Checked == true)
            {
                includeandexcludeFiels[3] = "-include=HTML5 ";
            }
            else
            {
                includeandexcludeFiels[3] = "-exclude=HTML5 ";
            }
        }
        //Andriod
        private void CBAndriod_CheckedChanged(object sender, EventArgs e)
        {
            if (CBAndriod.Checked == true)
            {
                includeandexcludeFiels[4] = "-include=Andriod ";
            }
            else
            {
                includeandexcludeFiels[4] = "-exclude=Andriod ";
            }
        }
        //WinRT
        private void CBWinRT_CheckedChanged(object sender, EventArgs e)
        {
            if (CBWinRT.Checked == true)
            {
                includeandexcludeFiels[5] = "-include=WinRT ";
            }
            else
            {
                includeandexcludeFiels[5] = "-exclude=WinRT ";
            }
        }
        //OSX32
        private void CBOSX32_CheckedChanged(object sender, EventArgs e)
        {
            if (CBOSX32.Checked == true)
            {
                includeandexcludeFiels[6] = "-include=OSX32 ";
            }
            else
            {
                includeandexcludeFiels[6] = "-exclude=OSX32 ";
            }

        }
        //OSX64
        private void CBOSX64_CheckedChanged(object sender, EventArgs e)
        {
            if (CBOSX64.Checked == true)
            {
                includeandexcludeFiels[7] = "-include=OSX64 ";
            }
            else
            {
                includeandexcludeFiels[7] = "-exclude=OSX64 ";
            }
        }
        //VS2012
        private void CBVS2012_CheckedChanged(object sender, EventArgs e)
        {
            if (CBVS2012.Checked == true)
            {
                includeandexcludeFiels[8] = "-include=VS2012 ";
            }
            else
            {
                includeandexcludeFiels[8] = "-exclude=VS2012 ";
                MessageBox.Show("You build might not build without VS2012", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //VS2013
        private void CBVS2013_CheckedChanged(object sender, EventArgs e)
        {
            if (CBVS2013.Checked == true)
            {
                includeandexcludeFiels[9] = "-include=VS2013 ";
            }
            else
            {
                includeandexcludeFiels[9] = "-exclude=VS2013 ";
            }
        }
        //VS2015
        private void CBVS2015_CheckedChanged(object sender, EventArgs e)
        {
            if (CBVS2015.Checked == true)
            {
                includeandexcludeFiels[10] = "-include=VS2015 ";
            }
            else
            {
                includeandexcludeFiels[10] = "-include=VS2015 ";
            }

        }
        //Mac
        private void CBMac_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMac.Checked == true)
            {
                includeandexcludeFiels[11] = "-include=Mac ";
                
            }
            else
            {
                includeandexcludeFiels[11] = "-exclude=Mac ";
            }

        }
    }
}



    
    
    



