CREATE TABLE [dbo].[Account] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Name]  VARCHAR (50) NULL,
    [Email] VARCHAR (50) NULL,
    [Pass]  VARCHAR (50) NULL,
    [uType] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Skill] (
    [Id]    INT  IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [Name]  VARCHAR (50) NULL,
    [Desscription] VARCHAR (MAX) NULL    
);

CREATE TABLE [dbo].[Author]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [DOB] DATE NULL
);

CREATE TABLE [dbo].[AuthorSkill] (
	[Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [authorId]    INT ,
    [skillId]  INT ,    
	CONSTRAINT [FK_Work_ASkill1] FOREIGN KEY ([authorId]) REFERENCES [Author]([Id]),
	CONSTRAINT [FK_Work_ASkill2] FOREIGN KEY ([skillId]) REFERENCES [Skill]([Id])
);

CREATE TABLE [dbo].[Conference] (
    [Id]    INT  IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [Title]  VARCHAR (50) NULL,
    [StartDate] Date NULL    
);

CREATE TABLE [dbo].[ResearchWork]
(
    [Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Doc] VARCHAR(50) NULL, 
    [uDate] DATE NULL, 
    [dType] VARCHAR(50) NULL, 
    [aId] INT NULL, 
    CONSTRAINT [FK_Work_ToTable] FOREIGN KEY ([aId]) REFERENCES [Author]([Id])
);

CREATE TABLE [dbo].[DocumentTag] (
    [docId]    INT NOT NULL PRIMARY KEY,
    [skillId]  INT NOT NULL,    
	CONSTRAINT [FK_Work_docskill1] FOREIGN KEY ([docId]) REFERENCES [ResearchWork]([Id]),
	CONSTRAINT [FK_Work_docskill2] FOREIGN KEY ([skillId]) REFERENCES [Skill]([Id])
);


CREATE TABLE [dbo].[Reviewer]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [DOB] DATE NULL
);

CREATE TABLE [dbo].[ReviewerSkill] (
    [Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [reviewerId]    INT NOT NULL,
    [skillId]  INT NOT NULL,    
	CONSTRAINT [FK_Work_revsill1] FOREIGN KEY (reviewerId) REFERENCES [Reviewer]([Id]),
	CONSTRAINT [FK_Work_revsill2] FOREIGN KEY ([skillId]) REFERENCES [Skill]([Id])
);

CREATE TABLE [dbo].[PeerReview]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [DOR] DATE NULL,
	[reviewerId]    INT NULL,
	[docId]    INT NULL,
	CONSTRAINT [FK_Work_reerRev1] FOREIGN KEY ([reviewerId]) REFERENCES [Reviewer]([Id]),
	CONSTRAINT [FK_Work_reerRev2] FOREIGN KEY ([docId]) REFERENCES [ResearchWork]([Id]),
    
);

CREATE TABLE [dbo].[Comment] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
	[peerRevId] INT , 
    [Remark] VARCHAR (MAX) NULL,
    [cDate]  DATE          NULL,
    [skillId] INT , 
	PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Comment1_ToTable] FOREIGN KEY ([peerRevId]) REFERENCES [dbo].[PeerReview] ([Id]),
    CONSTRAINT [FK_Comment2_ToTable] FOREIGN KEY ([skillId]) REFERENCES [dbo].[skill] ([Id])
);

CREATE TABLE [dbo].[Rating] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL PRIMARY KEY,
	[RatingValue] DECIMAL NULL,
	[commentId] INT , 
	[authorDocId] INT,
    CONSTRAINT [FK_Rating1_ToTable] FOREIGN KEY ([commentId]) REFERENCES [dbo].[Comment] ([Id]),
    CONSTRAINT [FK_Rating2_ToTable] FOREIGN KEY ([authorDocId]) REFERENCES [dbo].[ResearchWork] ([Id])
);



