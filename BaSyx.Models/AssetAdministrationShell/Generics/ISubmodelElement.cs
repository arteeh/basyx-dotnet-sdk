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
using Newtonsoft.Json;
using BaSyx.Models.Extensions;
using System.Runtime.Serialization;

namespace BaSyx.Models.AdminShell
{
    public delegate IValue GetValueHandler(ISubmodelElement submodelElement);
    public delegate void SetValueHandler(ISubmodelElement submodelElement, IValue value);

    public delegate TValue GetValueHandler<TValue>(ISubmodelElement submodelElement);
    public delegate void SetValueHandler<TValue>(ISubmodelElement submodelElement, TValue value);

    [JsonConverter(typeof(SubmodelElementConverter))]
    public interface ISubmodelElement : IHasSemantics, IQualifiable, IReferable, IHasKind, IModelElement, IHasDataSpecification, IValueChanged
    {
        [IgnoreDataMember]
        GetValueHandler Get { get; }
        [IgnoreDataMember]
        SetValueHandler Set { get; }
    }
}
