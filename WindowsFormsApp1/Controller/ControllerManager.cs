using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Controller
{
    public class ControllerManager
    {
        private static IDictionary<Type, IController> Controller { get; set; } = new Dictionary<Type, IController>();
        public static T Register<T>(T controller) where T : IController
        {
            Controller.Add(typeof(T), controller);
            return controller;
        }

        public static T Get<T>() where T : IController
        {
            return (T)(Controller.TryGetValue(typeof(T), out var controller) ? controller : null);
        }

        public static T Remove<T>() where T : IController
        {
            var result = Get<T>();
            Controller.Remove(typeof(T));
            return result;
        }
    }
}
