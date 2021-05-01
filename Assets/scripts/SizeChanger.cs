using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class SizeChanger : MonoBehaviour
{
    public enum Size {small,medium,big};
    public float BigScale = 1.2f;
    public float MediumScale = 1f;
    public float SmallScale = .2f;
    public Size ChanSize=Size.big;
    private Transform chanScale;
    private ThirdPersonCharacter thirdPerson;
    private Dictionary<Size, float> sizeSet;
    private int sizeCounter;
    //Property for size change Firing delay
    private float scFireRate = 0.5f;
    private float scNextFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.chanScale = this.GetComponent<Transform>();
        this.thirdPerson = this.GetComponent<ThirdPersonCharacter>();
        this.sizeSet = new Dictionary<Size,float>();
        this.sizeSet.Add(Size.small, this.SmallScale);
        this.sizeSet.Add(Size.medium, this.MediumScale);
        this.sizeSet.Add(Size.big, this.BigScale);
        float sizeVal = this.sizeSet[this.ChanSize];
        this.chanScale.localScale = new Vector3(sizeVal, sizeVal, sizeVal);
        this.sizeCounter = 0;
        
    }

    public void beBig()
    {
        this.ChanSize = Size.big;
        float sizeVal = this.sizeSet[this.ChanSize];
        this.chanScale.localScale = new Vector3(sizeVal, sizeVal, sizeVal);
        if (this.thirdPerson != null) this.thirdPerson.beBig();
    }
    public void beMedium()
    {
        this.ChanSize = Size.medium;
        float sizeVal = this.sizeSet[this.ChanSize];
        this.chanScale.localScale = new Vector3(sizeVal, sizeVal, sizeVal);
        if (this.thirdPerson != null) this.thirdPerson.beMedium();

    }
    public void beSmall()
    {
        this.ChanSize = Size.small;
        float sizeVal = this.sizeSet[this.ChanSize];
        this.chanScale.localScale = new Vector3(sizeVal, sizeVal, sizeVal);
        if (this.thirdPerson != null) this.thirdPerson.beSmall();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire3") && Time.time > scNextFire)
        {
            this.scNextFire = Time.time + this.scFireRate;
            switch((++this.sizeCounter)%3)
            {
                case 0:
                    this.beSmall();
                    break;
                case 1:
                    this.beMedium();
                    break;
                case 2:
                    this.beBig();
                    break;
            } 
        }
    }
}
