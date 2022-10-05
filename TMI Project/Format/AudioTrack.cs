namespace TMI_Project.Format
{
    public class AudioTrack
    {
        public string FilePath { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public bool IsMuted { get; set; }
        public AudioTrack(string filePath, string name, int volume = 50, bool isMuted = false)
        {
            FilePath = filePath;
            Name = name;
            Volume = volume;
            IsMuted = isMuted;
        }
    }
}
