// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// ContainerAppManagedCertificate.
/// </summary>
public partial class ContainerAppManagedCertificate : Resource
{
    /// <summary>
    /// Name of the Managed Certificate.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Certificate resource specific properties.
    /// </summary>
    public BicepValue<ManagedCertificateProperties> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<ManagedCertificateProperties> _properties;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerAppManagedEnvironment.
    /// </summary>
    public ContainerAppManagedEnvironment? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ContainerAppManagedEnvironment> _parent;

    /// <summary>
    /// Creates a new ContainerAppManagedCertificate.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerAppManagedCertificate.</param>
    /// <param name="resourceVersion">Version of the ContainerAppManagedCertificate.</param>
    public ContainerAppManagedCertificate(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.App/managedEnvironments/managedCertificates", resourceVersion ?? "2024-03-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _properties = BicepValue<ManagedCertificateProperties>.DefineProperty(this, "Properties", ["properties"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerAppManagedEnvironment>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ContainerAppManagedCertificate resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-02-preview.
        /// </summary>
        public static readonly string V2024_08_02_preview = "2024-08-02-preview";

        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";
    }

    /// <summary>
    /// Creates a reference to an existing ContainerAppManagedCertificate.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerAppManagedCertificate.</param>
    /// <param name="resourceVersion">Version of the ContainerAppManagedCertificate.</param>
    /// <returns>The existing ContainerAppManagedCertificate resource.</returns>
    public static ContainerAppManagedCertificate FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
