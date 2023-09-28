namespace Emlak.WebUI.Models.DTOs
{
    public class YonetimDTO
    {
        public int UserID { get; set; } 
        public int RoleID { get; set; } 

        public bool IsAdmin => RoleID == 1; 
    }
}
