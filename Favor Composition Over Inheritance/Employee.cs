namespace Favor_Composition_Over_Inheritance
{
    public class Employee
    {
        private readonly ISendNotification _sendNotification;
        public string Name { get; set; }
        public Employee(ISendNotification sendNotification)
        {
            _sendNotification = sendNotification;
        }
        public void notify()
        {
            _sendNotification.Send($"hello {Name}");
        }
    }
}
