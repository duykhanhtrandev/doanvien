# PROGRAM SETTING
## STEP 1: 
Import Database (QLDOANVIEN.bacpac) into your Microsoft SQL Server.

![Database](https://user-images.githubusercontent.com/109634649/182444984-74890694-ff1d-4c0c-a63d-50b50019b80a.png)

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
![login form](https://user-images.githubusercontent.com/109634649/182445341-5087e4a2-022c-428c-b68a-94d59e588a14.png)

![doanvien form](https://user-images.githubusercontent.com/109634649/182445997-08d8c3a9-31f2-483f-a266-76084c530867.png)


### END
And finally this is a big assignment in my important subject. There will be some unresolved issues. but maybe in the future I will develop it more complete. 
