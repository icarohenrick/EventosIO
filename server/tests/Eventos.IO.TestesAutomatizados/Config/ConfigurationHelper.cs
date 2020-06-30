using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.TestesAutomatizados.Config
{
    public class ConfigurationHelper
    {
        public static string SiteUrl => "http://localhost:2020/home";
        public static string RegisterUrl => "http://localhost:2020/usuarios/inscricao";
        public static string LoginUrl => "http://localhost:2020/usuarios/entrar";

        public static string ChromeDrive => "C:\\Users\\mazza\\Documents\\Estudos\\AspNetCore\\projetos\\Eventos.IO\\tests\\Eventos.IO.TestesAutomatizados\\bin\\Debug\\netcoreapp2.2";

        public static string TestUserName => "ihtech@hotmail.com";
        public static string TestPassword => "Teste@123";

        public static string FolderPath => "C:\\Users\\mazza\\Documents\\Estudos\\AspNetCore\\projetos\\Eventos.IO\\tests\\Eventos.IO.TestesAutomatizados";
        public static string FolderPicture => $"{FolderPath}\\ScreenShots\\";
    }
}
