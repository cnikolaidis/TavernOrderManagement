namespace TavernOrderManagement.DataAccessLayer.Services.ModelServices
{
    #region Usings
    using System.Linq;
    using System;
    #endregion

    public static class S
    {
        public static ICategoryService CategoryService => Get<ICategoryService>();
        public static IOrderItemService OrderItemService => Get<IOrderItemService>();
        public static IOrderService OrderService => Get<IOrderService>();
        public static IProductService ProductService => Get<IProductService>();

        public static T Get<T>() where T : class
        {
            object svcInstance = null;
            var svcClass = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(T).IsAssignableFrom(x))
                .Where(x => !x.IsInterface)
                .FirstOrDefault(x => !x.IsAbstract);

            if (svcClass != null)
                svcInstance = Activator.CreateInstance(svcClass);

            return svcInstance as T;
        }
    }
}
