﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NobiWinClient.AgentService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Agent", Namespace="http://schemas.datacontract.org/2004/07/Core")]
    [System.SerializableAttribute()]
    public partial class Agent : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NobiWinClient.AgentService.Campaign CampaignField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
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
        public NobiWinClient.AgentService.Campaign Campaign {
            get {
                return this.CampaignField;
            }
            set {
                if ((object.ReferenceEquals(this.CampaignField, value) != true)) {
                    this.CampaignField = value;
                    this.RaisePropertyChanged("Campaign");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AgentService.IAgentService")]
    public interface IAgentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/All", ReplyAction="http://tempuri.org/IAgentService/AllResponse")]
        NobiWinClient.AgentService.Agent[] All();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/All", ReplyAction="http://tempuri.org/IAgentService/AllResponse")]
        System.Threading.Tasks.Task<NobiWinClient.AgentService.Agent[]> AllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/Create", ReplyAction="http://tempuri.org/IAgentService/CreateResponse")]
        void Create(NobiWinClient.AgentService.Agent entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/Create", ReplyAction="http://tempuri.org/IAgentService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(NobiWinClient.AgentService.Agent entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/Read", ReplyAction="http://tempuri.org/IAgentService/ReadResponse")]
        NobiWinClient.AgentService.Agent Read(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/Read", ReplyAction="http://tempuri.org/IAgentService/ReadResponse")]
        System.Threading.Tasks.Task<NobiWinClient.AgentService.Agent> ReadAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/Update", ReplyAction="http://tempuri.org/IAgentService/UpdateResponse")]
        void Update(NobiWinClient.AgentService.Agent entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/Update", ReplyAction="http://tempuri.org/IAgentService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(NobiWinClient.AgentService.Agent entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/Delete", ReplyAction="http://tempuri.org/IAgentService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/Delete", ReplyAction="http://tempuri.org/IAgentService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAgentServiceChannel : NobiWinClient.AgentService.IAgentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AgentServiceClient : System.ServiceModel.ClientBase<NobiWinClient.AgentService.IAgentService>, NobiWinClient.AgentService.IAgentService {
        
        public AgentServiceClient() {
        }
        
        public AgentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AgentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public NobiWinClient.AgentService.Agent[] All() {
            return base.Channel.All();
        }
        
        public System.Threading.Tasks.Task<NobiWinClient.AgentService.Agent[]> AllAsync() {
            return base.Channel.AllAsync();
        }
        
        public void Create(NobiWinClient.AgentService.Agent entity) {
            base.Channel.Create(entity);
        }
        
        public System.Threading.Tasks.Task CreateAsync(NobiWinClient.AgentService.Agent entity) {
            return base.Channel.CreateAsync(entity);
        }
        
        public NobiWinClient.AgentService.Agent Read(int id) {
            return base.Channel.Read(id);
        }
        
        public System.Threading.Tasks.Task<NobiWinClient.AgentService.Agent> ReadAsync(int id) {
            return base.Channel.ReadAsync(id);
        }
        
        public void Update(NobiWinClient.AgentService.Agent entity) {
            base.Channel.Update(entity);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(NobiWinClient.AgentService.Agent entity) {
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
