using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;
    // Start is called before the first frame update
    void Start()
    {
        graphic.sprite = standard;
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Escape);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if(down)
        {
            graphic.sprite = downgfx;
        }
        else if (held)
        {
            graphic.sprite = heldgfx;  
        }
        else if (up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = standard;
        }

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + held;
    }
}
