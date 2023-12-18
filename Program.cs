namespace ExamQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var em = new Emergency();
            var boss = new Person("Menb", "4372613190");

            em.EventEmergency += boss.EmergencyHappen;
            em.Emergencyhappen("fire");


        }
        public class Person
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public Person(string name, string phone)
            {
                Name = name;
                Phone = phone;
            }
            public void EmrgancyHappen(object sender, EventPhone e)
            {
                Console.WriteLine("calling " + e.Messgae);
            }

            internal void EmergencyHappen(object? sender, EventPhone e)
            {
                throw new NotImplementedException();
            }
        }
        public class Emergency
        {
            public event EventHandler<EventPhone> EventEmergency;
            public void Emergencyhappen(string message)
            {
                EmrgancyCall(message);
            }
            public void EmrgancyCall(string message)
            {
                if (EventEmergency != null)
                {
                    EventEmergency.Invoke(this, new EventPhone(message));


                }
            }
        }



    }
}
}