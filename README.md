Overview: -

I have completed this Barclays test.
And completed it using single responsibility SOLID principle.
1.	Created one library project using dot net framework. (That is for single responsibility implementation) 
2.	Created two separate interfaces for file version and file size.
3.	And added reference of this project to console application(FileData)
4.	Added new project (SingleResponsibilityPrinciple.Tests) for unit testing. And written unit test cases using visual studio test tool.
5.	And in unit test project I have used mocking tool for mock interfaces object.
And using these project and tool I am able to achieve below task assign by Barclyas.

Task 1
There is a need for a prototype Console app that :
•	Takes 2 arguments
•	If the first argument is -v, pass the second argument to FileDetails.Version
•	Write the response from FileDetails.Version to the Console
________________________________________
Task 2
The prototype has been well received by the business who now want a full version of the app.
The new requirements are (in no particular order):
•	To call FileDetails.Version if the first argument is either of -v, --v, /v, --version
•	To call FileDetails.Size if the first argument is either of -s, --s, /s, --size
