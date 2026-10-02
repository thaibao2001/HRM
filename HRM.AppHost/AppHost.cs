var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql")
    .AddDatabase("HRM");

builder.AddProject<Projects.HRM_API>("hrm-api");

builder.Build().Run();
