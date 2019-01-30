using UnityEngine;
using UnityEngine.UI;


public class HitText : MonoBehaviour
{
    public Text hitText;
    


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Obstacle")
        {
            hitText.text = "ai lovit ceva";
        }

    }


}

