namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// # Records is a blueprint for creating objects 
    ///   that act as a immutable data containers.
    /// 
    /// # Records are immutable by defaults .
    /// </summary>
    public record Record(string def, string name);

    public class Class
    {
        public string Def { get; set; }
        public string Name { get; set; }
    }

    public class Main
    {
        public void Start()
        {
            var record = new Record(def: "rec", 
                                    name: "record");

            var itemClass = new Class
            {
                Def = "test",
                Name = "Test",
            };
        }
    }
}
