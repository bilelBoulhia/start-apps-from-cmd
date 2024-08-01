using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace start_from_command
{
    public class Dialogs
    {
        private readonly IRegistry _registry;
   
        public Dialogs()
        {
         
        }
        
     


        public string filebroswerAction(Action<string> action)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Executable files (*.exe)|*.exe",
                Title = "select file"
            };
            DialogResult result = openFileDialog.ShowDialog();
            string File = "";
            if (result == DialogResult.OK)
            {
                File = openFileDialog.FileName;

                action(File);
            }

            return File ;
        }
        public void DeleteActionConfirmAction(Action<string> action ,string selectedapp)
        {
            string message = "Do you want to delete this app for Cmd exec?";
            string title = "Delete item";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message,title , buttons);
            if (result == DialogResult.Yes)
            {
                action(selectedapp);
            } 
        }
        
    }
}