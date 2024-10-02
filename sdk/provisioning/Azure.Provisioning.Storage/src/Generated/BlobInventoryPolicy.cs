// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// BlobInventoryPolicy.
/// </summary>
public partial class BlobInventoryPolicy : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The storage account blob inventory policy object. It is composed of
    /// policy rules.
    /// </summary>
    public BicepValue<BlobInventoryPolicySchema> PolicySchema { get => _policySchema; set => _policySchema.Assign(value); }
    private readonly BicepValue<BlobInventoryPolicySchema> _policySchema;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Returns the last modified date and time of the blob inventory policy.
    /// </summary>
    public BicepValue<DateTimeOffset> LastModifiedOn { get => _lastModifiedOn; }
    private readonly BicepValue<DateTimeOffset> _lastModifiedOn;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent StorageAccount.
    /// </summary>
    public StorageAccount? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<StorageAccount> _parent;

    /// <summary>
    /// Creates a new BlobInventoryPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the BlobInventoryPolicy.</param>
    /// <param name="resourceVersion">Version of the BlobInventoryPolicy.</param>
    public BlobInventoryPolicy(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Storage/storageAccounts/inventoryPolicies", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _policySchema = BicepValue<BlobInventoryPolicySchema>.DefineProperty(this, "PolicySchema", ["properties", "policy"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _lastModifiedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastModifiedOn", ["properties", "lastModifiedTime"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<StorageAccount>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported BlobInventoryPolicy resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2021-05-01.
        /// </summary>
        public static readonly string V2021_05_01 = "2021-05-01";

        /// <summary>
        /// 2021-04-01.
        /// </summary>
        public static readonly string V2021_04_01 = "2021-04-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-07-01.
        /// </summary>
        public static readonly string V2018_07_01 = "2018-07-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-06-01.
        /// </summary>
        public static readonly string V2017_06_01 = "2017-06-01";

        /// <summary>
        /// 2016-12-01.
        /// </summary>
        public static readonly string V2016_12_01 = "2016-12-01";

        /// <summary>
        /// 2016-05-01.
        /// </summary>
        public static readonly string V2016_05_01 = "2016-05-01";

        /// <summary>
        /// 2016-01-01.
        /// </summary>
        public static readonly string V2016_01_01 = "2016-01-01";

        /// <summary>
        /// 2015-06-15.
        /// </summary>
        public static readonly string V2015_06_15 = "2015-06-15";
    }

    /// <summary>
    /// Creates a reference to an existing BlobInventoryPolicy.
    /// </summary>
    /// <param name="resourceName">Name of the BlobInventoryPolicy.</param>
    /// <param name="resourceVersion">Version of the BlobInventoryPolicy.</param>
    /// <returns>The existing BlobInventoryPolicy resource.</returns>
    public static BlobInventoryPolicy FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
