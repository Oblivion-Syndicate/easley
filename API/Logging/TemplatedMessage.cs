//////////////////////////////////////////////
/// Filename: TemplatedMessage.cs
/// Date: July 11, 2024
/// Author: Maverick Liberty
//////////////////////////////////////////////

using System;

namespace Easley.API.Logging
{

    /// <summary>
    /// Intended to be passed to an <see cref="IEasleyLoggable"/> for templated message output
    /// </summary>
    public readonly struct TemplatedMessage : IEquatable<TemplatedMessage>
    {

        #region Operators
        public static bool operator ==(TemplatedMessage left, TemplatedMessage right) =>
            left.Equals(right);
        
        public static bool operator !=(TemplatedMessage left, TemplatedMessage right) =>
            !left.Equals(right);

        #endregion

        public readonly string Message;
        public readonly object[] Objects;

        public TemplatedMessage(string message, params object[] objects)
        {
            this.Message = message ?? throw new ArgumentNullException(message);
            this.Objects = objects;
        }

        public override bool Equals(object obj)
        {
            if (obj is TemplatedMessage other)
                return other.Message.Equals(Message) && other.Objects.Equals(Objects);

            return false;
        }

        public bool Equals(TemplatedMessage other) =>
            other.Message.Equals(Message) && other.Objects == Objects;

        public override int GetHashCode()
        {
            int hashCode = Message.GetHashCode();
            hashCode ^= Objects.GetHashCode();
            return hashCode;
        }

        public bool Empty() =>
            string.IsNullOrEmpty(Message);

    }

}