﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapWSUnitTestProject.FibonacciWSReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FibonacciWSReference.LemonWayWebServiceSoap")]
    public interface LemonWayWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name FibonacciResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        SoapWSUnitTestProject.FibonacciWSReference.FibonacciResponse Fibonacci(SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fibonacci", ReplyAction="*")]
        System.Threading.Tasks.Task<SoapWSUnitTestProject.FibonacciWSReference.FibonacciResponse> FibonacciAsync(SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FibonacciRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Fibonacci", Namespace="http://tempuri.org/", Order=0)]
        public SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequestBody Body;
        
        public FibonacciRequest() {
        }
        
        public FibonacciRequest(SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FibonacciRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int n;
        
        public FibonacciRequestBody() {
        }
        
        public FibonacciRequestBody(int n) {
            this.n = n;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FibonacciResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FibonacciResponse", Namespace="http://tempuri.org/", Order=0)]
        public SoapWSUnitTestProject.FibonacciWSReference.FibonacciResponseBody Body;
        
        public FibonacciResponse() {
        }
        
        public FibonacciResponse(SoapWSUnitTestProject.FibonacciWSReference.FibonacciResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FibonacciResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FibonacciResult;
        
        public FibonacciResponseBody() {
        }
        
        public FibonacciResponseBody(string FibonacciResult) {
            this.FibonacciResult = FibonacciResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LemonWayWebServiceSoapChannel : SoapWSUnitTestProject.FibonacciWSReference.LemonWayWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LemonWayWebServiceSoapClient : System.ServiceModel.ClientBase<SoapWSUnitTestProject.FibonacciWSReference.LemonWayWebServiceSoap>, SoapWSUnitTestProject.FibonacciWSReference.LemonWayWebServiceSoap {
        
        public LemonWayWebServiceSoapClient() {
        }
        
        public LemonWayWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LemonWayWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LemonWayWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LemonWayWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapWSUnitTestProject.FibonacciWSReference.FibonacciResponse SoapWSUnitTestProject.FibonacciWSReference.LemonWayWebServiceSoap.Fibonacci(SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequest request) {
            return base.Channel.Fibonacci(request);
        }
        
        public string Fibonacci(int n) {
            SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequest inValue = new SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequest();
            inValue.Body = new SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequestBody();
            inValue.Body.n = n;
            SoapWSUnitTestProject.FibonacciWSReference.FibonacciResponse retVal = ((SoapWSUnitTestProject.FibonacciWSReference.LemonWayWebServiceSoap)(this)).Fibonacci(inValue);
            return retVal.Body.FibonacciResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoapWSUnitTestProject.FibonacciWSReference.FibonacciResponse> SoapWSUnitTestProject.FibonacciWSReference.LemonWayWebServiceSoap.FibonacciAsync(SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequest request) {
            return base.Channel.FibonacciAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoapWSUnitTestProject.FibonacciWSReference.FibonacciResponse> FibonacciAsync(int n) {
            SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequest inValue = new SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequest();
            inValue.Body = new SoapWSUnitTestProject.FibonacciWSReference.FibonacciRequestBody();
            inValue.Body.n = n;
            return ((SoapWSUnitTestProject.FibonacciWSReference.LemonWayWebServiceSoap)(this)).FibonacciAsync(inValue);
        }
    }
}
