// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database level migration state. </summary>
    public readonly partial struct DatabaseMigrationState : IEquatable<DatabaseMigrationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatabaseMigrationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatabaseMigrationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UndefinedValue = "UNDEFINED";
        private const string InitialValue = "INITIAL";
        private const string FullBackupUploadStartValue = "FULL_BACKUP_UPLOAD_START";
        private const string LOGShippingStartValue = "LOG_SHIPPING_START";
        private const string UploadLOGFilesStartValue = "UPLOAD_LOG_FILES_START";
        private const string CutoverStartValue = "CUTOVER_START";
        private const string PostCutoverCompleteValue = "POST_CUTOVER_COMPLETE";
        private const string CompletedValue = "COMPLETED";
        private const string CancelledValue = "CANCELLED";
        private const string FailedValue = "FAILED";

        /// <summary> UNDEFINED. </summary>
        public static DatabaseMigrationState Undefined { get; } = new DatabaseMigrationState(UndefinedValue);
        /// <summary> INITIAL. </summary>
        public static DatabaseMigrationState Initial { get; } = new DatabaseMigrationState(InitialValue);
        /// <summary> FULL_BACKUP_UPLOAD_START. </summary>
        public static DatabaseMigrationState FullBackupUploadStart { get; } = new DatabaseMigrationState(FullBackupUploadStartValue);
        /// <summary> LOG_SHIPPING_START. </summary>
        public static DatabaseMigrationState LOGShippingStart { get; } = new DatabaseMigrationState(LOGShippingStartValue);
        /// <summary> UPLOAD_LOG_FILES_START. </summary>
        public static DatabaseMigrationState UploadLOGFilesStart { get; } = new DatabaseMigrationState(UploadLOGFilesStartValue);
        /// <summary> CUTOVER_START. </summary>
        public static DatabaseMigrationState CutoverStart { get; } = new DatabaseMigrationState(CutoverStartValue);
        /// <summary> POST_CUTOVER_COMPLETE. </summary>
        public static DatabaseMigrationState PostCutoverComplete { get; } = new DatabaseMigrationState(PostCutoverCompleteValue);
        /// <summary> COMPLETED. </summary>
        public static DatabaseMigrationState Completed { get; } = new DatabaseMigrationState(CompletedValue);
        /// <summary> CANCELLED. </summary>
        public static DatabaseMigrationState Cancelled { get; } = new DatabaseMigrationState(CancelledValue);
        /// <summary> FAILED. </summary>
        public static DatabaseMigrationState Failed { get; } = new DatabaseMigrationState(FailedValue);
        /// <summary> Determines if two <see cref="DatabaseMigrationState"/> values are the same. </summary>
        public static bool operator ==(DatabaseMigrationState left, DatabaseMigrationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatabaseMigrationState"/> values are not the same. </summary>
        public static bool operator !=(DatabaseMigrationState left, DatabaseMigrationState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DatabaseMigrationState"/>. </summary>
        public static implicit operator DatabaseMigrationState(string value) => new DatabaseMigrationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatabaseMigrationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatabaseMigrationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
