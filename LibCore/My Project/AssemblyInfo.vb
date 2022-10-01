Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' La información general de un ensamblado se controla mediante el siguiente 
' conjunto de atributos. Cambie estos valores de atributo para modificar la información
' asociada con un ensamblado.

' Revisar los valores de los atributos del ensamblado

<Assembly: AssemblyTitle("LibCore")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("LibCore")>
<Assembly: AssemblyCopyright("Copyright ©  2022")>
<Assembly: AssemblyTrademark("")>

<Assembly: ComVisible(False)>

'El siguiente GUID sirve como id. de typelib si este proyecto se expone a COM.
<Assembly: Guid("7cf82dea-e9d7-44bb-99c2-a5bd44f316f3")>

' La información de versión de un ensamblado consta de los cuatro valores siguientes:
'
'      Versión principal
'      Versión secundaria
'      Número de compilación
'      Revisión
'
' Puede especificar todos los valores o usar los valores predeterminados de número de compilación y de revisión
' utilizando el carácter "*", como se muestra a continuación:

<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>

<Assembly: log4net.Config.XmlConfigurator(ConfigFile:="log4net.config", Watch:=True)>