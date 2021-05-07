using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterConductor : MonoBehaviour
{
    public AndreCollider Andre1;
    public AndreCollider Andre2;
    public AndreCollider Andre3;
    public AndreCollider Andre4;
    public AndreCollider Andre5;
    public AndreCollider Andre6;
    public AndreCollider Andre7;

    public SoundCollider Intro;
    public SoundCollider NatashaIntro;
    public SoundCollider Natasha;
    public SoundCollider SonyaIntro;
    public SoundCollider Sonya;
    public SoundCollider MaryaIntro;
    public SoundCollider Marya;
    public SoundCollider AnatoleIntro;
    public SoundCollider Anatole;
    public SoundCollider HeleneIntro;
    public SoundCollider Helene;
    public SoundCollider DolokhovIntro;
    public SoundCollider Dolokhov;
    public SoundCollider MinorCharacters;
    public SoundCollider Bolkonsky;
    public SoundCollider Mary;
    public SoundCollider Balaga;

    public bool IntroDone;
    public bool NatashaIntroDone;
    public bool SonyaIntroDone;
    public bool MaryaIntroDone;
    public bool AnatoleIntroDone;
    public bool HeleneIntroDone;
    public bool DolokhovIntroDone;
    public bool MinorCharactersDone;

    // Start is called before the first frame update
    void Start()
    {
        Intro.playable = true;
    }

    // Update is called once per frame
    void Update()
    {
        FullListCheck();
        AndreCheck();
        IntroCheck();
    }

    //Method to make next character in full list playable
    void FullListCheck()
    {
        if (Balaga.nextStepAvailable == true)
        {
            Bolkonsky.playable = true;
            Balaga.nextStepAvailable = false;
        }
        else if (Bolkonsky.nextStepAvailable == true)
        {
            Mary.playable = true;
            Bolkonsky.nextStepAvailable = false;
        }
        else if(Mary.nextStepAvailable == true)
        {
            Dolokhov.playable = true;
            Mary.nextStepAvailable = false;
        }
        else if (Dolokhov.nextStepAvailable == true)
        {
            Helene.playable = true;
            Dolokhov.nextStepAvailable = false;
        }
        else if(Helene.nextStepAvailable == true)
        {
            Anatole.playable = true;
            Helene.nextStepAvailable = false;
        }
        else if(Anatole.nextStepAvailable == true)
        {
            Marya.playable = true;
            Anatole.nextStepAvailable = false;
        }
        else if(Marya.nextStepAvailable == true)
        {
            Sonya.playable = true;
            Marya.nextStepAvailable = false;
        }
        else if(Sonya.nextStepAvailable == true)
        {
            Natasha.playable = true;
            Sonya.nextStepAvailable = false;
        }
        else if (Natasha.nextStepAvailable == true)
        {
            //Make the active Andre playable
            if(Andre1.isActiveAndEnabled)
            {
                Andre1.playable = true;
            }
            else if (Andre2.isActiveAndEnabled)
            {
                Andre2.playable = true;
            }
            else if (Andre3.isActiveAndEnabled)
            {
                Andre3.playable = true;
            }
            else if (Andre4.isActiveAndEnabled)
            {
                Andre4.playable = true;
            }
            else if (Andre5.isActiveAndEnabled)
            {
                Andre5.playable = true;
            }
            else if (Andre6.isActiveAndEnabled)
            {
                Andre6.playable = true;
            }
            else if (Andre7.isActiveAndEnabled)
            {
                Andre7.playable = true;
            }

            Natasha.nextStepAvailable = false;
        }
    }

    void AndreCheck()
    {
        if(Andre1.nextStepAvailable)
        {
            DelayPlayable(3, SonyaIntro);
            Andre1.nextStepAvailable = false;
        }
        else if(Andre2.nextStepAvailable)
        {
            DelayPlayable(3, MaryaIntro);
            Andre2.nextStepAvailable = false;
        }
        else if (Andre3.nextStepAvailable)
        {
            DelayPlayable(3, AnatoleIntro);
            Andre3.nextStepAvailable = false;
        }
        else if (Andre4.nextStepAvailable)
        {
            DelayPlayable(3, HeleneIntro);
            Andre4.nextStepAvailable = false;
        }
        else if (Andre5.nextStepAvailable)
        {
            DelayPlayable(3, DolokhovIntro);
            Andre5.nextStepAvailable = false;
        }
        else if (Andre6.nextStepAvailable)
        {
            DelayPlayable(3, MinorCharacters);
            Andre6.nextStepAvailable = false;
        }
        else if (Andre7.nextStepAvailable)
        {
            Andre7.nextStepAvailable = false;
        }
    }

    void IntroCheck()
    {
        if (!IntroDone && Intro.nextStepAvailable == true)
        {
            DelayPlayable(84, NatashaIntro);
            IntroDone = true;
            Intro.nextStepAvailable = false;
        }

        if (!NatashaIntroDone && NatashaIntro.nextStepAvailable == true)
        {
            DelayPlayable(11, Natasha);
            NatashaIntroDone = true;
            NatashaIntro.nextStepAvailable = false;
        }

        if (!SonyaIntroDone && SonyaIntro.nextStepAvailable == true)
        {
            DelayPlayable(7, Sonya);
            SonyaIntroDone = true;
            SonyaIntro.nextStepAvailable = false;
        }

        if (!MaryaIntroDone && MaryaIntro.nextStepAvailable == true)
        {
            DelayPlayable(9, Marya);
            MaryaIntroDone = true;
            MaryaIntro.nextStepAvailable = false;
        }

        if (!AnatoleIntroDone && AnatoleIntro.nextStepAvailable == true)
        {
            DelayPlayable(34, Anatole);
            AnatoleIntroDone = true;
            AnatoleIntro.nextStepAvailable = false;
        }

        if (!HeleneIntroDone && HeleneIntro.nextStepAvailable == true)
        {
            DelayPlayable(7, Helene);
            HeleneIntroDone = true;
            HeleneIntro.nextStepAvailable = false;
        }

        if (!DolokhovIntroDone && DolokhovIntro.nextStepAvailable == true)
        {
            DelayPlayable(9, Dolokhov);
            DolokhovIntroDone = true;
            DolokhovIntro.nextStepAvailable = false;
        }

        if (!MinorCharactersDone && MinorCharacters.nextStepAvailable == true)
        {
            DelayPlayable(23, Balaga);
            MinorCharactersDone = true;
            MinorCharacters.nextStepAvailable = false;
        }
    }

    //Wait for audio clips to finish
    void DelayPlayable(float waitTime, SoundCollider soundCollider)
    {
        StartCoroutine(CharacterPlayable(waitTime, soundCollider));
    }

    IEnumerator CharacterPlayable(float waitTime, SoundCollider soundCollider)
    {
        yield return new WaitForSeconds(waitTime);
        soundCollider.playable = true;
    }
}
