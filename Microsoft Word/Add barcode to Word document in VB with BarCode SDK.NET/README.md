## How to add barcode to word document in VB with barcode SDK in Microsoft Word with ByteScout Barcode Suite

### How to write a robust code in Microsoft Word to add barcode to word document in VB with barcode SDK with this step-by-step tutorial

Every ByteScout tool includes simple example Microsoft Word source codes that you can get here or in the folder with installed ByteScout product. What is ByteScout Barcode Suite? It is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can help you to add barcode to word document in VB with barcode SDK in your Microsoft Word application.

The SDK samples given below describe how to quickly make your application do add barcode to word document in VB with barcode SDK in Microsoft Word with the help of ByteScout Barcode Suite. IF you want to implement the functionality, just copy and paste this code for Microsoft Word below into your code editor with your app, compile and run your application. Applying Microsoft Word application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

The trial version of ByteScout Barcode Suite can be downloaded for free from our website. It also includes source code samples for Microsoft Word and other programming languages.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****InsertIntoMicrosoftWordDocument VB.NET.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{630024F8-F052-4B0B-A87A-5AFD23B4BD3A}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>InsertIntoMicrosoftWordDocument_VB.NET.Module1</StartupObject>
    <RootNamespace>InsertIntoMicrosoftWordDocument_VB.NET</RootNamespace>
    <AssemblyName>InsertIntoMicrosoftWordDocument VB.NET</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <OptionExplicit>On</OptionExplicit>
    <OptionCompare>Binary</OptionCompare>
    <OptionStrict>Off</OptionStrict>
    <OptionInfer>On</OptionInfer>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>InsertIntoMicrosoftWordDocument VB.NET.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>InsertIntoMicrosoftWordDocument VB.NET.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.1.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Module1.vb" />
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="Microsoft.Office.Core">
      <Guid>{2DF8D04C-5BFA-101B-BDE5-00AA0044DE52}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>3</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="VBIDE">
      <Guid>{0002E157-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>5</VersionMajor>
      <VersionMinor>3</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="Word">
      <Guid>{00020905-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>8</VersionMajor>
      <VersionMinor>3</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>

  <ItemGroup>
    <Content Include="input.doc">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>

  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Module1.vb:**
    
```
' IMPORTANT:
' Copy input.doc to your my documents folder
' and change the path to "input.doc" below 
' Word requires to provide absolute path to input files
'
'


Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Imports Bytescout.BarCode

Module Module1
    <STAThread()> _
    Sub Main()
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        barcode.Symbology = SymbologyType.Codabar
        ' Set value
        barcode.Value = "123456"

        ' Add checksum to barcode
        barcode.AddChecksum = True

        ' Create word instance
        Dim appWord As New Microsoft.Office.Interop.Word.Application()

        ' Hide word
        appWord.Visible = False

        ' Create missing object
        Dim mis As Object = System.Reflection.Missing.Value
        ' Template file - change to the appropraite path where you copied input.doc
        Dim fileInput As Object = "C:\input.doc"
        ' Template file -  change to the appropraite path where you copied input.doc
        Dim fileOutput As Object = "C:\output.doc"

        ' Open document
        Dim docWord As Microsoft.Office.Interop.Word.Document = appWord.Documents.Open(fileInput, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis)

        ' Set bookmark name
        Dim bookmarkName As Object = "MyBookmark"

        ' Get bookmark location
        Dim bookmarkLocation As Microsoft.Office.Interop.Word.Range = docWord.Bookmarks(bookmarkName).Range()

        ' Get barcode image
        Dim image As Bitmap = DirectCast(barcode.GetImage(), Bitmap)

        ' Copy image to the clipboard
        Clipboard.SetDataObject(image)

        ' Paste barcode image to the document
        bookmarkLocation.Paste()

        ' Save to the new document
        docWord.SaveAs(fileOutput, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis)

        ' We needn't save changes
        Dim saveChanges As Object = False

        ' Close word application
        appWord.Quit(saveChanges, mis, mis)

        ' Release COM object
        System.Runtime.InteropServices.Marshal.ReleaseComObject(appWord)
    End Sub

End Module

```

<!-- code block end -->