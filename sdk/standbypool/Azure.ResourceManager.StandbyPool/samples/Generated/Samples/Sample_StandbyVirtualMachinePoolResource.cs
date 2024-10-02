// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StandbyPool.Models;

namespace Azure.ResourceManager.StandbyPool.Samples
{
    public partial class Sample_StandbyVirtualMachinePoolResource
    {
        // StandbyVirtualMachinePools_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StandbyVirtualMachinePoolsGet()
        {
            // Generated from example definition: 2024-03-01/StandbyVirtualMachinePools_Get.json
            // this example is just showing the usage of "StandbyVirtualMachinePools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyVirtualMachinePoolResource created on azure
            // for more information of creating StandbyVirtualMachinePoolResource, please refer to the document of StandbyVirtualMachinePoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyVirtualMachinePoolName = "pool";
            ResourceIdentifier standbyVirtualMachinePoolResourceId = StandbyVirtualMachinePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            StandbyVirtualMachinePoolResource standbyVirtualMachinePool = client.GetStandbyVirtualMachinePoolResource(standbyVirtualMachinePoolResourceId);

            // invoke the operation
            StandbyVirtualMachinePoolResource result = await standbyVirtualMachinePool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyVirtualMachinePoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StandbyVirtualMachinePools_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_StandbyVirtualMachinePoolsDelete()
        {
            // Generated from example definition: 2024-03-01/StandbyVirtualMachinePools_Delete.json
            // this example is just showing the usage of "StandbyVirtualMachinePools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyVirtualMachinePoolResource created on azure
            // for more information of creating StandbyVirtualMachinePoolResource, please refer to the document of StandbyVirtualMachinePoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyVirtualMachinePoolName = "pool";
            ResourceIdentifier standbyVirtualMachinePoolResourceId = StandbyVirtualMachinePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            StandbyVirtualMachinePoolResource standbyVirtualMachinePool = client.GetStandbyVirtualMachinePoolResource(standbyVirtualMachinePoolResourceId);

            // invoke the operation
            await standbyVirtualMachinePool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // StandbyVirtualMachinePools_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_StandbyVirtualMachinePoolsUpdate()
        {
            // Generated from example definition: 2024-03-01/StandbyVirtualMachinePools_Update.json
            // this example is just showing the usage of "StandbyVirtualMachinePools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyVirtualMachinePoolResource created on azure
            // for more information of creating StandbyVirtualMachinePoolResource, please refer to the document of StandbyVirtualMachinePoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyVirtualMachinePoolName = "pool";
            ResourceIdentifier standbyVirtualMachinePoolResourceId = StandbyVirtualMachinePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName);
            StandbyVirtualMachinePoolResource standbyVirtualMachinePool = client.GetStandbyVirtualMachinePoolResource(standbyVirtualMachinePoolResourceId);

            // invoke the operation
            StandbyVirtualMachinePoolPatch patch = new StandbyVirtualMachinePoolPatch()
            {
                Tags =
{
},
                Properties = new StandbyVirtualMachinePoolUpdateProperties()
                {
                    ElasticityProfile = new StandbyVirtualMachinePoolElasticityProfile(304)
                    {
                        MinReadyCapacity = 300,
                    },
                    VirtualMachineState = StandbyVirtualMachineState.Running,
                    AttachedVirtualMachineScaleSetId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000009/resourceGroups/rgstandbypool/providers/Microsoft.Compute/virtualMachineScaleSets/myVmss"),
                },
            };
            StandbyVirtualMachinePoolResource result = await standbyVirtualMachinePool.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyVirtualMachinePoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StandbyVirtualMachinePools_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetStandbyVirtualMachinePools_StandbyVirtualMachinePoolsListBySubscription()
        {
            // Generated from example definition: 2024-03-01/StandbyVirtualMachinePools_ListBySubscription.json
            // this example is just showing the usage of "StandbyVirtualMachinePoolResource_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (StandbyVirtualMachinePoolResource item in subscriptionResource.GetStandbyVirtualMachinePoolsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StandbyVirtualMachinePoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
