using System.Collections.Generic;
using Library;
using NUnit.Framework;

[TestFixture]
public class ExampleTest
{
    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void GetTotalAttackCorrecto()
    {
        Item espada = new(20, 0);
        Item espada2 = new(50, 0);
        Item armadura = new(0, 10);

        List<Item> items = new List<Item>{espada, espada2, armadura};
        Elf elfo = new("elfo", items);

        double resultado = elfo.GetTotalAttack();
        double esperado = espada.AttackValue + espada2.AttackValue;
        Assert.True(resultado == esperado);
    }

    [Test]
    public void GetTotalDefenseCorrecto()
    {
        Item espada = new(20, 0);
        Item armadura0 = new(0, 30);
        Item armadura = new(0, 10);

        List<Item> items = new List<Item>{espada, armadura0, armadura};
        Elf elfo = new("elfo", items);

        double resultado = elfo.GetTotalDefense();
        double esperado = armadura0.DefenseValue + armadura.DefenseValue;
        Assert.True(resultado == esperado);
    }
}