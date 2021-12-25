Đồ án môn học Lập trình trực quan lớp IT008.M11 học kì I năm học 2021-2022. Sử dụng ngôn ngữ lập trình C#.

Đề tài: Xây dựng từ điển có hình ảnh và âm thanh
Nội dung: Xây dựng một phần mềm hỗ trợ tra cứu tiếng anh một cách trực quan hóa.

Thành viên nhóm
1.Nguyễn Duy Hào
2.Tạ Hoàng Long
3.Trương Đức Thiện
4.Nguyễn Minh Duy
5.Ngô Hoàng Phúc
 
 
 Chức năng chính:
 +Tra cứu tiếng anh
 +Đọc từ đã tìm kiếm và xuất ra hình ảnh
 +1 số trò chơi
 
 Thư viện sử dụng:
 c#/.NET
 
 
 Cộng cụ 
 Visual Studio 2019

How to build the project using Microsoft Visual Studio:

- To Debug:
1. In FormQuiz.cs, FormHangman.cs, FormSW.cs, ReviewSelection.cs, DefinitionHeader.cs, DefinitionHeader.Designer.cs, DatabaseHandle.cs,
uncomment the codes with // debug path at the end of the line, comment the codes with // setup path at the end of the line.

2. Run Debug, if an SqlException of any kind occured:
+ 2.1. Remove the DictionaryDB.mdf and DictionaryDBDataSet1.xsd from the project.
+ 2.2. Add a new .mdf file: Right click on DictionaryApp -> Add new item -> Service-based Database
       Rename it as DictionaryDB.mdf
+ 2.3. In the Server Explorer window -> Data Connections -> DictionaryDB.mdf, right click on Tables -> Add new tables.
       The definition for each tables:

CREATE TABLE [dbo].[Examples] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [word]       NVARCHAR (MAX) NULL,
    [topic]      NVARCHAR (MAX) NULL,
    [sense_hash] NVARCHAR (MAX) NULL,
    [sentence]   NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[History] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [word_id]   NVARCHAR (MAX) NULL,
    [word]      NVARCHAR (MAX) NULL,
    [word_type] NVARCHAR (MAX) NULL,
    [time]      NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Idiom_Examples] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [idiom]    NVARCHAR (MAX) NULL,
    [type]     NVARCHAR (MAX) NULL,
    [word]     NVARCHAR (MAX) NULL,
    [sentence] NVARCHAR (MAX) NULL,
    [hash]     NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Idiom_Meanings] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [idiom]   NVARCHAR (MAX) NULL,
    [type1]   NVARCHAR (MAX) NULL,
    [word]    NVARCHAR (MAX) NULL,
    [level]   NVARCHAR (MAX) NULL,
    [type2]   NVARCHAR (MAX) NULL,
    [meaning] NVARCHAR (MAX) NULL,
    [hash]    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Idiom_Topic] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [idiom] NVARCHAR (MAX) NULL,
    [type]  NVARCHAR (MAX) NULL,
    [word]  NVARCHAR (MAX) NULL,
    [topic] NVARCHAR (MAX) NULL,
    [level] NVARCHAR (MAX) NULL,
    [hash]  NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Idioms] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [idiom]   NVARCHAR (MAX) NULL,
    [type]    NVARCHAR (MAX) NULL,
    [word_id] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Image_Word] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [image_link] NVARCHAR (MAX) NULL,
    [word]       NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Images] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [image] IMAGE          NULL,
    [link]  NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Quizzes] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [question] NVARCHAR (MAX) NULL,
    [topic]    NVARCHAR (MAX) NULL,
    [ans1]     NVARCHAR (MAX) NULL,
    [ans2]     NVARCHAR (MAX) NULL,
    [ans3]     NVARCHAR (MAX) NULL,
    [ans4]     NVARCHAR (MAX) NULL,
    [rans]     INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[SeeAlso] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [word_id]    NVARCHAR (MAX) NULL,
    [sense_hash] NVARCHAR (MAX) NULL,
    [word]       NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Senses] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [word_id] NVARCHAR (MAX) NULL,
    [topic]   NVARCHAR (MAX) NULL,
    [meaning] NVARCHAR (MAX) NULL,
    [level]   NVARCHAR (MAX) NULL,
    [type1]   NVARCHAR (MAX) NULL,
    [type2]   NVARCHAR (MAX) NULL,
    [hash]    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Shortcuts] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [word_id]  NVARCHAR (MAX) NULL,
    [shortcut] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Topics] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [topic]       NVARCHAR (MAX) NULL,
    [subtopic]    NVARCHAR (MAX) NULL,
    [subsubtopic] NVARCHAR (MAX) NULL,
    [level]       NVARCHAR (MAX) NULL,
    [word]        NVARCHAR (MAX) NULL,
    [word_id]     NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Vocabulary] (
    [id]       NVARCHAR (MAX) NOT NULL,
    [word]     NVARCHAR (MAX) NULL,
    [type]     NVARCHAR (MAX) NULL,
    [bre]      NVARCHAR (MAX) NULL,
    [bre_file] NVARCHAR (MAX) NULL,
    [nae]      NVARCHAR (MAX) NULL,
    [nae_file] NVARCHAR (MAX) NULL,
    [starred]  INT            DEFAULT ((0)) NULL
);

CREATE TABLE [dbo].[WordForms] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [word_id]  NVARCHAR (MAX) NULL,
    [tense]    NVARCHAR (MAX) NULL,
    [subjects] NVARCHAR (MAX) NULL,
    [form]     NVARCHAR (MAX) NULL,
    [bre]      NVARCHAR (MAX) NULL,
    [bre_file] NVARCHAR (MAX) NULL,
    [nae]      NVARCHAR (MAX) NULL,
    [nae_file] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

+ 2.4. In the Data Source window -> Add New Data Source
       Database -> Dataset -> Next -> Choose the Tables as the objects -> Finish
+ 2.5. Right click on the DictionaryDB.mdf in the Solution Explorer window, change the Properties -> Copy to Output Directory to Copy if newer.
+ 2.6. Run the Debug again, the project will now add the data, the process can be tracked in the Output window.
       This process might take some time, but will only occur once.

- To make the setup/installer file:
1. In FormQuiz.cs, FormHangman.cs, FormSW.cs, ReviewSelection.cs, DefinitionHeader.cs, DefinitionHeader.Designer.cs, DatabaseHandle.cs,
uncomment the codes with // setup path at the end of the line, comment the codes with // debug path at the end of the line.
2. Build YourDictionary
