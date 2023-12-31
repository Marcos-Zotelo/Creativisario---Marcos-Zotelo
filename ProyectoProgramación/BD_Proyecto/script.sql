USE [BD_proyecto]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 06/12/2023 17:37:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[usua_id] [int] IDENTITY(1,1) NOT NULL,
	[usua_user] [varchar](100) NOT NULL,
	[usua_nivel] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[usua_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (56, N'maria', 2)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (57, N'jeremias', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (58, N'jeremias', 2)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (59, N'jere', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (60, N'marcos', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (61, N'colo', 2)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (62, N'aramis', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (63, N'tomas', 2)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (64, N'cachi', 3)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (65, N'mateo', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (66, N'taiel', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (67, N'lolo', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (68, N'susto', 4)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (69, N'chiki', 2)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (70, N'lali', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (71, N'lolo', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (72, N'alexis', 2)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (73, N'pocholo', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (74, N'admin', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (75, N'adminn', 2)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (76, N'messi', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (77, N'carlos', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (78, N'aloha', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (79, N'elena', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (80, N'anorak', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (81, N'pablo', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (82, N'Marcos', 1)
INSERT [dbo].[usuarios] ([usua_id], [usua_user], [usua_nivel]) VALUES (83, N'PERSONAJE', 2)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
/****** Object:  StoredProcedure [dbo].[ObtenerIdUsuario]    Script Date: 06/12/2023 17:37:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ObtenerIdUsuario]
    @nombreUsuario NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserId INT

    SELECT @UserId = usua_id
    FROM Usuarios
    WHERE usua_user = @nombreUsuario

    SELECT @UserId AS 'IdUsuario'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarNivelUsuario]    Script Date: 06/12/2023 17:37:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarNivelUsuario]
    @id INT,
    @nuevo_nivel INT
AS
BEGIN
    UPDATE usuarios
    SET usua_nivel = @nuevo_nivel
    WHERE usua_id = @id;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarUsuario]    Script Date: 06/12/2023 17:37:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[sp_AgregarUsuario]
    @user VARCHAR(255),
    @nivel INT = 1 -- Valor predeterminado: 1
AS
BEGIN
    INSERT INTO usuarios (usua_user, usua_nivel)
    VALUES (@user, @nivel);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerNivelUsuario]    Script Date: 06/12/2023 17:37:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerNivelUsuario]
    @NombreUsuario NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT usua_nivel
    FROM usuarios
    WHERE usua_user = @NombreUsuario;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerNombreUsuario]    Script Date: 06/12/2023 17:37:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerNombreUsuario]
    @usuarioID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT usua_user
    FROM usuarios
    WHERE usua_id = @usuarioID;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidarUsuario]    Script Date: 06/12/2023 17:37:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_ValidarUsuario]
    @user NVARCHAR(100)
AS
BEGIN
    -- Declarar una variable para almacenar el ID de rol del usuario
    DECLARE @usua_id INT;

    -- Intentar encontrar un usuario con el nombre y contraseña proporcionados
    SELECT @usua_id = usua_id
    FROM usuarios
    WHERE usua_user = @user

    -- Comprobar si se encontró un usuario válido
    IF @usua_id IS NOT NULL
    BEGIN
        -- Retornar el ID de rol del usuario
        SELECT @usua_id AS usua_id;
    END
    ELSE
    BEGIN
        -- No se encontró un usuario válido, retornar 0
        SELECT 0 AS usua_id;
    END
END;
GO
