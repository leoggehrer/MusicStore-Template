using MusicStore.Logic.DataObjects;

namespace MusicStore.Logic.DataContext
{
    /// <summary>
    /// Represents the data context for the Music Store application.
    /// </summary>
    public sealed class MusicStoreContext
    {
        #region Properties
        /// <summary>
        /// Gets or sets the collection of genres.
        /// </summary>
        public List<Genre> GenreSet { get; set; }

        /// <summary>
        /// Gets or sets the collection of artists.
        /// </summary>
        public List<Artist> ArtistSet { get; set; }

        /// <summary>
        /// Gets or sets the collection of albums.
        /// </summary>
        public List<Album> AlbumSet { get; set; }

        /// <summary>
        /// Gets or sets the collection of tracks.
        /// </summary>
        public List<Track> TrackSet { get; set; }
        #endregion Properties

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicStoreContext"/> class.
        /// </summary>
        public MusicStoreContext()
        {
            GenreSet = LoadGenresFromCsv("Data/genres.csv");
            ArtistSet = LoadArtistsFromCsv("Data/artists.csv");
            AlbumSet = LoadAlbumsFromCsv("Data/albums.csv", ArtistSet);
            TrackSet = LoadTracksFromCsv("Data/tracks.csv", GenreSet, AlbumSet);
        }

        #region methods
        /// <summary>
        /// Loads genres from a CSV file.
        /// </summary>
        /// <param name="path">The path to the CSV file.</param>
        /// <returns>A list of genres.</returns>
        private static List<Genre> LoadGenresFromCsv(string path)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads artists from a CSV file.
        /// </summary>
        /// <param name="path">The path to the CSV file.</param>
        /// <returns>A list of artists.</returns>
        private static List<Artist> LoadArtistsFromCsv(string path)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads albums from a CSV file.
        /// </summary>
        /// <param name="path">The path to the CSV file.</param>
        /// <param name="artists">The collection of artists.</param>
        /// <returns>A list of albums.</returns>
        private static List<Album> LoadAlbumsFromCsv(string path, IEnumerable<Artist> artists)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads tracks from a CSV file.
        /// </summary>
        /// <param name="path">The path to the CSV file.</param>
        /// <param name="genres">The collection of genres.</param>
        /// <param name="albums">The collection of albums.</param>
        /// <returns>A list of tracks.</returns>
        private static List<Track> LoadTracksFromCsv(string path, IEnumerable<Genre> genres, IEnumerable<Album> albums)
        {
            throw new NotImplementedException();
        }
        #endregion methods
    }
}
