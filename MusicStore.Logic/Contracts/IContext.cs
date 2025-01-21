namespace MusicStore.Logic.Contracts
{
    public interface IContext : IDisposable
    {
        List<IAlbum> AlbumSet { get; }
        List<IArtist> ArtistSet { get; }
        List<IGenre> GenreSet { get; }
        List<ITrack> TrackSet { get; }

        int SaveChanges();
    }
}