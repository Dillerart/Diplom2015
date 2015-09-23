INSERT INTO [dbo].[Role]
           ([id_role]
           ,[Name_R])
     VALUES
                   ('1', 'Кассир'),
		   ('2', 'Бухгалтер'),
		   ('3', 'Администратор БД')


INSERT INTO [dbo].[Access_user]
           ([id_role]
           ,[Login]
           ,[Pass]
           ,[NameInfoUser]
           ,[Info_dop]
	   ,[_delete])
     VALUES
           ('3', 'Admin', 'Admin', 'Admin', 'Admin', 'False')





