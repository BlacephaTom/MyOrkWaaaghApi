using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrkWaaaghLibrary.DataAccess;

public interface ISqlDataAccess
{
    Task LoadData<T, U>(string storedProcedure, U parameters, string connectionString); 

    Task PutData<T>(string storedProcedure, T parameters, string connectionStringName);
}
