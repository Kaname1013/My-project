using NUnit.Framework;
using UnityEngine;

public class CharacterTests
{
    [Test(Description = "")]
    public void Character_Attack_Enemy()
    {
        var go1 = new GameObject();
        go1.AddComponent<Character>();
        var character = go1.GetComponent<Character>();
        character.SetAtk(10);

        var go2 = new GameObject();
        go2.AddComponent<Enemy>();
        var enemy = go2.GetComponent<Enemy>();
        enemy.SetHp( 100);

        character.Attack(enemy);

        var hpint = enemy.GetHp();

        // Assert.AreEqual(90 ,  hp);
    }
}
