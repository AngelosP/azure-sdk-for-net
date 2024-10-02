// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkWatcherResource
    {
        // Get network watcher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetNetworkWatcher()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherGet.json
            // this example is just showing the usage of "NetworkWatchers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            NetworkWatcherResource result = await networkWatcher.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkWatcherData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete network watcher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteNetworkWatcher()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherDelete.json
            // this example is just showing the usage of "NetworkWatchers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            await networkWatcher.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update network watcher tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateNetworkWatcherTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherUpdateTags.json
            // this example is just showing the usage of "NetworkWatchers_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            NetworkWatcherResource result = await networkWatcher.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkWatcherData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all network watchers
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkWatchers_ListAllNetworkWatchers()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherListAll.json
            // this example is just showing the usage of "NetworkWatchers_ListAll" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkWatcherResource item in subscriptionResource.GetNetworkWatchersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkWatcherData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Topology
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetTopology_GetTopology()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherTopologyGet.json
            // this example is just showing the usage of "NetworkWatchers_GetTopology" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            TopologyContent content = new TopologyContent()
            {
                TargetResourceGroupName = "rg2",
            };
            NetworkTopology result = await networkWatcher.GetTopologyAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Ip flow verify
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task VerifyIPFlow_IpFlowVerify()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherIpFlowVerify.json
            // this example is just showing the usage of "NetworkWatchers_VerifyIPFlow" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            VerificationIPFlowContent content = new VerificationIPFlowContent(new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1"), NetworkTrafficDirection.Outbound, IPFlowProtocol.Tcp, "80", "80", "10.2.0.4", "121.10.1.1");
            ArmOperation<VerificationIPFlowResult> lro = await networkWatcher.VerifyIPFlowAsync(WaitUntil.Completed, content);
            VerificationIPFlowResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get next hop
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNextHop_GetNextHop()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherNextHopGet.json
            // this example is just showing the usage of "NetworkWatchers_GetNextHop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            NextHopContent content = new NextHopContent(new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1"), "10.0.0.5", "10.0.0.10")
            {
                TargetNicResourceId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/networkInterfaces/nic1"),
            };
            ArmOperation<NextHopResult> lro = await networkWatcher.GetNextHopAsync(WaitUntil.Completed, content);
            NextHopResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get security group view
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVmSecurityRules_GetSecurityGroupView()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherSecurityGroupViewGet.json
            // this example is just showing the usage of "NetworkWatchers_GetVmSecurityRules" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            SecurityGroupViewContent content = new SecurityGroupViewContent(new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1"));
            ArmOperation<SecurityGroupViewResult> lro = await networkWatcher.GetVmSecurityRulesAsync(WaitUntil.Completed, content);
            SecurityGroupViewResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get troubleshooting
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetTroubleshooting_GetTroubleshooting()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherTroubleshootGet.json
            // this example is just showing the usage of "NetworkWatchers_GetTroubleshooting" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            TroubleshootingContent content = new TroubleshootingContent(new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1"), new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Storage/storageAccounts/st1"), new Uri("https://st1.blob.core.windows.net/cn1"));
            ArmOperation<TroubleshootingResult> lro = await networkWatcher.GetTroubleshootingAsync(WaitUntil.Completed, content);
            TroubleshootingResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get troubleshoot result
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetTroubleshootingResult_GetTroubleshootResult()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherTroubleshootResultQuery.json
            // this example is just showing the usage of "NetworkWatchers_GetTroubleshootingResult" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            QueryTroubleshootingContent content = new QueryTroubleshootingContent(new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1"));
            ArmOperation<TroubleshootingResult> lro = await networkWatcher.GetTroubleshootingResultAsync(WaitUntil.Completed, content);
            TroubleshootingResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Configure flow log
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SetFlowLogConfiguration_ConfigureFlowLog()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherFlowLogConfigure.json
            // this example is just showing the usage of "NetworkWatchers_SetFlowLogConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            FlowLogInformation flowLogInformation = new FlowLogInformation(new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/networkSecurityGroups/nsg1"), new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Storage/storageAccounts/st1"), true)
            {
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.ManagedIdentity/userAssignedIdentities/id1")] = new UserAssignedIdentity(),
},
                },
            };
            ArmOperation<FlowLogInformation> lro = await networkWatcher.SetFlowLogConfigurationAsync(WaitUntil.Completed, flowLogInformation);
            FlowLogInformation result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get flow log status
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetFlowLogStatus_GetFlowLogStatus()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherFlowLogStatusQuery.json
            // this example is just showing the usage of "NetworkWatchers_GetFlowLogStatus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            FlowLogStatusContent content = new FlowLogStatusContent(new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/networkSecurityGroups/nsg1"));
            ArmOperation<FlowLogInformation> lro = await networkWatcher.GetFlowLogStatusAsync(WaitUntil.Completed, content);
            FlowLogInformation result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Check connectivity
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckConnectivity_CheckConnectivity()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherConnectivityCheck.json
            // this example is just showing the usage of "NetworkWatchers_CheckConnectivity" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            ConnectivityContent content = new ConnectivityContent(new ConnectivitySource(new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1")), new ConnectivityDestination()
            {
                Address = "192.168.100.4",
                Port = 3389,
            })
            {
                PreferredIPVersion = NetworkIPVersion.IPv4,
            };
            ArmOperation<ConnectivityInformation> lro = await networkWatcher.CheckConnectivityAsync(WaitUntil.Completed, content);
            ConnectivityInformation result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Azure Reachability Report
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAzureReachabilityReport_GetAzureReachabilityReport()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherAzureReachabilityReportGet.json
            // this example is just showing the usage of "NetworkWatchers_GetAzureReachabilityReport" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            AzureReachabilityReportContent content = new AzureReachabilityReportContent(new AzureReachabilityReportLocation("United States")
            {
                State = "washington",
            }, DateTimeOffset.Parse("2017-09-07T00:00:00Z"), DateTimeOffset.Parse("2017-09-10T00:00:00Z"))
            {
                Providers =
{
"Frontier Communications of America, Inc. - ASN 5650"
},
                AzureLocations =
{
new AzureLocation("West US")
},
            };
            ArmOperation<AzureReachabilityReport> lro = await networkWatcher.GetAzureReachabilityReportAsync(WaitUntil.Completed, content);
            AzureReachabilityReport result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Available Providers List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableProviders_GetAvailableProvidersList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherAvailableProvidersListGet.json
            // this example is just showing the usage of "NetworkWatchers_ListAvailableProviders" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            AvailableProvidersListContent content = new AvailableProvidersListContent()
            {
                AzureLocations =
{
new AzureLocation("West US")
},
                Country = "United States",
                State = "washington",
                City = "seattle",
            };
            ArmOperation<AvailableProvidersList> lro = await networkWatcher.GetAvailableProvidersAsync(WaitUntil.Completed, content);
            AvailableProvidersList result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Network configuration diagnostic
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkConfigurationDiagnostic_NetworkConfigurationDiagnostic()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkWatcherNetworkConfigurationDiagnostic.json
            // this example is just showing the usage of "NetworkWatchers_GetNetworkConfigurationDiagnostic" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkWatcherResource created on azure
            // for more information of creating NetworkWatcherResource, please refer to the document of NetworkWatcherResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            ResourceIdentifier networkWatcherResourceId = NetworkWatcherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName);
            NetworkWatcherResource networkWatcher = client.GetNetworkWatcherResource(networkWatcherResourceId);

            // invoke the operation
            NetworkConfigurationDiagnosticContent content = new NetworkConfigurationDiagnosticContent(new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1"), new NetworkConfigurationDiagnosticProfile[]
            {
new NetworkConfigurationDiagnosticProfile(NetworkTrafficDirection.Inbound,"TCP","10.1.0.4","12.11.12.14","12100")
            });
            ArmOperation<NetworkConfigurationDiagnosticResponse> lro = await networkWatcher.GetNetworkConfigurationDiagnosticAsync(WaitUntil.Completed, content);
            NetworkConfigurationDiagnosticResponse result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
