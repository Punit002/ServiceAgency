namespace code.ViewModels
{
    /// <summary>
    /// Service operator open slots
    /// </summary>
    public class ServiceOperatorOpenSlots
    {
        public ServiceOperatorOpenSlots(int operatorId, int time)
        {
            OperatorId = operatorId;
            Time = time;
        }

        /// <summary>
        /// Operator Id
        /// </summary>
        public int OperatorId { get; set; }

        /// <summary>
        /// Time
        /// </summary>
        public int Time { get; set; }
    }
}