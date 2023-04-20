CREATE TABLE F_FLOWER
(
    ID                  INT           IDENTITY(1,1)       NOT NULL,
    SPECIES             NVARCHAR(100)                     NOT NULL,
    PREVAILING_COLOR    VARCHAR(40)                       NOT NULL,

    CONSTRAINT  PK_F_FLOWER    PRIMARY KEY ( ID )
);
