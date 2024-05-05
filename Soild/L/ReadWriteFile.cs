namespace Soild.L
{
    public class ReadWriteFile
    {

        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            return "Read only file";
        }
        public void SaveText()
        {

        }   
    }
}
