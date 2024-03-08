
use [AdventureWorks2022]

select * from [HumanResources].[Employee]

select [NationalIDNumber],[LoginID],[JobTitle] from [HumanResources].[Employee]


select [Title],[FirstName],[LastName] from [Person].[Person]
where [Title]='Ms.' and [LastName]='Antrim'


select [SalesOrderID],[ShipDate] from [Sales].[SalesOrderHeader]
where [OrderDate] BETWEEN '2011-07-01 00:00:00.000' AND '2011-07-31 00:00:00.000';

select [ProductID],[Name] from [Production].[Product]
where [StandardCost]<110 ;



SELECT product.Name,Subcategory.Name,Category.Name
FROM [Production].[Product] as product join[Production].[ProductSubcategory] as Subcategory
on Subcategory.ProductSubcategoryID=product.ProductSubcategoryID
join [Production].[ProductCategory] as Category 
on Category.ProductCategoryID=Subcategory.ProductCategoryID



select [Name] from [Production].[Product]
where [Name] like 'B%' ;


SELECT [Production].[ProductSubcategory].[Name] FROM [Production].[ProductSubcategory]
INNER JOIN [Production].[Product] ON [Production].[Product].[ProductSubcategoryID]=[Production].[ProductSubcategory].[ProductSubcategoryID]
where [Production].[Product].[Name] in(select [Production].[Product].[Name]from[Production].[Product] where[Name]like 'B%') 





select sum([TotalDue]) from [Sales].[SalesOrderHeader]
where [OrderDate] BETWEEN '2011-07-01 00:00:00.000' AND '2011-07-31 00:00:00.000';







SELECT AVG([ListPrice]) as 'List Price',Category.Name
FROM [Production].[Product] as product join[Production].[ProductSubcategory] as Subcategory
on Subcategory.ProductSubcategoryID=product.ProductSubcategoryID
join [Production].[ProductCategory] as Category 
on Category.ProductCategoryID=Subcategory.ProductCategoryID
Group by Category.Name
having AVG([ListPrice])>1000 



SELECT 'The '+[Name]+' is only! '+cast([ListPrice] as char) 
FROM [Production].[Product]
where [ListPrice] between 100.3400 and 120.3400
order by [ListPrice] desc



--bonus
--1

SELECT COLUMN_NAME, DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Product'

--2

SELECT VendorID, [250] AS Emp1, [251] AS Emp2, [256] AS Emp3, [257] AS Emp4, [260] AS Emp5  
FROM   
(SELECT PurchaseOrderID, EmployeeID, VendorID  
FROM Purchasing.PurchaseOrderHeader) p  
PIVOT  
(  
COUNT (PurchaseOrderID)  
FOR EmployeeID IN  
( [250], [251], [256], [257], [260] )  
) AS pvt  
ORDER BY pvt.VendorID;  

--3
select * from [HumanResources].[Employee]

--7
use [AdventureWorks2022]
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select [Description]
from [Production].[ProductDescription]
where [Description] like '%[_]%'

--8

SELECT [rowguid],[Name],[SalesPersonID],[Demographics]
FROM [Sales].[Store]







--Rules, Defaults, Seq
--1

use [Company_SD]


create schema HR
go
alter schema HR
transfer [dbo].[Employee]


--2

create type CityUDD from Nvarchar(10)

--3

create type Tel from Nvarchar(11) not null

--4
go
CREATE DEFAULT d AS 'Not Applied'
go
--5

CREATE RULE r  
AS   
@Column IN ('Assiut', 'Mansoura', 'Cairo','Alex','Ismalia')
go
--6

sp_bindefault d, CityUDD;
go
sp_bindrule  r,CityUDD;
go
--7

create table Student
(
	id int not null primary key,
	name varchar(20) not null,
	city [dbo].[CityUDD] 
	
)

--8
insert into [dbo].[Student]
values (1,'hassan','Cairo') 

insert into [dbo].[Student]
values (2,'hussein',null) 

insert into [dbo].[Student]
values (3,'ahmed','sohag') 

insert into [dbo].[Student]
values (4,'adel','Alex') 

delete [dbo].[Student] 
Where [id]=2

