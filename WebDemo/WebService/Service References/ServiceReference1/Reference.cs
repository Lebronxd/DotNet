﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebXml.com.cn/", ConfigurationName="ServiceReference1.MobileCodeWSSoap")]
    public interface MobileCodeWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getMobileCodeInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string getMobileCodeInfo(string mobileCode, string userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getMobileCodeInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<string> getMobileCodeInfoAsync(string mobileCode, string userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getDatabaseInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] getDatabaseInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebXml.com.cn/getDatabaseInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> getDatabaseInfoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MobileCodeWSSoapChannel : WebService.ServiceReference1.MobileCodeWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MobileCodeWSSoapClient : System.ServiceModel.ClientBase<WebService.ServiceReference1.MobileCodeWSSoap>, WebService.ServiceReference1.MobileCodeWSSoap {
        
        public MobileCodeWSSoapClient() {
        }
        
        public MobileCodeWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MobileCodeWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MobileCodeWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MobileCodeWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getMobileCodeInfo(string mobileCode, string userID) {
            return base.Channel.getMobileCodeInfo(mobileCode, userID);
        }
        
        public System.Threading.Tasks.Task<string> getMobileCodeInfoAsync(string mobileCode, string userID) {
            return base.Channel.getMobileCodeInfoAsync(mobileCode, userID);
        }
        
        public string[] getDatabaseInfo() {
            return base.Channel.getDatabaseInfo();
        }
        
        public System.Threading.Tasks.Task<string[]> getDatabaseInfoAsync() {
            return base.Channel.getDatabaseInfoAsync();
        }
    }
}
