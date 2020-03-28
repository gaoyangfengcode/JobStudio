using System;
using Eplan.EplApi.DataModel;
using Eplan.EplApi.Starter;
using Eplan.EplApi.System;
namespace MagicStudio
{ 
    public static class FindEplan
    {
        public static string Find ()
        {
            EplanFinder EplanFinder = new EplanFinder();
            string DllPath = EplanFinder.SelectEplanVersion();
            AssemblyResolver Resolver = new AssemblyResolver();
            Resolver.SetEplanBinPath(DllPath);
            Resolver.PinToEplan();
            return DllPath;
        }
    }
    public class Starter
    {
        public EplApplication APP;
        public Starter ()
        {
            FindEplan.Find();
        }
        public void SetFrame ( IntPtr f )
        {
            APP = new EplApplication
            {
                EplanBinFolder = FindEplan.Find()
            };
            APP.Init("");
            APP.SetMainFrame(f);
        }
    }
    public class BaseEplan
    {
        public Project TemProject;
        public Project TarProject;
        public ProjectManager Manager;
        public LockingStep Locker;
        public readonly Starter starter = new Starter();
        public EplApplication app;
        public void SetMainForm ( IntPtr f )
        {
            starter.SetFrame(f);
            app = starter.APP;
            starter.SetFrame(f);
            this.app = starter.APP;
            Manager = new ProjectManager();
            Locker = new LockingStep();
        }
    }
}