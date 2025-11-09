namespace PlanAprendizaje
{
    public static class validaciones
    {
        public static void VerificarEdad(int edad)
        {
            if (edad < 18)
                throw new ArgumentException("No tiene la edad para crear un usuario");
        }


        public static void VerificarContraseña()
        {
            int intentos = 0;
            int maxIntentos = 3;
            bool accesoConcedido = false;

            while (intentos < maxIntentos)
            {
                Console.Write("Ingrese su contraseña: ");
                string entrada = Console.ReadLine();

                if (entrada == usuario.Contraseña)
                {
                    Console.WriteLine("✅ Acceso concedido.");
                    accesoConcedido = true;
                    break;
                }
                else
                {
                    intentos++;
                    Console.WriteLine($"❌ Contraseña incorrecta. Intento {intentos} de {maxIntentos}");
                }
            }
            if (!accesoConcedido)
            {
                Console.WriteLine(" Ha superado el número máximo de intentos. El sistema se bloquea.");

            }
        }
        public static void ValidarCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@") || !correo.Contains("."))
                throw new ArgumentException("El correo electrónico no tiene un formato válido");
        }
    }
}  