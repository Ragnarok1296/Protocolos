﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Protocolo4.WSOperacion {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://microsoft.com/webservices/", ConfigurationName="WSOperacion.WSOperacionesSoap")]
    public interface WSOperacionesSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento obtenerModuloResult del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/obtenerModulo", ReplyAction="*")]
        Protocolo4.WSOperacion.obtenerModuloResponse obtenerModulo(Protocolo4.WSOperacion.obtenerModuloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/obtenerModulo", ReplyAction="*")]
        System.Threading.Tasks.Task<Protocolo4.WSOperacion.obtenerModuloResponse> obtenerModuloAsync(Protocolo4.WSOperacion.obtenerModuloRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento telefono del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/obtenerLlavesPublica", ReplyAction="*")]
        Protocolo4.WSOperacion.obtenerLlavesPublicaResponse obtenerLlavesPublica(Protocolo4.WSOperacion.obtenerLlavesPublicaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/obtenerLlavesPublica", ReplyAction="*")]
        System.Threading.Tasks.Task<Protocolo4.WSOperacion.obtenerLlavesPublicaResponse> obtenerLlavesPublicaAsync(Protocolo4.WSOperacion.obtenerLlavesPublicaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento telefono del espacio de nombres http://microsoft.com/webservices/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/VerificarCertificado", ReplyAction="*")]
        Protocolo4.WSOperacion.VerificarCertificadoResponse VerificarCertificado(Protocolo4.WSOperacion.VerificarCertificadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.com/webservices/VerificarCertificado", ReplyAction="*")]
        System.Threading.Tasks.Task<Protocolo4.WSOperacion.VerificarCertificadoResponse> VerificarCertificadoAsync(Protocolo4.WSOperacion.VerificarCertificadoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class obtenerModuloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="obtenerModulo", Namespace="http://microsoft.com/webservices/", Order=0)]
        public Protocolo4.WSOperacion.obtenerModuloRequestBody Body;
        
        public obtenerModuloRequest() {
        }
        
        public obtenerModuloRequest(Protocolo4.WSOperacion.obtenerModuloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class obtenerModuloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public obtenerModuloRequestBody() {
        }
        
        public obtenerModuloRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class obtenerModuloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="obtenerModuloResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public Protocolo4.WSOperacion.obtenerModuloResponseBody Body;
        
        public obtenerModuloResponse() {
        }
        
        public obtenerModuloResponse(Protocolo4.WSOperacion.obtenerModuloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class obtenerModuloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string obtenerModuloResult;
        
        public obtenerModuloResponseBody() {
        }
        
        public obtenerModuloResponseBody(string obtenerModuloResult) {
            this.obtenerModuloResult = obtenerModuloResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class obtenerLlavesPublicaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="obtenerLlavesPublica", Namespace="http://microsoft.com/webservices/", Order=0)]
        public Protocolo4.WSOperacion.obtenerLlavesPublicaRequestBody Body;
        
        public obtenerLlavesPublicaRequest() {
        }
        
        public obtenerLlavesPublicaRequest(Protocolo4.WSOperacion.obtenerLlavesPublicaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class obtenerLlavesPublicaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string telefono;
        
        public obtenerLlavesPublicaRequestBody() {
        }
        
        public obtenerLlavesPublicaRequestBody(string telefono) {
            this.telefono = telefono;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class obtenerLlavesPublicaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="obtenerLlavesPublicaResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public Protocolo4.WSOperacion.obtenerLlavesPublicaResponseBody Body;
        
        public obtenerLlavesPublicaResponse() {
        }
        
        public obtenerLlavesPublicaResponse(Protocolo4.WSOperacion.obtenerLlavesPublicaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class obtenerLlavesPublicaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string obtenerLlavesPublicaResult;
        
        public obtenerLlavesPublicaResponseBody() {
        }
        
        public obtenerLlavesPublicaResponseBody(string obtenerLlavesPublicaResult) {
            this.obtenerLlavesPublicaResult = obtenerLlavesPublicaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerificarCertificadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerificarCertificado", Namespace="http://microsoft.com/webservices/", Order=0)]
        public Protocolo4.WSOperacion.VerificarCertificadoRequestBody Body;
        
        public VerificarCertificadoRequest() {
        }
        
        public VerificarCertificadoRequest(Protocolo4.WSOperacion.VerificarCertificadoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class VerificarCertificadoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string telefono;
        
        public VerificarCertificadoRequestBody() {
        }
        
        public VerificarCertificadoRequestBody(string telefono) {
            this.telefono = telefono;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerificarCertificadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerificarCertificadoResponse", Namespace="http://microsoft.com/webservices/", Order=0)]
        public Protocolo4.WSOperacion.VerificarCertificadoResponseBody Body;
        
        public VerificarCertificadoResponse() {
        }
        
        public VerificarCertificadoResponse(Protocolo4.WSOperacion.VerificarCertificadoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://microsoft.com/webservices/")]
    public partial class VerificarCertificadoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool VerificarCertificadoResult;
        
        public VerificarCertificadoResponseBody() {
        }
        
        public VerificarCertificadoResponseBody(bool VerificarCertificadoResult) {
            this.VerificarCertificadoResult = VerificarCertificadoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSOperacionesSoapChannel : Protocolo4.WSOperacion.WSOperacionesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSOperacionesSoapClient : System.ServiceModel.ClientBase<Protocolo4.WSOperacion.WSOperacionesSoap>, Protocolo4.WSOperacion.WSOperacionesSoap {
        
        public WSOperacionesSoapClient() {
        }
        
        public WSOperacionesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSOperacionesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSOperacionesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSOperacionesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Protocolo4.WSOperacion.obtenerModuloResponse Protocolo4.WSOperacion.WSOperacionesSoap.obtenerModulo(Protocolo4.WSOperacion.obtenerModuloRequest request) {
            return base.Channel.obtenerModulo(request);
        }
        
        public string obtenerModulo(int id) {
            Protocolo4.WSOperacion.obtenerModuloRequest inValue = new Protocolo4.WSOperacion.obtenerModuloRequest();
            inValue.Body = new Protocolo4.WSOperacion.obtenerModuloRequestBody();
            inValue.Body.id = id;
            Protocolo4.WSOperacion.obtenerModuloResponse retVal = ((Protocolo4.WSOperacion.WSOperacionesSoap)(this)).obtenerModulo(inValue);
            return retVal.Body.obtenerModuloResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Protocolo4.WSOperacion.obtenerModuloResponse> Protocolo4.WSOperacion.WSOperacionesSoap.obtenerModuloAsync(Protocolo4.WSOperacion.obtenerModuloRequest request) {
            return base.Channel.obtenerModuloAsync(request);
        }
        
        public System.Threading.Tasks.Task<Protocolo4.WSOperacion.obtenerModuloResponse> obtenerModuloAsync(int id) {
            Protocolo4.WSOperacion.obtenerModuloRequest inValue = new Protocolo4.WSOperacion.obtenerModuloRequest();
            inValue.Body = new Protocolo4.WSOperacion.obtenerModuloRequestBody();
            inValue.Body.id = id;
            return ((Protocolo4.WSOperacion.WSOperacionesSoap)(this)).obtenerModuloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Protocolo4.WSOperacion.obtenerLlavesPublicaResponse Protocolo4.WSOperacion.WSOperacionesSoap.obtenerLlavesPublica(Protocolo4.WSOperacion.obtenerLlavesPublicaRequest request) {
            return base.Channel.obtenerLlavesPublica(request);
        }
        
        public string obtenerLlavesPublica(string telefono) {
            Protocolo4.WSOperacion.obtenerLlavesPublicaRequest inValue = new Protocolo4.WSOperacion.obtenerLlavesPublicaRequest();
            inValue.Body = new Protocolo4.WSOperacion.obtenerLlavesPublicaRequestBody();
            inValue.Body.telefono = telefono;
            Protocolo4.WSOperacion.obtenerLlavesPublicaResponse retVal = ((Protocolo4.WSOperacion.WSOperacionesSoap)(this)).obtenerLlavesPublica(inValue);
            return retVal.Body.obtenerLlavesPublicaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Protocolo4.WSOperacion.obtenerLlavesPublicaResponse> Protocolo4.WSOperacion.WSOperacionesSoap.obtenerLlavesPublicaAsync(Protocolo4.WSOperacion.obtenerLlavesPublicaRequest request) {
            return base.Channel.obtenerLlavesPublicaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Protocolo4.WSOperacion.obtenerLlavesPublicaResponse> obtenerLlavesPublicaAsync(string telefono) {
            Protocolo4.WSOperacion.obtenerLlavesPublicaRequest inValue = new Protocolo4.WSOperacion.obtenerLlavesPublicaRequest();
            inValue.Body = new Protocolo4.WSOperacion.obtenerLlavesPublicaRequestBody();
            inValue.Body.telefono = telefono;
            return ((Protocolo4.WSOperacion.WSOperacionesSoap)(this)).obtenerLlavesPublicaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Protocolo4.WSOperacion.VerificarCertificadoResponse Protocolo4.WSOperacion.WSOperacionesSoap.VerificarCertificado(Protocolo4.WSOperacion.VerificarCertificadoRequest request) {
            return base.Channel.VerificarCertificado(request);
        }
        
        public bool VerificarCertificado(string telefono) {
            Protocolo4.WSOperacion.VerificarCertificadoRequest inValue = new Protocolo4.WSOperacion.VerificarCertificadoRequest();
            inValue.Body = new Protocolo4.WSOperacion.VerificarCertificadoRequestBody();
            inValue.Body.telefono = telefono;
            Protocolo4.WSOperacion.VerificarCertificadoResponse retVal = ((Protocolo4.WSOperacion.WSOperacionesSoap)(this)).VerificarCertificado(inValue);
            return retVal.Body.VerificarCertificadoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Protocolo4.WSOperacion.VerificarCertificadoResponse> Protocolo4.WSOperacion.WSOperacionesSoap.VerificarCertificadoAsync(Protocolo4.WSOperacion.VerificarCertificadoRequest request) {
            return base.Channel.VerificarCertificadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Protocolo4.WSOperacion.VerificarCertificadoResponse> VerificarCertificadoAsync(string telefono) {
            Protocolo4.WSOperacion.VerificarCertificadoRequest inValue = new Protocolo4.WSOperacion.VerificarCertificadoRequest();
            inValue.Body = new Protocolo4.WSOperacion.VerificarCertificadoRequestBody();
            inValue.Body.telefono = telefono;
            return ((Protocolo4.WSOperacion.WSOperacionesSoap)(this)).VerificarCertificadoAsync(inValue);
        }
    }
}
