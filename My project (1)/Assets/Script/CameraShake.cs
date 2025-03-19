using Unity.Cinemachine;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake instance;
    //Impulse Source������Ʈ ����
    private CinemachineImpulseSource impulseSource;
    void Start()
    {
        instance = this;
        //���� ������Ʈ�� ������ Impulse Source ������Ʈ ��������
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    //ī�޶���ũ ����
    public void CameraShakeShow()
    {
        if(impulseSource != null)
        {
            //�⺻ �������� ���޽� ����
            impulseSource.GenerateImpulse();
        }
    }
   
}