CREATE SEQUENCE SEQ
START WITH 5  
INCREMENT BY 1  

insert into [dbo].[Student]
values (next value for[dbo].[SEQ],'ahmed',null) 

insert into [dbo].[Student]
values (next value for[dbo].[SEQ],'adel','Alex') 

insert into [dbo].[Student]
values (7,'adel','Alex') 

alter SEQUENCE [dbo].[SEQ] 
RESTART WITH 8

Update [dbo].[Student] 
set [id] = 3
Where [id] = 5

insert into [HR].[Students]
values (next value for[dbo].[SEQ],252,'hassan',25,'0121010202','Alex') 

--9

create synonym [HR] for [HR].[Employee]



--b1

create table [HR].Students
(
	id int not null primary key,
	ssn int not null,
	name Nvarchar(20) DEFAULT 'hassan',
	age int ,
	TelNo [dbo].[Tel] DEFAULT '01111111111',
	City  [dbo].[CityUDD] DEFAULT 'Not Applied'
	
)



----View 
--1
use [ITI]

create view task1 as
select [St_Fname]+' '+[St_Lname] as 'full name', [dbo].[Course].[Crs_Name]
from [dbo].[Student] inner join [dbo].[Stud_Course]
on [dbo].[Stud_Course].St_Id = [dbo].[Student].St_Id
inner join [dbo].[Course]
on [dbo].[Stud_Course].Crs_Id = [dbo].[Course].Crs_Id
where [dbo].[Stud_Course].Grade > 50
go

select * from task1

---2

create view task2 as
select distinct [Ins_Name] as 'Manager name', [Top_Name]
from [dbo].[Instructor] as Ins inner join [dbo].[Department] as Dep
on Ins.Ins_Id = Dep.Dept_Manager
inner join [dbo].[Ins_Course] as Ins_Co
on Ins_Co.Ins_Id = Ins.Ins_Id
inner join [dbo].[Course] as Co
on Co.Crs_Id = Ins_Co.Crs_Id
inner join [dbo].[Topic] as Topic
on Co.Top_Id = Topic.Top_Id
go

select * from task2

--3

create view task3 as
select [Ins_Name] as 'Instructor name', [Dept_Name] as 'Department name'
from [dbo].[Instructor] as Ins inner join [dbo].[Department] as Dep
on Ins.Dept_Id = Dep.Dept_Id
where Dep.Dept_Name in ('SD','Java')
go

select * from task3

--4

create view V1 as
select * from [dbo].[Student]
where [St_Address] in ('Alex','Cairo')


Update V1 
set [St_Address]='Tanta'
Where [St_Address]='Alex'

select * from V1

--5

Use [Company_SD]

create view task5 as
select Proj.[Pname] as 'Project name', count(Works_for.ESSn) as 'number of employees'
from [Company].[Project] as Proj inner join [dbo].[Works_for] as Works_for
on Proj.Pnumber = Works_for.Pno
group by Proj.[Pname]
go

select * from task5


--6

create schema Company 
go
alter schema Company
transfer [dbo].[Departments]
alter schema Company
transfer [dbo].[Project]


create schema Human_Resource
go
alter schema Company
transfer [HR].[Employee]


--7

CREATE INDEX MGRStart
ON [Company].[Departments] ([MGRStart Date])

use [ITI]

CREATE INDEX Hiredate
ON [dbo].[Department] ([Manager_hiredate])

--8

CREATE UNIQUE INDEX ages
ON [dbo].[Student] ([St_Age] DESC)

CREATE UNIQUE INDEX id2
ON [dbo].[Student] ([St_Id])

--9

create table #Employee
(
	EmpName nvarchar(20),
	[Bdate] date,
	[Salary] int
)

insert into #Employee
select [Fname],[Bdate],[Salary] from [Company].[Employee] 

select * from #Employee


--10
use [Company_SD]
go

