using qhn.Data.Entity.Interfaces;
using shunshine.App.EntityCodeFirst.Constant;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shunshine.App.EntityCodeFirst
{
    [Table("SystemConfigs")]
    public class SystemConfig : EntityPrimaryKey<string>, ISwitchable
    {
        public SystemConfig()
        {
        }

        public SystemConfig(string name, string value1, int? value2, bool? value3, DateTime? value4, Status status)
        {
            Name = name;
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Status = status;
        }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public string Value1 { get; set; }
        public int? Value2 { get; set; }

        public bool? Value3 { get; set; }

        public DateTime? Value4 { get; set; }

        public Status Status { get; set; }
    }
}