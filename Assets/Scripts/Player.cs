using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public int health;
   public int damage;
   public Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello, I'm Player");
        enemy.health -= damage;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
            int enemyHealth = enemy.GetHealth();

            if (enemyHealth > 0)
            {
                enemy.Attack(damage);
            }
           
        }
    }
}
