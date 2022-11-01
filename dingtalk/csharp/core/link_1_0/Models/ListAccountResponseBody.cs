// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class ListAccountResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAccountResponseBodyResult> Result { get; set; }
        public class ListAccountResponseBodyResult : TeaModel {
            /// <summary>
            /// 服务窗帐号ID
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// 服务窗名称
            /// </summary>
            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

        }

    }

}
