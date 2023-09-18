//Guillermo 

using System.Collections;
using System.Collections.Generic;
using Library;

public class Wizard
{
    private string name;
    public double Lives{ get; private set;}
    private SpellBook spellBook; 
    public List<Mace> Items{ get; private set; } 




    // Es imposible dejar esto funcionando por ahora porque no puedo obtener el item.AttackValue 
    //de objetos de una lista genérica

    // public int GetTotalAttack()
    // {
    //     int attack = 0;
    //     foreach (var item in items)
    //     {
    //         attack += item.AttackValue;
    //     }
    //     return attack;
    // }

    // public int GetTotalDefense()
    // {
    //     int defense = 0;
    //     foreach (var item in items)
    //     {
    //         defense += item.DefenseValue;
    //     }
    //     return defense;
    // }

// Esto no funciona todavia porque faltan algunas clases

    // public void AttackDwarf(Dwarf dwarf) 
    // {
    //     dwarf.TakeDamage(GetTotalAttack());
    // }

    // public void AttackWizard(Wizard wizard)
    // {
    //     wizard.TakeDamage(GetTotalAttack());
    // }

    // public void AttackElf(Elf elf)
    // {
    //     elf.TakeDamage(GetTotalAttack());
    // }


    // Esto es muy poco útil porque tendria que crear uno por cada objeto
    public void AddMaceToItems(Mace mace)
    {
        Items.Add(mace);
    }

    public void TakeDamage(double amount) 
    {
        // Se puede checkear que el amount sea un valor valido
        this.Lives -= amount;
        // Acá se puede checkear que si la vida es menor o igual a cero, muere
    }


    public double GetKnowledgeLevel()
    {
        return spellBook.SpellAmount;
    }

    public void SetHeal()
    {
        this.Lives = 100;
    }
    

}