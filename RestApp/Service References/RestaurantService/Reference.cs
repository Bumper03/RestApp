﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestApp.RestaurantService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RestaurantDto", Namespace="http://schemas.datacontract.org/2004/07/Server.DTO")]
    [System.SerializableAttribute()]
    public partial class RestaurantDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlaceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid VersionField;
        
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
        public long Id {
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
        public string Place {
            get {
                return this.PlaceField;
            }
            set {
                if ((object.ReferenceEquals(this.PlaceField, value) != true)) {
                    this.PlaceField = value;
                    this.RaisePropertyChanged("Place");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Version {
            get {
                return this.VersionField;
            }
            set {
                if ((this.VersionField.Equals(value) != true)) {
                    this.VersionField = value;
                    this.RaisePropertyChanged("Version");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BadLoginCredentialsException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
    [System.SerializableAttribute()]
    public partial class BadLoginCredentialsException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NotFoundException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
    [System.SerializableAttribute()]
    public partial class NotFoundException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NotAuthorizedException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
    [System.SerializableAttribute()]
    public partial class NotAuthorizedException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ConcurrencyException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
    [System.SerializableAttribute()]
    public partial class ConcurrencyException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RestaurantService.IRestaurantService")]
    public interface IRestaurantService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/GetAllRestaurant", ReplyAction="http://tempuri.org/IRestaurantService/GetAllRestaurantResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RestApp.RestaurantService.BadLoginCredentialsException), Action="http://tempuri.org/IRestaurantService/GetAllRestaurantBadLoginCredentialsExceptio" +
            "nFault", Name="BadLoginCredentialsException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
        RestApp.RestaurantService.RestaurantDto[] GetAllRestaurant(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/GetAllRestaurant", ReplyAction="http://tempuri.org/IRestaurantService/GetAllRestaurantResponse")]
        System.Threading.Tasks.Task<RestApp.RestaurantService.RestaurantDto[]> GetAllRestaurantAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/GetMyRestaurants", ReplyAction="http://tempuri.org/IRestaurantService/GetMyRestaurantsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RestApp.RestaurantService.BadLoginCredentialsException), Action="http://tempuri.org/IRestaurantService/GetMyRestaurantsBadLoginCredentialsExceptio" +
            "nFault", Name="BadLoginCredentialsException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
        RestApp.RestaurantService.RestaurantDto[] GetMyRestaurants(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/GetMyRestaurants", ReplyAction="http://tempuri.org/IRestaurantService/GetMyRestaurantsResponse")]
        System.Threading.Tasks.Task<RestApp.RestaurantService.RestaurantDto[]> GetMyRestaurantsAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/AddRestaurant", ReplyAction="http://tempuri.org/IRestaurantService/AddRestaurantResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RestApp.RestaurantService.BadLoginCredentialsException), Action="http://tempuri.org/IRestaurantService/AddRestaurantBadLoginCredentialsExceptionFa" +
            "ult", Name="BadLoginCredentialsException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
        void AddRestaurant(string name, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/AddRestaurant", ReplyAction="http://tempuri.org/IRestaurantService/AddRestaurantResponse")]
        System.Threading.Tasks.Task AddRestaurantAsync(string name, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/EditRestaurant", ReplyAction="http://tempuri.org/IRestaurantService/EditRestaurantResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RestApp.RestaurantService.BadLoginCredentialsException), Action="http://tempuri.org/IRestaurantService/EditRestaurantBadLoginCredentialsExceptionF" +
            "ault", Name="BadLoginCredentialsException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
        [System.ServiceModel.FaultContractAttribute(typeof(RestApp.RestaurantService.NotFoundException), Action="http://tempuri.org/IRestaurantService/EditRestaurantNotFoundExceptionFault", Name="NotFoundException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
        [System.ServiceModel.FaultContractAttribute(typeof(RestApp.RestaurantService.NotAuthorizedException), Action="http://tempuri.org/IRestaurantService/EditRestaurantNotAuthorizedExceptionFault", Name="NotAuthorizedException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
        [System.ServiceModel.FaultContractAttribute(typeof(RestApp.RestaurantService.ConcurrencyException), Action="http://tempuri.org/IRestaurantService/EditRestaurantConcurrencyExceptionFault", Name="ConcurrencyException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
        void EditRestaurant(long id, string name, System.Guid version, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/EditRestaurant", ReplyAction="http://tempuri.org/IRestaurantService/EditRestaurantResponse")]
        System.Threading.Tasks.Task EditRestaurantAsync(long id, string name, System.Guid version, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/DeleteRestaurant", ReplyAction="http://tempuri.org/IRestaurantService/DeleteRestaurantResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RestApp.RestaurantService.BadLoginCredentialsException), Action="http://tempuri.org/IRestaurantService/DeleteRestaurantBadLoginCredentialsExceptio" +
            "nFault", Name="BadLoginCredentialsException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
        [System.ServiceModel.FaultContractAttribute(typeof(RestApp.RestaurantService.NotFoundException), Action="http://tempuri.org/IRestaurantService/DeleteRestaurantNotFoundExceptionFault", Name="NotFoundException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
        [System.ServiceModel.FaultContractAttribute(typeof(RestApp.RestaurantService.NotAuthorizedException), Action="http://tempuri.org/IRestaurantService/DeleteRestaurantNotAuthorizedExceptionFault" +
            "", Name="NotAuthorizedException", Namespace="http://schemas.datacontract.org/2004/07/Server.Exceptions")]
        void DeleteRestaurant(RestApp.RestaurantService.RestaurantDto restaurant, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestaurantService/DeleteRestaurant", ReplyAction="http://tempuri.org/IRestaurantService/DeleteRestaurantResponse")]
        System.Threading.Tasks.Task DeleteRestaurantAsync(RestApp.RestaurantService.RestaurantDto restaurant, string token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRestaurantServiceChannel : RestApp.RestaurantService.IRestaurantService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RestaurantServiceClient : System.ServiceModel.ClientBase<RestApp.RestaurantService.IRestaurantService>, RestApp.RestaurantService.IRestaurantService {
        
        public RestaurantServiceClient() {
        }
        
        public RestaurantServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RestaurantServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestaurantServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestaurantServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RestApp.RestaurantService.RestaurantDto[] GetAllRestaurant(string token) {
            return base.Channel.GetAllRestaurant(token);
        }
        
        public System.Threading.Tasks.Task<RestApp.RestaurantService.RestaurantDto[]> GetAllRestaurantAsync(string token) {
            return base.Channel.GetAllRestaurantAsync(token);
        }
        
        public RestApp.RestaurantService.RestaurantDto[] GetMyRestaurants(string token) {
            return base.Channel.GetMyRestaurants(token);
        }
        
        public System.Threading.Tasks.Task<RestApp.RestaurantService.RestaurantDto[]> GetMyRestaurantsAsync(string token) {
            return base.Channel.GetMyRestaurantsAsync(token);
        }
        
        public void AddRestaurant(string name, string token) {
            base.Channel.AddRestaurant(name, token);
        }
        
        public System.Threading.Tasks.Task AddRestaurantAsync(string name, string token) {
            return base.Channel.AddRestaurantAsync(name, token);
        }
        
        public void EditRestaurant(long id, string name, System.Guid version, string token) {
            base.Channel.EditRestaurant(id, name, version, token);
        }
        
        public System.Threading.Tasks.Task EditRestaurantAsync(long id, string name, System.Guid version, string token) {
            return base.Channel.EditRestaurantAsync(id, name, version, token);
        }
        
        public void DeleteRestaurant(RestApp.RestaurantService.RestaurantDto restaurant, string token) {
            base.Channel.DeleteRestaurant(restaurant, token);
        }
        
        public System.Threading.Tasks.Task DeleteRestaurantAsync(RestApp.RestaurantService.RestaurantDto restaurant, string token) {
            return base.Channel.DeleteRestaurantAsync(restaurant, token);
        }
    }
}
