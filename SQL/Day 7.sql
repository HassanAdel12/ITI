
--Day 7 Lab
--1

use [ITI]
go
create or alter proc getcountStudentForDepartment @DeptID int
as begin
	if exists(select * from [dbo].[Department] where [Dept_Id] = @DeptID)
	begin
		select count(*) from [dbo].[Student] where [Dept_Id] = @DeptID
	end
	else 
	begin
		print 'Department ID dont exist'
	end
end
go
execute getcountStudentForDepartment 30

--2

use [Company_SD]
go
create or alter proc getEmployeeDataforProject @ProjectID int
as begin
	declare @countEmployee  int ,@ProjectName nvarchar(50)
	declare @Empssn table (Empssn int)
	if exists(select * from [Company].[Project] where [Pnumber] = @ProjectID)
	begin
		select @countEmployee = count([ESSn]) from [dbo].[Works_for] where [Pno] = @ProjectID
		insert into @Empssn
		select [ESSn] from [dbo].[Works_for] where [Pno] = @ProjectID
		select @ProjectName = [Pname] from [Company].[Project] where [Pnumber] = @ProjectID
		if (@countEmployee>3)
		begin
			print'The number of employees in the project '+@ProjectName+' is 3 or more'
		end
		else
		begin
			select 'The following employees work for the project '+@ProjectName
			select [Fname],[Lname] 
			from [Company].[Employee]  
			where [SSN] in (select * from @Empssn)
		end
	end
	else 
	begin
		print 'Department ID dont exist'
	end
end
go
execute getEmployeeDataforProject 300

--3
go
create or alter proc updateOldEmployeeforProject @oldEmployeeSSN int,@newEmployeeSSN int,@ProjectID int
as begin
	
	if exists(select * from [Company].[Project] where [Pnumber] = @ProjectID)and
		exists(select * from [Company].[Employee] where [SSN] = @oldEmployeeSSN)and
		exists(select * from [Company].[Employee] where [SSN] = @newEmployeeSSN)
	begin
		update [dbo].[Works_for]
		set [ESSn]=@newEmployeeSSN
		where [ESSn] = @oldEmployeeSSN and [Pno] = @ProjectID
	end
	else 
	begin
		print 'Data dont exist'
	end
end
go
execute updateOldEmployeeforProject 102672,968574,200

--4
go
create or alter trigger InsertIntoEmployee 
on [Company].[Employee]
instead of Insert
as begin
	declare @monthNum  int
	select @monthNum = month([Bdate]) from inserted
	if(@monthNum != 3 )
	begin
		insert into [Company].[Employee]
		select * from inserted
	end
	else 
	begin
		print 'date of birth is in March'
	end
end

insert into [Company].[Employee] 
values('omer', 'ahmed',663212,'1973-07-18 00:00:00.000','10 sahog','M',1000,null,null)

--5
go
use [ITI]
go
create or alter trigger InsertIntoDepartment
on [dbo].[Department]
instead of Insert
as begin
	print 'you cant insert a new record in Department table'
end

insert into [dbo].[Department] 
values(80, 'SQL','Database','sahog',null,null)

--6
create table StudentAudit 
(
	UserName varchar(200),
	[DateTime] date,
	Note varchar(500)
)
go
create or alter trigger InsertIntoStudent
on [dbo].[Student]
after Insert
as begin
	declare @StudentID  int
	select @StudentID = [St_Id] from inserted
	insert into StudentAudit 
	values(SUSER_NAME(),GETDATE(),concat(SUSER_NAME(),' Insert New Row with ID= ',@StudentID,' in table Student'))
end
insert into [dbo].[Student] 
values(17, 'ahmed','omer','sahog',29,null,null)

select * from StudentAudit

--7
go
create or alter trigger deleteStudent
on [dbo].[Student]
after Delete
as begin
	declare @StudentID  int
	select @StudentID = [St_Id] from deleted
	delete from [dbo].[StudentAudit]
	where [Note] = concat(SUSER_NAME(),' Insert New Row with ID= ',@StudentID,' in table Student')
end
delete from [dbo].[Student]
where [St_Id] = 16

select * from StudentAudit

--9
go
create or alter proc insertInStudent @id int,@StFname nvarchar(50),@StLname nvarchar(10), @Address nvarchar(100)
as begin	
	begin try
		insert into [dbo].[Student] values(@id,@StFname,@StLname,@Address,null,null,null)
	end try

	begin catch
		RAISERROR ('cant insert the same Student ID' ,10,1)
	end catch
end
go
execute insertInStudent 21,'hassan','adel','Minia'





