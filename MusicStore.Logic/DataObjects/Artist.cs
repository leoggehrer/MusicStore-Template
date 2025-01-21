﻿using MusicStore.Logic.Contracts;

namespace MusicStore.Logic.DataObjects
{
    /// <summary>
    /// Represents an artist in the music store.
    /// </summary>
    public partial class Artist : IdentityObject, Contracts.IArtist
    {
        #region Properties
        /// <summary>
        /// Gets or sets the name of the artist.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        #endregion Properties

        #region Navigation Properties
        /// <summary>
        /// Gets or sets the albums associated with the artist.
        /// </summary>
        public List<IAlbum> Albums { get; set; } = [];
        #endregion Navigation Properties

        /// <summary>
        /// Copies the properties from another artist.
        /// </summary>
        /// <param name="other">The other artist to copy properties from.</param>
        /// <exception cref="ArgumentNullException">Thrown when the other artist is null.</exception>
        public void CopyProperties(IArtist other)
        {
            Id = other.Id;

            Id = other.Id;
            Name = other.Name;
        }

        /// <summary>
        /// Returns a string that represents the current artist.
        /// </summary>
        /// <returns>A string that represents the current artist.</returns>
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}