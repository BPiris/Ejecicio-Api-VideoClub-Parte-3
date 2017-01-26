using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiVideoClub.Models.ViewModels.Base
{
    public interface IViewModel<T> where T : class
    {
        T ToModel();
        void FromModel(T model);
        void UpdateModel(T model);
        int[] GetPk();
    }
}
