// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> notification event. </summary>
    public readonly partial struct WebhookNotificationEvent : IEquatable<WebhookNotificationEvent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebhookNotificationEvent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebhookNotificationEvent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GenerateSnapshotSuccessValue = "generate_snapshot_success";
        private const string GenerateSnapshotFailedValue = "generate_snapshot_failed";
        private const string AssessmentFailureValue = "assessment_failure";
        private const string ReportConfigurationChangesValue = "report_configuration_changes";
        private const string ReportDeletionValue = "report_deletion";

        /// <summary> The subscribed report's snapshot is successfully generated. </summary>
        public static WebhookNotificationEvent GenerateSnapshotSuccess { get; } = new WebhookNotificationEvent(GenerateSnapshotSuccessValue);
        /// <summary> The subscribed report's snapshot is failed to generate. </summary>
        public static WebhookNotificationEvent GenerateSnapshotFailed { get; } = new WebhookNotificationEvent(GenerateSnapshotFailedValue);
        /// <summary> The subscribed report failed while collecting the assessments. </summary>
        public static WebhookNotificationEvent AssessmentFailure { get; } = new WebhookNotificationEvent(AssessmentFailureValue);
        /// <summary> The subscribed report's configuration is changed. </summary>
        public static WebhookNotificationEvent ReportConfigurationChanges { get; } = new WebhookNotificationEvent(ReportConfigurationChangesValue);
        /// <summary> The subscribed report is deleted. </summary>
        public static WebhookNotificationEvent ReportDeletion { get; } = new WebhookNotificationEvent(ReportDeletionValue);
        /// <summary> Determines if two <see cref="WebhookNotificationEvent"/> values are the same. </summary>
        public static bool operator ==(WebhookNotificationEvent left, WebhookNotificationEvent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebhookNotificationEvent"/> values are not the same. </summary>
        public static bool operator !=(WebhookNotificationEvent left, WebhookNotificationEvent right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WebhookNotificationEvent"/>. </summary>
        public static implicit operator WebhookNotificationEvent(string value) => new WebhookNotificationEvent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebhookNotificationEvent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebhookNotificationEvent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
