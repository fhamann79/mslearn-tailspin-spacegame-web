using Newtonsoft.Json;

namespace TailSpin.SpaceGame.Web.Models
{
    /// <summary>
    /// Base class for data models.
    /// </summary>
    public abstract class Model
    {
        // The value that uniquely identifies this object.
        //Esta es una prueba de diseño
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}