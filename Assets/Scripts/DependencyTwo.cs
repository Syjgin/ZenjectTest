using UnityEngine;
using Zenject;

public class DependencyTwo : MonoBehaviour
{
    [Inject] private DependencyOne _dependencyOne;

    private void OnEnable()
    {
        Debug.Log(_dependencyOne.SayHello());
    }
}