DECLARE @Salary  int , @SSN int
DECLARE cursor_Employee CURSOR
FOR SELECT [Salary],[SSN] FROM [Company].[Employee]
OPEN cursor_Employee
FETCH NEXT FROM cursor_Employee INTO @Salary ,@SSN
WHILE @@FETCH_STATUS = 0
    BEGIN
        update[Company].[Employee]
		set [Salary]=@Salary+(@Salary*0.1)
		where @Salary<3000 and [SSN]=@SSN
		update[Company].[Employee]
		set [Salary]=@Salary+(@Salary*0.2)
		where @Salary>=3000 and [SSN]=@SSN
        FETCH NEXT FROM cursor_Employee INTO @Salary ,@SSN
    END;
SELECT CONCAT([Fname],'  ',[Lname]) as 'Employee name',[Salary] FROM [Company].[Employee]
CLOSE cursor_Employee
DEALLOCATE cursor_Employee


--11
use [ITI]
go
DECLARE @Dept_Name NVARCHAR(50),@Dept_Manager NVARCHAR(50)
DECLARE cursor_Department CURSOR
FOR SELECT [Dept_Name],[Ins_Name] 
FROM [dbo].[Department] left join [dbo].[Instructor]
on [Dept_Manager]=[Ins_Id]
OPEN cursor_Department;
FETCH NEXT FROM cursor_Department INTO @Dept_Name,@Dept_Manager
WHILE @@FETCH_STATUS = 0
    BEGIN
        SELECT @Dept_Name as 'Department Name', @Dept_Manager as 'Manager Name'
        FETCH NEXT FROM cursor_Department INTO @Dept_Name,@Dept_Manager
    END;
CLOSE cursor_Department
DEALLOCATE cursor_Department

--13
use [ITI]
go
DECLARE @ST_Name NVARCHAR(50),@ST_Names NVARCHAR(450)
DECLARE cursor_Student CURSOR
FOR SELECT [St_Fname] FROM [dbo].[Student] 
OPEN cursor_Student;
FETCH NEXT FROM cursor_Student INTO @ST_Name
WHILE @@FETCH_STATUS = 0
    BEGIN
        set @ST_Names = CONCAT(@ST_Names ,ISNULL(@ST_Name+' , ',''))
        FETCH NEXT FROM cursor_Student INTO @ST_Name
    END;
select @ST_Names as 'Frist Name Students'
CLOSE cursor_Student
DEALLOCATE cursor_Student
















---Views
--1
use [Company_SD]
create view task1 as
select Emp.[Fname]+'  '+Emp.[Lname] as 'Employee name', Proj.[Pname] as 'Project name'
from [Company].[Employee] as Emp inner join [dbo].[Works_for] as Works
on Emp.[SSN] = Works.[ESSn]
inner join [Company].[Project] as Proj
on Proj.[Pnumber] = Works.Pno

select * from task1


---2

create view task2 as
select Proj.[Pname] as 'Project name', count(Works.ESSn) as 'number of employees'
from [Company].[Project] as Proj left JOIN [dbo].[Works_for] as Works
on Proj.Pnumber = Works.Pno
group by Proj.[Pname]
go

select * from task2


--insert into task2
--values ('project',4) 

--Update task2 
--set [Pname]='project 2'
--Where [Pname]='Al Rabwah'

--delete task2 
--Where [Pname]='Al Rabwah'






----DQL
--1
use [Company_SD]


select Dep.[Dependent_name],Dep.[Sex],Emp.Sex
from [dbo].[Dependent] as Dep JOIN [Company].[Employee] as Emp
on Dep.ESSN = Emp.SSN
where Dep.Sex = 'F' and Emp.Sex = 'F'
Union
select Dep.[Dependent_name],Dep.[Sex],Emp.Sex
from [dbo].[Dependent] as Dep JOIN [Company].[Employee] as Emp
on Dep.ESSN = Emp.SSN
where Dep.Sex = 'M' and Emp.Sex = 'M'

--2

select Proj.[Pname],sum(Works.[Hours])
from [Company].[Project] as Proj JOIN [dbo].[Works_for] as Works
on Proj.Pnumber = Works.Pno
group by Proj.[Pname]


--3

select top 1 Dep.[Dname],count(Emp.[SSN])
from [Company].[Departments] as Dep JOIN [Company].[Employee] as Emp
on Dep.[Dnum] = Emp.[Dno]
group by Dep.[Dname]
order by count(Emp.[SSN]) 


