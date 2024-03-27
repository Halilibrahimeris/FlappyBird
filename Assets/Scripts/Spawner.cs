using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SpawnObject;
    public Player PlayerRef;
    public float timer;
    public float SpawnRate;
    public float[] MaxLimits = new float[2];
    public bool check = false;
    float randomRange;
    public float[] UppreLimit = new float[2];
    public float[] LowerLimit = new float[2];
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= SpawnRate)
        {
            timer = 0f;
            if(PlayerRef.Score >= 25)
            {
                if (check)
                {
                    check = false;
                    randomRange = Random.Range(UppreLimit[1], UppreLimit[0]);
                }
                else
                {
                    check = true;
                    randomRange = Random.Range(LowerLimit[1], LowerLimit[0]);
                }
            }
            else
            {
                randomRange = Random.Range(MaxLimits[1], MaxLimits[0]);
            }
            var Object = Instantiate(SpawnObject);
            Object.transform.position = new Vector3(this.transform.position.x, randomRange, this.transform.position.z); 
        }
    }

}
