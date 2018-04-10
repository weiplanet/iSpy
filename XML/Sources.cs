﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Manufacturers {
    
    private ManufacturersManufacturer[] manufacturerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Manufacturer")]
    public ManufacturersManufacturer[] Manufacturer {
        get {
            return this.manufacturerField;
        }
        set {
            this.manufacturerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class ManufacturersManufacturer {
    
    private ManufacturersManufacturerUrl[] urlField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("url")]
    public ManufacturersManufacturerUrl[] url {
        get {
            return this.urlField;
        }
        set {
            this.urlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class ManufacturersManufacturerUrl {
    
    private string versionField;
    
    private string confirmedField;
    
    private string prefixField;
    
    private string sourceField;
    
    private string urlField;
    
    private bool fixedField;
    
    private string audioModelField;
    
    private string flagsField;
    
    private int portField;
    
    private bool portFieldSpecified;
    
    private string cookiesField;
    
    private string audioSourceField;
    
    private string audioURLField;
    
    private int idField;
    
    private bool idFieldSpecified;
    
    private string tokenPathField;
    
    private string tokenPostField;
    
    private int tokenPortField;
    
    private bool tokenPortFieldSpecified;
    
    public ManufacturersManufacturerUrl() {
        this.confirmedField = "false";
        this.fixedField = false;
        this.cookiesField = "";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("false")]
    public string confirmed {
        get {
            return this.confirmedField;
        }
        set {
            this.confirmedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string prefix {
        get {
            return this.prefixField;
        }
        set {
            this.prefixField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Source {
        get {
            return this.sourceField;
        }
        set {
            this.sourceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url {
        get {
            return this.urlField;
        }
        set {
            this.urlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool @fixed {
        get {
            return this.fixedField;
        }
        set {
            this.fixedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AudioModel {
        get {
            return this.audioModelField;
        }
        set {
            this.audioModelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string flags {
        get {
            return this.flagsField;
        }
        set {
            this.flagsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int port {
        get {
            return this.portField;
        }
        set {
            this.portField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool portSpecified {
        get {
            return this.portFieldSpecified;
        }
        set {
            this.portFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string cookies {
        get {
            return this.cookiesField;
        }
        set {
            this.cookiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AudioSource {
        get {
            return this.audioSourceField;
        }
        set {
            this.audioSourceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AudioURL {
        get {
            return this.audioURLField;
        }
        set {
            this.audioURLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool idSpecified {
        get {
            return this.idFieldSpecified;
        }
        set {
            this.idFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tokenPath {
        get {
            return this.tokenPathField;
        }
        set {
            this.tokenPathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tokenPost {
        get {
            return this.tokenPostField;
        }
        set {
            this.tokenPostField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int tokenPort {
        get {
            return this.tokenPortField;
        }
        set {
            this.tokenPortField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tokenPortSpecified {
        get {
            return this.tokenPortFieldSpecified;
        }
        set {
            this.tokenPortFieldSpecified = value;
        }
    }
}
