// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditIntostockRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditIntostockRequestData Data { get; set; }
        public class EditIntostockRequestData : TeaModel {
            [NameInMap("askempid")]
            [Validation(Required=false)]
            public string Askempid { get; set; }

            [NameInMap("auditreson")]
            [Validation(Required=false)]
            public string Auditreson { get; set; }

            [NameInMap("billno")]
            [Validation(Required=false)]
            public string Billno { get; set; }

            [NameInMap("child_mx")]
            [Validation(Required=false)]
            public string ChildMx { get; set; }

            [NameInMap("customerid")]
            [Validation(Required=false)]
            public string Customerid { get; set; }

            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            [NameInMap("empid")]
            [Validation(Required=false)]
            public string Empid { get; set; }

            [NameInMap("inorout")]
            [Validation(Required=false)]
            public string Inorout { get; set; }

            [NameInMap("libiodate")]
            [Validation(Required=false)]
            public string Libiodate { get; set; }

            [NameInMap("libioname")]
            [Validation(Required=false)]
            public string Libioname { get; set; }

            [NameInMap("libiostate")]
            [Validation(Required=false)]
            public string Libiostate { get; set; }

            [NameInMap("orderid")]
            [Validation(Required=false)]
            public string Orderid { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("stocklibid")]
            [Validation(Required=false)]
            public string Stocklibid { get; set; }

        }

        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

    }

}
