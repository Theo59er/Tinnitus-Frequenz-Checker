using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NeuralNetworkLesson;
using System.IO;
using System;
using TMPro;

public class Programm : MonoBehaviour
{
    public TextMeshProUGUI Pitchfrequenz;


    int maxpitch = 15000;
    int minpitch = 0;
    public int pitch = 3000; // Frequenz des Tons in Hertz
    public float volume = 1f;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        // AudioSource-Komponente hinzufügen
        audioSource = gameObject.AddComponent<AudioSource>();

        // Unendlichen Loop aktivieren
        audioSource.loop = true;

        
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = volume;
        Pitchfrequenz.text = ("TonHöhe = " + pitch + "Hz");
    }



    public void StartTone()
    {

        
        // Audiodaten für den Sinuswellenton generieren
        int sampleRate = 44100; // Standard-Audiosample-Rate
        float[] data = new float[sampleRate];
        float increment = pitch * 2.0f * Mathf.PI / sampleRate;

        for (int i = 0; i < sampleRate; i++)
        {
            data[i] = Mathf.Sin(increment * i);
        }

        // Audiodaten dem AudioSource zuweisen
        audioSource.clip = AudioClip.Create("PermanentTone", sampleRate, 1, sampleRate, false);
        audioSource.clip.SetData(data, 0);

        // Ton abspielen
        
        audioSource.Play();

        // Optional: Überprüfe die Lautstärke im Inspektor
        // audioSource.volume = 1.0f;

        Invoke("StopTone", 1f);
    }

    void StopTone()
    {
        // Ton stoppen
        audioSource.Stop();
    }

    


    public int LowerPitch(int pitch,int minpitch)
    {

        this.maxpitch = pitch;
        int randomNumber = UnityEngine.Random.Range(minpitch, pitch);
        pitch = randomNumber;

        
        return pitch;


    }


    public int HigherPitch(int pitch, int maxpitch)
    {
        this.minpitch = pitch;
        int randomNumber = UnityEngine.Random.Range(pitch, maxpitch);
        pitch = randomNumber;

        
        return pitch;

    }


    public void StartToneOnClick()
    {
        // Methode, die vom Button aufgerufen wird, um den Ton zu starten
        StartTone();
    }

    public void HigherPitchOnClick()
    {
        this.pitch = HigherPitch(pitch, maxpitch);
    }

    public void LowerPitchOnClick()
    {
       this.pitch = LowerPitch(pitch, minpitch);
    }

}
