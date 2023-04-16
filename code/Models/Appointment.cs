namespace code.Models
{
    public class Appointment
    {
        public Appointment(Guid id, int appointmentId, string description, Status status, int time, DateTime date, int operatorId)
        {
            Id = id;
            AppointmentId = appointmentId;
            Description = description;
            Status = status;
            Time = time;
            Date = date;
            OperatorId = operatorId;
        }

        public Guid Id { get; set; }

        public int AppointmentId { get; set; }

        public string Description { get; set; }

        public Status Status { get; set; }

        public int Time { get; set; }

        public DateTime Date { get; set; }

        public int OperatorId { get; set; }
    }

    public enum Status
    {
        Booked,
        Cancel
    }
}