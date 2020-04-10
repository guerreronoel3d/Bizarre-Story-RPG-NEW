using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
public class enemyFactory
{
    public enemy getEnemy(string type)
    {
       if(type=="basicEnemy")
        {
            return new basicEnemy();
        }
        return null;
    }
}
public interface enemy
{
     void spawn();
     void move();
     void attack();
    
}
public class basicEnemy : enemy
{
    int health;
    int atk;
    int speed;
    public basicEnemy()
    {
        health = 10;
        atk = 10;
        speed = 10;
    }
    public void attack()
    {
        throw new System.NotImplementedException();
    }

    public void move()
    {
        throw new System.NotImplementedException();
    }

    public void spawn()
    {
        throw new System.NotImplementedException();
    }
}