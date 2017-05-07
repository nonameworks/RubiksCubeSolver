using System;

namespace RubiksCube.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<Cube, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new Cube();
            callback(item, null);
        }
    }
}