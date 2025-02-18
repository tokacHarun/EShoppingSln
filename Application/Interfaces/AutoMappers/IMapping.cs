namespace Application.Interfaces.AutoMappers
{
    public interface IMapping
    {
        TDestination Map<TDestination, TSource>(TSource source, string? ignore = null);
        IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null);
        TDestination Map<TDestination>(object source, string? ignore = null);
        IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null);
    }
}
