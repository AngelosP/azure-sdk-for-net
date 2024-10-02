// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The command type. </summary>
    public readonly partial struct DataFlowDebugCommandType : IEquatable<DataFlowDebugCommandType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataFlowDebugCommandType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFlowDebugCommandType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExecutePreviewQueryValue = "executePreviewQuery";
        private const string ExecuteStatisticsQueryValue = "executeStatisticsQuery";
        private const string ExecuteExpressionQueryValue = "executeExpressionQuery";

        /// <summary> executePreviewQuery. </summary>
        public static DataFlowDebugCommandType ExecutePreviewQuery { get; } = new DataFlowDebugCommandType(ExecutePreviewQueryValue);
        /// <summary> executeStatisticsQuery. </summary>
        public static DataFlowDebugCommandType ExecuteStatisticsQuery { get; } = new DataFlowDebugCommandType(ExecuteStatisticsQueryValue);
        /// <summary> executeExpressionQuery. </summary>
        public static DataFlowDebugCommandType ExecuteExpressionQuery { get; } = new DataFlowDebugCommandType(ExecuteExpressionQueryValue);
        /// <summary> Determines if two <see cref="DataFlowDebugCommandType"/> values are the same. </summary>
        public static bool operator ==(DataFlowDebugCommandType left, DataFlowDebugCommandType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataFlowDebugCommandType"/> values are not the same. </summary>
        public static bool operator !=(DataFlowDebugCommandType left, DataFlowDebugCommandType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataFlowDebugCommandType"/>. </summary>
        public static implicit operator DataFlowDebugCommandType(string value) => new DataFlowDebugCommandType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataFlowDebugCommandType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataFlowDebugCommandType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
