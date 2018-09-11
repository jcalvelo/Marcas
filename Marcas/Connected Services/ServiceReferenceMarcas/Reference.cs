﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marcas.ServiceReferenceMarcas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceMarcas.IMarcas")]
    public interface IMarcas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/MarcaEntrada", ReplyAction="http://tempuri.org/IMarcas/MarcaEntradaResponse")]
        void MarcaEntrada(string user, string login_computer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/MarcaEntrada", ReplyAction="http://tempuri.org/IMarcas/MarcaEntradaResponse")]
        System.Threading.Tasks.Task MarcaEntradaAsync(string user, string login_computer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/MarcaSalida", ReplyAction="http://tempuri.org/IMarcas/MarcaSalidaResponse")]
        void MarcaSalida(string user, string login_computer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcas/MarcaSalida", ReplyAction="http://tempuri.org/IMarcas/MarcaSalidaResponse")]
        System.Threading.Tasks.Task MarcaSalidaAsync(string user, string login_computer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMarcasChannel : Marcas.ServiceReferenceMarcas.IMarcas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MarcasClient : System.ServiceModel.ClientBase<Marcas.ServiceReferenceMarcas.IMarcas>, Marcas.ServiceReferenceMarcas.IMarcas {
        
        public MarcasClient() {
        }
        
        public MarcasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MarcasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarcasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarcasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void MarcaEntrada(string user, string login_computer) {
            base.Channel.MarcaEntrada(user, login_computer);
        }
        
        public System.Threading.Tasks.Task MarcaEntradaAsync(string user, string login_computer) {
            return base.Channel.MarcaEntradaAsync(user, login_computer);
        }
        
        public void MarcaSalida(string user, string login_computer) {
            base.Channel.MarcaSalida(user, login_computer);
        }
        
        public System.Threading.Tasks.Task MarcaSalidaAsync(string user, string login_computer) {
            return base.Channel.MarcaSalidaAsync(user, login_computer);
        }
    }
}