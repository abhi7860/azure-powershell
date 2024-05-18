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
    using Microsoft.WindowsAzure.Commands.Common.Attributes;
    using MNM = Management.Network.Models;

    public class PSBastionSessionState
    {
        [Ps1Xml(Target = ViewControl.All)]
        public string SessionId { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public string State { get; set; }

        [Ps1Xml(Target = ViewControl.All)]
        public string Message { get; set; }

        public PSBastionSessionState()
        {
        }

        public PSBastionSessionState(MNM.BastionSessionState sessionState)
        {
            this.SessionId = sessionState.SessionId;
            this.State = sessionState.State;
            this.Message = sessionState.Message;
        }
    }
}
