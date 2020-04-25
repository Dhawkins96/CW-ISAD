# ISAD157 Coursework 
#### Assignment

For this assignment I have created a simple web-interface to display data stored in a mySQL database. The interface has 2 webpages:
* Login Page
* User Information Page


### Login Page

![Login](https://github.com/Dhawkins96/CW-ISAD/blob/master/Login.png)

The first page is a Login Page for the user to confirm their unique user ID number. If the user enters an incorrect user ID or clicks the button without typing anything a message box will pop up prompting the user to try again. 

![UserError](https://github.com/Dhawkins96/CW-ISAD/blob/master/UserError.png)

### User Information Page 

![UserInfo](https://github.com/Dhawkins96/CW-ISAD/blob/master/UserInfo.png)

Once the user has entered a correct user ID they will then be taken to the User Information Page. As you can see from the picture above they will be able to see;
* Their own information such as full name, gender, hometown, city, relationship status, their education name(s) and their workplace(s)
* The messages between them and their friends, the date and time the messages were sent, the text in the messages it's self
* Their friend list with their friends full name

This information is being retrieved from a MySQL server where five tables have been created;
* Users
* Friendship
* Messages
* Education
* Workplace

Within the code there are several SQL SELECT statements where the tables are being called to display or join tables however best show the which information is needed.

If this project was to be extended I would first add the choice to edit the users information, the ability send and receive messages, and for the user to add new friends.
