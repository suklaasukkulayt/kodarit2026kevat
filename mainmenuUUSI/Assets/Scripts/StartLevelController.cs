using UnityEngine;

public class StartLevelController : MonoBehaviour
{
    public FadeController fade;
    void Start()
    {
        fade.FadeOut();
    }

}
