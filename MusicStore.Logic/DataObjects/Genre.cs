using MusicStore.Logic.Contracts;

namespace MusicStore.Logic.DataObjects
{
    /// <summary>
    /// Represents a music genre with an identifiable ID and a name.
    /// </summary>
    public partial class Genre : IdentityObject, Contracts.IGenre
    {
        #region Properties
        /// <summary>
        /// Gets or sets the name of the genre.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        #endregion Properties

        #region Navigation Properties
        /// <summary>
        /// Gets or sets the tracks associated with the genre.
        /// </summary>
        public List<ITrack> Tracks { get; set; } = [];
        #endregion Navigation Properties

        /// <summary>
        /// Copies the properties from another genre.
        /// </summary>
        /// <param name="other">The other genre to copy properties from.</param>
        /// <exception cref="ArgumentNullException">Thrown when the other genre is null.</exception>
        public void CopyProperties(Contracts.IGenre other)
        {
            base.CopyProperties(other);

            Name = other.Name;
        }

        /// <summary>
        /// Returns a string that represents the current genre.
        /// </summary>
        /// <returns>A string that represents the current genre.</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
