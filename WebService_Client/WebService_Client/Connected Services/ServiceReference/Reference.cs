﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService_Client.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sendmail/", ConfigurationName="ServiceReference.SendMailInterface")]
    public interface SendMailInterface {
        
        // CODEGEN: 参数“return”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebService_Client.ServiceReference.sendEmailResponse sendEmail(WebService_Client.ServiceReference.sendEmail request);
        
        // CODEGEN: 参数“return”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebService_Client.ServiceReference.validateEmailAddressResponse validateEmailAddress(WebService_Client.ServiceReference.validateEmailAddress request);
        
        // CODEGEN: 参数“return”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebService_Client.ServiceReference.sendEmailBatchResponse sendEmailBatch(WebService_Client.ServiceReference.sendEmailBatch request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendEmail", WrapperNamespace="http://sendmail/", IsWrapped=true)]
    public partial class sendEmail {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sendmail/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string url;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sendmail/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string payload;
        
        public sendEmail() {
        }
        
        public sendEmail(string url, string payload) {
            this.url = url;
            this.payload = payload;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendEmailResponse", WrapperNamespace="http://sendmail/", IsWrapped=true)]
    public partial class sendEmailResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sendmail/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public sendEmailResponse() {
        }
        
        public sendEmailResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validateEmailAddress", WrapperNamespace="http://sendmail/", IsWrapped=true)]
    public partial class validateEmailAddress {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sendmail/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string email;
        
        public validateEmailAddress() {
        }
        
        public validateEmailAddress(string email) {
            this.email = email;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validateEmailAddressResponse", WrapperNamespace="http://sendmail/", IsWrapped=true)]
    public partial class validateEmailAddressResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sendmail/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public validateEmailAddressResponse() {
        }
        
        public validateEmailAddressResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendEmailBatch", WrapperNamespace="http://sendmail/", IsWrapped=true)]
    public partial class sendEmailBatch {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sendmail/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("url", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] url;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sendmail/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string payload;
        
        public sendEmailBatch() {
        }
        
        public sendEmailBatch(string[] url, string payload) {
            this.url = url;
            this.payload = payload;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendEmailBatchResponse", WrapperNamespace="http://sendmail/", IsWrapped=true)]
    public partial class sendEmailBatchResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sendmail/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public sendEmailBatchResponse() {
        }
        
        public sendEmailBatchResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SendMailInterfaceChannel : WebService_Client.ServiceReference.SendMailInterface, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SendMailInterfaceClient : System.ServiceModel.ClientBase<WebService_Client.ServiceReference.SendMailInterface>, WebService_Client.ServiceReference.SendMailInterface {
        
        public SendMailInterfaceClient() {
        }
        
        public SendMailInterfaceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SendMailInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendMailInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendMailInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebService_Client.ServiceReference.sendEmailResponse WebService_Client.ServiceReference.SendMailInterface.sendEmail(WebService_Client.ServiceReference.sendEmail request) {
            return base.Channel.sendEmail(request);
        }
        
        public bool sendEmail(string url, string payload) {
            WebService_Client.ServiceReference.sendEmail inValue = new WebService_Client.ServiceReference.sendEmail();
            inValue.url = url;
            inValue.payload = payload;
            WebService_Client.ServiceReference.sendEmailResponse retVal = ((WebService_Client.ServiceReference.SendMailInterface)(this)).sendEmail(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebService_Client.ServiceReference.validateEmailAddressResponse WebService_Client.ServiceReference.SendMailInterface.validateEmailAddress(WebService_Client.ServiceReference.validateEmailAddress request) {
            return base.Channel.validateEmailAddress(request);
        }
        
        public bool validateEmailAddress(string email) {
            WebService_Client.ServiceReference.validateEmailAddress inValue = new WebService_Client.ServiceReference.validateEmailAddress();
            inValue.email = email;
            WebService_Client.ServiceReference.validateEmailAddressResponse retVal = ((WebService_Client.ServiceReference.SendMailInterface)(this)).validateEmailAddress(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebService_Client.ServiceReference.sendEmailBatchResponse WebService_Client.ServiceReference.SendMailInterface.sendEmailBatch(WebService_Client.ServiceReference.sendEmailBatch request) {
            return base.Channel.sendEmailBatch(request);
        }
        
        public bool sendEmailBatch(string[] url, string payload) {
            WebService_Client.ServiceReference.sendEmailBatch inValue = new WebService_Client.ServiceReference.sendEmailBatch();
            inValue.url = url;
            inValue.payload = payload;
            WebService_Client.ServiceReference.sendEmailBatchResponse retVal = ((WebService_Client.ServiceReference.SendMailInterface)(this)).sendEmailBatch(inValue);
            return retVal.@return;
        }
    }
}
