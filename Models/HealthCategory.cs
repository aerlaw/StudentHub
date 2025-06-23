using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace StudentHub.Models
{
    public class HealthCategory
    {
        public string Name { get; set; }
        public List<Video> Videos { get; set; }
    }
}
