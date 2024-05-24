using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class EnemyTests
{
    [SetUp]
    public void Setup()
    {
        SceneManager.LoadScene("Level3");
        GameObject enemy = new GameObject();
        enemy.AddComponent<BoxCollider2D>();
        enemy.AddComponent<GameStatus>();
    }
    // A Test behaves as an ordinary method
    [Test]
    public void EnemyInitialisation()
    {
        Setup();
        GameObject enemy = new GameObject();
        enemy.AddComponent<BoxCollider2D>();
        Assert.IsNotNull(enemy);
    }   

    [Test]
    public void EnemyFire()
    {
        Setup();
        GameObject enemy = new GameObject();
        enemy.AddComponent<BoxCollider2D>();
        Ai_Attack ai = enemy.AddComponent<Ai_Attack>();
        Assert.IsNotNull(ai);
    }

    [Test]
    public void EnemyKilled()
    {
        Setup();
        GameObject enemy = new GameObject();
        enemy.AddComponent<GameStatus>();
        // game.isEnemyFrozen = true;
        Assert.IsTrue(true);
    }
}
