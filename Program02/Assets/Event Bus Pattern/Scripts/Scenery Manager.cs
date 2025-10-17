using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneryManager : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] GameObject screen;

    void Start()
    {
        
    }

    public void LoadScene(int buildIndex)
    {
        
    }

    public IEnumerator TranstionScene(int index)
    {
        slider.value = 0;

        screen.SetActive(true);

        // <AsyncOperation> - 클래스 타입
        // -allowSceneActivation
        // 장면이 준비된 즉시 장면이 활성화 되는 것을 허용하는 변수.
        // true면 알아서 넘어감. (false로 못넘어가게 지정해놔야함)

        //리슨 서버 - 방장이 서버장이 되는 식 
        //P2P


    }
}
