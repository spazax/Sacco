;#DropDB SaccoEasyTest

#Application Sacco.Win
#Application Sacco.Web

*FillForm
 User Name = Admin
*Action Log On

#IfDef Sacco.Win

*Action About...
 
*Action OK

#EndIf

#IfDef Sacco.Web
*Action Navigation(My Details)
#EndIf
