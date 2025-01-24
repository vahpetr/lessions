
public class AppSettings
{
    public string? FirstWord { get; set; }
    public string? SecondWord { get; set; }


    public class Version
    {
        public int Number { get; set; }
    }

    public List<Version> Versions { get; set; } = new();
}