namespace WebApplication3.Test
{

    public struct Olle : IHaveFoo
    {
        public string Foo { get; set; }
    }

    public record Pelle : IHaveFoo
    {
        public string Foo { get; init; }
    }

    public class Hakan : IHaveFoo
    {
        public string TextFromDatabase { get; init; }
        string IHaveFoo.Foo => TextFromDatabase;
    }


    public interface IHaveFoo
    {
        string Foo { get; }
    }

}