using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public List<PowerUpSO> powerUpList = new List<PowerUpSO>();
    private int currentPowerUpIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (powerUpList.Count < 1)
        {
            Debug.LogError("The PowerUpManager component on the character needs to have at least 1 power up");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void nextPowerUp()
    {
        if (currentPowerUpIndex < powerUpList.Count - 1)
        {
            currentPowerUpIndex++;
        }
        else
        {
            currentPowerUpIndex = 0;
        }
    }

    public void previousPowerUp()
    {
        if (currentPowerUpIndex > 0)
        {
            currentPowerUpIndex++;
        }
        else
        {
            currentPowerUpIndex = powerUpList.Count - 1;
        }
    }

    public PowerUpSO getCurrentPowerUpScriptableObject()
    {
        return powerUpList[currentPowerUpIndex];
    }

    public PowerUp currentPowerUpType()
    {
        return this.getCurrentPowerUpScriptableObject().powerUpType;
    }
}
