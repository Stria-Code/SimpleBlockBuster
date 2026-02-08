using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PillarPositions : MonoBehaviour
{
    [SerializeField] private Vector3 pillarStartPos;
    enum Pillars
    {
        TopPillar,
        RightPillar,
        LeftPillar
    }

    [SerializeField] Pillars pillar;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        pillarStartPos = transform.position;

        SetPillarPos();

        transform.position = pillarStartPos;
    }

    //setting edges positions

    void SetPillarPos()
    {    
        switch(pillar)
        {
            case Pillars.TopPillar:
                pillarStartPos.y = (ScreenDimensions.screenHeight) * 2 -40;
                break;

            case Pillars.RightPillar:
                pillarStartPos.x = (ScreenDimensions.screenWidth - 35);
                break;

            case Pillars.LeftPillar:
                pillarStartPos.x = (-ScreenDimensions.screenWidth + 35);
                break;
        }
    }
}
