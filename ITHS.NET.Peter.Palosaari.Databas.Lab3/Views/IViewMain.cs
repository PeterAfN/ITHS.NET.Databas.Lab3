using System;

namespace ITHS.NET.Peter.Palosaari.Databas.Lab3.Views
{
    public interface IViewMain
    {
        event EventHandler Load;

        void AddControls();
    }
}
