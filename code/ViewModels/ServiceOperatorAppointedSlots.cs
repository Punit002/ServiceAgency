namespace code.ViewModels
{
    /// <summary>
    /// Operator appointed slots with appointmentId and Time
    /// </summary>
    public class ServiceOperatorAppointedSlots
    {
        public ServiceOperatorAppointedSlots(int operatorId, int time, int appointmentId)
        {
            OperatorId = operatorId;
            Time = time;
            AppointmentId = appointmentId;
        }

        /// <summary>
        /// Operator Id
        /// </summary>
        public int OperatorId { get; set; }

        /// <summary>
        /// Time
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// AppointmentId
        /// </summary>
        public int AppointmentId { get; set; }
    }
}
