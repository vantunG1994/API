﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace BusinessLogicLayer.SubCategoryLocalhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SubCategoryServiceSoap", Namespace="http://SubCategoryService.org/")]
    public partial class SubCategoryService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetListSubCategoryOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddSubCategoryOperationCompleted;
        
        private System.Threading.SendOrPostCallback ExisSubNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback EditSubCategoryOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SubCategoryService() {
            this.Url = global::BusinessLogicLayer.Properties.Settings.Default.BusinessLogicLayer_SubCategoryLocalhost_SubCategoryService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetListSubCategoryCompletedEventHandler GetListSubCategoryCompleted;
        
        /// <remarks/>
        public event AddSubCategoryCompletedEventHandler AddSubCategoryCompleted;
        
        /// <remarks/>
        public event ExisSubNameCompletedEventHandler ExisSubNameCompleted;
        
        /// <remarks/>
        public event EditSubCategoryCompletedEventHandler EditSubCategoryCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://SubCategoryService.org/GetListSubCategory", RequestNamespace="http://SubCategoryService.org/", ResponseNamespace="http://SubCategoryService.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SubCategoryDTO[] GetListSubCategory() {
            object[] results = this.Invoke("GetListSubCategory", new object[0]);
            return ((SubCategoryDTO[])(results[0]));
        }
        
        /// <remarks/>
        public void GetListSubCategoryAsync() {
            this.GetListSubCategoryAsync(null);
        }
        
        /// <remarks/>
        public void GetListSubCategoryAsync(object userState) {
            if ((this.GetListSubCategoryOperationCompleted == null)) {
                this.GetListSubCategoryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetListSubCategoryOperationCompleted);
            }
            this.InvokeAsync("GetListSubCategory", new object[0], this.GetListSubCategoryOperationCompleted, userState);
        }
        
        private void OnGetListSubCategoryOperationCompleted(object arg) {
            if ((this.GetListSubCategoryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetListSubCategoryCompleted(this, new GetListSubCategoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://SubCategoryService.org/AddSubCategory", RequestNamespace="http://SubCategoryService.org/", ResponseNamespace="http://SubCategoryService.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddSubCategory(SubCategoryDTO pSubCategoryDTO) {
            object[] results = this.Invoke("AddSubCategory", new object[] {
                        pSubCategoryDTO});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddSubCategoryAsync(SubCategoryDTO pSubCategoryDTO) {
            this.AddSubCategoryAsync(pSubCategoryDTO, null);
        }
        
        /// <remarks/>
        public void AddSubCategoryAsync(SubCategoryDTO pSubCategoryDTO, object userState) {
            if ((this.AddSubCategoryOperationCompleted == null)) {
                this.AddSubCategoryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddSubCategoryOperationCompleted);
            }
            this.InvokeAsync("AddSubCategory", new object[] {
                        pSubCategoryDTO}, this.AddSubCategoryOperationCompleted, userState);
        }
        
        private void OnAddSubCategoryOperationCompleted(object arg) {
            if ((this.AddSubCategoryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddSubCategoryCompleted(this, new AddSubCategoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://SubCategoryService.org/ExisSubName", RequestNamespace="http://SubCategoryService.org/", ResponseNamespace="http://SubCategoryService.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ExisSubName(string pSubName, int pSubID) {
            object[] results = this.Invoke("ExisSubName", new object[] {
                        pSubName,
                        pSubID});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ExisSubNameAsync(string pSubName, int pSubID) {
            this.ExisSubNameAsync(pSubName, pSubID, null);
        }
        
        /// <remarks/>
        public void ExisSubNameAsync(string pSubName, int pSubID, object userState) {
            if ((this.ExisSubNameOperationCompleted == null)) {
                this.ExisSubNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnExisSubNameOperationCompleted);
            }
            this.InvokeAsync("ExisSubName", new object[] {
                        pSubName,
                        pSubID}, this.ExisSubNameOperationCompleted, userState);
        }
        
        private void OnExisSubNameOperationCompleted(object arg) {
            if ((this.ExisSubNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ExisSubNameCompleted(this, new ExisSubNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://SubCategoryService.org/EditSubCategory", RequestNamespace="http://SubCategoryService.org/", ResponseNamespace="http://SubCategoryService.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool EditSubCategory(SubCategoryDTO pSubCategoryDTO) {
            object[] results = this.Invoke("EditSubCategory", new object[] {
                        pSubCategoryDTO});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void EditSubCategoryAsync(SubCategoryDTO pSubCategoryDTO) {
            this.EditSubCategoryAsync(pSubCategoryDTO, null);
        }
        
        /// <remarks/>
        public void EditSubCategoryAsync(SubCategoryDTO pSubCategoryDTO, object userState) {
            if ((this.EditSubCategoryOperationCompleted == null)) {
                this.EditSubCategoryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEditSubCategoryOperationCompleted);
            }
            this.InvokeAsync("EditSubCategory", new object[] {
                        pSubCategoryDTO}, this.EditSubCategoryOperationCompleted, userState);
        }
        
        private void OnEditSubCategoryOperationCompleted(object arg) {
            if ((this.EditSubCategoryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EditSubCategoryCompleted(this, new EditSubCategoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://SubCategoryService.org/")]
    public partial class SubCategoryDTO {
        
        private int idField;
        
        private string nameField;
        
        private int categoryIdField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int CategoryId {
            get {
                return this.categoryIdField;
            }
            set {
                this.categoryIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GetListSubCategoryCompletedEventHandler(object sender, GetListSubCategoryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetListSubCategoryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetListSubCategoryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SubCategoryDTO[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SubCategoryDTO[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void AddSubCategoryCompletedEventHandler(object sender, AddSubCategoryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddSubCategoryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddSubCategoryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void ExisSubNameCompletedEventHandler(object sender, ExisSubNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExisSubNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ExisSubNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void EditSubCategoryCompletedEventHandler(object sender, EditSubCategoryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EditSubCategoryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EditSubCategoryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591