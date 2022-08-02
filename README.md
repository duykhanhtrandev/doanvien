# CÀI ĐẶT CHƯƠNG TRÌNH
## Bước 1: 
Import Database (QLDOANVIEN.bacpac) vào Microsoft SQL của bạn.

## Bước 2:
Vào file App.Config thay đổi data source thành Server name của bạn, ở đây của tôi là "ADMIN\SQLEXPRESS01"
 
    bash
        <connectionStrings>
            <add name="QLDOANVIENEntities" connectionString="metadata=res://*/QLDV.csdl|res://*/QLDV.ssdl|res://*/QLDV.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=ADMIN\SQLEXPRESS01;initial catalog=QLDOANVIEN;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
        </connectionStrings>

## Bước 3:
Khởi động chương trình bằng visual studio

    bash
        Login form:
        - Tài khoản: admin
        - Mật khẩu: admin
