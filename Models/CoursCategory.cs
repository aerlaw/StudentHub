namespace StudentHub.Models
{
    public class CoursCategory
    {
        public string Name { get; set; }
        public List<CoursSubCategory> Subcategories { get; set; }
    }
}
