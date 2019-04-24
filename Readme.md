1. Make sure that you have .netcore 2.2 installed in the system.
2. Export your api schema as json files and place them in 'Schema' folder.
3. Rename your schema to the controller that you want to generate (Ex: location.json will generate LocationController.cs, user.json will generate UserController.cs)
4. Run 'GenerateController.bat'
5. Your generated controllers will be added under 'Controller' folder.