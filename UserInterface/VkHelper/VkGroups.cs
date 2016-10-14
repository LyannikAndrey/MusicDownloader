namespace UserInterface.VkHelper
{

    public class VkGroups
    {
        public GroupResponse[] response { get; set; }
    }

    public class GroupResponse
    {
        public int gid { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public int is_closed { get; set; }
        public int is_admin { get; set; }
        public string type { get; set; }
        public string photo { get; set; }
        public string photo_medium { get; set; }
        public string photo_big { get; set; }
    }

}
