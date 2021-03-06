﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NobiWinClient.CampaignService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Campaign", Namespace="http://schemas.datacontract.org/2004/07/Core")]
    [System.SerializableAttribute()]
    public partial class Campaign : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CampaignService.ICampaignService")]
    public interface ICampaignService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICampaignService/All", ReplyAction="http://tempuri.org/ICampaignService/AllResponse")]
        NobiWinClient.CampaignService.Campaign[] All();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICampaignService/All", ReplyAction="http://tempuri.org/ICampaignService/AllResponse")]
        System.Threading.Tasks.Task<NobiWinClient.CampaignService.Campaign[]> AllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICampaignService/Create", ReplyAction="http://tempuri.org/ICampaignService/CreateResponse")]
        void Create(NobiWinClient.CampaignService.Campaign entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICampaignService/Create", ReplyAction="http://tempuri.org/ICampaignService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(NobiWinClient.CampaignService.Campaign entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICampaignService/Read", ReplyAction="http://tempuri.org/ICampaignService/ReadResponse")]
        NobiWinClient.CampaignService.Campaign Read(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICampaignService/Read", ReplyAction="http://tempuri.org/ICampaignService/ReadResponse")]
        System.Threading.Tasks.Task<NobiWinClient.CampaignService.Campaign> ReadAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICampaignService/Update", ReplyAction="http://tempuri.org/ICampaignService/UpdateResponse")]
        void Update(NobiWinClient.CampaignService.Campaign entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICampaignService/Update", ReplyAction="http://tempuri.org/ICampaignService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(NobiWinClient.CampaignService.Campaign entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICampaignService/Delete", ReplyAction="http://tempuri.org/ICampaignService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICampaignService/Delete", ReplyAction="http://tempuri.org/ICampaignService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICampaignServiceChannel : NobiWinClient.CampaignService.ICampaignService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CampaignServiceClient : System.ServiceModel.ClientBase<NobiWinClient.CampaignService.ICampaignService>, NobiWinClient.CampaignService.ICampaignService {
        
        public CampaignServiceClient() {
        }
        
        public CampaignServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CampaignServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CampaignServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CampaignServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public NobiWinClient.CampaignService.Campaign[] All() {
            return base.Channel.All();
        }
        
        public System.Threading.Tasks.Task<NobiWinClient.CampaignService.Campaign[]> AllAsync() {
            return base.Channel.AllAsync();
        }
        
        public void Create(NobiWinClient.CampaignService.Campaign entity) {
            base.Channel.Create(entity);
        }
        
        public System.Threading.Tasks.Task CreateAsync(NobiWinClient.CampaignService.Campaign entity) {
            return base.Channel.CreateAsync(entity);
        }
        
        public NobiWinClient.CampaignService.Campaign Read(int id) {
            return base.Channel.Read(id);
        }
        
        public System.Threading.Tasks.Task<NobiWinClient.CampaignService.Campaign> ReadAsync(int id) {
            return base.Channel.ReadAsync(id);
        }
        
        public void Update(NobiWinClient.CampaignService.Campaign entity) {
            base.Channel.Update(entity);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(NobiWinClient.CampaignService.Campaign entity) {
            return base.Channel.UpdateAsync(entity);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
