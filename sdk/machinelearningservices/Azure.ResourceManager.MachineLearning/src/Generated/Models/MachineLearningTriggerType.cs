// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Is the trigger type recurrence or cron. </summary>
    public readonly partial struct MachineLearningTriggerType : IEquatable<MachineLearningTriggerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningTriggerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningTriggerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RecurrenceValue = "Recurrence";
        private const string CronValue = "Cron";

        /// <summary> Recurrence. </summary>
        public static MachineLearningTriggerType Recurrence { get; } = new MachineLearningTriggerType(RecurrenceValue);
        /// <summary> Cron. </summary>
        public static MachineLearningTriggerType Cron { get; } = new MachineLearningTriggerType(CronValue);
        /// <summary> Determines if two <see cref="MachineLearningTriggerType"/> values are the same. </summary>
        public static bool operator ==(MachineLearningTriggerType left, MachineLearningTriggerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningTriggerType"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningTriggerType left, MachineLearningTriggerType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MachineLearningTriggerType"/>. </summary>
        public static implicit operator MachineLearningTriggerType(string value) => new MachineLearningTriggerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningTriggerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningTriggerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
