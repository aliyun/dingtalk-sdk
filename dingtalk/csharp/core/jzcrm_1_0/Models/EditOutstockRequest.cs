// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditOutstockRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditOutstockRequestData Data { get; set; }
        public class EditOutstockRequestData : TeaModel {
            [NameInMap("askempid")]
            [Validation(Required=false)]
            public string Askempid { get; set; }

            [NameInMap("auditreson")]
            [Validation(Required=false)]
            public string Auditreson { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("billno")]
            [Validation(Required=false)]
            public string Billno { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("child_mx")]
            [Validation(Required=false)]
            public string ChildMx { get; set; }

            [NameInMap("customerid")]
            [Validation(Required=false)]
            public string Customerid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("empid")]
            [Validation(Required=false)]
            public string Empid { get; set; }

            [NameInMap("inorout")]
            [Validation(Required=false)]
            public string Inorout { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("libiodate")]
            [Validation(Required=false)]
            public string Libiodate { get; set; }

            [NameInMap("libioname")]
            [Validation(Required=false)]
            public string Libioname { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("libiostate")]
            [Validation(Required=false)]
            public string Libiostate { get; set; }

            [NameInMap("orderid")]
            [Validation(Required=false)]
            public string Orderid { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("stocklibid")]
            [Validation(Required=false)]
            public string Stocklibid { get; set; }

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
