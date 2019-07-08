# Human Resources Sample
The Human Resources module of PRIMAVERA ERP includes several features that allow you to manage your organization's human resources processes with greater speed and efficiency, such as salary processing, integration with social security or payment and receipts management.

In this project, you will find code samples to show how to work with the human resources integration, such as:
- Employee
- Monthly Changes
- Payroll
- Payslips

## Employee
Among all the options available in the module, the main Human Resources entity is the employee table, where you can access employee files. This table is used in many of the existing processes and includes the configurations used in most of the module.

To create an employee, follow these steps:

#### 1. Create the employee object with the required information
```C#
RhpBEFuncionario employee = new RhpBEFuncionario
{
  Funcionario = "<employee_code>",
  Nome = "<employee_name>",
  (...)
};
```

#### 2. Save the employee
```C#
PriEngine.Engine.RecursosHumanos.Funcionarios.Actualiza(employee);
```

## Monthly Changes
You can manage changes to your employees' data, such as recording absences, overtime, salaries and deductions.

To record an absence for an employee, follow these steps:

#### 1. Validate if the Absence exists

You can only report employee absences that exist in the absence table.

#### 2. Create the absence object with the necessary information
```C#
RhpBECadastroFalta absenceRecords = new RhpBECadastroFalta
{
  Funcionario = txtEmployee.Text.ToUpper(),
  (...)
};
```

#### 3. Save the absence record

You need to check if the absence associated with the employee already exists on the specified date before entering it.
If it already exists, the system updates the existing absence data, otherwise it will report a new absence with the entered data.
```C#
PriEngine.Engine.RecursosHumanos.CadastroFaltas.Actualiza(absenceRecords);
```

## Salary Processing
In practice, employee salary processing is one of the module's most important features, allowing you to process earning amounts, holiday and Christmas allowances, extraordinary and end-of-contract pays.

To process an employee's salary, follow these steps:

#### 1. Validate if the Employee exists

To be able to process employees' earnings, they must already be registered in the database.
```C#
PriEngine.Engine.RecursosHumanos.Funcionarios.Existe(txtEmployeeID.Text)
```

#### 2. Create the processing object with the necessary information
```C#
RhpBEProcessamento Payroll = new RhpBEProcessamento
{
  Funcionario = txtEmployeeID.Text.ToUpper(),
  (...)
}
```

#### 3. Enter the period specified for the Employee
```C#
Payroll.Periodo = PriEngine.Engine.RecursosHumanos.Funcionarios.DaValorAtributo(Payroll.Funcionario, "Periodo").ToString();
```

#### 4. Perform the processing
```C#
PriEngine.Engine.RecursosHumanos.Processamento.ProcessaAuto(Payroll, ref error);
```

