/*******************************************************************************
* Copyright (c) 2022 Bosch Rexroth AG
* Author: Constantin Ziesche (constantin.ziesche@bosch.com)
*
* This program and the accompanying materials are made available under the
* terms of the MIT License which is available at
* https://github.com/eclipse-basyx/basyx-dotnet/blob/main/LICENSE
*
* SPDX-License-Identifier: MIT
*******************************************************************************/
using BaSyx.Models.AdminShell;
using System.Runtime.Serialization;

namespace BaSyx.Models.AdminShell
{
    /// <summary>
    /// A basic event
    /// </summary>
    public interface IBasicEvent : IEvent
    {
        /// <summary>
        /// Reference to the data or other elements that are being observed.
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "observed")]
        IReference Observed { get; set; }
    }
}