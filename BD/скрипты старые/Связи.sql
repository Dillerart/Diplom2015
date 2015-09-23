
ALTER TABLE [dbo].[Access_user]  WITH CHECK ADD  CONSTRAINT [FK_Access_user_Role] FOREIGN KEY([id_role])
REFERENCES [dbo].[Role] ([id_role])
GO

ALTER TABLE [dbo].[Access_user] CHECK CONSTRAINT [FK_Access_user_Role]
GO



ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Access_user] FOREIGN KEY([id_access])
REFERENCES [dbo].[Access_user] ([id_access])
GO

ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Access_user]
GO

ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Bonus] FOREIGN KEY([id_bonus])
REFERENCES [dbo].[Bonus] ([id_bonus])
ON UPDATE CASCADE
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Bonus]
GO



ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD  CONSTRAINT [FK_Expenses_Access_user] FOREIGN KEY([id_access])
REFERENCES [dbo].[Access_user] ([id_access])
GO

ALTER TABLE [dbo].[Expenses] CHECK CONSTRAINT [FK_Expenses_Access_user]
GO

ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD  CONSTRAINT [FK_Expenses_Client] FOREIGN KEY([id_client])
REFERENCES [dbo].[Client] ([id_client])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Expenses] CHECK CONSTRAINT [FK_Expenses_Client]
GO

ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD  CONSTRAINT [FK_Expenses_Service] FOREIGN KEY([id_service])
REFERENCES [dbo].[Service] ([id_service])
GO

ALTER TABLE [dbo].[Expenses] CHECK CONSTRAINT [FK_Expenses_Service]
GO


ALTER TABLE [dbo].[Flow]  WITH CHECK ADD  CONSTRAINT [FK_Flow_Access_user] FOREIGN KEY([id_access])
REFERENCES [dbo].[Access_user] ([id_access])
GO

ALTER TABLE [dbo].[Flow] CHECK CONSTRAINT [FK_Flow_Access_user]
GO

ALTER TABLE [dbo].[Flow]  WITH CHECK ADD  CONSTRAINT [FK_Flow_Client] FOREIGN KEY([id_client])
REFERENCES [dbo].[Client] ([id_client])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Flow] CHECK CONSTRAINT [FK_Flow_Client]
GO

ALTER TABLE [dbo].[Flow]  WITH CHECK ADD  CONSTRAINT [FK_Flow_Currency] FOREIGN KEY([id_currency])
REFERENCES [dbo].[Currency] ([id_currency])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Flow] CHECK CONSTRAINT [FK_Flow_Currency]
GO




ALTER TABLE [dbo].[Level_bns]  WITH CHECK ADD  CONSTRAINT [FK_Level_bns_Bonus] FOREIGN KEY([id_bonus])
REFERENCES [dbo].[Bonus] ([id_bonus])
GO

ALTER TABLE [dbo].[Level_bns] CHECK CONSTRAINT [FK_Level_bns_Bonus]
GO







