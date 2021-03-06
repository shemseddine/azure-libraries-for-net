// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.GroupableResource.Definition;
    using Microsoft.Azure.Management.ContainerRegistry.Fluent.Webhook.Definition;
    using Microsoft.Azure.Management.ContainerRegistry.Fluent;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.Storage.Fluent;

    /// <summary>
    /// The first stage of a container service definition.
    /// </summary>
    public interface IBlank :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Definition.IDefinitionWithRegion<Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithGroup>
    {
    }

    /// <summary>
    /// The stage of the container service definition allowing to specify the resource group.
    /// </summary>
    public interface IWithGroup :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IBeta,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.GroupableResource.Definition.IWithGroup<Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithSku>
    {
    }

    /// <summary>
    /// The stage of the container registry definition allowing to add or remove a webhook.
    /// </summary>
    public interface IWithWebhook
    {
        /// <summary>
        /// Begins the definition of a new webhook to be added to this container registry.
        /// </summary>
        /// <param name="name">The name of the new webhook.</param>
        /// <return>The first stage of the new webhook definition.</return>
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Webhook.Definition.IBlank<Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithCreate> DefineWebhook(string name);
    }

    /// <summary>
    /// Container interface for all the definitions related to a registry.
    /// </summary>
    public interface IDefinition :
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IBlank,
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithGroup,
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithSku,
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithStorageAccount,
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithCreate
    {
    }

    /// <summary>
    /// The stage of the registry definition allowing to specify the SKU type.
    /// </summary>
    public interface IWithSku :
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithSkuBeta
    {
    }

    /// <summary>
    /// The stage of the definition which contains all the minimum required inputs for the resource to be created,
    /// but also allows for any other optional settings to be specified.
    /// </summary>
    public interface IWithCreate :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.ICreatable<Microsoft.Azure.Management.ContainerRegistry.Fluent.IRegistry>,
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithAdminUserEnabled,
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithWebhook,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Definition.IDefinitionWithTags<Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithCreate>
    {
    }

    /// <summary>
    /// The stage of the registry definition allowing to enable admin user.
    /// </summary>
    public interface IWithAdminUserEnabled
    {
        /// <summary>
        /// Enable admin user.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithCreate WithRegistryNameAsAdminUser();
    }

    /// <summary>
    /// The stage of the registry definition allowing to specify the storage account.
    /// </summary>
    public interface IWithStorageAccount :
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithStorageAccountBeta
    {
        /// <summary>
        /// The parameters for a storage account for the container registry.
        /// If specified, the storage account must be in the same physical location as the container registry.
        /// </summary>
        /// <param name="creatable">The storage account to create.</param>
        /// <return>The next stage.</return>
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithCreate WithNewStorageAccount(ICreatable<Microsoft.Azure.Management.Storage.Fluent.IStorageAccount> creatable);

        /// <summary>
        /// The parameters of a storage account for the container registry.
        /// If specified, the storage account must be in the same physical location as the container registry.
        /// </summary>
        /// <param name="storageAccount">The storage account.</param>
        /// <return>The next stage.</return>
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithCreate WithExistingStorageAccount(IStorageAccount storageAccount);

    }

    /// <summary>
    /// The stage of the registry definition allowing to specify the SKU type.
    /// </summary>
    public interface IWithSkuBeta :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IBeta
    {
        /// <summary>
        /// Creates a 'managed' registry with a 'Premium' SKU type.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithCreate WithPremiumSku();

        /// <summary>
        /// Creates a container registry with a 'Classic' SKU type.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithStorageAccount WithClassicSku();

        /// <summary>
        /// Creates a 'managed' registry with a 'Basic' SKU type.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithCreate WithBasicSku();

        /// <summary>
        /// Creates a 'managed' registry with a 'Standard' SKU type.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithCreate WithStandardSku();
    }

    /// <summary>
    /// The stage of the registry definition allowing to specify the storage account.
    /// </summary>
    public interface IWithStorageAccountBeta :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IBeta
    {
        /// <summary>
        /// The parameters for a storage account for the container registry.
        /// A new storage account with default setting and specified name will be created.
        /// </summary>
        /// <param name="storageAccountName">The name of the storage account.</param>
        /// <return>The next stage.</return>
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithCreate WithNewStorageAccount(string storageAccountName);

        /// <summary>
        /// The ID of an existing storage account for the container registry.
        /// If specified, the storage account must be in the same physical location as the container registry.
        /// </summary>
        /// <param name="id">The resource ID of the storage account; must be in the same physical location as the container registry.</param>
        /// <return>The next stage.</return>
        Microsoft.Azure.Management.ContainerRegistry.Fluent.Registry.Definition.IWithCreate WithExistingStorageAccount(string id);
    }
}