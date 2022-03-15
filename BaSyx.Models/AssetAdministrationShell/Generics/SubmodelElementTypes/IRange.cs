/*******************************************************************************
* Copyright (c) 2020, 2021 Robert Bosch GmbH
* Author: Constantin Ziesche (constantin.ziesche@bosch.com)
*
* This program and the accompanying materials are made available under the
* terms of the Eclipse Public License 2.0 which is available at
* http://www.eclipse.org/legal/epl-2.0
*
* SPDX-License-Identifier: EPL-2.0
*******************************************************************************/
using BaSyx.Models.AdminShell;
using BaSyx.Models.Extensions;
using BaSyx.Utils.Json;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace BaSyx.Models.AdminShell
{
    /// <summary>
    /// A range data element is a data element that defines a range with min and max
    /// </summary>
    [JsonConverter(typeof(RangeConverter))]
    public interface IRange : ISubmodelElement
    {
        /// <summary>
        /// The minimum value of the range. If the min value is missing then the value is assumed to be negative infinite.
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "min")]
        [JsonConverter(typeof(ValueOnlyConverter))]
        IValue Min { get; }

        /// <summary>
        /// The maximum value of the range. If the max value is missing then the value is assumed to be positive infinite.
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "max")]
        [JsonConverter(typeof(ValueOnlyConverter))]
        IValue Max { get; }

        /// <summary>
        /// Data type of the min und max.
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "valueType")]
        DataType ValueType { get; set; }
    }
}
