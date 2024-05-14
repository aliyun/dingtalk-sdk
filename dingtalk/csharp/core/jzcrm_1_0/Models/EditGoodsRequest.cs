// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditGoodsRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditGoodsRequestData Data { get; set; }
        public class EditGoodsRequestData : TeaModel {
            [NameInMap("addedtime")]
            [Validation(Required=false)]
            public string Addedtime { get; set; }

            [NameInMap("cbprice")]
            [Validation(Required=false)]
            public string Cbprice { get; set; }

            [NameInMap("cp_parentid")]
            [Validation(Required=false)]
            public string CpParentid { get; set; }

            [NameInMap("cparea")]
            [Validation(Required=false)]
            public string Cparea { get; set; }

            [NameInMap("cpbarcode")]
            [Validation(Required=false)]
            public string Cpbarcode { get; set; }

            [NameInMap("cpbrand")]
            [Validation(Required=false)]
            public string Cpbrand { get; set; }

            [NameInMap("cpcontent")]
            [Validation(Required=false)]
            public string Cpcontent { get; set; }

            [NameInMap("cpguige")]
            [Validation(Required=false)]
            public string Cpguige { get; set; }

            [NameInMap("cpimg")]
            [Validation(Required=false)]
            public string Cpimg { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cpname")]
            [Validation(Required=false)]
            public string Cpname { get; set; }

            [NameInMap("cpno")]
            [Validation(Required=false)]
            public string Cpno { get; set; }

            [NameInMap("cpremark")]
            [Validation(Required=false)]
            public string Cpremark { get; set; }

            [NameInMap("cptype")]
            [Validation(Required=false)]
            public string Cptype { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cpunit")]
            [Validation(Required=false)]
            public string Cpunit { get; set; }

            [NameInMap("cpweight")]
            [Validation(Required=false)]
            public string Cpweight { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            [NameInMap("gysid")]
            [Validation(Required=false)]
            public string Gysid { get; set; }

            [NameInMap("ispicimanage")]
            [Validation(Required=false)]
            public string Ispicimanage { get; set; }

            [NameInMap("issnmanage")]
            [Validation(Required=false)]
            public string Issnmanage { get; set; }

            [NameInMap("isstock")]
            [Validation(Required=false)]
            public string Isstock { get; set; }

            [NameInMap("isstop")]
            [Validation(Required=false)]
            public string Isstop { get; set; }

            [NameInMap("preprice1")]
            [Validation(Required=false)]
            public string Preprice1 { get; set; }

            [NameInMap("preprice2")]
            [Validation(Required=false)]
            public string Preprice2 { get; set; }

            [NameInMap("preprice3")]
            [Validation(Required=false)]
            public string Preprice3 { get; set; }

            [NameInMap("preprice4")]
            [Validation(Required=false)]
            public string Preprice4 { get; set; }

            [NameInMap("stockdown")]
            [Validation(Required=false)]
            public string Stockdown { get; set; }

            [NameInMap("stockup")]
            [Validation(Required=false)]
            public string Stockup { get; set; }

            [NameInMap("typeid")]
            [Validation(Required=false)]
            public string Typeid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unitrate")]
            [Validation(Required=false)]
            public string Unitrate { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

    }

}
