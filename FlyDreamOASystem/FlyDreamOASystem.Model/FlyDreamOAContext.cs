
using SqlSugar;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FlyDreamOASystem.Model
{
    public class FlyDreamOAContext
    {
        public FlyDreamOAContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "server=.;uid=sa;pwd=123;database=FlyDreamOA",
                DbType = DbType.SqlServer,
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = true,

            });
             Db.DbMaintenance.CreateDatabase();
             Assembly asm = Assembly.Load("FlyDreamOASystem.Model");
             Type[] list = asm.GetTypes().Where(m => m.IsClass && !m.IsAbstract &&m.BaseType==typeof(BaseEntity)).ToArray();
             Db.CodeFirst.SetStringDefaultLength(200).InitTables(list);
  
          
        }
            public SqlSugarClient Db;
            public SimpleClient<Entitys.Dictionary> DictionaryList { get { return new SimpleClient<Entitys.Dictionary>(Db); } }


    }
    
}
