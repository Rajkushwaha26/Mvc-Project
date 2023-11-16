
using Microsoft.EntityFrameworkCore;
using AngularApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IO;
using System.Text;
 
var builder = WebApplication.CreateBuilder(args);
 
// Add services to the container.




IConfiguration cons=builder.Configuration;
builder.Services.AddControllers();

builder.Services.AddAuthentication(x=>{
    x.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(token=>{
    var key=Encoding.UTF8.GetBytes(cons["JWT:Key"]);
    token.TokenValidationParameters=new TokenValidationParameters
    {
        ValidateIssuer=false,
        ValidateAudience=false,
        ValidateLifetime=false,
        ValidateIssuerSigningKey=true,
        ValidIssuer=cons["Jwt:Issuer"],
        ValidAudience=cons["jwt:Audience"],
        IssuerSigningKey=new SymmetricSecurityKey(key)
    };
});
 
//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
builder.Services.AddDbContext<AppDbContext>(Options=>{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("DbConn"));
});
//builder.Services.AddTransient<IDepartment,DepartmentRepository>();
 
 
 
var app = builder.Build();
 
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
 
app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();
 
app.MapControllers();
 
app.Run();



// using Microsoft.EntityFrameworkCore;
// using AngularApi.Models;
// using Microsoft.AspNetCore.Authentication.JwtBearer;
// using Microsoft.IdentityModel.Tokens;
// using System.IO;
// using System.Text;
 
// var builder = WebApplication.CreateBuilder(args);
// IConfiguration cons=builder.Configuration;
// builder.Services.AddControllers();
// builder.Services.AddAuthentication(x=>{
//     x.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme;
//     x.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;
// }).AddJwtBearer(token=>{
//     var key=System.Text.Encoding.UTF8.GetBytes(cons["JWT:Key"]);
//     var key=System.Text.Encoding.UTF8.GetBytes(cons["JWT:Key"]);
//     token.TokenValidationParameters=new TokenValidationParameters
//     {
//         ValidateIssuer=false,
//         ValidateAudience=false,
//         ValidateLifetime=false,
//         ValidateIssuerSigningKey=true,
//         ValidIssuer=cons["Jwt:Issuer"],
//         ValidAudience=cons["jwt:Audience"],
//         IssuerSigningKey=new SymmetricSecurityKey(key)
//     };
// });
 
// //builder.Services.AddControllers();
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
 
// builder.Services.AddDbContext<AppDbContext>(Options=>{
//     Options.UseSqlServer(builder.Configuration.GetConnectionString("DbConn"));
// });
// //builder.Services.AddTransient<IDepartment,DepartmentRepository>();
 
 
 
// var app = builder.Build();
 
// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
 
// app.UseHttpsRedirection();
// app.UseAuthentication();

// app.UseAuthorization();
 
// app.MapControllers();
 
// app.Run();