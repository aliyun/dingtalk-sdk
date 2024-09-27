// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QueryAdvancedContractVersionResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryAdvancedContractVersionResponseBodyResult Result { get; set; }
        public class QueryAdvancedContractVersionResponseBodyResult : TeaModel {
            [NameInMap("enableEsignAttachmentSign")]
            [Validation(Required=false)]
            public bool? EnableEsignAttachmentSign { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>advanced</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
