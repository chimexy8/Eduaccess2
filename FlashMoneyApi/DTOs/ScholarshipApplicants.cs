namespace EducationAccessApi.DTOs
{
    public class ScholarshipApplicants
    {
        public int Id { get; set; }
        public int ScholarshipId { get; set; }
        public int? UserId { get; set; }
        public bool IsRegistered { get; set; }
        public bool IsApproved { get; set; }
    }
}