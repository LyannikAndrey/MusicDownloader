namespace UserInterface.VkHelper
{

    public class VkAudio
    {
        public AlbumResponse[] response { get; set; }
    }

    public class AlbumResponse
    {
        public string aid { get; set; }
        public string owner_id { get; set; }
        public string artist { get; set; }
        public string title { get; set; }
        public string duration { get; set; }
        public string url { get; set; }
    }

}
