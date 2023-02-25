using TecNM.Practica3_0.Core.Entities;
using TecNM.Practica3_0.Core.Managers.Interfaces;
using TecNM.Practica3_0.Core.Services.Interfaces;

namespace TecNM.Practica3_0.Core.Managers;

public class ISRManager : IISRManager
{
    private readonly IISRService _service;

    public ISRManager(IISRService service)
    {
        _service = service;
    }

    public ISR GetIsr(Person person)
    {
        return _service.ProcessIsr(person);
    }
}