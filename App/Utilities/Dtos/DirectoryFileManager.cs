using System.IO;

namespace shunshine.App.Utilities.Dtos
{
    public class DirectoryFileManager
    {
        public static void GetListResutFolder(string folderRoot)
        {
            string pathRoot = Directory.GetCurrentDirectory().ToString() + "/" + folderRoot;
            var listFolder = Directory.GetDirectories(pathRoot);

            foreach (var folder in listFolder)
            {
                string folderName = DirectoryFileManager.ReplacePathFolder(pathRoot, folder);
            }
        }

        public static string ReplacePathFolder(string pathRoot, string pathhandle)
        {
            string temp = pathhandle.Replace(pathRoot, "");
            temp = temp.Replace("/", "");
            temp = temp.Replace("\\", "");
            return temp;
        }
    }
}