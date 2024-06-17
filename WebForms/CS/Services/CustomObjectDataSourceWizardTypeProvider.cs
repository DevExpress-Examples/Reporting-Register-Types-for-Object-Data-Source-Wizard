#region usings_1
using System;
using System.Collections.Generic;
#endregion
#region usings_2
using System.Linq;
using System.Reflection;
#endregion
#region usings
using DevExpress.DataAccess.Web;
#endregion

namespace WebForms.Services {
    #region CustomObjectDataSourceWizardTypeProvider
    // ...
    public class CustomObjectDataSourceWizardTypeProvider : IObjectDataSourceWizardTypeProvider {
        public IEnumerable<Type> GetAvailableTypes(string context) {
            return new[] {
                typeof(SampleObjectTypes.DataSource),
                typeof(SampleObjectTypes.DataSource2)
            };
        }
    }
    #endregion

    #region CustomObjectDataSourceConstructorFilterService
    // ...
    public class CustomObjectDataSourceConstructorFilterService : IObjectDataSourceConstructorFilterService {
        public IEnumerable<ConstructorInfo> Filter(Type dataSourceType, IEnumerable<ConstructorInfo> constructors) {
            if(dataSourceType == typeof(SampleObjectTypes.DataSource2)) {
                return constructors;
            }
            return constructors.Where(x => x.GetParameters().Length > 0);
        }
    }
    #endregion

    #region CustomObjectDataSourceMemberFilterService
    // ...
    public class CustomObjectDataSourceMemberFilterService : IObjectDataSourceMemberFilterService {
        public IEnumerable<MemberInfo> Filter(Type dataSourceType, IEnumerable<MemberInfo> members) {
            if(dataSourceType == typeof(SampleObjectTypes.DataSource2)) {
                return members;
            }
            return members.Where(x => {
                var method = x as MethodInfo;
                if(method != null) return method.GetParameters().Length > 0;
                return false;
            });
        }
    }
    #endregion
}
