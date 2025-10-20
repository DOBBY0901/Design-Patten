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

        // <AsyncOperation> - Ŭ���� Ÿ��
        // -allowSceneActivation
        // ����� �غ�� ��� ����� Ȱ��ȭ �Ǵ� ���� ����ϴ� ����.
        // true�� �˾Ƽ� �Ѿ. (false�� ���Ѿ�� �����س�����)

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);

        asyncOperation.allowSceneActivation = false;

        // <AsyncOperation>
        // - isdone
        // �ش� ������ �Ϸ�Ǿ����� ��Ÿ���� ����
        while (asyncOperation.isDone == false)
        {
            // <AsyncOperation>
            // - progress
            // ������ ���� ���¸� ��Ÿ���� ����

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
