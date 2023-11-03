using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRobot : MonoBehaviour
{
    public float speed;
    public int wordCount;
    float hAxis;
    float vAxis;
    bool jDown;

    AudioSource audio;

    public int animalsA;
    public int animalsB;
    public int animalsC; 
    public int animalsD;
    public int animalsE;
    public int animalsF;
    public int animalsG;
    public int animalsH;
    public int animalsI;
    public int animalsJ;
    public int animalsK;
    public int animalsL;
    public int animalsM;
    public int animalsN;
    public int animalsO;
    public int animalsP;
    public int animalsQ;
    public int animalsR;
    public int animalsS;
    public int animalsT;
    public int animalsU;
    public int animalsV;
    public int animalsW;
    public int animalsX;
    public int animalsY;
    public int animalsZ;
    public int animalsAA;
    public int animalsBB;
    public int animalsCC;
    public int animalsDD;
    public int animalsEE;
    public int animalsFF;
    public int animalsGG;
    public int animalsHH;
    public int animalsII;
    public int animalsJJ;
    public int animalsKK;
    public int animalsLL;
    public int animalsMM;
    public int animalsNN;
    public int animalsOO;
    public int animalsPP;
    public int animalsQQ;
    public int animalsRR;
    public int animalsSS;
    public int animalsTT;
    public int animalsUU;
    public int animalsVV;
    public int animalsWW;
    public int animalsXX;
    public int animalsYY;
    public int animalsZZ;
    public int animalsAAA;
    public int animalsBBB;
    public int animalsCCC;
    public int animalsDDD;

    public int FruitsA;
    public int FruitsB;
    public int FruitsC; 
    public int FruitsD;
    public int FruitsE;
    public int FruitsF;
    public int FruitsG;
    public int FruitsH;
    public int FruitsI;
    public int FruitsJ;
    public int FruitsK;
    public int FruitsL;
    public int FruitsM;
    public int FruitsN;
    public int FruitsO;
    public int FruitsP;
    public int FruitsQ;
    public int FruitsR;
    public int FruitsS;
    public int FruitsT;
    public int FruitsU;
    public int FruitsV;
    public int FruitsW;
    public int FruitsX;
    public int FruitsY;
    public int FruitsZ;
    public int FruitsAA;
    public int FruitsBB;
    public int FruitsCC;
    public int FruitsDD;
    public int FruitsEE;
    public int FruitsFF;
    public int FruitsGG;
    public int FruitsHH;
    public int FruitsII;
    public int FruitsJJ;
    public int FruitsKK;
    public int FruitsLL;
    public int FruitsMM;
    public int FruitsNN;
    public int FruitsOO;
    public int FruitsPP;
    public int FruitsQQ;
    public int FruitsRR;
    public int FruitsSS;
    public int FruitsTT;
    public int FruitsUU;
    public int FruitsVV;
    public int FruitsWW;
    public int FruitsXX;
    public int FruitsYY;
    public int FruitsZZ;
    public int FruitsAAA;
    public int FruitsBBB;
    public int FruitsCCC;

    bool isJump;
    bool isBorder;

    Vector3 moveVec;

    Rigidbody rigid;

    
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        GetInput();
        Move();
        Turn();
        Jump();
    }

    void GetInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        jDown = Input.GetButtonDown("Jump");
    }

    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        if(!isBorder)
            transform.position += moveVec * speed * Time.deltaTime;
    }

    void Turn()
    {
        transform.LookAt(transform.position + moveVec);
    }

    void Jump()
    {
        if(jDown && !isJump){
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
            isJump = true;
        }
    }

    void StopToobject()
    {
        Debug.DrawRay(transform.position, transform.forward * 1, Color.green);
        isBorder = Physics.Raycast(transform.position, transform.forward, 1, LayerMask.GetMask("Wall"));
    }

    void FreezeRotation()
    {
        rigid.angularVelocity = Vector3.zero;
    }

    void FixedUpdate()
    {
        FreezeRotation();
        StopToobject();
    }

    void OnCollisionEnter(Collision collision)//바닥 오브젝트의 태그를 새로 추가하여 지정 Floor로 만들고 지정한다, 모든 지형의 모듈은 정적static)으로 변경, 모든 지형들은 리지드 바다 추가후 use gravity해제, is kinematic 체크
    {
        if(collision.gameObject.tag == "Floor"){
            isJump = false;
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Item"){
            wordCount++;
            audio.Play();
            other.gameObject.SetActive(false);
        }
    }

}
