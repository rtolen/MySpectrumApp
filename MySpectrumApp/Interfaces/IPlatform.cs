using System;
using System.Collections.Generic;
using System.Text;

namespace MySpectrumApp.Interfaces
{
    public interface IPlatform
    {
        string GetModel();

        string GetVersion();
    }
}
