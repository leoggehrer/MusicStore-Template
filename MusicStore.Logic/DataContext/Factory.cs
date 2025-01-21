﻿using MusicStore.Logic.Contracts;

namespace MusicStore.Logic.DataContext
{
    /// <summary>
    /// Factory class to create instances of IContext.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Creates an instance of IContext.
        /// </summary>
        /// <returns>An instance of IContext.</returns>
        public static IContext CreateContext()
        {
            MusicStoreContext? result = new();

            return result;
        }
    }
}
