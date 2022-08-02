# PROGRAMING SETTING
## STEP 1: 
Import Database (QLDOANVIEN.bacpac) into your Microsoft SQL.

![Database](https://user-images.githubusercontent.com/109634649/182444857-913ee0f4-98fb-4c4c-8451-f0ed9f01b144.png)

## Step 2:
Go to the App.Config files in Datalayer, ManageLayer and DLDOANVIEN to change the "data source" in the "connectionStrings" tag to the Server name of the machine in use, for example: "ADMIN\SQLEXPRESS01"
 
    bash
        <connectionStrings>
            <add name="QLDOANVIENEntities" connectionString="metadata=res://*/QLDV.csdl|res://*/QLDV.ssdl|res://*/QLDV.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=ADMIN\SQLEXPRESS01;initial catalog=QLDOANVIEN;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
        </connectionStrings>

## Step 3:
Start the program with Visual Studio

    bash
        Login form:
        - Username: admin
        - Password: admin
