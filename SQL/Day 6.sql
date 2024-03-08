

----Day 6 Lab Assignments

--1
use [AdventureWorks2022]
create function betweenTwoValues (@x int, @y int)
returns int
as begin
	declare @result int = 0
	set @result = (@x+@y)/2
	return @result
end
print dbo.betweenTwoValues(10,20)

create function betweenTwoValues2(@x int, @y int)
returns @result table (bet int)
as begin
	while(@x<@y)
	begin
		insert into @result 
		values(@x)
		set @x = @x+1
	end
	return
end

select * from dbo.betweenTwoValues2(10,20)

--2

create function getEmployees()
returns table as return(
	select concat([FirstName],' ',[MiddleName],' ',[LastName]) as 'Full Name',
	ISNULL(CAST([Title] AS nvarchar(20)), 'Not provided') as 'Title',

	case [MaritalStatus]
		when 'M' then 'Maried'
		 when 'S' then 'Single'
	end as 'MaritalStatus', 
	case [Gender]
		when 'M' then 'Male'
		when 'F' then 'Female'
	end as 'Gender'
	from [Person].[Person] as Person join [HumanResources].[Employee] as Employee
	on Person.BusinessEntityID = Employee.BusinessEntityID
	
)

select * from dbo.getEmployees()

--3

create function getDataEmployees()
returns table as return(
	select concat([FirstName],' ',[MiddleName],' ',[LastName]) as 'Full Name',
	ISNULL(CAST([Title] AS nvarchar(20)), 'Not provided') as 'Title',
	datediff(year,[HireDate],getDate()) as 'experience years',
	format(DATEADD(year,21,[BirthDate]),'dd, MMMM yyyy') as 'graduation date'
	from [Person].[Person] as Person join [HumanResources].[Employee] as Employee
	on Person.BusinessEntityID = Employee.BusinessEntityID
	
)

select * from dbo.getDataEmployees()

--4

create function getSalaryAfterIncrease (@Salary int,@experience int)
returns int
as begin
	declare @result int = 0
	if (@experience > 7)
	begin
		set @experience = 7
	end
	set @result = @Salary+(@Salary*(@experience*0.1))
	return @result
end

print dbo.getSalaryAfterIncrease(1000,10)

--5
use [Company_SD]
create function getEmployeesForDepartment(@DepartmentNum int)
returns @result table ([Fullname] nvarchar(100), [Salary] int)
as begin
	if exists(select * from [Company].[Departments] where [Dnum] = @DepartmentNum)
	begin
		insert into @result 
		select top 10 concat([Fname],' ',[Lname]) as 'Full name', [Salary] 
		from [Company].[Employee] as Employee join [Company].[Departments] as Depart
		on Employee.Dno = Depart.Dnum
		where Depart.Dnum = @DepartmentNum
		order by [Salary] desc
	end
	return
end

select * from dbo.getEmployeesForDepartment(30)

--Bonus
--1
use [ITI]
create function getDataStudent(@StId int)
returns nvarchar(200)
as begin
	declare @Name nvarchar(50),@Address nvarchar(150),@Data nvarchar(200)

	select @Name = concat(SUBSTRING([St_Fname],1,1),'. ',SUBSTRING([St_Lname],1,1)+'. '),
	@Address = case [St_Address]
		when 'Cairo' then 'lives in great cairo'
		when 'Alex' then 'lives in lovely Alexandria'
		when 'Mansoura' then 'lives in El-Mansoura'
		when 'Assiut' then 'lives in Assiut'
		else 'lives in Non ITI city'
	end  
	from [dbo].[Student]
	where [St_Id] = @StId
	
	set @Data = concat(@Name,@Address)
	return @Data
end

select dbo.getDataStudent(2)

---2
use [Company_SD]
create function getDataDepartment()
returns @result table (DepartmentName nvarchar(50), countEmployee int,sumSalary int)
as begin
	
	insert into @result 
	select Depart.[Dname],count(Emp.[SSN]) as 'Count Employee',sum(Emp.[Salary]) as 'Sum Salary'
	from [Company].[Employee] as Emp join [Company].[Departments] as Depart
	on Emp.Dno = Depart.Dnum
	group by Depart.[Dname] 
	
	return
end

select * from dbo.getDataDepartment()