using GraphApp.BusinessLogic;
using GraphApp.LogicContracts;
using GraphApp.Presenters.Implementations;
using GraphApp.Presenters.Interfaces;
using GraphApp.Views.Implementations;
using GraphApp.Views.Interfaces;
using Unity;

namespace GraphApp.Configuration
{
    public static class UnityConfiguration
    {
        public static void RegisterServices(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IMathGraph, MathGraph>();
            unityContainer.RegisterType<IMainPresenter, MainPresenter>();
            unityContainer.RegisterType<IMainView, MainForm>();
        }
    }
}