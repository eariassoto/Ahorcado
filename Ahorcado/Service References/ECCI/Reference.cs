﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ahorcado.ECCI {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ECCI_HolaMundo", ConfigurationName="ECCI.ECCI_HolaMundoPort")]
    public interface ECCI_HolaMundoPort {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (iniciarJuegoReturn) del mensaje iniciarJuegoResponse no coincide con el valor predeterminado (iniciarJuego)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#iniciarJuego", ReplyAction="*")]
        Ahorcado.ECCI.iniciarJuegoResponse iniciarJuego(Ahorcado.ECCI.iniciarJuegoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#iniciarJuego", ReplyAction="*")]
        System.Threading.Tasks.Task<Ahorcado.ECCI.iniciarJuegoResponse> iniciarJuegoAsync(Ahorcado.ECCI.iniciarJuegoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (ingresarLetraReturn) del mensaje ingresarLetraResponse no coincide con el valor predeterminado (ingresarLetra)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#ingresarLetra", ReplyAction="*")]
        Ahorcado.ECCI.ingresarLetraResponse ingresarLetra(Ahorcado.ECCI.ingresarLetraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#ingresarLetra", ReplyAction="*")]
        System.Threading.Tasks.Task<Ahorcado.ECCI.ingresarLetraResponse> ingresarLetraAsync(Ahorcado.ECCI.ingresarLetraRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (obtenerIntentosRestantesReturn) del mensaje obtenerIntentosRestantesResponse no coincide con el valor predeterminado (obtenerIntentosRestantes)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerIntentosRestantes", ReplyAction="*")]
        Ahorcado.ECCI.obtenerIntentosRestantesResponse obtenerIntentosRestantes(Ahorcado.ECCI.obtenerIntentosRestantesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerIntentosRestantes", ReplyAction="*")]
        System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerIntentosRestantesResponse> obtenerIntentosRestantesAsync(Ahorcado.ECCI.obtenerIntentosRestantesRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (obtenerPalabraParcialReturn) del mensaje obtenerPalabraParcialResponse no coincide con el valor predeterminado (obtenerPalabraParcial)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerPalabraParcial", ReplyAction="*")]
        Ahorcado.ECCI.obtenerPalabraParcialResponse obtenerPalabraParcial(Ahorcado.ECCI.obtenerPalabraParcialRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerPalabraParcial", ReplyAction="*")]
        System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerPalabraParcialResponse> obtenerPalabraParcialAsync(Ahorcado.ECCI.obtenerPalabraParcialRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (obtenerPalabraReturn) del mensaje obtenerPalabraResponse no coincide con el valor predeterminado (obtenerPalabra)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerPalabra", ReplyAction="*")]
        Ahorcado.ECCI.obtenerPalabraResponse obtenerPalabra(Ahorcado.ECCI.obtenerPalabraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerPalabra", ReplyAction="*")]
        System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerPalabraResponse> obtenerPalabraAsync(Ahorcado.ECCI.obtenerPalabraRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (obtenerTiempoReturn) del mensaje obtenerTiempoResponse no coincide con el valor predeterminado (obtenerTiempo)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerTiempo", ReplyAction="*")]
        Ahorcado.ECCI.obtenerTiempoResponse obtenerTiempo(Ahorcado.ECCI.obtenerTiempoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerTiempo", ReplyAction="*")]
        System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerTiempoResponse> obtenerTiempoAsync(Ahorcado.ECCI.obtenerTiempoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (obtenerTopReturn) del mensaje obtenerTopResponse no coincide con el valor predeterminado (obtenerTop)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerTop", ReplyAction="*")]
        Ahorcado.ECCI.obtenerTopResponse obtenerTop(Ahorcado.ECCI.obtenerTopRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerTop", ReplyAction="*")]
        System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerTopResponse> obtenerTopAsync(Ahorcado.ECCI.obtenerTopRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (ganoReturn) del mensaje ganoResponse no coincide con el valor predeterminado (gano)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#gano", ReplyAction="*")]
        Ahorcado.ECCI.ganoResponse gano(Ahorcado.ECCI.ganoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#gano", ReplyAction="*")]
        System.Threading.Tasks.Task<Ahorcado.ECCI.ganoResponse> ganoAsync(Ahorcado.ECCI.ganoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="iniciarJuego", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class iniciarJuegoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string usuario;
        
        public iniciarJuegoRequest() {
        }
        
        public iniciarJuegoRequest(string usuario) {
            this.usuario = usuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="iniciarJuegoReturn", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class iniciarJuegoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string iniciarJuegoResult;
        
        public iniciarJuegoResponse() {
        }
        
        public iniciarJuegoResponse(string iniciarJuegoResult) {
            this.iniciarJuegoResult = iniciarJuegoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ingresarLetra", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class ingresarLetraRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string letra;
        
        public ingresarLetraRequest() {
        }
        
        public ingresarLetraRequest(string letra) {
            this.letra = letra;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ingresarLetraReturn", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class ingresarLetraResponse {
        
        public ingresarLetraResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerIntentosRestantes", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class obtenerIntentosRestantesRequest {
        
        public obtenerIntentosRestantesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerIntentosRestantesReturn", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class obtenerIntentosRestantesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public long obtenerIntentosRestantesResult;
        
        public obtenerIntentosRestantesResponse() {
        }
        
        public obtenerIntentosRestantesResponse(long obtenerIntentosRestantesResult) {
            this.obtenerIntentosRestantesResult = obtenerIntentosRestantesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerPalabraParcial", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class obtenerPalabraParcialRequest {
        
        public obtenerPalabraParcialRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerPalabraParcialReturn", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class obtenerPalabraParcialResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string obtenerPalabraParcialResult;
        
        public obtenerPalabraParcialResponse() {
        }
        
        public obtenerPalabraParcialResponse(string obtenerPalabraParcialResult) {
            this.obtenerPalabraParcialResult = obtenerPalabraParcialResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerPalabra", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class obtenerPalabraRequest {
        
        public obtenerPalabraRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerPalabraReturn", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class obtenerPalabraResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string obtenerPalabraResult;
        
        public obtenerPalabraResponse() {
        }
        
        public obtenerPalabraResponse(string obtenerPalabraResult) {
            this.obtenerPalabraResult = obtenerPalabraResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerTiempo", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class obtenerTiempoRequest {
        
        public obtenerTiempoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerTiempoReturn", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class obtenerTiempoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int obtenerTiempoResult;
        
        public obtenerTiempoResponse() {
        }
        
        public obtenerTiempoResponse(int obtenerTiempoResult) {
            this.obtenerTiempoResult = obtenerTiempoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerTop", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class obtenerTopRequest {
        
        public obtenerTopRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerTopReturn", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class obtenerTopResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string obtenerTopResult;
        
        public obtenerTopResponse() {
        }
        
        public obtenerTopResponse(string obtenerTopResult) {
            this.obtenerTopResult = obtenerTopResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="gano", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class ganoRequest {
        
        public ganoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ganoReturn", WrapperNamespace="urn:ECCI_HolaMundo", IsWrapped=true)]
    public partial class ganoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public bool ganoResult;
        
        public ganoResponse() {
        }
        
        public ganoResponse(bool ganoResult) {
            this.ganoResult = ganoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ECCI_HolaMundoPortChannel : Ahorcado.ECCI.ECCI_HolaMundoPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ECCI_HolaMundoPortClient : System.ServiceModel.ClientBase<Ahorcado.ECCI.ECCI_HolaMundoPort>, Ahorcado.ECCI.ECCI_HolaMundoPort {
        
        public ECCI_HolaMundoPortClient() {
        }
        
        public ECCI_HolaMundoPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ECCI_HolaMundoPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_HolaMundoPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ECCI_HolaMundoPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ahorcado.ECCI.iniciarJuegoResponse Ahorcado.ECCI.ECCI_HolaMundoPort.iniciarJuego(Ahorcado.ECCI.iniciarJuegoRequest request) {
            return base.Channel.iniciarJuego(request);
        }
        
        public string iniciarJuego(string usuario) {
            Ahorcado.ECCI.iniciarJuegoRequest inValue = new Ahorcado.ECCI.iniciarJuegoRequest();
            inValue.usuario = usuario;
            Ahorcado.ECCI.iniciarJuegoResponse retVal = ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).iniciarJuego(inValue);
            return retVal.iniciarJuegoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ahorcado.ECCI.iniciarJuegoResponse> Ahorcado.ECCI.ECCI_HolaMundoPort.iniciarJuegoAsync(Ahorcado.ECCI.iniciarJuegoRequest request) {
            return base.Channel.iniciarJuegoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ahorcado.ECCI.iniciarJuegoResponse> iniciarJuegoAsync(string usuario) {
            Ahorcado.ECCI.iniciarJuegoRequest inValue = new Ahorcado.ECCI.iniciarJuegoRequest();
            inValue.usuario = usuario;
            return ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).iniciarJuegoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ahorcado.ECCI.ingresarLetraResponse Ahorcado.ECCI.ECCI_HolaMundoPort.ingresarLetra(Ahorcado.ECCI.ingresarLetraRequest request) {
            return base.Channel.ingresarLetra(request);
        }
        
        public void ingresarLetra(string letra) {
            Ahorcado.ECCI.ingresarLetraRequest inValue = new Ahorcado.ECCI.ingresarLetraRequest();
            inValue.letra = letra;
            Ahorcado.ECCI.ingresarLetraResponse retVal = ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).ingresarLetra(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ahorcado.ECCI.ingresarLetraResponse> Ahorcado.ECCI.ECCI_HolaMundoPort.ingresarLetraAsync(Ahorcado.ECCI.ingresarLetraRequest request) {
            return base.Channel.ingresarLetraAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ahorcado.ECCI.ingresarLetraResponse> ingresarLetraAsync(string letra) {
            Ahorcado.ECCI.ingresarLetraRequest inValue = new Ahorcado.ECCI.ingresarLetraRequest();
            inValue.letra = letra;
            return ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).ingresarLetraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ahorcado.ECCI.obtenerIntentosRestantesResponse Ahorcado.ECCI.ECCI_HolaMundoPort.obtenerIntentosRestantes(Ahorcado.ECCI.obtenerIntentosRestantesRequest request) {
            return base.Channel.obtenerIntentosRestantes(request);
        }
        
        public long obtenerIntentosRestantes() {
            Ahorcado.ECCI.obtenerIntentosRestantesRequest inValue = new Ahorcado.ECCI.obtenerIntentosRestantesRequest();
            Ahorcado.ECCI.obtenerIntentosRestantesResponse retVal = ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).obtenerIntentosRestantes(inValue);
            return retVal.obtenerIntentosRestantesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerIntentosRestantesResponse> Ahorcado.ECCI.ECCI_HolaMundoPort.obtenerIntentosRestantesAsync(Ahorcado.ECCI.obtenerIntentosRestantesRequest request) {
            return base.Channel.obtenerIntentosRestantesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerIntentosRestantesResponse> obtenerIntentosRestantesAsync() {
            Ahorcado.ECCI.obtenerIntentosRestantesRequest inValue = new Ahorcado.ECCI.obtenerIntentosRestantesRequest();
            return ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).obtenerIntentosRestantesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ahorcado.ECCI.obtenerPalabraParcialResponse Ahorcado.ECCI.ECCI_HolaMundoPort.obtenerPalabraParcial(Ahorcado.ECCI.obtenerPalabraParcialRequest request) {
            return base.Channel.obtenerPalabraParcial(request);
        }
        
        public string obtenerPalabraParcial() {
            Ahorcado.ECCI.obtenerPalabraParcialRequest inValue = new Ahorcado.ECCI.obtenerPalabraParcialRequest();
            Ahorcado.ECCI.obtenerPalabraParcialResponse retVal = ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).obtenerPalabraParcial(inValue);
            return retVal.obtenerPalabraParcialResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerPalabraParcialResponse> Ahorcado.ECCI.ECCI_HolaMundoPort.obtenerPalabraParcialAsync(Ahorcado.ECCI.obtenerPalabraParcialRequest request) {
            return base.Channel.obtenerPalabraParcialAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerPalabraParcialResponse> obtenerPalabraParcialAsync() {
            Ahorcado.ECCI.obtenerPalabraParcialRequest inValue = new Ahorcado.ECCI.obtenerPalabraParcialRequest();
            return ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).obtenerPalabraParcialAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ahorcado.ECCI.obtenerPalabraResponse Ahorcado.ECCI.ECCI_HolaMundoPort.obtenerPalabra(Ahorcado.ECCI.obtenerPalabraRequest request) {
            return base.Channel.obtenerPalabra(request);
        }
        
        public string obtenerPalabra() {
            Ahorcado.ECCI.obtenerPalabraRequest inValue = new Ahorcado.ECCI.obtenerPalabraRequest();
            Ahorcado.ECCI.obtenerPalabraResponse retVal = ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).obtenerPalabra(inValue);
            return retVal.obtenerPalabraResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerPalabraResponse> Ahorcado.ECCI.ECCI_HolaMundoPort.obtenerPalabraAsync(Ahorcado.ECCI.obtenerPalabraRequest request) {
            return base.Channel.obtenerPalabraAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerPalabraResponse> obtenerPalabraAsync() {
            Ahorcado.ECCI.obtenerPalabraRequest inValue = new Ahorcado.ECCI.obtenerPalabraRequest();
            return ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).obtenerPalabraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ahorcado.ECCI.obtenerTiempoResponse Ahorcado.ECCI.ECCI_HolaMundoPort.obtenerTiempo(Ahorcado.ECCI.obtenerTiempoRequest request) {
            return base.Channel.obtenerTiempo(request);
        }
        
        public int obtenerTiempo() {
            Ahorcado.ECCI.obtenerTiempoRequest inValue = new Ahorcado.ECCI.obtenerTiempoRequest();
            Ahorcado.ECCI.obtenerTiempoResponse retVal = ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).obtenerTiempo(inValue);
            return retVal.obtenerTiempoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerTiempoResponse> Ahorcado.ECCI.ECCI_HolaMundoPort.obtenerTiempoAsync(Ahorcado.ECCI.obtenerTiempoRequest request) {
            return base.Channel.obtenerTiempoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerTiempoResponse> obtenerTiempoAsync() {
            Ahorcado.ECCI.obtenerTiempoRequest inValue = new Ahorcado.ECCI.obtenerTiempoRequest();
            return ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).obtenerTiempoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ahorcado.ECCI.obtenerTopResponse Ahorcado.ECCI.ECCI_HolaMundoPort.obtenerTop(Ahorcado.ECCI.obtenerTopRequest request) {
            return base.Channel.obtenerTop(request);
        }
        
        public string obtenerTop() {
            Ahorcado.ECCI.obtenerTopRequest inValue = new Ahorcado.ECCI.obtenerTopRequest();
            Ahorcado.ECCI.obtenerTopResponse retVal = ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).obtenerTop(inValue);
            return retVal.obtenerTopResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerTopResponse> Ahorcado.ECCI.ECCI_HolaMundoPort.obtenerTopAsync(Ahorcado.ECCI.obtenerTopRequest request) {
            return base.Channel.obtenerTopAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ahorcado.ECCI.obtenerTopResponse> obtenerTopAsync() {
            Ahorcado.ECCI.obtenerTopRequest inValue = new Ahorcado.ECCI.obtenerTopRequest();
            return ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).obtenerTopAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Ahorcado.ECCI.ganoResponse Ahorcado.ECCI.ECCI_HolaMundoPort.gano(Ahorcado.ECCI.ganoRequest request) {
            return base.Channel.gano(request);
        }
        
        public bool gano() {
            Ahorcado.ECCI.ganoRequest inValue = new Ahorcado.ECCI.ganoRequest();
            Ahorcado.ECCI.ganoResponse retVal = ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).gano(inValue);
            return retVal.ganoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Ahorcado.ECCI.ganoResponse> Ahorcado.ECCI.ECCI_HolaMundoPort.ganoAsync(Ahorcado.ECCI.ganoRequest request) {
            return base.Channel.ganoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Ahorcado.ECCI.ganoResponse> ganoAsync() {
            Ahorcado.ECCI.ganoRequest inValue = new Ahorcado.ECCI.ganoRequest();
            return ((Ahorcado.ECCI.ECCI_HolaMundoPort)(this)).ganoAsync(inValue);
        }
    }
}
