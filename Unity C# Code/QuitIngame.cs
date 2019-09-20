using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitIngame : MonoBehaviour
{

    public GameObject quitMenu; //add a field to insert a game object into this class and link it to quitMenu.

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) //when the escape key is pressed, the pause/quit menu is opened.
        {
            //checks whether it is active or inactive.
            bool isActive = quitMenu.activeSelf;

            quitMenu.SetActive(!isActive);
        }
    }

    
}
