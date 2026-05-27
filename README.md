# ASPNYOLCMASODJARA
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.22
Install-Package Microsoft.EntityFrameworkCore.Design -Version 8.0.22
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.22
zsoltikv — tegnap 20:40-kor
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
