﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

' 
' This source code was auto-generated by wsdl, Version=2.0.50727.42.
' 


'/ <remarks/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")> _
<System.Web.Services.WebServiceAttribute(Namespace:="http://webservices.aspitalia.com/WeatherService")> _
<System.Web.Services.WebServiceBindingAttribute(Name:="WeatherServiceSoap", Namespace:="http://webservices.aspitalia.com/WeatherService")> _
Partial Public MustInherit Class ContractFirstWeatherService
    Inherits System.Web.Services.WebService

    '/ <remarks/>
    <System.Web.Services.WebMethodAttribute()> _
    <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://webservices.aspitalia.com/WeatherService/GetTemperature", RequestNamespace:="http://webservices.aspitalia.com/WeatherService", ResponseNamespace:="http://webservices.aspitalia.com/WeatherService", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
    Public Overridable Function GetTemperature(ByVal cityName As String) As Double

    End Function
End Class