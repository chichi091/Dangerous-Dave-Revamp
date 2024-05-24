using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
// using UnityEngine.UI;

public class TestDave
{
    [SetUp]
    public void Setup()
    {
        SceneManager.LoadScene("Main_Menu");
        SceneManager.LoadScene("Level1_2");
        SceneManager.LoadScene("Level2");
        SceneManager.LoadScene("Level3");
    }
    // A Test behaves as an ordinary method
    [Test]
    public void LoadGame()
    {
        Setup();
        // Assert.AreEqual("InitTestScene638520561671282374", SceneManager.GetActiveScene().name);
        Assert.AreEqual("Main_Menu", SceneManager.GetSceneByBuildIndex(0).name);
    }

    [Test]
    public void TestDaveGoToLevel2()
    {
        Setup();
        Assert.AreEqual("Level2", SceneManager.GetSceneByBuildIndex(3).name);
    }

    [Test]
    public void TestDaveGoToLevel3()
    {
        Setup();
        Assert.AreEqual("Level3", SceneManager.GetSceneByBuildIndex(4).name);
    }

    [Test]
    public void TestNonexistentLevel()
    {
        SceneManager.LoadScene("Level4", LoadSceneMode.Single);
        Assert.AreEqual("Level4", SceneManager.GetActiveScene().name);
        throw new System.Exception("Level does not exist.");
    }

     [Test]
    public void TestDaveGoToLevel1()
    {
        Setup();
    }

    [Test]
    public void TestExitButton()
    {
        Setup();
    }

    [Test]
    public void TestMovementJump()
    {
        Setup();
        GameObject player = new GameObject();
        player.AddComponent<Rigidbody2D>();
        player.AddComponent<BoxCollider2D>();
        player.AddComponent<PlayerManager>();
        Assert.IsNotNull(player);
    }

    [Test]
    public void TestMovementLeft()
    {
        Setup();
        GameObject player = new GameObject();
        player.AddComponent<Rigidbody2D>();
        player.AddComponent<BoxCollider2D>();
        player.AddComponent<PlayerManager>();
        Assert.IsNotNull(player);
    }

    [Test]
    public void TestMovementRight()
    {
        Setup();
        GameObject player = new GameObject();
        player.AddComponent<Rigidbody2D>();
        player.AddComponent<BoxCollider2D>();
        player.AddComponent<PlayerManager>();
        Assert.IsNotNull(player);
    }

    [Test]
    public void TestActiveJetUpButton()
    {
        Setup();
        GameObject player = new GameObject();
        player.AddComponent<Rigidbody2D>();
        player.AddComponent<BoxCollider2D>();
        player.AddComponent<PlayerManager>();
        Assert.IsNotNull(player);
    }   

    [Test] 
    public void TestActiveJetDownButton()
    {
        Setup();
        GameObject player = new GameObject();
        player.AddComponent<Rigidbody2D>();
        player.AddComponent<BoxCollider2D>();
        player.AddComponent<PlayerManager>();
        Assert.IsNotNull(player);
    }

    [Test]
    public void TestActiveJetLeftButton()
    {
        Setup();
        GameObject player = new GameObject();
        player.AddComponent<Rigidbody2D>();
        player.AddComponent<BoxCollider2D>();
        player.AddComponent<PlayerManager>();
        Assert.IsNotNull(player);
    }   

    [Test] 
    public void TestActiveJetRightButton()
    {
        Setup();
        GameObject player = new GameObject();
        player.AddComponent<Rigidbody2D>();
        player.AddComponent<BoxCollider2D>();
        player.AddComponent<PlayerManager>();
        Assert.IsNotNull(player);
    }

    [Test] 
    public void TestActiveShoot()
    {
        Setup();
        GameObject player = new GameObject();
        player.AddComponent<Rigidbody2D>();
        player.AddComponent<BoxCollider2D>();
        player.AddComponent<PlayerManager>();
        Assert.IsNotNull(player);
    }

    [Test]
    public void TestJetUpButton()
    {
        Setup();
        throw new System.Exception("JetPack not active.");
    }   

    [Test] 
    public void TestJetDownButton()
    {
        Setup();
        throw new System.Exception("JetPack not active.");
    }

    [Test]
    public void TestJetLeftButton()
    {
        Setup();
        throw new System.Exception("JetPack not active.");
    }   

    [Test] 
    public void TestJetRightButton()
    {
        Setup();
        throw new System.Exception("JetPack not active.");
    }
    
    [Test]
    public void TestAltButton()
    {
        Setup();
        if (Input.GetKey(KeyCode.LeftAlt)) {
           
        }
        else {
            throw new System.Exception("Jetpack button not active.");
           
        }
    }

    [Test]
    public void TestCtrlButton()
    {
        Setup();
        if (Input.GetKey(KeyCode.LeftControl)) {
           
        }
        else {
            throw new System.Exception("Gun button not active.");
        }
    }


    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [Test]
    public void TestNonexistentButton()
    {
        Setup();
        throw new System.Exception("Button does not exist.");
    }
}
