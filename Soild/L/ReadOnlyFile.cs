namespace Soild.L
{
    public class ReadOnlyFile
    {

        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            return "Read only file";
        }
        public void SaveText()
        {
            throw new IOException("Can't Save");
        }
    }
}
