using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Proyecto
    {
        private DateTime fecha_inicio { set; get; }
        private DateTime fecha_fin { get; set; }
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha_Inicio
        {
            get
            {
                return fecha_inicio;
            }
            set
            {
                if (value.Date > DateTime.Now.Date)
                {
                    fecha_inicio = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        paramName: "Fecha_Inicio",
                        message: "La fecha debe ser posterior a la fecha actual");
                }
            }
        }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha_Fin
        {
            get
            {
                return fecha_fin;
            }
            set
            {
                if (value > fecha_inicio)
                {
                    fecha_fin = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        paramName: "Fecha_Fin",
                        message: "La fecha de finalización del proyecto debe ser mayor a la fecha de inicio del mismo");
                }
            }
        }
        private List<Tarea> Tareas { get; set; }

        public void AddTarea(Tarea tarea)
        {
            if (tarea.Fecha_Ejecucion > Fecha_Inicio && tarea.Fecha_Ejecucion < Fecha_Fin)
            {
                Tareas.Add(tarea);
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    paramName: "Fecha_Ejecucion",
                    message: "La fecha de ejecución de latarea no puede estra fuera del rango de fechas del proyecto");
            }
        }
        public IEnumerable<Tarea> GetTareas()
        {
            return Tareas
                .AsEnumerable();
        }
    }
}
