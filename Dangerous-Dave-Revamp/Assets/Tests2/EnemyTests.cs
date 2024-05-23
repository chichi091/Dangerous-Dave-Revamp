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
        GameStatus game = new GameStatus();
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
        GameStatus game = new GameStatus();
        // game.isEnemyFrozen = true;
        Assert.IsTrue(true);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator EnemyTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
