using UnityEngine;
using Zenject;

namespace DefaultNamespace
{
    public class DependencyTwoInstaller : MonoInstaller<DependencyTwoInstaller>
    {
        [SerializeField] private DependencyTwo _dependencyTwo;
        public override void InstallBindings()
        {
            Container.Bind<DependencyTwo>().FromInstance(_dependencyTwo).AsSingle();
        }
    }
}