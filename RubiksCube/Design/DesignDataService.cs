using System;
using RubiksCube.Model;

namespace RubiksCube.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<Cube, Exception> callback)
        {
            // Use this to create design time data

            var item = new Cube();
            callback(item, null);
        }
    }
}