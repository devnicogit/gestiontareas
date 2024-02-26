CREATE DATABASE BD_TAREAS;

USE BD_TAREAS;

CREATE TABLE usuarios (
    id_usuario INT PRIMARY KEY IDENTITY(1,1),
    nombre_usuario NVARCHAR(50) NOT NULL,
    password_hash NVARCHAR(100) NOT NULL, -- Almacenar el hash de la contraseña
    CONSTRAINT uc_nombre_usuario UNIQUE (nombre_usuario)
);

CREATE TABLE tareas (
    id_tarea INT PRIMARY KEY IDENTITY(1,1),
    id_usuario INT FOREIGN KEY REFERENCES usuarios(id_usuario) NOT NULL,
    titulo NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(MAX),
    fecha_vencimiento DATE,
    estado NVARCHAR(20) CHECK (estado IN ('Pendiente', 'En Progreso', 'Completado')) NOT NULL,
    CONSTRAINT fk_id_usuario FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
);



