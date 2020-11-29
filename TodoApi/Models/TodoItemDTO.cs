using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    // Es un subconjunto del modelo TodoItme.
    // Una de las razones es la seguridad.
    // DTO Objeto transferencia de datos, modelo de entrada o modelo de salida.
    // Se utiliza para evitar el exceso de publicación.
    // Ocultar propiedads que los clientes no deben ver.
    // Omitir algunas propiedades para reducir el tamaño de la carga.
    // Acoplar los gráficos de objetos que contienen objetos anidados.
    // Los gráficos de objeto acoplados pueden ser más comdos para los clientes.

    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
