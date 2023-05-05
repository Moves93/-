using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   // public static int baseMoverGo = 20; //BaseMover выезд базы на игрока
    public static float spawnerActiveEasy = 20; // Spawner до какого идут мобцы легкий++
    public static float spawnerActiveMedium = 50;// Spawner до какого идут мобцы средний++
    public static float spawnerActiveHard = 100;// Spawner до какого идут мобцы сложный++
    //public static int spawnerActiveEndless = 100;// Spawner до какого идут мобцы бесконеный, потом уберу условие из спавнера и будет бесконечно++
    public static float extraLives = 9; //ObjectPool выход оп жизни++
    public static float hardMobs = 15; //ObjectPool выход сложного моба++ ставь 20
    public static float speedBullet = 11; //ObjectPool выход сложного моба++ ставь 20

    public static float weAreInPlace; //мы на месте ScoreDisplay++ x
    public static float baseActivetrue; //выезд юазы для EndGame++ x
    public static float driveToBase; // забег в базу для EndGame++ x+1
    public static float stopTime; // остановка времени для EndGame++ x+4
    public static float playerMoverStop; // PlayerMover остановка управления++ x+1
    public static float speedMobs; // EnemyMover скорость мобов

    private float scoreTime;
    public void Start()
    {
        switch (GameDifficultySelection.gameDifficultyText)
        {
            case "Легкая":
                weAreInPlace = spawnerActiveEasy +2f;   //+2
                baseActivetrue = spawnerActiveEasy +2f;   //+2
                driveToBase = spawnerActiveEasy +3f;   //+3
                stopTime = spawnerActiveEasy +6f;    //+6
                playerMoverStop = spawnerActiveEasy +3f;   //+3
                speedMobs = 7f;
                break;
            case "Средняя":
                weAreInPlace = spawnerActiveMedium + 2;
                baseActivetrue = spawnerActiveMedium + 2;
                driveToBase = spawnerActiveMedium + 3;
                stopTime = spawnerActiveMedium + 6;
                playerMoverStop = spawnerActiveMedium + 3;
                speedMobs = 8;
                break;
            case "Сложная":
                weAreInPlace = spawnerActiveHard + 2;
                baseActivetrue = spawnerActiveHard + 2;
                driveToBase = spawnerActiveHard + 3;
                stopTime = spawnerActiveHard + 6;
                playerMoverStop = spawnerActiveHard + 3;
                speedMobs = 9;
                break;
            case "Бесконечная":
                weAreInPlace = spawnerActiveHard + 2;
                baseActivetrue = spawnerActiveHard + 2;
                driveToBase = spawnerActiveHard + 3;
                stopTime = spawnerActiveHard + 6;
                playerMoverStop = spawnerActiveHard + 3;
                speedMobs = 9;
                break;

        }
    }

    private void Update()
    {
        scoreTime += Time.deltaTime;
        ObjectPool.score = scoreTime;
    }

    //public static int weAreInPlace = 32; //мы на месте ScoreDisplay++ x
    //public static int baseActivetrue = 32; //выезд юазы для EndGame++ x
    //public static int driveToBase = 33; // забег в базу для EndGame++ x+1
    //public static int stopTime = 36; // остановка времени для EndGame++ x+4
    //public static int playerMoverStop = 33; // PlayerMover остановка управления++ x+1

}
     
