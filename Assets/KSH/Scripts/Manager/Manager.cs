using UnityEngine;

public interface ManagerInit
{
    public void ManagerInit();
}

public class Manager : MonoBehaviour, ManagerInit
{
    public virtual void ManagerInit()
    {

    }
}