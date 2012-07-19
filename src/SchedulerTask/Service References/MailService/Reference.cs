﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulerTask.MailService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MailService.IMailService")]
    public interface IMailService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/AddNewUser", ReplyAction="http://tempuri.org/IMailService/AddNewUserResponse")]
        bool AddNewUser(string mailingList, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMailService/SendMail", ReplyAction="http://tempuri.org/IMailService/SendMailResponse")]
        bool SendMail(string mailingList, string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMailServiceChannel : SchedulerTask.MailService.IMailService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MailServiceClient : System.ServiceModel.ClientBase<SchedulerTask.MailService.IMailService>, SchedulerTask.MailService.IMailService {
        
        public MailServiceClient() {
        }
        
        public MailServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MailServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MailServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddNewUser(string mailingList, string email) {
            return base.Channel.AddNewUser(mailingList, email);
        }
        
        public bool SendMail(string mailingList, string message) {
            return base.Channel.SendMail(mailingList, message);
        }
    }
}
