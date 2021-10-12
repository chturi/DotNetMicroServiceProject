namespace PlatformService.Dtos
{
    public class PlatformUpdateDto
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Cost { get; set; }
        public byte[] Revision { get; set; }
    }
}