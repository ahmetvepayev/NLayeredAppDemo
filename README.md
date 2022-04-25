# NLayeredAppDemo

Simple Windows Forms application (.NET Framework) showcasing the use of multiple layers in a software architecture and how they can access data and interact with one another
+ Written while following along an online C# course
+ Written on Visual Studio Community 2022 in March 2022
+ ***Note -*** The application UI contains Turkish words. The labels will be rewritten in English when time permits. The labels in this README are written in English with that plan in mind

![](https://i.imgur.com/LQDRDcb.gif)



## Architecture

+ Classic three-tier architecture was employed, namely UI, Business and Data Access
+ Any given layer can only communicate with a layer one level above or below it



## Database

+ Used Northwind-Pubs sample database from [Microsoft sample SQL databases](https://github.com/microsoft/sql-server-samples/tree/master/samples/databases).
+ Application performs basic CRUD operations on the "Products" and "Catagories" tables in the database
+ Currently, the mapping is done with the help of EntityFramework
+ ***Note:*** NHibernate support is not implemented. The related class in the solution is placeholder

![](https://i.imgur.com/oQC11bV.png)



## NuGet Packages

+ __EntityFramework__ for object-relational mapping
+ __FluentValidation__ for validation
+ __Ninject__ for handling dependency injections



## Usage

+ **Search** for products by category using the combobox (drop down list). You can further search for products by product name using the search box
+ **Add** - Fill in the product information and click the "Add" button to add the product. The field requirements are as follows:
    - Product name : string
    - Category name : selected from the drop down list
    - Unit price : decimal
    - Quantity per unit : string
    - Stock amount : Int16
    - None of the fields can be empty
    - There may be additional rules enforced by validation. They can be changed anytime by editing [Northwind.Business/ValidationRules/FluentValidation/ProductValidator.cs](Northwind.Business/ValidationRules/FluentValidation/ProductValidator.cs)
+ **Update** - Select a product in the table and the product information will be automatically filled in the update box. After making changes to the product information, click the "Update" button
+ **Delete** - Select a product in the table and click the "Delete" button