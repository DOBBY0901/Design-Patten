using JetBrains.Annotations;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneryManager : MonoBehaviour
{
    [SerializeField] static SceneryManager instance;

    [SerializeField] Slider slider;
    [SerializeField] GameObject screen;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(instance);
            
            return;
        }
    }

    public void LoadScene(int buildIndex)
    {
        StartCoroutine(TranstionScene(buildIndex));
    }

    public IEnumerator TranstionScene(int index)
    {
        slider.value = 0;

        screen.SetActive(true);

        // <AsyncOperation> - 클래스 타입
        // -allowSceneActivation
        // 장면이 준비된 즉시 장면이 활성화 되는 것을 허용하는 변수.
        // true면 알아서 넘어감. (false로 못넘어가게 지정해놔야함)

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);

        asyncOperation.allowSceneActivation = false;

        // <AsyncOperation>
        // - isdone
        // 해당 동작이 완료되었는지 나타내는 변수
        while (asyncOperation.isDone == false)
        {
            // <AsyncOperation>
            // - progress
            // 직업의 진행 상태를 나타내는 변수

            if (asyncOperation.progress >= 0.9f)
            {
                slider.value = Mathf.Lerp(slider.value, 1f, Time.deltaTime);

                if(slider.value >= 0.99f)
                {
                    slider.value = 1.0f;

                    asyncOperation.allowSceneActivation = true;

                }
                
            }
              else
            {
                slider.value = asyncOperation.progress;
                
            }

            yield return null;
        }

        screen.SetActive(false);
    }
}
