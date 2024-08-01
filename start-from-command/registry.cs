using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using IWshRuntimeLibrary;

namespace start_from_command
{
    public class registry : IRegistry
    {
        private string Exec_folder = @"C:\Users\Origin Systems\Documents\CmdExecutableApps";
        private string appname;
        private string shortcutpath;

        public void AddFolderToPathEnv()
        {
            var name = "Path";
            var scope = EnvironmentVariableTarget.User;
            Console.WriteLine(scope);
            var oldValue = Environment.GetEnvironmentVariable(name, scope);
            if (oldValue.Contains(Exec_folder))
            {
                MessageBox.Show("failed to add foldr to path env");
                return;
            }
            var newValue = oldValue + $";{Exec_folder}";
            Environment.SetEnvironmentVariable(name, newValue, scope);
           
        }
        public void AddSelectedAppToExecutableFolder(string selectedAppPath)
        {
            
            if (string.IsNullOrEmpty(selectedAppPath)  && CheckIfShortCutExists(GetAppsInExecFolderPath().Item1,ParseAppName(selectedAppPath))) 
            {
                MessageBox.Show("app path is null or already exist in exec folder");
                return ;
            }
            WshShell shell = new WshShell();
            shortcutpath = Path.Combine(Exec_folder, $"{ParseAppName(selectedAppPath)}_shortcut.lnk");
            IWshShortcut shortcut = shell.CreateShortcut(shortcutpath) as IWshShortcut;
            shortcut.TargetPath = selectedAppPath;
            shortcut.Save();

       
        }

        public void AddSelectedAppToRegistry(string selectedapp)
        {
            
                if (string.IsNullOrEmpty(selectedapp))
                {
                    MessageBox.Show("app is empty.", nameof(selectedapp));
                    return;
                }

                using (RegistryKey pathkey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths", true))
                {
                    if (pathkey == null)
                    {
                        MessageBox.Show("path to the registry doesnt exist.");
                    }

                    string appName = ParseAppName($"{selectedapp}.exe");
                    if (string.IsNullOrEmpty(appName))
                    {
                        MessageBox.Show("app parsing failed, the app must end with .exe");
                        return;
                    }

                    using (RegistryKey appKey = pathkey.CreateSubKey(appName))
                    {
                     

                        string pathValue = Path.Combine(Exec_folder, shortcutpath);
                        if (string.IsNullOrEmpty(pathValue))
                        {
                            MessageBox.Show("Path value is null or empty.");
                            return ;
                        }
                        appKey.SetValue(null, pathValue);
                        appKey.SetValue("Path", pathValue);
                        MessageBox.Show($"{appName} has been added to registry feel free to use it.");
                        
                        
                    }
                }

            
            }
           
        


        public (List<string>,int) GetAppsInExecFolderPath()
        {
           
            if(!Directory.Exists(Exec_folder)) return (null, 0);
            if(Directory.GetFiles(Exec_folder).Length == 0) return (null, 1);
            List<string> apps = new List<string>();
            var AppsPath = Directory.GetFiles(Exec_folder);
            foreach (var appPath in AppsPath)
            {
                var app = Path.GetFileName(appPath);
                apps.Add(app);
            }
         
            return (apps, 2);
        }
        
        public bool CheckIfShortCutExists(List<string> apps,string app)
        {
            for (int i = 0; i < apps.Count; i++) {
                
                    if(app==apps[i]){
                        
                        return false;
                    }
                
                
            }
        
            return true;

        }
        
        public  string ParseAppName(string filePath)
        {
            string pattern = @"\\([^\\]+)\.exe$";
            Match match = Regex.Match(filePath, pattern, RegexOptions.IgnoreCase);
    
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
    
            return string.Empty;
        }
        public  string DeteremineWhatToDisplay(int i)
        {

            string FolderNotfound = "no Executbale folder has been set create";
            string FodlerEmpty = "no apps has been added to exec folder";
            string NoError = "";
            
            
            switch (i)
            {
                case 0 :
                    return FolderNotfound;
                    break;
                case 1 :
                    return  FodlerEmpty;
                    break;
                case 2 :
                    return NoError;
                break;
               
                    
            };
            return null;
        }

     

     
    }
}
