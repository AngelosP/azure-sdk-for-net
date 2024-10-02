// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkManagerRoutingConfigurationResource
    {
        // Get routing configurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRoutingConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerRoutingConfigurationGet.json
            // this example is just showing the usage of "NetworkManagerRoutingConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerRoutingConfigurationResource created on azure
            // for more information of creating NetworkManagerRoutingConfigurationResource, please refer to the document of NetworkManagerRoutingConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestRoutingConfig";
            ResourceIdentifier networkManagerRoutingConfigurationResourceId = NetworkManagerRoutingConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            NetworkManagerRoutingConfigurationResource networkManagerRoutingConfiguration = client.GetNetworkManagerRoutingConfigurationResource(networkManagerRoutingConfigurationResourceId);

            // invoke the operation
            NetworkManagerRoutingConfigurationResource result = await networkManagerRoutingConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerRoutingConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create network manager routing configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateNetworkManagerRoutingConfiguration()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerRoutingConfigurationPut.json
            // this example is just showing the usage of "NetworkManagerRoutingConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerRoutingConfigurationResource created on azure
            // for more information of creating NetworkManagerRoutingConfigurationResource, please refer to the document of NetworkManagerRoutingConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestRoutingConfig";
            ResourceIdentifier networkManagerRoutingConfigurationResourceId = NetworkManagerRoutingConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            NetworkManagerRoutingConfigurationResource networkManagerRoutingConfiguration = client.GetNetworkManagerRoutingConfigurationResource(networkManagerRoutingConfigurationResourceId);

            // invoke the operation
            NetworkManagerRoutingConfigurationData data = new NetworkManagerRoutingConfigurationData()
            {
                Description = "A sample policy",
            };
            ArmOperation<NetworkManagerRoutingConfigurationResource> lro = await networkManagerRoutingConfiguration.UpdateAsync(WaitUntil.Completed, data);
            NetworkManagerRoutingConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerRoutingConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete network manager routing configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteNetworkManagerRoutingConfiguration()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerRoutingConfigurationDelete.json
            // this example is just showing the usage of "NetworkManagerRoutingConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerRoutingConfigurationResource created on azure
            // for more information of creating NetworkManagerRoutingConfigurationResource, please refer to the document of NetworkManagerRoutingConfigurationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestRoutingConfig";
            ResourceIdentifier networkManagerRoutingConfigurationResourceId = NetworkManagerRoutingConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName);
            NetworkManagerRoutingConfigurationResource networkManagerRoutingConfiguration = client.GetNetworkManagerRoutingConfigurationResource(networkManagerRoutingConfigurationResourceId);

            // invoke the operation
            await networkManagerRoutingConfiguration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
