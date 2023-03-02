# MacMillan.WebUi

System Requirements:

1. .NET SDK 7.0
2. Visual Studio or Visual Studio Code
3. Chrome browser latest (The tests have been created using Chrome version 110.0.5481.177 (Official Build) (x86_64))

To Run Tests:

Run the below command,

dotnet test

Change Environments:

1. Environment details can be updated in the Architecture/EnvironmentConfig/config.json
2. EnvironmentName field in EnvironmentDetails.cs need to be modified to access different environment configurations

Known Issues:

1. The DatePicker tests are designed to use the DatePicker GUI. So, can only enter time in 15 minute intervals as shown in the UI.
2. Coding to use the Up or Down arrows while choosing year hasn't been included in this version.
3. Scenario 'Scenario: Open a new Window message' has been  marked as Ignored due to a bug in the application (timeout error occurs while trying to read text from the New Window Message window)
4. Negative scenarios have only been added for the TextBox and LoginPage scenarios due to availability of time