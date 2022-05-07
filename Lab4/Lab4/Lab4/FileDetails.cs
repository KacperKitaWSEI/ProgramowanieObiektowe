namespace Lab4
{
    public class FileDetails
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Category { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public char FirstLetter { get; set; }

        public FileDetails(string name, string extension, string category, string path, long size)
        {
            this.Name = name;
            this.Extension = extension;
            this.Category = category;
            this.Path = path;
            this.Size = size;
            this.FirstLetter = name[0];
        }

        public string FileHumanSize()
        {
            return Utils.GetFileSize(this.Size);
        }

    }

}
