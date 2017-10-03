[<img src="https://cdn.anychart.com/images/logo-transparent-segoe.png?2" width="234px" alt="AnyChart - Robust JavaScript/HTML5 Chart library for any project">](https://anychart.com)
# ASP.NET C# basic template

This example shows how to use Anychart library with the C# programming language using ASP.NET and MySQL database.

## Running
This example uses .NET framework 4.6.1, ASP.NET 4.0.30319, ASP.NET MVC 5.2, Visual Studio 2015 Community, MySQL 5.6 and MySQL Connector/NET 6.9.9.0 - ADO.NET driver for MySQL.
To check your installations, please, use Windows Control Panel -> Programs and features.
If you miss some installations, please, visit:<br />
[MySQL download page](https://dev.mysql.com/downloads/installer/) and [installation instructions](http://dev.mysql.com/doc/refman/5.7/en/installing.html) to setup MySQL;<br />
[Visual Studio download page](https://www.visualstudio.com/downloads/) to install Visual Studio, .NET framework and ASP.NET;<br />
[Connector/Net download page](https://dev.mysql.com/downloads/connector/net/6.9.html) to install MySQL Connector/NET.<br />

To start this example run commands listed below.

Clone the repository from github.com to your working directory:
```
$ git clone git@github.com:anychart-integrations/asp-net-c-sharp-mysql-template.git
```

Open cmd console in 'asp-net-c-sharp-mysql-template' folder and set up MySQL database, use -u -p flags to provide username and password:
```
$  "[YOUR_PATH_TO_MYSQL]\bin\mysql.exe" -u[USER_NAME] -p < database_backup.sql
e.g:  
$  "C:\Program Files\MySQL\MySQL Server 5.6\bin\mysql.exe" -uroot -p < database_backup.sql
```

Open project in Visual Studio using AspNetCSharpMysqlTemplate.sln solution file

Run application using Run button or press F5

If you have some problems with MySQL connection, ensure that MySql.Data.Entity.EF6 in References has correct path to MySql.Data.Entity.EF6.dll

## Workspace
Your workspace should look like:
```
AspNetCSharpMysqlTemplate/
    App_Start/
		RouteConfig.cs			# app routes
	Controllers/
		ChartController.cs		# main controller
    css/
		style.css				# main css file
    Models/
		fruit.cs				# Entity framework model for MySQL
		FruitDBContext.cs		# DB data provider
	Views/
		Chart/
			Index.cshtml		# html template
		web.config
	Global.asax
	packages.config
	Web.config					# main ASP.NET project settings
```

## Technologies
Language - [C#](https://msdn.microsoft.com/en-us/library/ms228593.aspx)<br />
Web framework - [ASP.NET](https://www.asp.net)<br />
Database Mapping - [Entity Framework](https://www.asp.net/entity-framework)<br />
HTML Tepmlate - [Razor](https://www.asp.net/web-pages/overview/getting-started/introducing-razor-syntax-c)<br />
Database - [MySQL](https://www.mysql.com/)<br />

## Further Learning
* [Documentation](https://docs.anychart.com)
* [JavaScript API Reference](https://api.anychart.com)
* [Code Playground](https://playground.anychart.com)
* [Technical Support](https://anychart.com/support)

## License
AnyChart ASP.NET/C#/MySql integration sample includes two parts:
- Code of the integration sample that allows to use Javascript library (in this case, AnyChart) with ASP.NET framework, C# language and MySql database. You can use, edit, modify it, use it with other Javascript libraries without any restrictions. It is released under [Apache 2.0 License](https://github.com/anychart-integrations/asp-net-c-sharp-mysql-template/blob/master/LICENSE).
- AnyChart JavaScript library. It is released under Commercial license. You can test this plugin with the trial version of AnyChart. Our trial version is not limited by time and doesn't contain any feature limitations. Check details [here](https://www.anychart.com/buy/).

If you have any questions regarding licensing - please contact us. <sales@anychart.com>
