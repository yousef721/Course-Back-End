namespace Task11.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public DateTime AppointmentTime { get; set; }
        public int DoctorID { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
