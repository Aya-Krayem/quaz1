

using System.Xml.Linq;

namespace quaz1
{
    public class Request
    {
        public string Id { get; }
        public string URL { get; set; }

        public void Print() => Console.WriteLine($"ID: {Id}, {URL} ");
    }
}
