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
using BaSyx.Models.Connectivity;
using BaSyx.Models.AdminShell;
using BaSyx.Utils.ResultHandling;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BaSyx.Utils.DependencyInjection
{
    public static class DefaultImplementation
    {
        public static IServiceCollection AddStandardImplementation(this IServiceCollection services)
        {
            services.AddTransient<IAsset, Asset>();
            services.AddTransient<IAssetInformation, AssetInformation>();
            services.AddTransient<IAssetAdministrationShell, AssetAdministrationShell>();
            services.AddTransient<ISubmodel, Submodel>();
            services.AddTransient<IView, View>();
            services.AddTransient<IConceptDictionary, ConceptDictionary>();

            services.AddTransient<IAssetAdministrationShellRepositoryDescriptor, AssetAdministrationShellRepositoryDescriptor>();
            services.AddTransient<IAssetAdministrationShellDescriptor, AssetAdministrationShellDescriptor>();
            services.AddTransient<ISubmodelDescriptor, SubmodelDescriptor>();

            services.AddTransient(typeof(IElementContainer<>), typeof(ElementContainer<>));
            services.AddTransient(typeof(IElementContainer<IAssetAdministrationShellRepositoryDescriptor>), typeof(ElementContainer<IAssetAdministrationShellRepositoryDescriptor>));
            services.AddTransient(typeof(IElementContainer<IAssetAdministrationShellDescriptor>), typeof(ElementContainer<IAssetAdministrationShellDescriptor>));
            services.AddTransient(typeof(IElementContainer<ISubmodelDescriptor>), typeof(ElementContainer<ISubmodelDescriptor>));
            services.AddTransient(typeof(IElementContainer<IAssetAdministrationShell>), typeof(ElementContainer<IAssetAdministrationShell>));
            services.AddTransient(typeof(IElementContainer<IAsset>), typeof(ElementContainer<IAsset>));
            services.AddTransient(typeof(IElementContainer<ISubmodel>), typeof(ElementContainer<ISubmodel>));
            services.AddTransient(typeof(IElementContainer<ISubmodelElement>), typeof(ElementContainer<ISubmodelElement>));
            services.AddTransient(typeof(IElementContainer<IView>), typeof(ElementContainer<IView>));
            services.AddTransient(typeof(IElementContainer<IConceptDictionary>), typeof(ElementContainer<IConceptDictionary>));

            services.AddTransient(typeof(IQueryableElementContainer<>), typeof(QueryableElementContainer<>));
            services.AddTransient(typeof(IQueryableElementContainer<IAssetAdministrationShellDescriptor>), typeof(QueryableElementContainer<IAssetAdministrationShellDescriptor>));
            services.AddTransient(typeof(IQueryableElementContainer<ISubmodelDescriptor>), typeof(QueryableElementContainer<ISubmodelDescriptor>));

            services.AddTransient<IOperationVariableSet, OperationVariableSet>();
            services.AddTransient<IOperationVariable, OperationVariable>();

            services.AddTransient<IProperty, Property>();
            services.AddTransient(typeof(IProperty<>), typeof(Property<>));
            services.AddTransient<IOperation, Operation>();
            services.AddTransient<IEvent, BasicEvent>();
            services.AddTransient<IEventElement, EventElement>();
            services.AddTransient<IEventMessage, EventMessage>();
            services.AddTransient<ISubmodelElementCollection, SubmodelElementCollection>();
            services.AddTransient<IMultiLanguageProperty, MultiLanguageProperty>();
            services.AddTransient<IRelationshipElement, RelationshipElement>();
            services.AddTransient<IAnnotatedRelationshipElement, AnnotatedRelationshipElement>();
            services.AddTransient<IReferenceElement, ReferenceElement>();
            services.AddTransient<IFileElement, FileElement>();
            services.AddTransient<IBlob, Blob>();

            services.AddTransient<IConceptDictionary, ConceptDictionary>();
            services.AddTransient<IConceptDescription, ConceptDescription>();

            services.AddTransient<IValue, ElementValue>();
            services.AddTransient<IKey, Key>();

            services.AddTransient<IResult, Result>();
            services.AddTransient(typeof(IResult<>), typeof(Result<>));
            services.AddTransient<IMessage, Message>();

            services.AddTransient<IReference, Reference>();
            services.AddTransient(typeof(IReference<IAssetAdministrationShell>), typeof(Reference<AssetAdministrationShell>));
            services.AddTransient(typeof(IReference<IAsset>), typeof(Reference<Asset>));
            services.AddTransient(typeof(IReference<ISubmodel>), typeof(Reference<Submodel>));
            services.AddTransient(typeof(IReference<IConceptDescription>), typeof(Reference<ConceptDescription>));

            return services;
        }

        public static IServiceCollection GetStandardServiceCollection()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddStandardImplementation();
            return services;
        }

        public static IServiceProvider GetStandardServiceProvider()
        {
            IServiceCollection standardServiceCollection = GetStandardServiceCollection();
            DefaultServiceProviderFactory serviceProviderFactory = new DefaultServiceProviderFactory();
            return serviceProviderFactory.CreateServiceProvider(standardServiceCollection);
        }
    }
}
