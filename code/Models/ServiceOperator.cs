namespace code.Models
{
    public class ServiceOperator
    {
        public ServiceOperator(Guid id, string firstName, string lastName, int operatorId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            OperatorId = operatorId;
        }
        public Guid Id { get; set; }

        public int OperatorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
