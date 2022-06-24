using Zenject;

namespace DefaultNamespace
{
    public class DependencyOneInstaller : MonoInstaller<DependencyOneInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<DependencyOne>().FromComponentInHierarchy().AsSingle();
        }
    }
}