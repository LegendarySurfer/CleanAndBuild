﻿using DataAccess;
using System.Data;

namespace Domain
{
    public class UserModel
    {
        UserDao userDato = new UserDao(); // Estancia de los usuarios 

        //comprueba si hay bbdd existente
        public bool CompruebaBD()
        {
            return userDato.ComprobarBBDD();
        }

        public void CrearBD()
        {
            userDato.CrearBBDD();
        }

        // Comprobar usuario
        public bool LoginUser(string user, string pass)
        {
            return userDato.Login(user, pass);
        }

        public DataSet ObtenerAplicacionesEquipo(string nombreEquipo)
        {
            return userDato.ObtenerAplicaciones(nombreEquipo);
        }

        public DataSet ObtenerComandosEquipo(string nombreUsuario)
        {
            return userDato.ObtenerComandos(nombreUsuario);
        }

        public void CreateUser(string user, string contrasena)
        {
            userDato.CrearNuevoUsuario(user, contrasena);
        }

        public bool CompruebaUser(string user)
        {
            return userDato.CompruebaUsuario(user);
        }

        public bool CambiarContrasena(string user, string passs)
        {
            return userDato.CambiarContrasena(user, passs);
        }

        public bool CambiarNombre(string usuarioActual, string nuevoNombre)
        {
            return userDato.CambiarNombre(usuarioActual, nuevoNombre);
        }
    
        public void EliminarUsuario(string name)
        {
            userDato.ElimiarUsuario(name);
        }
    
        //comprobar equipo
        public bool CompruebaEquipo()
        {
            return userDato.CompEquipo();
        }
    
        public void AddEquipo()
        {
            userDato.AgregarEquipo();
        }
        
        public void AddEquipoEnRegistra(string nombreuser)
        {
            userDato.AgregarEquipoEnRegistra(nombreuser);
        }
  
        public void GuardarAplicacion(string name, string tipo)
        {
             userDato.GuardarAplication(name,tipo);

        }
    
        public void GuardarAplicacionEnIstalan()
        {
            userDato.GuardarEnInstalan();
        }

        public void GuardarComando(string nombreComando, string logica)
        {
            userDato.GuardarComando(nombreComando,logica);
        }

        public void GuardarEnHistorial(string nombreUsuario)
        {
            userDato.GuardarHistorial(nombreUsuario);
        }

        public DataSet ObtenerComandosCreados()
        {
            return userDato.DevolverComandosCreados();
        }
    
        public void AgregarComandoCreado(string nombre_comando, string logica)
        {
            userDato.GuardarComandoCreado(nombre_comando,logica);
        }
    }
}

