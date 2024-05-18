import sqlite3
import hashlib

def encriptar_contrasena(contrasena):
    """Función para encriptar una contraseña utilizando SHA-256."""
    return hashlib.sha256(contrasena.encode()).hexdigest()

# Conexión a la base de datos
conexion = sqlite3.connect('cleandbuild.db')
cursor = conexion.cursor()

# Insertar un usuario con contraseña encriptada
nombre_usuario = 'usuario1'
contrasena_usuario = 'password123'
contrasena_encriptada = encriptar_contrasena(contrasena_usuario)
cursor.execute("INSERT INTO usuarios (nombre, contrasena) VALUES (?, ?)",
               (nombre_usuario, contrasena_encriptada))

# Guardar cambios y cerrar la conexión
conexion.commit()
conexion.close()
