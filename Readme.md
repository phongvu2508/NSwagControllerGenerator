## Follow this step to generate controller code from api schema

- Clone this and put it under **C:\Source** or **C:\Src**
- Make sure that you have .netcore 2.1 installed in the system.
- Export your api schema as yaml files and place them in 'Schema' folder.
- Rename your schema to the project that you want to generate
  > **Example:**  InternalApi.yaml will generate Internal API controllers and client code
  > **Example:**  WebApi.yaml will generate Web API controllers
- Run 'GenerateController.bat'
- Your generated controllers will be added under 'Controller' folder.
