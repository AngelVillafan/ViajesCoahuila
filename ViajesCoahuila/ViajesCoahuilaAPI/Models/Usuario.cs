namespace ViajesCoahuilaAPI.Models
{
    /// <summary>
    /// Representa un usuario de nuestra aplicación, 
    /// puede tratarse de una persona que realiza
    /// un viaje o alguien que busca un viaje (sin verde)
    /// </summary>
    public class Usuario
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        /// <summary>
        /// Obtiene o establece la califación promedio
        /// que el usuario ha obtenido como un usuario 
        /// pasajero
        /// </summary>
        public float CalificacionPasajero { get; set; }
        /// <summary>
        /// Obtiene o establece la califación promedio
        /// que el usuario ha obtenido como un usuario 
        /// chofer
        /// </summary>
        public float CalificacionChofer { get; set; }
    }
}
