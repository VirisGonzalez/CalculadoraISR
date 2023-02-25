using TecNM.Practica3_0.Core.Entities;

namespace TecNM.Practica3_0.Core.Managers.Interfaces;

public interface IISRManager
{
    ISR GetIsr(Person person);
}