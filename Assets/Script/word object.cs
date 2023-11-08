using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordobject : MonoBehaviour
{
    public enum Type{Fruits1,Fruits2,Fruits3,Fruits4,Fruits5,Fruits6,Fruits7,Fruits8,Fruits9,Fruits10,Fruits11,Fruits12,Fruits13,Fruits14,Fruits15,Fruits16,Fruits17,Fruits18,Fruits19,Fruits20,Fruits21,Fruits22,Fruits23,Fruits24,Fruits25,Fruits26,Fruits27,Fruits28,Fruits29,Fruits30,Fruits31,Fruits32,Fruits33,Fruits34,Fruits35,Fruits36,Fruits37,Fruits38,Fruits39,Fruits40,Fruits41,Fruits42,Fruits43,Fruits44,Fruits45,Fruits46,Fruits47,Fruits48,Fruits49,Fruits50,Fruits51,Fruits52,Fruits53,Fruits54,Fruits55,
    Animals1,Animals2,Animals3,Animals4,Animals5,Animals6,Animals7,Animals8,Animals9,Animals10,Animals11,Animals12,Animals13,Animals14,Animals15,Animals16,Animals17,Animals18,Animals19,Animals20,Animals21,Animals22,Animals23,Animals24,Animals25,Animals26,Animals27,Animals28,Animals29,Animals30,Animals31,Animals32,Animals33,Animals34,Animals35,Animals36,Animals37,Animals38,Animals39,Animals40,Animals41,Animals42,Animals43,Animals44,Animals45,Animals46,Animals47,Animals48,Animals49,Animals50,Animals51,Animals52,Animals53,Animals54,Animals55,Animals56};
    public Type type;
    public int value;

    AudioSource audio;//없어도 됨(캐릭터 스크립트에 있음)

    void Awake()//없어도 됨(캐릭터 스크립트에 있음)
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    /*void OnTriggerEnter(Collider other)//없어도 됨(캐릭터 스크립트에 있음)
    {
        if(other.name == "Ball Robot"){
            BallRobot player = other.GetComponent<BallRobot>();
            player.wordCount++;
            audio.Play();
            gameObject.SetActive(false);
        }
    }*/
}
