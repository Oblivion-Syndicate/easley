///////////////////////////////////////////////////////
/// Filename: INetworkNode.cs
/// Date: July 20, 2025
/// Author: Maverick Liberty
///////////////////////////////////////////////////////

using System;

namespace Easley.API.Node
{

    public interface INetworkNode
    {

        /// <summary>
        /// Fetches the Network Time as shown on the Network Clock<br/>
        /// Returns 0 if the socket is not running
        /// </summary>
        TimeSpan Time { get; }

        TimeSpan LocalTime { get; }

        INodeDataStorage DataStorage { get; }

    }

}