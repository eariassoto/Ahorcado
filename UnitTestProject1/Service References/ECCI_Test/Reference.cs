﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject1.ECCI_Test {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ECCI_HolaMundo", ConfigurationName="ECCI_Test.ECCI_HolaMundoPort")]
    public interface ECCI_HolaMundoPort {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (iniciarJuegoReturn) del mensaje iniciarJuegoResponse no coincide con el valor predeterminado (iniciarJuego)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#iniciarJuego", ReplyAction="*")]
        UnitTestProject1.ECCI_Test.iniciarJuegoResponse iniciarJuego(UnitTestProject1.ECCI_Test.iniciarJuegoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#iniciarJuego", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.iniciarJuegoResponse> iniciarJuegoAsync(UnitTestProject1.ECCI_Test.iniciarJuegoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (ingresarLetraReturn) del mensaje ingresarLetraResponse no coincide con el valor predeterminado (ingresarLetra)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#ingresarLetra", ReplyAction="*")]
        UnitTestProject1.ECCI_Test.ingresarLetraResponse ingresarLetra(UnitTestProject1.ECCI_Test.ingresarLetraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#ingresarLetra", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.ingresarLetraResponse> ingresarLetraAsync(UnitTestProject1.ECCI_Test.ingresarLetraRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (obtenerIntentosRestantesReturn) del mensaje obtenerIntentosRestantesResponse no coincide con el valor predeterminado (obtenerIntentosRestantes)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerIntentosRestantes", ReplyAction="*")]
        UnitTestProject1.ECCI_Test.obtenerIntentosRestantesResponse obtenerIntentosRestantes(UnitTestProject1.ECCI_Test.obtenerIntentosRestantesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerIntentosRestantes", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerIntentosRestantesResponse> obtenerIntentosRestantesAsync(UnitTestProject1.ECCI_Test.obtenerIntentosRestantesRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (obtenerPalabraParcialReturn) del mensaje obtenerPalabraParcialResponse no coincide con el valor predeterminado (obtenerPalabraParcial)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerPalabraParcial", ReplyAction="*")]
        UnitTestProject1.ECCI_Test.obtenerPalabraParcialResponse obtenerPalabraParcial(UnitTestProject1.ECCI_Test.obtenerPalabraParcialRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerPalabraParcial", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerPalabraParcialResponse> obtenerPalabraParcialAsync(UnitTestProject1.ECCI_Test.obtenerPalabraParcialRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (obtenerPalabraReturn) del mensaje obtenerPalabraResponse no coincide con el valor predeterminado (obtenerPalabra)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerPalabra", ReplyAction="*")]
        UnitTestProject1.ECCI_Test.obtenerPalabraResponse obtenerPalabra(UnitTestProject1.ECCI_Test.obtenerPalabraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerPalabra", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerPalabraResponse> obtenerPalabraAsync(UnitTestProject1.ECCI_Test.obtenerPalabraRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (obtenerTiempoReturn) del mensaje obtenerTiempoResponse no coincide con el valor predeterminado (obtenerTiempo)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerTiempo", ReplyAction="*")]
        UnitTestProject1.ECCI_Test.obtenerTiempoResponse obtenerTiempo(UnitTestProject1.ECCI_Test.obtenerTiempoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerTiempo", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerTiempoResponse> obtenerTiempoAsync(UnitTestProject1.ECCI_Test.obtenerTiempoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (obtenerTopReturn) del mensaje obtenerTopResponse no coincide con el valor predeterminado (obtenerTop)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerTop", ReplyAction="*")]
        UnitTestProject1.ECCI_Test.obtenerTopResponse obtenerTop(UnitTestProject1.ECCI_Test.obtenerTopRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#obtenerTop", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerTopResponse> obtenerTopAsync(UnitTestProject1.ECCI_Test.obtenerTopRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de contenedor (ganoReturn) del mensaje ganoResponse no coincide con el valor predeterminado (gano)
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#gano", ReplyAction="*")]
        UnitTestProject1.ECCI_Test.ganoResponse gano(UnitTestProject1.ECCI_Test.ganoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ECCI_HolaMundo#HolaMundo#gano", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.ganoResponse> ganoAsync(UnitTestProject1.ECCI_Test.ganoRequest request);
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
    public interface ECCI_HolaMundoPortChannel : UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ECCI_HolaMundoPortClient : System.ServiceModel.ClientBase<UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort>, UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort {
        
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
        UnitTestProject1.ECCI_Test.iniciarJuegoResponse UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.iniciarJuego(UnitTestProject1.ECCI_Test.iniciarJuegoRequest request) {
            return base.Channel.iniciarJuego(request);
        }
        
        public string iniciarJuego(string usuario) {
            UnitTestProject1.ECCI_Test.iniciarJuegoRequest inValue = new UnitTestProject1.ECCI_Test.iniciarJuegoRequest();
            inValue.usuario = usuario;
            UnitTestProject1.ECCI_Test.iniciarJuegoResponse retVal = ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).iniciarJuego(inValue);
            return retVal.iniciarJuegoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.iniciarJuegoResponse> UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.iniciarJuegoAsync(UnitTestProject1.ECCI_Test.iniciarJuegoRequest request) {
            return base.Channel.iniciarJuegoAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.iniciarJuegoResponse> iniciarJuegoAsync(string usuario) {
            UnitTestProject1.ECCI_Test.iniciarJuegoRequest inValue = new UnitTestProject1.ECCI_Test.iniciarJuegoRequest();
            inValue.usuario = usuario;
            return ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).iniciarJuegoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitTestProject1.ECCI_Test.ingresarLetraResponse UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.ingresarLetra(UnitTestProject1.ECCI_Test.ingresarLetraRequest request) {
            return base.Channel.ingresarLetra(request);
        }
        
        public void ingresarLetra(string letra) {
            UnitTestProject1.ECCI_Test.ingresarLetraRequest inValue = new UnitTestProject1.ECCI_Test.ingresarLetraRequest();
            inValue.letra = letra;
            UnitTestProject1.ECCI_Test.ingresarLetraResponse retVal = ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).ingresarLetra(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.ingresarLetraResponse> UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.ingresarLetraAsync(UnitTestProject1.ECCI_Test.ingresarLetraRequest request) {
            return base.Channel.ingresarLetraAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.ingresarLetraResponse> ingresarLetraAsync(string letra) {
            UnitTestProject1.ECCI_Test.ingresarLetraRequest inValue = new UnitTestProject1.ECCI_Test.ingresarLetraRequest();
            inValue.letra = letra;
            return ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).ingresarLetraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitTestProject1.ECCI_Test.obtenerIntentosRestantesResponse UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.obtenerIntentosRestantes(UnitTestProject1.ECCI_Test.obtenerIntentosRestantesRequest request) {
            return base.Channel.obtenerIntentosRestantes(request);
        }
        
        public long obtenerIntentosRestantes() {
            UnitTestProject1.ECCI_Test.obtenerIntentosRestantesRequest inValue = new UnitTestProject1.ECCI_Test.obtenerIntentosRestantesRequest();
            UnitTestProject1.ECCI_Test.obtenerIntentosRestantesResponse retVal = ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).obtenerIntentosRestantes(inValue);
            return retVal.obtenerIntentosRestantesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerIntentosRestantesResponse> UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.obtenerIntentosRestantesAsync(UnitTestProject1.ECCI_Test.obtenerIntentosRestantesRequest request) {
            return base.Channel.obtenerIntentosRestantesAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerIntentosRestantesResponse> obtenerIntentosRestantesAsync() {
            UnitTestProject1.ECCI_Test.obtenerIntentosRestantesRequest inValue = new UnitTestProject1.ECCI_Test.obtenerIntentosRestantesRequest();
            return ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).obtenerIntentosRestantesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitTestProject1.ECCI_Test.obtenerPalabraParcialResponse UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.obtenerPalabraParcial(UnitTestProject1.ECCI_Test.obtenerPalabraParcialRequest request) {
            return base.Channel.obtenerPalabraParcial(request);
        }
        
        public string obtenerPalabraParcial() {
            UnitTestProject1.ECCI_Test.obtenerPalabraParcialRequest inValue = new UnitTestProject1.ECCI_Test.obtenerPalabraParcialRequest();
            UnitTestProject1.ECCI_Test.obtenerPalabraParcialResponse retVal = ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).obtenerPalabraParcial(inValue);
            return retVal.obtenerPalabraParcialResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerPalabraParcialResponse> UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.obtenerPalabraParcialAsync(UnitTestProject1.ECCI_Test.obtenerPalabraParcialRequest request) {
            return base.Channel.obtenerPalabraParcialAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerPalabraParcialResponse> obtenerPalabraParcialAsync() {
            UnitTestProject1.ECCI_Test.obtenerPalabraParcialRequest inValue = new UnitTestProject1.ECCI_Test.obtenerPalabraParcialRequest();
            return ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).obtenerPalabraParcialAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitTestProject1.ECCI_Test.obtenerPalabraResponse UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.obtenerPalabra(UnitTestProject1.ECCI_Test.obtenerPalabraRequest request) {
            return base.Channel.obtenerPalabra(request);
        }
        
        public string obtenerPalabra() {
            UnitTestProject1.ECCI_Test.obtenerPalabraRequest inValue = new UnitTestProject1.ECCI_Test.obtenerPalabraRequest();
            UnitTestProject1.ECCI_Test.obtenerPalabraResponse retVal = ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).obtenerPalabra(inValue);
            return retVal.obtenerPalabraResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerPalabraResponse> UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.obtenerPalabraAsync(UnitTestProject1.ECCI_Test.obtenerPalabraRequest request) {
            return base.Channel.obtenerPalabraAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerPalabraResponse> obtenerPalabraAsync() {
            UnitTestProject1.ECCI_Test.obtenerPalabraRequest inValue = new UnitTestProject1.ECCI_Test.obtenerPalabraRequest();
            return ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).obtenerPalabraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitTestProject1.ECCI_Test.obtenerTiempoResponse UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.obtenerTiempo(UnitTestProject1.ECCI_Test.obtenerTiempoRequest request) {
            return base.Channel.obtenerTiempo(request);
        }
        
        public int obtenerTiempo() {
            UnitTestProject1.ECCI_Test.obtenerTiempoRequest inValue = new UnitTestProject1.ECCI_Test.obtenerTiempoRequest();
            UnitTestProject1.ECCI_Test.obtenerTiempoResponse retVal = ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).obtenerTiempo(inValue);
            return retVal.obtenerTiempoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerTiempoResponse> UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.obtenerTiempoAsync(UnitTestProject1.ECCI_Test.obtenerTiempoRequest request) {
            return base.Channel.obtenerTiempoAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerTiempoResponse> obtenerTiempoAsync() {
            UnitTestProject1.ECCI_Test.obtenerTiempoRequest inValue = new UnitTestProject1.ECCI_Test.obtenerTiempoRequest();
            return ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).obtenerTiempoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitTestProject1.ECCI_Test.obtenerTopResponse UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.obtenerTop(UnitTestProject1.ECCI_Test.obtenerTopRequest request) {
            return base.Channel.obtenerTop(request);
        }
        
        public string obtenerTop() {
            UnitTestProject1.ECCI_Test.obtenerTopRequest inValue = new UnitTestProject1.ECCI_Test.obtenerTopRequest();
            UnitTestProject1.ECCI_Test.obtenerTopResponse retVal = ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).obtenerTop(inValue);
            return retVal.obtenerTopResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerTopResponse> UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.obtenerTopAsync(UnitTestProject1.ECCI_Test.obtenerTopRequest request) {
            return base.Channel.obtenerTopAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.obtenerTopResponse> obtenerTopAsync() {
            UnitTestProject1.ECCI_Test.obtenerTopRequest inValue = new UnitTestProject1.ECCI_Test.obtenerTopRequest();
            return ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).obtenerTopAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitTestProject1.ECCI_Test.ganoResponse UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.gano(UnitTestProject1.ECCI_Test.ganoRequest request) {
            return base.Channel.gano(request);
        }
        
        public bool gano() {
            UnitTestProject1.ECCI_Test.ganoRequest inValue = new UnitTestProject1.ECCI_Test.ganoRequest();
            UnitTestProject1.ECCI_Test.ganoResponse retVal = ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).gano(inValue);
            return retVal.ganoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.ganoResponse> UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort.ganoAsync(UnitTestProject1.ECCI_Test.ganoRequest request) {
            return base.Channel.ganoAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitTestProject1.ECCI_Test.ganoResponse> ganoAsync() {
            UnitTestProject1.ECCI_Test.ganoRequest inValue = new UnitTestProject1.ECCI_Test.ganoRequest();
            return ((UnitTestProject1.ECCI_Test.ECCI_HolaMundoPort)(this)).ganoAsync(inValue);
        }
    }
}
