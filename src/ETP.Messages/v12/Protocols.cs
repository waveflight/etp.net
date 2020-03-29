//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2019 Energistics
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

namespace Energistics.Etp.v12
{
	public enum Protocols
	{
		Core = 0,
		ChannelStreaming = 1,		
		Discovery = 3,
		Store = 4,
		StoreNotification = 5,
		GrowingObject = 6,
        GrowingObjectNotification = 7,
        DataArray = 9,
        DiscoveryQuery = 13,
        StoreQuery = 14,
        GrowingObjectQuery = 16,
        Transaction = 18,
        ChannelSubscribe = 21,
        ChannelDataLoad = 22,
        Dataspaces = 24,
		SupportedTypes = 25
    }
}
