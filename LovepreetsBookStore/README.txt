12/11/2022
9:52  pmstarted the assignment 2
10:00 pm Sign in requirement removed
10:07 pm Debug Tested
10:15 pm Selected Solar Theme
10:22 pm Replaced the existing site.css file
10:29 pm Changed the file name in views folder
10:41 pm Changed to navbar dark from light and bg white to primary
10:53 pm Added additional properties to footer class
11:06 pm Added additional stylesheets and scripts from css_js.txt file to _Layout.cshtml
13/11/2022
1:58 am added dropdown to navbar
2:14 am added three new projects to the application
2:23 am Installed microsoft entity framework core.relational and core.sqlserver
2:33 am deleted the migrations folder
8:53 pm deleted default class1.cs file in all projects
9:24 pm renamed models folder to viewModels
9:26 pm modified startup.cs service
9:30 pm runned the application and reviewed the browser presentation
9:33 pm modified the properties of class
9:35 pm Added customers area to areas
17/11/2022
11:00 am To start the new Assig 2 Part 2 
11:05 am open the github repo... clone it in the Visual Studio 2019 community version
11:06 am start with the base by clossing all the unnecessary tabs...build the application and confirm there are no errors...
11:10 am after runnning the application move forward from the pptx...
11:11 am open the appsetting.json file and remove the code from line 3.
11:15 am from the nuGet Package console add the migration file in the .DataAccess class library
11:20 am "Add-Migration AddDefaultIdentityMigration"
11:26 am at first you get the error of target file project failed after selecting the .Dataaccess project it will Succeeded
11:30 am modify the created migration file as per pptx and update the migration...
11:34 am the new migration file creted by name : "20221117160630_AddDefaultIdentityMigration.cs" and "20221117161314_AddCategoryToDb.cs"11:
11:35 am add new table to the database by creating the model and push it to Db.
11:40 am Create new class file Category.cs in the model project
11:44 am modify the Category.cs file and again update the database !!!
11:50 am After altering the code in the ApplicationDb.context file update the migration and database again after Succeeded 
11:51 am commit this Part 2.1 in the github repo..
17/11/2022 
12:01 pm create new "Repository" folder and add new Interface Folder : "IRepository" in it..
12:05 pm create the IRepository.cs interface file in the IRepository folder edit the code after it...
12:06 pm same way create the new class file "Repository.cs" and edit it as per the requirement...
12:08 pm Create the new ICategoryReposiroty.cs interface file and then Create new CategoryRepository class file
12:10 pm after creating both the files modify both of them by the code provided in the pptx.
12:14 pm after fixing the error commmit all the changes in the GITHUB...
12:16 pm
12:18 pm Create the new interface file in IRepository folder named : ISP_Call.cs and add the code for
12:19 pm Dapper and iunstall the latest version in that...
12:20 pm SP_Call class file created and modify it with all the code present in PPTX.
12:22 pm After creating all the files like UnitOfWork and IUnitOfWork edit the code in given in the PPtx reference...
12:24 pm edit the using statment and reference in all the class and interface files...
12:25 pm open the startup.cs file and edit the line number 40 for the add serivice context to wrapper
12:30 pm after adding the line add the reference to the IRepository Folder in the using statment.commit till this part
12:31 pm after going forward to create CRUD pages Create one Controller in the folder name: CategoryController.cs file... edit the code inside it and create one category 
12:37 pm push all commit to github create the category.js file in the wwwroot > js > category.jsedit the code in the javascript file as per provided in the blackboard...
12:40 pm after it all done check the functionality of the edit ad delete and run the applivcation add the relevant code in the index.cshtml file and category.js file
12:44 pm check the expected the output in the web application  4 succeeded 0 failed 0 up-to-date all done !!!  commit all  End of Part 2
18/11/2022
02:22 am There were some errors with git pushing so I solved it and copied the README.txt file
		 and now am continuing the same step for expected output