// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.TrustedSigning.Models
{
    /// <summary> The status of the current operation. </summary>
    public readonly partial struct TrustedSigningProvisioningState : IEquatable<TrustedSigningProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TrustedSigningProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TrustedSigningProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string AcceptedValue = "Accepted";

        /// <summary> Resource has been created. </summary>
        public static TrustedSigningProvisioningState Succeeded { get; } = new TrustedSigningProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static TrustedSigningProvisioningState Failed { get; } = new TrustedSigningProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static TrustedSigningProvisioningState Canceled { get; } = new TrustedSigningProvisioningState(CanceledValue);
        /// <summary> Updating in progress. </summary>
        public static TrustedSigningProvisioningState Updating { get; } = new TrustedSigningProvisioningState(UpdatingValue);
        /// <summary> Deletion in progress. </summary>
        public static TrustedSigningProvisioningState Deleting { get; } = new TrustedSigningProvisioningState(DeletingValue);
        /// <summary> Resource creation started. </summary>
        public static TrustedSigningProvisioningState Accepted { get; } = new TrustedSigningProvisioningState(AcceptedValue);
        /// <summary> Determines if two <see cref="TrustedSigningProvisioningState"/> values are the same. </summary>
        public static bool operator ==(TrustedSigningProvisioningState left, TrustedSigningProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TrustedSigningProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(TrustedSigningProvisioningState left, TrustedSigningProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TrustedSigningProvisioningState"/>. </summary>
        public static implicit operator TrustedSigningProvisioningState(string value) => new TrustedSigningProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TrustedSigningProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TrustedSigningProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
