﻿/*******************************************************************************
* Copyright (c) 2020, 2021 Robert Bosch GmbH
* Author: Constantin Ziesche (constantin.ziesche@bosch.com)
*
* This program and the accompanying materials are made available under the
* terms of the Eclipse Public License 2.0 which is available at
* http://www.eclipse.org/legal/epl-2.0
*
* SPDX-License-Identifier: EPL-2.0
*******************************************************************************/

namespace BaSyx.API.Http
{
    /// <summary>
    /// The collection of a all Submodel Repository routes
    /// </summary>
    public static class SubmodelRepositoryRoutes
    {
        /// <summary>
        /// Root route
        /// </summary>
        public const string SUBMODELS = "/submodels";
        /// <summary>
        /// Submodel by id
        /// </summary>
        public const string SUBMODEL_BYID = "/submodels/{submodelIdentifier}";
    }
}
