IF DB_ID('AccesoDatos') IS NULL
    CREATE DATABASE AccesoDatos;
GO
USE AccesoDatos;
GO

IF OBJECT_ID('Productos') IS NULL
BEGIN
    CREATE TABLE Productos (
        Id        INT IDENTITY(1,1) PRIMARY KEY,
        Nombre    NVARCHAR(100) NOT NULL,
        Precio    DECIMAL(10,2) NOT NULL CHECK (Precio >= 0),
        Stock     INT NOT NULL DEFAULT 0,
        FechaAlta DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
        Activo    BIT NOT NULL DEFAULT 1
    );

    INSERT INTO Productos (Nombre, Precio, Stock) VALUES
        (N'Teclado', 29.90, 10),
        (N'Ratón',   15.50, 25),
        (N'Monitor', 149.00, 5);
END;
GO