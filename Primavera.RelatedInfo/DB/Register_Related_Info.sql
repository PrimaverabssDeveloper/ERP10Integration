/* Delete component if exist on the system.*/
DELETE  from ContextosInformacaoRelacionada WHERE [IdCategoria]='8701B2DD-3FA4-4874-9E6E-E4195734FF22'
DELETE  from InformacaoRelacionada WHERE [Id]='8701B2DD-3FA4-4874-9E6E-E4195734FF22'
GO

/* Register the component on the system */
/* To find the "Categoria" field use the ERP diagnostics window. */
/* Set a new ID for the componente. This ID will identify your component in the system. */
INSERT INTO InformacaoRelacionada ([Id],[Categoria],[Config]) 
Values(
	'8701B2DD-3FA4-4874-9E6E-E4195734FF22', 'Clientes',
	'<Config>
    <General>
        <TypeClassName>Primavera.Party.RelatedInfo.CurrentAccountInfo</TypeClassName>
        <Name>Pendente por entidade</Name>
        <Title>Saldo em divida por conta</Title>
        <Description>Saldo em divida por conta</Description>
        <ShowDescription>0</ShowDescription>
        <Height>200</Height>
    </General>
	</Config>'
)
GO

/* The window where the component will be display. In this case the sales editor. */
/* To find the "Contexto" field use the ERP diagnostics window. */
INSERT INTO ContextosInformacaoRelacionada([IdCategoria],[Contexto],[Ordem],[Params]) 
Values (
	'8701B2DD-3FA4-4874-9E6E-E4195734FF22','frmDocVendas',1,
	'<Config>
		<General>
	        <Expanded>1</Expanded>
	    </General>
	    <Params></Params>
	</Config>'
)
GO