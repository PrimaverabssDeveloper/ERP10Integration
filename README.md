# Resources V10

In this repository you will find resources and code samples to accelerate your integration with PRIMAVERABSS ERP V10.

## What is PRIMAVERA V10?

First of all, PRIMAVERA is a company specialized in the development of management solutions (*ERP - Enterprise Resource Planning*) for small, medium and large companies. PRIMAVERA's ERP 10 has a set of extensibility technologies that enable third-party applications to extend the base functionality or add new in order to provide richer solutions to the end customer.

The PRIMAVERA V10 is a solution that runs on Windows plataform, witch is developed on the .NET framework (*C#*) and SQL Server.

## Repository Organization

This repository is organized in two sections, in the section ERP you will found samples that will help you understand how to use ERP modules. In the section Platform you will found samples that will help you understand how to use platform features.

## Before Start

Before you start develop you integration, frist some base principles.

* The assemblies are installed by default in the PRIMAVERA folder `C:\Program Files (x86)\PRIMAVERA\SG100\Apl`.
* All the modules are identified by a prefix, fore example sales are `Vnd`, base entities like customer `Bas`, inventory are `Inv`.
* Witch module publish three assemblies:
    * **VndBEXXX.Dl** (XXX is the version): provide acess to the module the entities.
    * **IVndBSXXX.Dll** provide access to the module the entities.
    * **IVndDSXXX.Dll** provides access  to the data layer.
* Module services can only be used after open the database connection. **ERPBS100.DLL** provides a end point to do that.

```csharp
EnumTipoPlataforma objTipoPlataforma;
objTipoPlataforma = EnumTipoPlataforma.tpEmpresarial;

StdBETransaccao objStdTransac = new StdBETransaccao();
ErpBS MotorLE = new ErpBS();

MotorLE.AbreEmpresaTrabalho(objTipoPlataforma, <Companykey>, <User>, <Password>, objStdTransac, "Default");
```

## How to use the API?

To start developing a third-party application with Visual Studio you need:

1. A local installation of PRIMAVERA ERP 10.
2. Reference to .NET Framework 4.7.
3. Add to your project a reference to `ERPBS100.DLL`. This will provide access to all available modules services.
4. Add to your project a reference to the module that you want work with, for sales you must add `VndBE100.DLL` and `IVndBS100.DLL`
5. Add to your project a reference to `StdBE100.DLL` and `ConstantesPrimavera100`. This will provide access to enumeration types and some base entities.
6. Set the output path for your solution.
7. Finally you can start coding your project.

## Contributing and Feedback
Everyone is free to contribute to the repository.

Any bugs detected in the code samples can be reported in the *Issues* section of this repository.

## License

Unless otherwise specified, the code samples are released under the [MIT license](https://pt.wikipedia.org/wiki/Licen%C3%A7a_MIT).
