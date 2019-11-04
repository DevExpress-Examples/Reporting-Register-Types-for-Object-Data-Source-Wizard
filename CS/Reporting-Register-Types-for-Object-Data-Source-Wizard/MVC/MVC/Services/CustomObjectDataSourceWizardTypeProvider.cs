using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DevExpress.DataAccess.Web;

namespace MVC.Services {
    // ...
    public class CustomObjectDataSourceWizardTypeProvider : IObjectDataSourceWizardTypeProvider {
        public IEnumerable<Type> GetAvailableTypes(string context) {
            return new[] {
                typeof(SampleObjectTypes.DataSource),
                typeof(SampleObjectTypes.DataSource2)
            };
        }
    }

    // ...
    public class CustomObjectDataSourceConstructorFilterService : IObjectDataSourceConstructorFilterService {
        public IEnumerable<ConstructorInfo> Filter(Type dataSourceType, IEnumerable<ConstructorInfo> constructors) {
            if(dataSourceType == typeof(SampleObjectTypes.DataSource2)) {
                return constructors;
            }
            return constructors.Where(x => x.GetParameters().Length > 0);
        }
    }

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
}
