using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentEnemy 
{
    public static class Enemy
    {
        public static class EnemyLv1
        {
            public static float health = ConfigurationUtils.HealthEnemy1;
            public static int attack = ConfigurationUtils.Enemy1Attack;
            public static float speed = ConfigurationUtils.Enemy1Speed;
            public static float attackSpeed = 1;
        }
        public static class EnemyLv2
        {
            public static float health = ConfigurationUtils.HealthEnemy2;
            public static int attack = ConfigurationUtils.Enemy2Attack;
            public static float speed = ConfigurationUtils.Enemy2Speed;
            public static float attackSpeed = 1;
        }
        public static class EnemyLv3
        {
            public static float health = ConfigurationUtils.HealthEnemy3;
            public static int attack = ConfigurationUtils.Enemy3Attack;
            public static float speed = ConfigurationUtils.Enemy3Speed;
            public static float attackSpeed = 1;
        }
    }
}
