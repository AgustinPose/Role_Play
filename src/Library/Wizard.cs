using System.Collections;

public class Wizard
{
    private string name;
    private int lives;
    private SpellBook spellBook; 
    private ArrayList items;


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
        items.Add(mace);
    }

    public void TakeDamage(int amount) 
    {
        // Se puede checkear que el amount sea un valor valido
        lives -= amount;
        // Acá se puede checkear que si la vida es menor o igual a cero, muere
    }

    public void Heal(int amount) 
    {
        // Se puede checkear que el amount sea un valor valido
        lives += amount;
    }

    public int GetKnowledgeLevel()
    {
        return spellBook.spellAmount;
    }

    

}