--4

select Dep.[Dname],max(Emp.Salary),min(Emp.Salary),avg(Emp.Salary)
from [Company].[Departments] as Dep JOIN [Company].[Employee] as Emp
on Dep.[Dnum] = Emp.[Dno]
group by Dep.[Dname]

--5

select Emp.Fname+'  '+Emp.Lname as 'manager name'
from [Company].[Departments] as Dep JOIN [Company].[Employee] as Emp
on Dep.MGRSSN = Emp.SSN
left JOIN [dbo].[Dependent] as Depend
on Emp.SSN = Depend.ESSN
group by Emp.Fname,Emp.Lname
having COUNT(Depend.Dependent_name)=0


--6

select Dep.Dnum,Dep.[Dname],count(Emp.SSN)
from [Company].[Departments] as Dep JOIN [Company].[Employee] as Emp
on Dep.[Dnum] = Emp.[Dno]
group by Dep.Dnum,Dep.[Dname]
having avg(Emp.Salary)< (select avg(Emp.Salary) from [Company].[Employee] as Emp)

--7

select Emp.Fname,Emp.Lname,Proj.Pname
from [Company].[Departments] as Dep JOIN [Company].[Employee] as Emp
on Dep.Dnum = Emp.Dno
JOIN [dbo].[Works_for] as Works
on Works.ESSn = Emp.SSN
JOIN [Company].[Project] as Proj
on Proj.Pnumber = Works.Pno
JOIN [Company].[Departments] as Depart
on Depart.Dnum = Proj.Dnum
order by Emp.Lname,Emp.Fname

--8

select top 2 [Fname],[Lname],[Salary]
from [Company].[Employee] as Emp
order by [Salary] desc

select [Fname],[Lname],[Salary]
from [Company].[Employee] as Emp
where [SSN] in (
select top 2 [SSN]
from [Company].[Employee] as Emp
order by [Salary] desc
)

--9

select Emp.Fname+' '+Emp.Lname ,Depend.[Dependent_name]
from [Company].[Employee] as Emp full JOIN [dbo].[Dependent] as Depend
on Emp.SSN = Depend.ESSN
where Emp.Fname+' '+Emp.Lname = Depend.[Dependent_name]


--10 

insert into [Company].[Departments]
values ('Department 100',100,968574,'2009-01-03 00:00:00.000')

Update [Company].[Employee] 
set [Dno] = 100
Where [SSN] = 968574

insert into [Company].[Employee]
values ('Hassan','Adel',102672,'1992-12-06 00:00:00.000','55 sahog','M',2000,968574,20)

Update [Company].[Departments] 
set [MGRSSN] = 102672
Where [Dnum] = 20

insert into [Company].[Employee]
values ('Kerem','Ahmed',102660,'1998-12-06 00:00:00.000','10 sahog','M',1000,102672,20)

---11

select Emp.Fname,Emp.Lname 
from [Company].[Employee] as Emp
where [SSN] = 223344
select Depend.Dependent_name 
from [dbo].[Dependent] as Depend
where [ESSN] = 223344

delete [dbo].[Dependent]
Where [ESSN] = 223344

select Depart.Dname 
from [Company].[Departments] as Depart
where [MGRSSN] = 223344

Update [Company].[Departments]
set [MGRSSN] = 102672
Where [MGRSSN] = 223344

select Emp.Fname,Emp.Lname 
from [Company].[Employee] as Emp
where [Superssn] = 223344

Update [Company].[Employee]
set [Superssn] = 102672
Where [Superssn] = 223344

select Works.Pno 
from [dbo].[Works_for] as Works
where [ESSn] = 223344

Update [dbo].[Works_for]
set [ESSn] = 102672
Where [ESSn] = 223344

delete [Company].[Employee]
Where [SSN] = 223344


--12

Update [Company].[Employee]
set [Salary] = [Salary]+(30*[Salary]/100)
Where [SSN] in (
select [ESSn]
from [dbo].[Works_for] as Works JOIN [Company].[Project] as Proj
on Proj.Pnumber = Works.Pno
where [Pname]='Al Rabwah'
)




