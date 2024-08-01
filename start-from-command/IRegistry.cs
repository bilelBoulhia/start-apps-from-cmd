
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace start_from_command
{
    public interface IRegistry
    {

        void AddSelectedAppToRegistry(string selectedapp);

        void AddFolderToPathEnv();

        string ParseAppName(string filePath);
        bool CheckIfShortCutExists(List<string> apps,string app);

        (List<string>, int) GetAppsInExecFolderPath();

        string DeteremineWhatToDisplay(int i);


        void AddSelectedAppToExecutableFolder(string selectedAppPath);
    }
}