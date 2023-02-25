using TecNM.Practica3_0.Core.Entities;
using TecNM.Practica3_0.Core.Services;

namespace TecNM.Practica3_0.Tests;

public class IsrCalculatorService
{
    [Fact]
    public void ProcessIsr()
    {
        //arrange
        var expectedType = 107.52000427246094;
        var person = new Person { Salario = 5600 };
        var sut = new ISRService();

        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expectedType, result.TotalIsr);
    }
    
    [Fact]
    public void ProcessIsr1()
    {
        //arrange
        var expectedType = 517.4693603515625;
        var person = new Person { Salario = 13500 };
        var sut = new ISRService();

        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expectedType, result.TotalIsr);
    }
    
    [Fact]
    public void ProcessIsr2()
    {
        //arrange
        var expectedType =  613.4693603515625;
        var person = new Person { Salario = 15000 };
        var sut = new ISRService();

        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expectedType, result.TotalIsr);
    }
    
    [Fact]
    public void ProcessIsr3()
    {
        //arrange
        var expectedType = 680.79736328125;
        var person = new Person { Salario = 16052 };
        var sut = new ISRService();

        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expectedType, result.TotalIsr);
    }
    
    [Fact]
    public void ProcessIsr4()
    {
        //arrange
        var expectedType = 408.66937255859375;
        var person = new Person { Salario = 11800 };
        var sut = new ISRService();

        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expectedType, result.TotalIsr);
    }
    
    [Fact]
    public void ProcessIsr5()
    {
        //arrange
        var expectedType = 805.4694213867188;
        var person = new Person { Salario = 18000 };
        var sut = new ISRService();

        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expectedType, result.TotalIsr);
    }
    
    [Fact]
    public void ProcessIsr6()
    {
        //arrange
        var expectedType = 475.869384765625;
        var person = new Person { Salario = 12850 };
        var sut = new ISRService();

        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expectedType, result.TotalIsr);
    }
    
    [Fact]
    public void ProcessIsr7()
    {
        //arrange
        var expectedType = 1253.4693603515625;
        var person = new Person { Salario = 25000 };
        var sut = new ISRService();

        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expectedType, result.TotalIsr);
    }
    
    [Fact]
    public void ProcessIsr8()
    {
        //arrange
        var expectedType = 1311.0694580078125;
        var person = new Person { Salario = 25900 };
        var sut = new ISRService();

        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expectedType, result.TotalIsr);
    }
    
    [Fact]
    public void ProcessIsr9()
    {
        //arrange
        var expectedType = 1893.469482421875;
        var person = new Person { Salario = 35000 };
        var sut = new ISRService();

        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expectedType, result.TotalIsr);
    }
    
    [Fact]
    public void ProcessIsr10()
    {
        //arrange
        var expectedType = 1925.469482421875;
        var person = new Person { Salario = 35500 };
        var sut = new ISRService();

        //act
        var result = sut.ProcessIsr(person);

        //assert
        Assert.Equal(expectedType, result.TotalIsr);
    }
    
}