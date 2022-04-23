

namespace Dusty
{
    /// <summary>
    /// Basic Interface for Writing a Json Format 
    /// </summary>
    public interface IJsonFormat
    {
       string Format { get; init; }
       string Description { get; init; }
       string Author { get; init; }
    }
    
}
