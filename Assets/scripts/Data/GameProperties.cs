﻿using UnityEngine;
using System.Collections;

public  class GameProperties :MonoBehaviour
{
    public const int NUMBER_OF_PLAYERS = 4;
    public const int NUMBER_OF_COLORS = NUMBER_OF_PLAYERS * 2;
    public const float ANGLE_OFFSET_BETWEEN_HANDS = 15 * Mathf.PI / 180f;
    public const float BEAT_SUCCEED_RATIO = 0.6f;

    private static float spawnRadius ;
	public static float SpawnRadius {get{return spawnRadius;}}

    private static float beatsPerMinute = 140f;
    public static float BeatsPerMinute { get { return beatsPerMinute; } }
    public static float SecondsPerBeat { get { return 60f / beatsPerMinute; } }

    private static float beatsUntilCenter = 3f;
    private static float noteDuration = SecondsPerBeat * BeatsUntilCenter;
    public static float NoteDuration { get { return noteDuration; } }
    public static float NoteVelocity { get { return SpawnRadius / NoteDuration; } }
    //degreesPerSecond
    private static float noteRotation = 20f;
    public static float NoteRotation { get { return noteRotation; } }
    public static float BeatsUntilCenter { get { return beatsUntilCenter; } }



    void Awake(){
        spawnRadius = Camera.main.orthographicSize * 0.8f;
    }
}
