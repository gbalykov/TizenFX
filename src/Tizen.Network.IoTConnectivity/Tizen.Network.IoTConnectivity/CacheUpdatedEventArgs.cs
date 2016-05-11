﻿/// Copyright 2016 by Samsung Electronics, Inc.,
///
/// This software is the confidential and proprietary information
/// of Samsung Electronics, Inc. ("Confidential Information"). You
/// shall not disclose such Confidential Information and shall use
/// it only in accordance with the terms of the license agreement
/// you entered into with Samsung.

using System;

namespace Tizen.Network.IoTConnectivity
{
    /// <summary>
    /// CacheUpdatedEventArgs class. This class is an event arguments of the CacheUpdated event.
    /// </summary>
    public class CacheUpdatedEventArgs : EventArgs
    {
        /// <summary>
        /// Representation property.
        /// </summary>
        /// <returns>Representation Representation.</returns>
        public Representation Representation { get; internal set; }
    }
}
