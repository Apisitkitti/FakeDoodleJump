using UnityEngine;
using UnityEngine.SceneManagement;
public class ScreenWrap : MonoBehaviour
{
    private Camera mainCamera;
    private float screenWidth;

    private void Start()
    {
        mainCamera = Camera.main;
        screenWidth = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
    }

    private void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 newPosition = currentPosition;

        if (currentPosition.x < -screenWidth)
        {
            newPosition.x = screenWidth;
        }
        else if (currentPosition.x > screenWidth)
        {
            newPosition.x = -screenWidth;
        }
       /* else if(currentPosition.y < screenWidth)
        {
            SceneManager.LoadScene("SampleScene");


        }*/

        transform.position = newPosition;
    }
}
