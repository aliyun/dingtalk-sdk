// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models
{
    public class ParseMsgToDingTypeRequest : TeaModel {
        /// <summary>
        /// messageList
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ParseMsgToDingTypeRequestBody> Body { get; set; }
        public class ParseMsgToDingTypeRequestBody : TeaModel {
            [NameInMap("msgType")]
            [Validation(Required=false)]
            public string MsgType { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

        }

    }

}
