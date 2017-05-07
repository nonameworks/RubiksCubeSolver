using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RubiksCube.Model
{
    public interface IDataService
    {
        void GetData(Action<Cube, Exception> callback);
    }
}
