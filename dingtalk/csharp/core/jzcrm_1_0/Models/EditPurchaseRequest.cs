// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditPurchaseRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditPurchaseRequestData Data { get; set; }
        public class EditPurchaseRequestData : TeaModel {
            [NameInMap("cg_fjmoney")]
            [Validation(Required=false)]
            public string CgFjmoney { get; set; }

            [NameInMap("cg_fjmoneylx")]
            [Validation(Required=false)]
            public string CgFjmoneylx { get; set; }

            [NameInMap("cg_kjmoney")]
            [Validation(Required=false)]
            public string CgKjmoney { get; set; }

            [NameInMap("cg_moneyzhekou")]
            [Validation(Required=false)]
            public string CgMoneyzhekou { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cg_zxstate")]
            [Validation(Required=false)]
            public string CgZxstate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cgdate")]
            [Validation(Required=false)]
            public string Cgdate { get; set; }

            [NameInMap("cgname")]
            [Validation(Required=false)]
            public string Cgname { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cgno")]
            [Validation(Required=false)]
            public string Cgno { get; set; }

            [NameInMap("cgremark")]
            [Validation(Required=false)]
            public string Cgremark { get; set; }

            [NameInMap("cgtype")]
            [Validation(Required=false)]
            public string Cgtype { get; set; }

            [NameInMap("child_mx")]
            [Validation(Required=false)]
            public string ChildMx { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            [NameInMap("empid")]
            [Validation(Required=false)]
            public string Empid { get; set; }

            [NameInMap("gys_lxrid")]
            [Validation(Required=false)]
            public string GysLxrid { get; set; }

            [NameInMap("gys_lxrinfo")]
            [Validation(Required=false)]
            public string GysLxrinfo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gysid")]
            [Validation(Required=false)]
            public string Gysid { get; set; }

            [NameInMap("gysjingban")]
            [Validation(Required=false)]
            public string Gysjingban { get; set; }

            [NameInMap("order_htid")]
            [Validation(Required=false)]
            public string OrderHtid { get; set; }

            [NameInMap("order_khid")]
            [Validation(Required=false)]
            public string OrderKhid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("summoney")]
            [Validation(Required=false)]
            public string Summoney { get; set; }

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
