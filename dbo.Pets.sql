CREATE TABLE [dbo].[Pets] (
    [PetID]     INT             IDENTITY (1, 1) NOT NULL,
    [PetName]   NVARCHAR (100)  NOT NULL,
    [Mood]      NVARCHAR (50)   NOT NULL,
    [MoodImage] VARBINARY (MAX) NULL,
    [Action]    NVARCHAR (50)   NOT NULL,
    [ToyImage]  VARBINARY (MAX) NULL,
    PRIMARY KEY CLUSTERED ([PetID] ASC)
);

