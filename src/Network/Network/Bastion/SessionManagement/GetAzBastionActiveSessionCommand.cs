// ----------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Network.Bastion
{
    using System;
    using System.Collections.Generic;
    using System.Management.Automation;

    using Microsoft.Azure.Commands.Network.Models;
    using Microsoft.Azure.Commands.Network.Models.Bastion;
    using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
    using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Azure.Management.Network.Models;
    using Microsoft.Rest;

    [Cmdlet(VerbsCommon.Get,
        ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Bastion" + "ActiveSession",
        DefaultParameterSetName = BastionParameterSetNames.ByBastionObject,
        SupportsShouldProcess = true),
        OutputType(typeof(List<PSBastionActiveSession>))]
    public class GetAzBastionActiveSessionCommand : BastionBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            ParameterSetName = BastionParameterSetNames.ByResourceGroupName + BastionParameterSetNames.ByName,
            HelpMessage = "The resource group name where Bastion resource exists")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Alias("ResourceName", "BastionName")]
        [Parameter(
            Mandatory = true,
            ParameterSetName = BastionParameterSetNames.ByResourceGroupName + BastionParameterSetNames.ByName,
            HelpMessage = "The Bastion resource name.")]
        [ValidateNotNullOrEmpty]
        [ResourceNameCompleter("Microsoft.Network/bastionHosts", "ResourceGroupName")]
        public string Name { get; set; }

        [Parameter(
           Mandatory = true,
           ParameterSetName = BastionParameterSetNames.ByResourceId,
           HelpMessage = "The Bastion Resource ID")]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        [Parameter(
            Mandatory = true,
            ParameterSetName = BastionParameterSetNames.ByBastionObject,
            HelpMessage = "Bastion Object")]
        [ValidateNotNullOrEmpty]
        public PSBastion InputObject { get; set; }

        public override void Execute()
        {
            base.Execute();
            if (ParameterSetName.Equals(BastionParameterSetNames.ByResourceId, StringComparison.OrdinalIgnoreCase))
            {
                var parsedResourceId = new ResourceIdentifier(this.ResourceId);
                this.Name = parsedResourceId.ResourceName;
                this.ResourceGroupName = parsedResourceId.ResourceGroupName;
            }
            else if (ParameterSetName.Equals(BastionParameterSetNames.ByBastionObject, StringComparison.OrdinalIgnoreCase))
            {
                this.Name = this.InputObject.Name;
                this.ResourceGroupName = this.InputObject.ResourceGroupName;
            }

            if (!this.TryGetBastion(this.ResourceGroupName, this.Name, out PSBastion bastion))
            {
                throw new ItemNotFoundException(string.Format(Properties.Resources.ResourceNotFound, this.Name));
            }

            WriteVerbose($"Found Bastion:\n{bastion.ToString()}");

            // # Check if this should be added
            if (!string.Equals(bastion.ProvisioningState, PSProvisioningState.Succeeded.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                throw new ValidationException($"Bastion {bastion.Name} is in {bastion.ProvisioningState} state. Please try again later.");
            }

            List<PSBastionActiveSession> psActiveSessionsList = new List<PSBastionActiveSession>();
            var activeSessionsIterable = NetworkClient.NetworkManagementClient.GetActiveSessions(this.ResourceGroupName, this.Name);
            if (activeSessionsIterable != null)
            {
                foreach (BastionActiveSession activeSession in activeSessionsIterable)
                {
                    WriteVerbose($"Found {activeSession} active sessions from SDK");
                    PSBastionActiveSession psActiveSession = new PSBastionActiveSession(activeSession);
                    psActiveSessionsList.Add(psActiveSession);
                }
            }

            WriteVerbose($"Found {psActiveSessionsList.Count} active sessions");
            WriteObject(psActiveSessionsList);
        }
    }
}
