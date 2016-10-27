[<img src="https://cdn.anychart.com/images/logo-transparent-segoe.png?2" width="234px" alt="AnyChart - Robust JavaScript/HTML5 Chart library for any project">](https://anychart.com)
PHP basic template
=========================

This example shows how to use Anychart library with the C# programming language using ASP.NET and MySQL database.

## Running

To use this sample you must have .net framework installed, Visual Studio 2015 or higher, MySQL database and MySQL Connector/NET - ADO.NET driver for MySQL.
 To check your installations, please, use Windows Control Panel -> Programs and features.
If you miss some installations, please, visit:<br />
https://dev.mysql.com/downloads/installer/ and http://dev.mysql.com/doc/refman/5.7/en/installing.html to install MySQL<br />
https://www.visualstudio.com/downloads/ to install Visual Studio and .net framework <br />
https://dev.mysql.com/downloads/connector/net/6.9.html to install MySQL Connector/NET<br />

To start this example run commands listed below.

Clone the repository from github.com to your working directory:
```
$ git clone git@github.com:anychart-integrations/asp-net-c-sharp-mysql-template.git
```

Set up MySQL database, use -u -p flags to provide username and password:
```
$  "[YOUR_PATH_TO_MYSQL]\MySQL\MySQL Server 5.6\bin\mysql.exe" < "[YOUR_WORKING_DIRECTORY]\asp-net-c-sharp-mysql-template\database_backup.sql"
e.g:  
$  "C:\Program Files\MySQL\MySQL Server 5.6\bin\mysql.exe" -uroot -ppassword < "D:\work\asp\asp-net-c-sharp-mysql-template\database_backup.sql" 
```

Open project in Visual Studio using AspNetCSharpMysqlTemplate.sln solution file

Run application using Run button or press F5


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
		FruitDBContext			# DB data provider
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
Web framework - [Symfony](https://www.asp.net)<br />
Database Mapping [Entity Framework](https://www.asp.net/entity-framework)<br />
HTML Tepmlate - [Razor](https://www.asp.net/web-pages/overview/getting-started/introducing-razor-syntax-c)<br />
Database - [MySQL](https://www.mysql.com/)<br />

## Further Learning
* [Documentation](https://docs.anychart.com)
* [JavaScript API Reference](https://api.anychart.com)
* [Code Playground](https://playground.anychart.com)
* [Technical Support](https://anychart.com/support)

## License
[© AnyChart.com - JavaScript charts](http://www.anychart.com). Released under the [Apache 2.0 License](https://github.com/anychart-integrations/php-symfony-mysql/blob/master/LICENSE).
