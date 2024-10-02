// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The authentication type to use. </summary>
    public readonly partial struct ImpalaAuthenticationType : IEquatable<ImpalaAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImpalaAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImpalaAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnonymousValue = "Anonymous";
        private const string SaslUsernameValue = "SASLUsername";
        private const string UsernameAndPasswordValue = "UsernameAndPassword";

        /// <summary> Anonymous. </summary>
        public static ImpalaAuthenticationType Anonymous { get; } = new ImpalaAuthenticationType(AnonymousValue);
        /// <summary> SASLUsername. </summary>
        public static ImpalaAuthenticationType SaslUsername { get; } = new ImpalaAuthenticationType(SaslUsernameValue);
        /// <summary> UsernameAndPassword. </summary>
        public static ImpalaAuthenticationType UsernameAndPassword { get; } = new ImpalaAuthenticationType(UsernameAndPasswordValue);
        /// <summary> Determines if two <see cref="ImpalaAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(ImpalaAuthenticationType left, ImpalaAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImpalaAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(ImpalaAuthenticationType left, ImpalaAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ImpalaAuthenticationType"/>. </summary>
        public static implicit operator ImpalaAuthenticationType(string value) => new ImpalaAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImpalaAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImpalaAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
