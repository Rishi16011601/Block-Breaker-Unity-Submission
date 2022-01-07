using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockNew : Block //INHERITENCE
{
    public override void TriggerSparklesVFX()  //POLYMORPHISM 
    {
        GameObject sparkles = Instantiate(blockSparklesVFX, transform.position, transform.rotation);
        Destroy(sparkles, 1f);
    }
}
