CREATE TABLE [dbo].[Vocabulary]
(
	[id] TEXT NOT NULL PRIMARY KEY, 
    [word] NTEXT NULL, 
    [type] TEXT NULL, 
    [bre] NTEXT NULL, 
    [bre_file] TEXT NULL, 
    [nae] NTEXT NULL, 
    [nae_file] TEXT NULL
)
