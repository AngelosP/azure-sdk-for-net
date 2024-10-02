// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The confidence score calculation status, i.e. indicating if score calculation is pending for this alert, not applicable or final. </summary>
    public readonly partial struct SecurityInsightsAlertConfidenceScoreStatus : IEquatable<SecurityInsightsAlertConfidenceScoreStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAlertConfidenceScoreStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsAlertConfidenceScoreStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotApplicableValue = "NotApplicable";
        private const string InProcessValue = "InProcess";
        private const string NotFinalValue = "NotFinal";
        private const string FinalValue = "Final";

        /// <summary> Score will not be calculated for this alert as it is not supported by virtual analyst. </summary>
        public static SecurityInsightsAlertConfidenceScoreStatus NotApplicable { get; } = new SecurityInsightsAlertConfidenceScoreStatus(NotApplicableValue);
        /// <summary> No score was set yet and calculation is in progress. </summary>
        public static SecurityInsightsAlertConfidenceScoreStatus InProcess { get; } = new SecurityInsightsAlertConfidenceScoreStatus(InProcessValue);
        /// <summary> Score is calculated and shown as part of the alert, but may be updated again at a later time following the processing of additional data. </summary>
        public static SecurityInsightsAlertConfidenceScoreStatus NotFinal { get; } = new SecurityInsightsAlertConfidenceScoreStatus(NotFinalValue);
        /// <summary> Final score was calculated and available. </summary>
        public static SecurityInsightsAlertConfidenceScoreStatus Final { get; } = new SecurityInsightsAlertConfidenceScoreStatus(FinalValue);
        /// <summary> Determines if two <see cref="SecurityInsightsAlertConfidenceScoreStatus"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsAlertConfidenceScoreStatus left, SecurityInsightsAlertConfidenceScoreStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsAlertConfidenceScoreStatus"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsAlertConfidenceScoreStatus left, SecurityInsightsAlertConfidenceScoreStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SecurityInsightsAlertConfidenceScoreStatus"/>. </summary>
        public static implicit operator SecurityInsightsAlertConfidenceScoreStatus(string value) => new SecurityInsightsAlertConfidenceScoreStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsAlertConfidenceScoreStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsAlertConfidenceScoreStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
