using GameStoreDomain.Abstract;
using GameStoreDomain.Entities;
using Moq;
using Ninject;
using System.Web.Mvc;

namespace GameStore.WebUi.Infrastructure
{
    //Основна ідея IoC полягає в тому, щоб зсунути відповідальність за створення та управління залежностями з клієнтського коду на зовнішній контейнер (у цьому випадку Ninject). Це допомагає зменшити зв'язаність між різними компонентами програми і полегшує тестування та зміну коду.

//    Інтерфейс IDependencyResolver визначає два методи:

//object GetService(Type serviceType): Цей метод призначений для отримання одного екземпляра служби(залежності) за типом serviceType.Він приймає параметр serviceType, який вказує, яку службу потрібно отримати, і повертає об'єкт цієї служби.

//IEnumerable<object> GetServices(Type serviceType): Цей метод призначений для отримання переліку екземплярів служби за типом serviceType.Він приймає параметр serviceType і повертає перелік об'єктів цієї служби.
    
    public class NinjectDependencyResolver : IDependencyResolver
    {
        //  private IKernel kernel;: Це приватне поле kernel, яке представляє контейнер інверсії управління(IoC) Ninject, який використовується для управління залежностями.
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernel)
        {

            
            this.kernel = kernel;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
          return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            //        Mock<IGameRepository> mock = new Mock<IGameRepository>();
            //        mock.Setup(m => m.Games).Returns(new List<Game>
            //{
            //    new Game { Name = "SimCity", Price = 1499 },
            //    new Game { Name = "TITANFALL", Price=2299 },
            //    new Game { Name = "Battlefield 4", Price=899.4M }
            //});
            //        kernel.Bind<IGameRepository>().ToConstant(mock.Object);
            // Здесь размещаются привязки


            kernel.Bind<IGameRepository>().To<EFGameRepository>();
            // Для применения нового класса хранилища понадобится отредактировать привязки Ninject и заменить имитированное хранилище привязкой к реальному хранилищу.

        }
    }
}
