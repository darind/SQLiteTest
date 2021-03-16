namespace SQLiteTest
{
    public class Parent
    {
        public int Id { get; set; }

        public virtual Child Sender { get; set; }

        public int? SenderId { get; set; }

        public virtual Child Receiver { get; set; }

        public int? ReceiverId { get; set; }
    }
}
