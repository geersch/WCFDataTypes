﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Deze code is gegenereerd met een hulpprogramma.
//     Runtime-versie:2.0.50727.1433
//
//     Als u wijzigingen aanbrengt in dit bestand, kan dit onjuist gedrag veroorzaken wanneer
//     de code wordt gegenereerd.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="cgeers.wordpress.com", ConfigurationName="IWcfDataTypeService")]
public interface IWcfDataTypeService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="cgeers.wordpress.com/IWcfDataTypeService/GetEmployeesAsDictionary", ReplyAction="cgeers.wordpress.com/IWcfDataTypeService/GetEmployeesAsDictionaryResponse")]
    System.Collections.Generic.Dictionary<int, string> GetEmployeesAsDictionary();
    
    [System.ServiceModel.OperationContractAttribute(Action="cgeers.wordpress.com/IWcfDataTypeService/GetEmployeesAsCollection", ReplyAction="cgeers.wordpress.com/IWcfDataTypeService/GetEmployeesAsCollectionResponse")]
    System.Collections.ObjectModel.Collection<string> GetEmployeesAsCollection();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IWcfDataTypeServiceChannel : IWcfDataTypeService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class WcfDataTypeServiceClient : System.ServiceModel.ClientBase<IWcfDataTypeService>, IWcfDataTypeService
{
    
    public WcfDataTypeServiceClient()
    {
    }
    
    public WcfDataTypeServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public WcfDataTypeServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WcfDataTypeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WcfDataTypeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public System.Collections.Generic.Dictionary<int, string> GetEmployeesAsDictionary()
    {
        return base.Channel.GetEmployeesAsDictionary();
    }
    
    public System.Collections.ObjectModel.Collection<string> GetEmployeesAsCollection()
    {
        return base.Channel.GetEmployeesAsCollection();
    }
}
