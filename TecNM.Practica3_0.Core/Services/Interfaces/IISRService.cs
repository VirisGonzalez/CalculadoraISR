using TecNM.Practica3_0.Core.Entities;

namespace TecNM.Practica3_0.Core.Services.Interfaces;

public interface IISRService
{
    ISR ProcessIsr(Person person);
}