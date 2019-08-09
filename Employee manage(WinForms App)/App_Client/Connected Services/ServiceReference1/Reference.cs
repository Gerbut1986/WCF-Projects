﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App_Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employers", Namespace="http://schemas.datacontract.org/2004/07/WCF_Service_App")]
    [System.SerializableAttribute()]
    public partial class Employers : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DatebirthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FIOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalaryField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Datebirthday {
            get {
                return this.DatebirthdayField;
            }
            set {
                if ((object.ReferenceEquals(this.DatebirthdayField, value) != true)) {
                    this.DatebirthdayField = value;
                    this.RaisePropertyChanged("Datebirthday");
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
        public string FIO {
            get {
                return this.FIOField;
            }
            set {
                if ((object.ReferenceEquals(this.FIOField, value) != true)) {
                    this.FIOField = value;
                    this.RaisePropertyChanged("FIO");
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
        public int Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((this.PhoneField.Equals(value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SalaryField, value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertEmployer", ReplyAction="http://tempuri.org/IService1/InsertEmployerResponse")]
        string InsertEmployer(App_Client.ServiceReference1.Employers e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertEmployer", ReplyAction="http://tempuri.org/IService1/InsertEmployerResponse")]
        System.Threading.Tasks.Task<string> InsertEmployerAsync(App_Client.ServiceReference1.Employers e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindEmployerById", ReplyAction="http://tempuri.org/IService1/FindEmployerByIdResponse")]
        string[] FindEmployerById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindEmployerById", ReplyAction="http://tempuri.org/IService1/FindEmployerByIdResponse")]
        System.Threading.Tasks.Task<string[]> FindEmployerByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowAllEntities", ReplyAction="http://tempuri.org/IService1/ShowAllEntitiesResponse")]
        System.Data.DataSet ShowAllEntities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ShowAllEntities", ReplyAction="http://tempuri.org/IService1/ShowAllEntitiesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> ShowAllEntitiesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : App_Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<App_Client.ServiceReference1.IService1>, App_Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertEmployer(App_Client.ServiceReference1.Employers e) {
            return base.Channel.InsertEmployer(e);
        }
        
        public System.Threading.Tasks.Task<string> InsertEmployerAsync(App_Client.ServiceReference1.Employers e) {
            return base.Channel.InsertEmployerAsync(e);
        }
        
        public string[] FindEmployerById(int id) {
            return base.Channel.FindEmployerById(id);
        }
        
        public System.Threading.Tasks.Task<string[]> FindEmployerByIdAsync(int id) {
            return base.Channel.FindEmployerByIdAsync(id);
        }
        
        public System.Data.DataSet ShowAllEntities() {
            return base.Channel.ShowAllEntities();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ShowAllEntitiesAsync() {
            return base.Channel.ShowAllEntitiesAsync();
        }
    }
}
