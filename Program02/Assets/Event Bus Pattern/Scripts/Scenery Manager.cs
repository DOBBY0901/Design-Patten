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

        // <AsyncOperation> - Ŭ���� Ÿ��
        // -allowSceneActivation
        // ����� �غ�� ��� ����� Ȱ��ȭ �Ǵ� ���� ����ϴ� ����.
        // true�� �˾Ƽ� �Ѿ. (false�� ���Ѿ�� �����س�����)

        //���� ���� - ������ �������� �Ǵ� �� 
        //P2P


    }
}
