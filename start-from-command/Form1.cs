
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace start_from_command
{
    public partial class Form1 : Form
    {
        public static registry rg = new registry();
        public string SelectedApp;
  
        public List<string> applist = rg.GetAppsInExecFolderPath().Item1;
        
        public Form1()
        {  
         
            InitializeComponent();
            init_ListView();
        
         
        }
        
        public void init_ListView()
        {

            int functionreturnType = rg.GetAppsInExecFolderPath().Item2;
            if (rg.DeteremineWhatToDisplay(functionreturnType) == null)
            {
                LVapp.Visible = false;
                Lberr.Visible = true;
                Lberr.Text = rg.DeteremineWhatToDisplay(functionreturnType);
            }

            applist = rg.GetAppsInExecFolderPath().Item1;
            LVapp.DataSource = null;
            LVapp.DataSource = applist;
          
         
        
        }


        private void BTNfile_Click(object sender, EventArgs e)
        {
            
            new Dialogs().filebroswerAction(result => broswerResult(result));
             
        }

        private void broswerResult(string selectedapp)
        {
            SelectedApp = selectedapp;
            TBshowFilePath.Text = selectedapp;
            
        }

        private void BTNadd_Click(object sender, EventArgs e)
        {
         
            if (SelectedApp == null)
            {

                MessageBox.Show("please select an app befor u continue");
                return;
            } 
            rg.AddSelectedAppToExecutableFolder(SelectedApp);
            rg.AddSelectedAppToRegistry(SelectedApp);
            init_ListView();

        }


        private void LVapp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(LVapp.SelectedItem);
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}