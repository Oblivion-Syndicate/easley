///////////////////////////////////////////////////////
/// Filename: INodeDataStorage.cs
/// Date: July 20, 2025
/// Author: Maverick Liberty
///////////////////////////////////////////////////////

using Easley.API.Data;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Easley.API.Node
{

    /// <summary>
    /// Sandboxed storage for each <see cref="INetworkNode"/>
    /// </summary>

    public interface INodeDataStorage : INodeDescendant, IDisposable
    {

        /// <summary>
        /// Adds or updates an entry in a <see cref="IDataHolder"/>'s custom data dictionary.
        /// </summary>
        /// <param name="dataHolder">The non-null IDataHolder instance</param>
        /// <param name="key">The key cannot be null or empty</param>
        /// <param name="value">Any object including null is permitted</param>
        /// <returns>Whether or not the custom data entry for the <see cref="IDataHolder"/> was added or updated</returns>

        bool AddOrUpdateCustomDataEntry([NotNull] IDataHolder dataHolder,
            [NotNull] string key, object value);

        bool TryGetCustomDataEntry([NotNull] IDataHolder dataHolder,
            [NotNull] string key, out object value);

        object GetCustomDataEntry([NotNull] IDataHolder dataHolder,
            [NotNull] string key);

        /// <summary>
        /// Removes an entry in a <see cref="IDataHolder"/>'s custom data dictionary.
        /// </summary>
        /// <param name="dataHolder">The non-null IDataHolder instance</param>
        /// <param name="key">The key cannot be null or empty</param>
        /// <param name="value">Any object including null is permitted</param>
        /// <returns>Whether or not the custom data entry for the <see cref="IDataHolder"/> was deleted</returns>

        bool RemoveCustomDataEntry([NotNull] IDataHolder dataHolder,
            [NotNull] string key, out object value);

        /// <summary>
        /// Fetches the entire map of custom data for the specified <see cref="IDataHolder"/>
        /// </summary>
        /// <param name="dataHolder"></param>
        /// <returns>The entire dictionary of custom data for the specified <see cref="IDataHolder"/></returns>

        Dictionary<string, object> GetOrCreateCustomData([NotNull] IDataHolder dataHolder);

        /// <summary>
        /// Deletes the custom data associated with the specified <see cref="IDataHolder"/> (if it exists)
        /// </summary>
        /// <param name="dataHolder"></param>
        /// <returns>Whether or not a dictionary of custom data was deleted</returns>

        bool DeleteCustomData([NotNull] IDataHolder dataHolder);

        /// <summary>
        /// Checks if a dictionary of custom data exists for the specified <see cref="IDataHolder"/>
        /// </summary>
        /// <param name="dataHolder"></param>
        /// <returns>Whether or not data exists for the specified <see cref="IDataHolder"/></returns>

        public bool HasCustomData([NotNull] IDataHolder dataHolder);
    }

}
