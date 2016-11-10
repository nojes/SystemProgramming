namespace _02_GarbageCollectorInfo
{
    class GarbageHelper
    {
        public class Person
        {
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }

            public override string ToString()
            {
                return $"{Id} {Firstname} {Lastname}";
            }
        }

        public void MakeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                var p = new Person()
                {
                    Id = 1,
                    Firstname = "Vasya",
                    Lastname = "Pupkin"
                };
            }
        }
    }
}