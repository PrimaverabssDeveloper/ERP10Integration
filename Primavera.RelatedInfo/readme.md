# Related Information

This code sample shows how to use the PRIMAVERA ERP context panel to show related information.

### What is context panel?

In order to answer this question, you need to know what a panel is. A panel simply is a region where you can insert different types of content 
and add some extra information related with an entity on a particular windows. The related information panel are linked with a specific category and will be displayed only when this category is selected.

### How panel tecnology works?
To start developing a third-party component you need:
1. Register the new component in the system. Add some information to `InformacaoRelacionada` table.
2. Set the window(s) where the component will be displayed. Add some information to `ContextosInformacaoRelacionada` table.
3. Create visual studio solution an add a reference to `StdPlatBE100` 
4. Add a user control and implement the `IStdBEInfRelacionada` interface.
