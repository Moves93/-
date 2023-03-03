using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   // public static int baseMoverGo = 20; //BaseMover выезд базы на игрока
    public static int spawnerActiveEasy = 30; // Spawner до какого идут мобцы легкий++
    public static int spawnerActiveMedium = 50;// Spawner до какого идут мобцы средний++
    public static int spawnerActiveHard = 100;// Spawner до какого идут мобцы сложный++
    //public static int spawnerActiveEndless = 100;// Spawner до какого идут мобцы бесконеный, потом уберу условие из спавнера и будет бесконечно++
    public static int extraLives = 10; //ObjectPool выход оп жизни++
    public static int hardMobs = 20; //ObjectPool выход сложного моба++

    public static int weAreInPlace; //мы на месте ScoreDisplay++ x
    public static int baseActivetrue; //выезд юазы для EndGame++ x
    public static int driveToBase; // забег в базу для EndGame++ x+1
    public static int stopTime; // остановка времени для EndGame++ x+4
    public static int playerMoverStop; // PlayerMover остановка управления++ x+1
    public static int speedMobs; // EnemyMover скорость мобов

    public void Start()
    {
        switch (GameDifficultySelection.gameDifficultyText)
        {
            case "Легкая":
                weAreInPlace = spawnerActiveEasy + 2;
                baseActivetrue = spawnerActiveEasy + 2;
                driveToBase = spawnerActiveEasy + 3;
                stopTime = spawnerActiveEasy + 6;
                playerMoverStop = spawnerActiveEasy + 3;
                speedMobs = 5;
                Debug.Log(GameDifficultySelection.gameDifficultyText + "Score" + weAreInPlace);
                break;
            case "Средняя":
                weAreInPlace = spawnerActiveMedium + 2;
                baseActivetrue = spawnerActiveMedium + 2;
                driveToBase = spawnerActiveMedium + 3;
                stopTime = spawnerActiveMedium + 6;
                playerMoverStop = spawnerActiveMedium + 3;
                speedMobs = 7;
                Debug.Log(GameDifficultySelection.gameDifficultyText + "Score" + weAreInPlace);
                break;
            case "Сложная":
                weAreInPlace = spawnerActiveHard + 2;
                baseActivetrue = spawnerActiveHard + 2;
                driveToBase = spawnerActiveHard + 3;
                stopTime = spawnerActiveHard + 6;
                playerMoverStop = spawnerActiveHard + 3;
                speedMobs = 9;
                Debug.Log(GameDifficultySelection.gameDifficultyText + "Score" + weAreInPlace);
                break;
            case "Бесконечная":
                weAreInPlace = spawnerActiveHard + 2;
                baseActivetrue = spawnerActiveHard + 2;
                driveToBase = spawnerActiveHard + 3;
                stopTime = spawnerActiveHard + 6;
                playerMoverStop = spawnerActiveHard + 3;
                speedMobs = 9;
                Debug.Log(GameDifficultySelection.gameDifficultyText + "Score" + weAreInPlace);
                break;

        }
    }

    //public static int weAreInPlace = 32; //мы на месте ScoreDisplay++ x
    //public static int baseActivetrue = 32; //выезд юазы для EndGame++ x
    //public static int driveToBase = 33; // забег в базу для EndGame++ x+1
    //public static int stopTime = 36; // остановка времени для EndGame++ x+4
    //public static int playerMoverStop = 33; // PlayerMover остановка управления++ x+1

}
     
