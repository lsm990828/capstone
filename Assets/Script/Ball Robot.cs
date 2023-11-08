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

    public int animals1;
    public int animals2;
    public int animals3; 
    public int animals4;
    public int animals5;
    public int animals6;
    public int animals7;
    public int animals8;
    public int animals9;
    public int animals10;
    public int animals11;
    public int animals12;
    public int animals13;
    public int animals14;
    public int animals15;
    public int animals16;
    public int animals17;
    public int animals18;
    public int animals19;
    public int animals20;
    public int animals21;
    public int animals22;
    public int animals23;
    public int animals24;
    public int animals25;
    public int animals26;
    public int animals27;
    public int animals28;
    public int animals29;
    public int animals30;
    public int animals31;
    public int animals32;
    public int animals33;
    public int animals34;
    public int animals35;
    public int animals36;
    public int animals37;
    public int animals38;
    public int animals39;
    public int animals40;
    public int animals41;
    public int animals42;
    public int animals43;
    public int animals44;
    public int animals45;
    public int animals46;
    public int animals47;
    public int animals48;
    public int animals49;
    public int animals50;
    public int animals51;
    public int animals52;
    public int animals53;
    public int animals54;
    public int animals55;
    public int animals56;

    public int fruits1;
    public int fruits2;
    public int fruits3; 
    public int fruits4;
    public int fruits5;
    public int fruits6;
    public int fruits7;
    public int fruits8;
    public int fruits9;
    public int fruits10;
    public int fruits11;
    public int fruits12;
    public int fruits13;
    public int fruits14;
    public int fruits15;
    public int fruits16;
    public int fruits17;
    public int fruits18;
    public int fruits19;
    public int fruits20;
    public int fruits21;
    public int fruits22;
    public int fruits23;
    public int fruits24;
    public int fruits25;
    public int fruits26;
    public int fruits27;
    public int fruits28;
    public int fruits29;
    public int fruits30;
    public int fruits31;
    public int fruits32;
    public int fruits33;
    public int fruits34;
    public int fruits35;
    public int fruits36;
    public int fruits37;
    public int fruits38;
    public int fruits39;
    public int fruits40;
    public int fruits41;
    public int fruits42;
    public int fruits43;
    public int fruits44;
    public int fruits45;
    public int fruits46;
    public int fruits47;
    public int fruits48;
    public int fruits49;
    public int fruits50;
    public int fruits51;
    public int fruits52;
    public int fruits53;
    public int fruits54;
    public int fruits55;

    AudioSource audio;

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
           wordobject item = other.GetComponent<wordobject>();
            switch (item.type){
                case wordobject.Type.Animals1:
                    animals1 += item.value;
                    break;  
                case wordobject.Type.Animals2:
                    animals2 += item.value;
                    break;
                case wordobject.Type.Animals3:
                    animals3 += item.value;
                    break;
                case wordobject.Type.Animals4:
                    animals4 += item.value;
                    break;
                case wordobject.Type.Animals5:
                    animals5 += item.value;
                    break;
                case wordobject.Type.Animals6:
                    animals6 += item.value;
                    break;
                case wordobject.Type.Animals7:
                    animals7 += item.value;
                    break;
                case wordobject.Type.Animals8:
                    animals8 += item.value;
                    break;
                case wordobject.Type.Animals9:
                    animals9 += item.value;
                    break;
                case wordobject.Type.Animals10:
                    animals10 += item.value;
                    break;
                case wordobject.Type.Animals11:
                    animals11 += item.value;
                    break;
                case wordobject.Type.Animals12:
                    animals12 += item.value;
                    break;
                case wordobject.Type.Animals13:
                    animals13 += item.value;
                    break;
                case wordobject.Type.Animals14:
                    animals14 += item.value;
                    break;
                case wordobject.Type.Animals15:
                    animals15 += item.value;
                    break;
                case wordobject.Type.Animals16:
                    animals16 += item.value;
                    break;
                case wordobject.Type.Animals17:
                    animals17 += item.value;
                    break;
                case wordobject.Type.Animals18:
                    animals18 += item.value;
                    break;
                case wordobject.Type.Animals19:
                    animals19 += item.value;
                    break;
                case wordobject.Type.Animals20:
                    animals20 += item.value;
                    break;
                case wordobject.Type.Animals21:
                    animals21 += item.value;
                    break;
                case wordobject.Type.Animals22:
                    animals22 += item.value;
                    break;
                case wordobject.Type.Animals23:
                    animals23 += item.value;
                    break;
                case wordobject.Type.Animals24:
                    animals24 += item.value;
                    break;
                case wordobject.Type.Animals25:
                    animals25 += item.value;
                    break;
                case wordobject.Type.Animals26:
                    animals26 += item.value;
                    break;
                case wordobject.Type.Animals27:
                    animals27 += item.value;
                    break;
                case wordobject.Type.Animals28:
                    animals28 += item.value;
                    break;
                case wordobject.Type.Animals29:
                    animals29 += item.value;
                    break;
                case wordobject.Type.Animals30:
                    animals30 += item.value;
                    break;
                case wordobject.Type.Animals31:
                    animals31 += item.value;
                    break;
                case wordobject.Type.Animals32:
                    animals32 += item.value;
                    break;
                case wordobject.Type.Animals33:
                    animals33 += item.value;
                    break;
                case wordobject.Type.Animals34:
                    animals34 += item.value;
                    break;
                case wordobject.Type.Animals35:
                    animals35 += item.value;
                    break;
                case wordobject.Type.Animals36:
                    animals36 += item.value;
                    break;
                case wordobject.Type.Animals37:
                    animals37 += item.value;
                    break;
                case wordobject.Type.Animals38:
                    animals38 += item.value;
                    break;
                case wordobject.Type.Animals39:
                    animals39 += item.value;
                    break;
                case wordobject.Type.Animals40:
                    animals40 += item.value;
                    break;
                case wordobject.Type.Animals41:
                    animals41 += item.value;
                    break;
                case wordobject.Type.Animals42:
                    animals42 += item.value;
                    break;
                case wordobject.Type.Animals43:
                    animals43 += item.value;
                    break;
                case wordobject.Type.Animals44:
                    animals44 += item.value;
                    break;
                case wordobject.Type.Animals45:
                    animals45 += item.value;
                    break;
                case wordobject.Type.Animals46:
                    animals46 += item.value;
                    break;
                case wordobject.Type.Animals47:
                    animals47 += item.value;
                    break;
                case wordobject.Type.Animals48:
                    animals48 += item.value;
                    break;
                case wordobject.Type.Animals49:
                    animals49 += item.value;
                    break;
                case wordobject.Type.Animals50:
                    animals50 += item.value;
                    break;
                case wordobject.Type.Animals51:
                    animals51 += item.value;
                    break;
                case wordobject.Type.Animals52:
                    animals52 += item.value;
                    break;
                case wordobject.Type.Animals53:
                    animals53 += item.value;
                    break;
                case wordobject.Type.Animals54:
                    animals54 += item.value;
                    break;
                case wordobject.Type.Animals55:
                    animals55 += item.value;
                    break;
                case wordobject.Type.Animals56:
                    animals56 += item.value;
                    break;
                case wordobject.Type.Fruits1:
                    fruits1 += item.value;
                    break;
                case wordobject.Type.Fruits2:
                    fruits2 += item.value;
                    break;
                case wordobject.Type.Fruits3:
                    fruits3 += item.value;
                    break;
                case wordobject.Type.Fruits4:
                    fruits4 += item.value;
                    break;
                case wordobject.Type.Fruits5:
                    fruits5 += item.value;
                    break;
                case wordobject.Type.Fruits6:
                    fruits6 += item.value;
                    break;
                case wordobject.Type.Fruits7:
                    fruits7 += item.value;
                    break;
                case wordobject.Type.Fruits8:
                    fruits8 += item.value;
                    break;
                case wordobject.Type.Fruits9:
                    fruits9 += item.value;
                    break;
                case wordobject.Type.Fruits10:
                    fruits10 += item.value;
                    break;
                case wordobject.Type.Fruits11:
                    fruits11 += item.value;
                    break;
                case wordobject.Type.Fruits12:
                    fruits12 += item.value;
                    break;
                case wordobject.Type.Fruits13:
                    fruits13 += item.value;
                    break;
                case wordobject.Type.Fruits14:
                    fruits14 += item.value;
                    break;
                case wordobject.Type.Fruits15:
                    fruits15 += item.value;
                    break;
                case wordobject.Type.Fruits16:
                    fruits16 += item.value;
                    break;
                case wordobject.Type.Fruits17:
                    fruits17 += item.value;
                    break;
                case wordobject.Type.Fruits18:
                    fruits18 += item.value;
                    break;
                case wordobject.Type.Fruits19:
                    fruits19 += item.value;
                    break;
                case wordobject.Type.Fruits20:
                    fruits20 += item.value;
                    break;
                case wordobject.Type.Fruits21:
                    fruits21 += item.value;
                    break;
                case wordobject.Type.Fruits22:
                    fruits22 += item.value;
                    break;
                case wordobject.Type.Fruits23:
                    fruits23 += item.value;
                    break;
                case wordobject.Type.Fruits24:
                    fruits24 += item.value;
                    break;
                case wordobject.Type.Fruits25:
                    fruits25 += item.value;
                    break;
                case wordobject.Type.Fruits26:
                    fruits26 += item.value;
                    break;
                case wordobject.Type.Fruits27:
                    fruits27 += item.value;
                    break;
                case wordobject.Type.Fruits28:
                    fruits28 += item.value;
                    break;
                case wordobject.Type.Fruits29:
                    fruits29 += item.value;
                    break;
                case wordobject.Type.Fruits30:
                    fruits30 += item.value;
                    break;
                case wordobject.Type.Fruits31:
                    fruits31 += item.value;
                    break;
                case wordobject.Type.Fruits32:
                    fruits32 += item.value;
                    break;
                case wordobject.Type.Fruits33:
                    fruits33 += item.value;
                    break;
                case wordobject.Type.Fruits34:
                    fruits34 += item.value;
                    break;
                case wordobject.Type.Fruits35:
                    fruits35 += item.value;
                    break;
                case wordobject.Type.Fruits36:
                    fruits36 += item.value;
                    break;
                case wordobject.Type.Fruits37:
                    fruits37 += item.value;
                    break;
                case wordobject.Type.Fruits38:
                    fruits38 += item.value;
                    break;
                case wordobject.Type.Fruits39:
                    fruits39 += item.value;
                    break;
                case wordobject.Type.Fruits40:
                    fruits40 += item.value;
                    break;
                case wordobject.Type.Fruits41:
                    fruits41 += item.value;
                    break;
                case wordobject.Type.Fruits42:
                    fruits42 += item.value;
                    break;
                case wordobject.Type.Fruits43:
                    fruits43 += item.value;
                    break;
                case wordobject.Type.Fruits44:
                    fruits44 += item.value;
                    break;
                case wordobject.Type.Fruits45:
                    fruits45 += item.value;
                    break;
                case wordobject.Type.Fruits46:
                    fruits46 += item.value;
                    break;
                case wordobject.Type.Fruits47:
                    fruits47 += item.value;
                    break;
                case wordobject.Type.Fruits48:
                    fruits48 += item.value;
                    break;
                case wordobject.Type.Fruits49:
                    fruits49 += item.value;
                    break;
                case wordobject.Type.Fruits50:
                    fruits50 += item.value;
                    break;
                case wordobject.Type.Fruits51:
                    fruits51 += item.value;
                    break;
                case wordobject.Type.Fruits52:
                    fruits52 += item.value;
                    break;
                case wordobject.Type.Fruits53:
                    fruits53 += item.value;
                    break;
                case wordobject.Type.Fruits54:
                    fruits54 += item.value;
                    break;
                case wordobject.Type.Fruits55:
                    fruits55 += item.value;
                    break;
            }
            audio.Play();
            Destroy(other.gameObject);
        }
    }

}
