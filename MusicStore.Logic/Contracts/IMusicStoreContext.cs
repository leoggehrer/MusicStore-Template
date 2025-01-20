using MusicStore.Logic.DataObjects;

namespace MusicStore.Logic.Contracts
{
    public interface IMusicStoreContext
    {
        List<Album> AlbumSet { get; }
        List<Artist> ArtistSet { get; }
        List<Genre> GenreSet { get; }
        List<Track> TrackSet { get; }

        int SaveChanges();
    }
}