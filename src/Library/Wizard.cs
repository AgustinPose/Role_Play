//Guillermo 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Library;

public class Wizard
{
    private SpellBook spellBook; 
    public double Lives { get; private set; }
    public string Name { get; private set;}
    public List<Item> Items { get; private set; }

    public Wizard (string name, List<Item> items, SpellBook spellBook)
    {
        this.Name = name;
        this.Items = items;
        this.Lives = 100;
        this.spellBook = spellBook;
    }
        


    // Es imposible dejar esto funcionando por ahora porque no puedo obtener el item.AttackValue 
    //de objetos de una lista genérica

    public double GetTotalAttack()
    {
        double attack = 0;
        foreach (var item in Items)
        {
            attack += item.AttackValue;
        }
        return attack;
    }

    public double GetTotalDefense()
    {
        double defense = 0;
        foreach (var item in Items)
        {
            defense += item.DefenseValue;
        }
        return defense;
    }

// Esto no funciona todavia porque faltan algunas clases

    public void AttackDwarf(Dwarf dwarf) 
    {
        dwarf.TakeDamage(GetTotalAttack());
    }

    public void AttackWizard(Wizard wizard)
    {
        wizard.TakeDamage(GetTotalAttack());
    }

    public void AttackElf(Elf elf)
    {
        elf.TakeDamage(GetTotalAttack());
    }

    public void TakeDamage(double amount) 
    {
        // Si el valor no es valido, me voy
        if (amount <= 0)
            return;

        this.Lives -= amount;
        CheckDeath();
    }

    public void CheckDeath()
    {
        if (this.Lives <= 0)
        {
            //Muere
            Console.WriteLine($"{this.Name} ha muerto");
        }
    }

    public void Heal()
    {
        this.Lives = 100;
    }
    
    public double GetKnowledgeLevel() // ----- EXCLUSIVO DE WIZARD
    {
        return spellBook.SpellAmount;
    }

}