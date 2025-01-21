using MusicStore.Logic.Contracts;

namespace MusicStore.Logic.DataContext
{
    /// <summary>
    /// Represents the data context for the Music Store application.
    /// </summary>
    public sealed class MusicStoreContext : IContext
    {
        #region Properties
        /// <summary>
        /// Gets or sets the collection of genres.
        /// </summary>
        public List<IGenre> GenreSet { get; set; }

        /// <summary>
        /// Gets or sets the collection of artists.
        /// </summary>
        public List<IArtist> ArtistSet { get; set; }

        /// <summary>
        /// Gets or sets the collection of albums.
        /// </summary>
        public List<IAlbum> AlbumSet { get; set; }

        /// <summary>
        /// Gets or sets the collection of tracks.
        /// </summary>
        public List<ITrack> TrackSet { get; set; }
        #endregion Properties

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicStoreContext"/> class.
        /// </summary>
        public MusicStoreContext()
        {
        }

        #region methods
        /// <summary>
        /// Saves changes to the data context.
        /// </summary>
        /// <returns>Returns the count of saved items.</returns>
        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion methods
    }
}
