CÀI ĐẶT CHƯƠNG TRÌNH
Bước 1: Tải và add database(QLDOANVIEN.bacpac) vào Microsoft SQL của các bạn

Vào file App.config thay đổi tên data source, ở đây của tôi là "ADMIN\SQLEXPRESS01"
<connectionStrings>
    <add name="QLDOANVIENEntities" connectionString="metadata=res://*/QLDV.csdl|res://*/QLDV.ssdl|res://*/QLDV.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=ADMIN\SQLEXPRESS01;initial catalog=QLDOANVIEN;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
