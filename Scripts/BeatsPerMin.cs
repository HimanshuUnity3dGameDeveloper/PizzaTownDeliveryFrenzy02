using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatsPerMin : MonoBehaviour
{
    public static BeatsPerMin _beatsPerMinInstance;

    public AudioSource song;
    float[] historyBuffer = new float[4];
    public Camera mainCam;
    float initZ;
    public float Spawner;

    private void Awake()
    {
        _beatsPerMinInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        initZ = mainCam.transform.localPosition.z;
        song.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //compute instant sound energy
        float[] channelRight = song.GetComponent<AudioSource>().GetOutputData(1024, 0);
        float[] channelLeft = song.GetComponent<AudioSource>().GetOutputData(1024, 1);

        float e = sumStereo(channelLeft, channelRight);

        //compute local average sound evergy
        float E = sumLocalEnergy() / historyBuffer.Length; // E being the average local sound energy

        //calculate variance
        float sumV = 0;
        for (int i = 0; i < historyBuffer.Length; i++)
            sumV += (historyBuffer[i] - E) * (historyBuffer[i] - E);

        float V = sumV / historyBuffer.Length;
        float constant = (float)((-0.0025714 * V) + 1.5142857);

        float[] shiftingHistoryBuffer = new float[historyBuffer.Length]; // make a new array and copy all the values to it

        for (int i = 0; i < (historyBuffer.Length - 1); i++)
        { // now we shift the array one slot to the right
            shiftingHistoryBuffer[i + 1] = historyBuffer[i]; // and fill the empty slot with the new instant sound energy
        }

        shiftingHistoryBuffer[0] = e;

        for (int i = 0; i < historyBuffer.Length; i++)
        {
            historyBuffer[i] = shiftingHistoryBuffer[i]; //then we return the values to the original array
        }
        Mod(e);
    }

    float sumStereo(float[] channel1, float[] channel2)
    {
        float e = 0;
        for (int i = 0; i < channel1.Length; i++)
        {
            e += ((channel1[i] * channel1[i]) + (channel2[i] * channel2[i]));
        }

        return e;
    }

    float sumLocalEnergy()
    {
        float E = 0;

        for (int i = 0; i < historyBuffer.Length; i++)
        {
            E += historyBuffer[i] * historyBuffer[i];
        }

        return E;
    }

    string historybuffer()
    {
        string s = "";
        for (int i = 0; i < historyBuffer.Length; i++)
        {
            s += (historyBuffer[i] + ",");
        }
        return s;
    }

    void Mod(float f)
    {
        if (f > 130)
            f = 130;

        if (f <= 10)
            f = 1f;
        else if (f <= 20 && f > 10)
            f = 2f;
        else if (f <= 30 && f > 20)
            f = 3f;
        else if (f <= 40 && f > 30)
            f = 4f;
        else if (f <= 50 && f > 40)
            f = 5f;
        else if (f <= 60 && f > 50)
            f = 6f;
        else if (f <= 70 && f > 60)
            f = 7f;
        else if (f <= 80 && f > 70)
            f = 8f;
        else if (f <= 90 && f > 80)
            f = 7f;
        else if (f <= 100 && f > 90)
            f = 6f;
        else if (f <= 110 && f > 100)
            f = 7f;
        else if (f <= 120 && f > 110)
            f = 6.5f;
        else if (f <= 130 && f > 120)
            f = 2f;
        Spawner = f;
    }
}

































//    public float bpm;
//    private float _beatInternal, _beatTimer, _beatIntervalD8, _beatTimerD8;
//    public static bool _beatFull, _beatD8;
//    public static int _beatCountFull, _beatCountD8 ;



//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        BeatDetection();
//    }

//    void BeatDetection()
//    {
//        _beatFull = false;
//        _beatInternal = 60 / bpm;
//        _beatTimer += Time.deltaTime;
//        if (_beatTimer >= _beatInternal)
//        {
//            _beatTimer -= _beatInternal;
//            _beatFull = true;
//            _beatCountFull++;
//        }

//        //Divided by 8..
//        _beatD8 = false;
//        _beatIntervalD8 = _beatInternal / 8;
//        _beatTimerD8 += Time.deltaTime;
//        if (_beatTimerD8 >= _beatIntervalD8)
//        {
//            _beatTimerD8 -= _beatIntervalD8;
//            _beatD8 = true;
//            _beatCountD8++;
//        }
//    }
//}
