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

#### Delete an existing record

We will select the desiered row and then we will press the ```DELETE``` button, after that a pop-up will appear and if we press ```OK``` the updated table will be shown.(**THIS IS AVALABILE FOR ALL THE ACTIONS THAT MODIFIES THE TABLE**)

![fig6](https://user-images.githubusercontent.com/100710098/222252157-b7007031-c3e6-4859-9ecf-14f96c34e1b3.PNG)


![fig7](https://user-images.githubusercontent.com/100710098/222252636-00f159a7-da8b-4db8-843d-212e1610175d.PNG)

It also has a warining for delete cascade

![FIG14](https://user-images.githubusercontent.com/100710098/222256357-74dc2e0e-a061-406c-8757-6036067e34f8.PNG)


**NOTE: THE ```RESET``` BUTTON WILL CLEAR THE TEXT TABELS AND WILL DESELECT THE SELECTED ROW**

####  Displaying the products and the customers who have ordered products with a price greater than or equal to x in a quantity greater than or equal to y

We will click on the button with this name and after that, we will write the desiered values in the text labels and click on ```AFISARE``` BUTTON

![FIG8](https://user-images.githubusercontent.com/100710098/222254027-665779b8-0aee-4a0f-8813-f6e6e7790d4e.PNG)

![FIG9](https://user-images.githubusercontent.com/100710098/222254081-4906f2e2-d8ec-42f5-8e10-a991c305510f.PNG)


#####  Displaying the profitability of a product including the discount granted to the customer

We will click on the button with the same name and there will be two casese: one case which shows profitability for only one product or to show the profitability for all the products. When we open this window we will see the product table to know exactly every detail of each product

![FIG11](https://user-images.githubusercontent.com/100710098/222255576-1c4e89ea-1e68-4273-8b5b-7eba6f28c1a7.PNG)

We need to select the desiered product from the dropdown list (if we want one product)
![fig13](https://user-images.githubusercontent.com/100710098/222255820-70e6b06f-3f3c-4832-8f13-d331fa84eca5.PNG)

We need to press the button ```TOATE PRODUSELE``` (if we want all the products)
![FIG 12](https://user-images.githubusercontent.com/100710098/222255838-69fbf427-eae3-4f92-80e6-eb6ce2a37c6c.PNG)

**THANK YOU!**

**FULL DETAILED DOCUMENTATION IN ROMANIAN**

[Proiect_TURIS_Gavriil_Vlad.pdf]
(https://github.com/VladRo26/User_Graphic_Interface-.NET-/files/10864989/Rezolvari_Capitolul_III_Proiect_TURIS_Gavriil_Vlad_262.pdf)



