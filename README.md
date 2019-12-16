Requirements:  
    • All fields are required to fill   
    (tests #1 - #8)  
    • First/Last name fields are case insensitive  
    (test #1)  
    • Week password is < 6 characters  
    (Test #9)  
    • Normal password is > 6 < 10 characters and numbers  
    (Test #10)  
    • Strong password is > 10 characters, numbers and special characters  
    (Test #11)  
    • Phone field should use format: +380639992211  
    (Test #12, #13)  
    • Organization name are case insensitive  
    (test #1)  

Bugs:  
1)Registration is successful without fill the field Organization Name  
Steps:  
1.Fill field Email address ("test@gmail.com")   
2.Fill field First name ("Testing")  
3.Fill field Last name ("User")  
4.Fill field Password ("test")  
5.Fill field Confirm Password ("test")  
6.Fill field Phone ("+380639992211")  
7.Field Organization Name is empty  
8.Click Submit  
AR: Welcome Page is opened.   
ER: "Field cannot be empty" message for field Organization name should be displayed  
Test # 8  

2)Verification password as "normal" is failed   
Steps:  
1.Fill field Email address ("test@gmail.com")  
2.Fill field First name ("Testing")  
3.Fill field Last name ("User")  
4.Fill field Password ("test123")  
5.Field Confirm Password is empty  
6.Fill field Phone ("+380639992211")  
7.Fill field Organization name ("TestingUser")  
8.Click Submit  
AR:"Password strength: weak" message is displayed".   
ER:Should be "Password strength: normal"  
Test #10  

3)Verification  password as "strong" is failed   
Steps:  
1.Fill field Email address ("test@gmail.com")  
2.Fill field First name ("Testing")  
3.Fill field Last name ("User")  
4.Fill field Password ("test123!@#$")  
5.Field Confirm Password is empty  
6.Fill field Phone ("+380639992211")  
7.Fill field Organization name ("TestingUser")  
8.Click Submit  
AR:"Password strength: weak" message is displayed".   
ER: Should be "Password strength: strong"  
Test #11  

4) User can enter wrong formatphone nubmer  
Steps:  
1.Fill field Email address ("test@gmail.com")  
2.Fill field First name ("Testing")  
3.Fill field Last name ("User")  
4.Fill field Password ("test")  
5.Field Confirm Password is empty  
6.Fill field Phone ("+38(063)999-22-11")  
7.Fill field Organization name ("TestingUser")  
8.Click Submit  
AR:Welcome Page is opened.    
ER:Should be "Phone field should use format: +380639992211"  
Test #12   

5) User can enter spaces on fields  
Steps:  
1.Fill field Email address (" ")  
2.Fill field First name (" ")  
3.Fill field Last name (" ")hone field should use format: +380639992211  
4.Fill field Password (" ")  
5.Fill field Confirm Password (" ")  
6.Fill field Phone (" ") 
7.Fill field Organization name (" ")  
8.Click Submit  
AR:Welcome Page is opened.    
ER:Should be "Field cannot be empty" message for all fields  
Test #14  
 
6) Button "Sign up with G Suite Directory" does'not work  
Steps:  
1.Click "Sign up with G Suite Directory" button  
AR: Nothing happens  
ER: Google acount should be opened  
Test # 15  

6) Button "Sign up with Azure Directory" does'not work   
Steps:  
1.Click "Sign up with Azure Directory" button  
AR: Nothing happens  
ER: Azure acount should be opened  
Test # 16  

7)Function "Check your inbox!" does not work  
Steps:  
1.Fill field Email address ("test@gmail.com")  
2.Fill field First name ("Testing")  
3.Fill field Last name ("User")  
4.Fill field Password ("test")   
5.Fill field Confirm Password ("test")  
6.Fill field Phone ("+380639992211")  
7. Fill field Organization name ("TestingUser")  
8.Click Submit  
AR: Welcome Page is opened.   
9. Click "Check your inbox!" form  
AR: Nothing happens  
ER: Email box should be opened  
Test # 17  
