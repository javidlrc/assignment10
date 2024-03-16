namespace mission10.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }
        IEnumerable<Teams> Teams { get; }
    }
}
