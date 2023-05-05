using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   // public static int baseMoverGo = 20; //BaseMover ����� ���� �� ������
    public static float spawnerActiveEasy = 20; // Spawner �� ������ ���� ����� ������++
    public static float spawnerActiveMedium = 50;// Spawner �� ������ ���� ����� �������++
    public static float spawnerActiveHard = 100;// Spawner �� ������ ���� ����� �������++
    //public static int spawnerActiveEndless = 100;// Spawner �� ������ ���� ����� ����������, ����� ����� ������� �� �������� � ����� ����������++
    public static float extraLives = 9; //ObjectPool ����� �� �����++
    public static float hardMobs = 15; //ObjectPool ����� �������� ����++ ����� 20
    public static float speedBullet = 11; //ObjectPool ����� �������� ����++ ����� 20

    public static float weAreInPlace; //�� �� ����� ScoreDisplay++ x
    public static float baseActivetrue; //����� ���� ��� EndGame++ x
    public static float driveToBase; // ����� � ���� ��� EndGame++ x+1
    public static float stopTime; // ��������� ������� ��� EndGame++ x+4
    public static float playerMoverStop; // PlayerMover ��������� ����������++ x+1
    public static float speedMobs; // EnemyMover �������� �����

    private float scoreTime;
    public void Start()
    {
        switch (GameDifficultySelection.gameDifficultyText)
        {
            case "������":
                weAreInPlace = spawnerActiveEasy +2f;   //+2
                baseActivetrue = spawnerActiveEasy +2f;   //+2
                driveToBase = spawnerActiveEasy +3f;   //+3
                stopTime = spawnerActiveEasy +6f;    //+6
                playerMoverStop = spawnerActiveEasy +3f;   //+3
                speedMobs = 7f;
                break;
            case "�������":
                weAreInPlace = spawnerActiveMedium + 2;
                baseActivetrue = spawnerActiveMedium + 2;
                driveToBase = spawnerActiveMedium + 3;
                stopTime = spawnerActiveMedium + 6;
                playerMoverStop = spawnerActiveMedium + 3;
                speedMobs = 8;
                break;
            case "�������":
                weAreInPlace = spawnerActiveHard + 2;
                baseActivetrue = spawnerActiveHard + 2;
                driveToBase = spawnerActiveHard + 3;
                stopTime = spawnerActiveHard + 6;
                playerMoverStop = spawnerActiveHard + 3;
                speedMobs = 9;
                break;
            case "�����������":
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

    //public static int weAreInPlace = 32; //�� �� ����� ScoreDisplay++ x
    //public static int baseActivetrue = 32; //����� ���� ��� EndGame++ x
    //public static int driveToBase = 33; // ����� � ���� ��� EndGame++ x+1
    //public static int stopTime = 36; // ��������� ������� ��� EndGame++ x+4
    //public static int playerMoverStop = 33; // PlayerMover ��������� ����������++ x+1

}
     
