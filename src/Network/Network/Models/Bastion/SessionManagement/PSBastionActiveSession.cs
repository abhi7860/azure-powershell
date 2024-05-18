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

namespace Microsoft.Azure.Commands.Network.Models.Bastion
{
    using System;

    using Microsoft.WindowsAzure.Commands.Common.Attributes;
    using MNM = Management.Network.Models;

    public class PSBastionActiveSession
    {
        // Check if makes sense to use enum for Protocol
        public enum PSBastionConnectProtocol
        {
            RDP,
            SSH
        };

        [Ps1Xml(Target = ViewControl.All)]
        public string SessionId { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public DateTime StartTime { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public string TargetSubscriptionId { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public string ResourceType { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public string TargetHostName { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public string TargetResourceGroup { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public string UserName { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public string TargetIPAddress { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public string Protocol { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public string TargetResourceId { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public double SessionDurationInMins { get; set; }

        public PSBastionActiveSession()
        {
        }

        public PSBastionActiveSession(MNM.BastionActiveSession activeSession)
        {
            this.SessionId = activeSession.SessionId;
            this.StartTime = DateTime.Parse(activeSession.StartTime.ToString());
            this.TargetSubscriptionId = activeSession.TargetSubscriptionId;
            this.ResourceType = activeSession.ResourceType;
            this.TargetHostName = activeSession.TargetHostName;
            this.TargetResourceGroup = activeSession.TargetResourceGroup;
            this.UserName = activeSession.UserName;
            this.TargetIPAddress = activeSession.TargetIPAddress;
            this.Protocol = activeSession.Protocol;
            this.TargetResourceId = activeSession.TargetResourceId;
            this.SessionDurationInMins = (double)activeSession.SessionDurationInMins;
        }
    }
}
