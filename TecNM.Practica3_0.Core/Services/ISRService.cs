using TecNM.Practica3_0.Core.Entities;
using TecNM.Practica3_0.Core.Services.Interfaces;

namespace TecNM.Practica3_0.Core.Services;

public class ISRService : IISRService
{
    public ISR ProcessIsr(Person person){
        
    var isr = new ISR();
        
        if (person.Salario > 0 && person.Salario <= 7735.00)
    {
        isr.TotalIsr = person.Salario * 0.0192f;
    }
    else if (person.Salario > 7735.01 && person.Salario <= 65651.07)
    {
        isr.TotalIsr = (float)(148.51 + (person.Salario - 7735.01) * 0.064f);
    }
    else if (person.Salario > 65651.08 && person.Salario <= 115375.90)
    {
        isr.TotalIsr = (float)(3855.14 + (person.Salario - 65651.08) * 0.1088f);
    }
    else if (person.Salario > 115375.91 && person.Salario <= 134119.41)
    {
        isr.TotalIsr = (float)(9265.20 + (person.Salario - 115375.91) * 0.16f);
    }
    else if (person.Salario > 134119.42 && person.Salario <= 160577.65)
    { 
        isr.TotalIsr = (float)(12264.16 + (person.Salario - 134119.42) * 0.1792f);
    }
    else if (person.Salario > 160577.66 && person.Salario <= 323862.00)
    {
        isr.TotalIsr = (float)(17005.47 + (person.Salario - 160577.66) * 0.2136f);
    }
    else if (person.Salario > 323862.01 && person.Salario <= 510451.00)
    {
        isr.TotalIsr = (float)(51883.01 + (person.Salario - 323862.01) * 0.2352f);
    }
    else if (person.Salario > 510451.01 && person.Salario <= 974535.03)
    {
        isr.TotalIsr = (float)(95768.74 + (person.Salario - 510451.01) * 0.3000f);
    }
    else if (person.Salario > 974535.04 && person.Salario <= 1299380.04)
    {
        isr.TotalIsr = (float)(234993.95 + (person.Salario - 974535.04) * 0.3200f);
    }
    else if (person.Salario > 1299380.05 && person.Salario <= 3898140.12)
    {
        isr.TotalIsr = (float)(338944.34 + (person.Salario - 1299380.05) * 0.3400f);
    }
    else if (person.Salario > 3898140.13)
    {
        isr.TotalIsr = (float)(1222522.76 + (person.Salario - 3898140.13) * 0.3500f);
    }
    return isr;
    }
}