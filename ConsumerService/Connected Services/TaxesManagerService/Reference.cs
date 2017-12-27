﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumerService.TaxesManagerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaxModel", Namespace="http://schemas.datacontract.org/2004/07/ProducerService.Models")]
    [System.SerializableAttribute()]
    public partial class TaxModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MunicipalityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PeriodEndField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PeriodStartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TaxField;
        
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
        public string Municipality {
            get {
                return this.MunicipalityField;
            }
            set {
                if ((object.ReferenceEquals(this.MunicipalityField, value) != true)) {
                    this.MunicipalityField = value;
                    this.RaisePropertyChanged("Municipality");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PeriodEnd {
            get {
                return this.PeriodEndField;
            }
            set {
                if ((this.PeriodEndField.Equals(value) != true)) {
                    this.PeriodEndField = value;
                    this.RaisePropertyChanged("PeriodEnd");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PeriodStart {
            get {
                return this.PeriodStartField;
            }
            set {
                if ((this.PeriodStartField.Equals(value) != true)) {
                    this.PeriodStartField = value;
                    this.RaisePropertyChanged("PeriodStart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Tax {
            get {
                return this.TaxField;
            }
            set {
                if ((this.TaxField.Equals(value) != true)) {
                    this.TaxField = value;
                    this.RaisePropertyChanged("Tax");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TaxesManagerService.ITaxesManagerService")]
    public interface ITaxesManagerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaxesManagerService/GetTax", ReplyAction="http://tempuri.org/ITaxesManagerService/GetTaxResponse")]
        decimal GetTax(string municipality, System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaxesManagerService/GetTax", ReplyAction="http://tempuri.org/ITaxesManagerService/GetTaxResponse")]
        System.Threading.Tasks.Task<decimal> GetTaxAsync(string municipality, System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaxesManagerService/InsertScheduledTax", ReplyAction="http://tempuri.org/ITaxesManagerService/InsertScheduledTaxResponse")]
        void InsertScheduledTax(ConsumerService.TaxesManagerService.TaxModel newRecord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaxesManagerService/InsertScheduledTax", ReplyAction="http://tempuri.org/ITaxesManagerService/InsertScheduledTaxResponse")]
        System.Threading.Tasks.Task InsertScheduledTaxAsync(ConsumerService.TaxesManagerService.TaxModel newRecord);
        
        // CODEGEN: Generating message contract since the operation UploadMunicipalitiesDataJson is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaxesManagerService/UploadMunicipalitiesDataJson", ReplyAction="http://tempuri.org/ITaxesManagerService/UploadMunicipalitiesDataJsonResponse")]
        ConsumerService.TaxesManagerService.UploadMunicipalitiesDataJsonResponse UploadMunicipalitiesDataJson(ConsumerService.TaxesManagerService.FileUploadModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaxesManagerService/UploadMunicipalitiesDataJson", ReplyAction="http://tempuri.org/ITaxesManagerService/UploadMunicipalitiesDataJsonResponse")]
        System.Threading.Tasks.Task<ConsumerService.TaxesManagerService.UploadMunicipalitiesDataJsonResponse> UploadMunicipalitiesDataJsonAsync(ConsumerService.TaxesManagerService.FileUploadModel request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FileUploadModel", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FileUploadModel {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream FileByteStream;
        
        public FileUploadModel() {
        }
        
        public FileUploadModel(System.IO.Stream FileByteStream) {
            this.FileByteStream = FileByteStream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadMunicipalitiesDataJsonResponse {
        
        public UploadMunicipalitiesDataJsonResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITaxesManagerServiceChannel : ConsumerService.TaxesManagerService.ITaxesManagerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TaxesManagerServiceClient : System.ServiceModel.ClientBase<ConsumerService.TaxesManagerService.ITaxesManagerService>, ConsumerService.TaxesManagerService.ITaxesManagerService {
        
        public TaxesManagerServiceClient() {
        }
        
        public TaxesManagerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TaxesManagerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaxesManagerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaxesManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal GetTax(string municipality, System.DateTime dateTime) {
            return base.Channel.GetTax(municipality, dateTime);
        }
        
        public System.Threading.Tasks.Task<decimal> GetTaxAsync(string municipality, System.DateTime dateTime) {
            return base.Channel.GetTaxAsync(municipality, dateTime);
        }
        
        public void InsertScheduledTax(ConsumerService.TaxesManagerService.TaxModel newRecord) {
            base.Channel.InsertScheduledTax(newRecord);
        }
        
        public System.Threading.Tasks.Task InsertScheduledTaxAsync(ConsumerService.TaxesManagerService.TaxModel newRecord) {
            return base.Channel.InsertScheduledTaxAsync(newRecord);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumerService.TaxesManagerService.UploadMunicipalitiesDataJsonResponse ConsumerService.TaxesManagerService.ITaxesManagerService.UploadMunicipalitiesDataJson(ConsumerService.TaxesManagerService.FileUploadModel request) {
            return base.Channel.UploadMunicipalitiesDataJson(request);
        }
        
        public void UploadMunicipalitiesDataJson(System.IO.Stream FileByteStream) {
            ConsumerService.TaxesManagerService.FileUploadModel inValue = new ConsumerService.TaxesManagerService.FileUploadModel();
            inValue.FileByteStream = FileByteStream;
            ConsumerService.TaxesManagerService.UploadMunicipalitiesDataJsonResponse retVal = ((ConsumerService.TaxesManagerService.ITaxesManagerService)(this)).UploadMunicipalitiesDataJson(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumerService.TaxesManagerService.UploadMunicipalitiesDataJsonResponse> ConsumerService.TaxesManagerService.ITaxesManagerService.UploadMunicipalitiesDataJsonAsync(ConsumerService.TaxesManagerService.FileUploadModel request) {
            return base.Channel.UploadMunicipalitiesDataJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumerService.TaxesManagerService.UploadMunicipalitiesDataJsonResponse> UploadMunicipalitiesDataJsonAsync(System.IO.Stream FileByteStream) {
            ConsumerService.TaxesManagerService.FileUploadModel inValue = new ConsumerService.TaxesManagerService.FileUploadModel();
            inValue.FileByteStream = FileByteStream;
            return ((ConsumerService.TaxesManagerService.ITaxesManagerService)(this)).UploadMunicipalitiesDataJsonAsync(inValue);
        }
    }
}