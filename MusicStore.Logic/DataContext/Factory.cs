using MusicStore.Logic.Contracts;

namespace MusicStore.Logic.DataContext
{
    /// <summary>
    /// Factory class to create instances of IMusicStoreContext.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Creates an instance of IMusicStoreContext.
        /// </summary>
        /// <returns>An instance of IMusicStoreContext.</returns>
        public static IMusicStoreContext CreateMusicStoreContext()
        {
            MusicStoreContext? result = new();

            return result;
        }
    }
}
