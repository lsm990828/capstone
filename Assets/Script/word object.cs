using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordobject : MonoBehaviour
{
    AudioSource audio;//없어도 됨(캐릭터 스크립트에 있음)

    void Awake()//없어도 됨(캐릭터 스크립트에 있음)
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)//없어도 됨(캐릭터 스크립트에 있음)
    {
        if(other.name == "Ball Robot"){
            BallRobot player = other.GetComponent<BallRobot>();
            player.wordCount++;
            audio.Play();
            gameObject.SetActive(false);
        }
    }
}
