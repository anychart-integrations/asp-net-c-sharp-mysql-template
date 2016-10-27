namespace AspNetCSharpMysqlTemplate
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Script.Serialization;

    [Table("anychart_db.fruits")]
    public partial class fruit
    {
        [ScriptIgnore]
        public int id { get; set; }

        [StringLength(64)]
        public string name { get; set; }

        public int? value { get; set; }
    }
}
