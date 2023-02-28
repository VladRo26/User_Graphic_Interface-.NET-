# User_Graphic_Interface-.NET-
## Cafeteria GUI(Oracle SQL/Windows form application C#)
### About the project

**Step 1**
-The database was designed by me using [LuchidChart](https://www.lucidchart.com/pages)
![Diagrama conceptuala finala  (1)](https://user-images.githubusercontent.com/100710098/221895952-a20f5723-ed8f-455e-91cc-0a5122cf8736.jpeg)

**Step 2**

-The script of the database was written in DataGrip(Oracle SQL)

**Step 3**
-I developed the GUI using Visual Studio 2019 using Windows Forms App(.NET Framework)


### The GUI can perform the following tasks:

- Lists the records from all the tables:
- Create a new record
- Modify a new record
- Delete a record
- Displaying the profitability of a product including the discount granted to the customer
- Displaying the products and the customers who have ordered products with a price greater than or equal to x in a quantity greater than or equal to y
(**x and y are read from keyboard**)

### Presentation

The main page of the GUI contains buttons for all the tables in the database. 
![fig1](https://user-images.githubusercontent.com/100710098/221899982-7d73ced6-b50c-4ccd-8ae5-0665da6cce2c.PNG)

#### Displaying the records
To display records from a table you need to click on the button with the name of the desiered table and, after that a pop-up will notice you if you want to modify the table
In this case if we want just to see the table we will click ```NO```
![fig2](https://user-images.githubusercontent.com/100710098/221901385-dbb9f936-d4a2-4a3d-84cb-608d2e175966.PNG)

You can also **sort the records**. If you press  ```RESET``` button the current table will dissappear.

![fig3](https://user-images.githubusercontent.com/100710098/221902522-a76104a1-7a3a-4c19-b3ad-d788899e5aa0.PNG)

**IF YOU WANT TO MODIFY A TABLE YOU NEED TO CLICK ON THE NAME OF THE TABLE, AND AFTER THAT YOU NEED TO CLICK ```YES``` on the pop-up that asks you : Do you want to modify the table?**

#### Create a new record
We will insert our data in the blank spaces and after that we will click on the ```INSERT``` button

![fig4](https://user-images.githubusercontent.com/100710098/221905977-26c29959-ed83-40d0-8536-60906b2f203a.PNG)


#### Modify an existing record

We will select the row that we want to modify and all the date will appear in the blank spaces, and after we modify the date we will press on the ```UPDATE``` button

![fig5](https://user-images.githubusercontent.com/100710098/221907115-7b71f4ab-04f6-4422-8674-065eb0a0515b.PNG)
