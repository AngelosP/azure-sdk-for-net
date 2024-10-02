// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Authorization type options. </summary>
    public readonly partial struct ApiManagementAuthorizationType : IEquatable<ApiManagementAuthorizationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApiManagementAuthorizationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApiManagementAuthorizationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OAuth2Value = "OAuth2";

        /// <summary> OAuth2 authorization type. </summary>
        public static ApiManagementAuthorizationType OAuth2 { get; } = new ApiManagementAuthorizationType(OAuth2Value);
        /// <summary> Determines if two <see cref="ApiManagementAuthorizationType"/> values are the same. </summary>
        public static bool operator ==(ApiManagementAuthorizationType left, ApiManagementAuthorizationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApiManagementAuthorizationType"/> values are not the same. </summary>
        public static bool operator !=(ApiManagementAuthorizationType left, ApiManagementAuthorizationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ApiManagementAuthorizationType"/>. </summary>
        public static implicit operator ApiManagementAuthorizationType(string value) => new ApiManagementAuthorizationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApiManagementAuthorizationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApiManagementAuthorizationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
