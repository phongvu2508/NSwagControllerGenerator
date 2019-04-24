## Follow this step to generate controller code from api schema

- Make sure that you have .netcore 2.2 installed in the system.
- Export your api schema as json files and place them in 'Schema' folder.
- Rename your schema to the controller that you want to generate
> **Example:**  location.json will generate LocationController.cs, user.json will generate UserController.cs
- Run 'GenerateController.bat'
- Your generated controllers will be added under 'Controller' folder.
