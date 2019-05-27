# AwesomeAlligator Angular Playground

## NileMoster. Build Asp DotNet - Angular App

### NileMoster.WebApi

#### Command tools
* dotnet new webapi -o NileMoster.WebApi -n AwesomeAlligator.NileMoster.WebApi
* switch Development / Production hosting enviroment in *launchSettings.json* file
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
* dotnet run / dotnet watch run
* Entity Framework
	https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core-example.html
	dotnet add package MySql.Data.EntityFrameworkCore
	*Startup.cs*
		public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(x => x.UseMySQL(Configuration.GetConnectionString("MySqlConnection")));
	*appsettings.json*
		"ConnectionStrings": {
			"MySqlConnection" : "server=localhost;database=CROCODILE;user=root;password="
	dotnet ef
	dotnet ef migrations add InitialCreate
	dotnet ef database update

#### Pendiente Stuff
* config http / https project run
* dotnet web applications startup configuration (dependency)
* entity framework MIGRATIONS configuration and gestion files

#### Visual Studio CODE tools and tricks
