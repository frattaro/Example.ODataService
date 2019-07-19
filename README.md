To run this example solution:

1. Restore nuget packages.

2. Generate data models and context in the Data project:

	a. If not using SQL Server, add the nuget package for the target database provider (example: Microsoft.EntityFrameworkCore.SqlServer)

	b. Open the Package Manager Console, run (example provider_name: Microsoft.EntityFrameworkCore.SqlServer):
		Scaffold-DbContext "<connection_string>" <provider_name>

3. Modify the included controllers in the Service project to use your data model.

4. Modify the included requests in the Client and NodeLambdaClient projects to use your data model.

5. Run the Service project (without debugging).

6. Run the Client project.

7. Run the NodeLambdaClient project.