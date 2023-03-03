using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   // public static int baseMoverGo = 20; //BaseMover ����� ���� �� ������
    public static int spawnerActiveEasy = 30; // Spawner �� ������ ���� ����� ������++
    public static int spawnerActiveMedium = 50;// Spawner �� ������ ���� ����� �������++
    public static int spawnerActiveHard = 100;// Spawner �� ������ ���� ����� �������++
    //public static int spawnerActiveEndless = 100;// Spawner �� ������ ���� ����� ����������, ����� ����� ������� �� �������� � ����� ����������++
    public static int extraLives = 10; //ObjectPool ����� �� �����++
    public static int hardMobs = 20; //ObjectPool ����� �������� ����++

    public static int weAreInPlace; //�� �� ����� ScoreDisplay++ x
    public static int baseActivetrue; //����� ���� ��� EndGame++ x
    public static int driveToBase; // ����� � ���� ��� EndGame++ x+1
    public static int stopTime; // ��������� ������� ��� EndGame++ x+4
    public static int playerMoverStop; // PlayerMover ��������� ����������++ x+1
    public static int speedMobs; // EnemyMover �������� �����

    public void Start()
    {
        switch (GameDifficultySelection.gameDifficultyText)
        {
            case "������":
                weAreInPlace = spawnerActiveEasy + 2;
                baseActivetrue = spawnerActiveEasy + 2;
                driveToBase = spawnerActiveEasy + 3;
                stopTime = spawnerActiveEasy + 6;
                playerMoverStop = spawnerActiveEasy + 3;
                speedMobs = 5;
                Debug.Log(GameDifficultySelection.gameDifficultyText + "Score" + weAreInPlace);
                break;
            case "�������":
                weAreInPlace = spawnerActiveMedium + 2;
                baseActivetrue = spawnerActiveMedium + 2;
                driveToBase = spawnerActiveMedium + 3;
                stopTime = spawnerActiveMedium + 6;
                playerMoverStop = spawnerActiveMedium + 3;
                speedMobs = 7;
                Debug.Log(GameDifficultySelection.gameDifficultyText + "Score" + weAreInPlace);
                break;
            case "�������":
                weAreInPlace = spawnerActiveHard + 2;
                baseActivetrue = spawnerActiveHard + 2;
                driveToBase = spawnerActiveHard + 3;
                stopTime = spawnerActiveHard + 6;
                playerMoverStop = spawnerActiveHard + 3;
                speedMobs = 9;
                Debug.Log(GameDifficultySelection.gameDifficultyText + "Score" + weAreInPlace);
                break;
            case "�����������":
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

    //public static int weAreInPlace = 32; //�� �� ����� ScoreDisplay++ x
    //public static int baseActivetrue = 32; //����� ���� ��� EndGame++ x
    //public static int driveToBase = 33; // ����� � ���� ��� EndGame++ x+1
    //public static int stopTime = 36; // ��������� ������� ��� EndGame++ x+4
    //public static int playerMoverStop = 33; // PlayerMover ��������� ����������++ x+1

}
     
