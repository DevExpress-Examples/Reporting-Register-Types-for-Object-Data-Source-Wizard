using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WebForms.SampleObjectTypes {
    [DisplayName("My Data Source")]
    public class DataSource {
        List<DataItem> data = new List<DataItem>();
        public DataSource() : this(100) { }
        public DataSource(int count) : this(count, 1000) { }
        public DataSource(int count, int maxValue) {
            var random = new Random();
            for(var i = 0; i < count; i++) {
                data.Add(new DataItem() {
                    Random = random.Next(0, maxValue)
                });
            }
        }
        public List<DataItem> GetData() {
            return data;
        }

        public List<DataItem> GetData(int count) {
            return data.GetRange(0, count);
        }
    }

    public class DataSource2 : DataSource {
        public DataSource2() : base(1000, 1000) { }
    }
    public class DataItem {
        public int Random { get; set; }
    }
}
