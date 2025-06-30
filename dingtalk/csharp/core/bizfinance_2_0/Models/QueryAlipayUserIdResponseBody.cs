// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryAlipayUserIdResponseBody : TeaModel {
        [NameInMap("alipayBizUserList")]
        [Validation(Required=false)]
        public List<QueryAlipayUserIdResponseBodyAlipayBizUserList> AlipayBizUserList { get; set; }
        public class QueryAlipayUserIdResponseBodyAlipayBizUserList : TeaModel {
            [NameInMap("alipayUserId")]
            [Validation(Required=false)]
            public string AlipayUserId { get; set; }

            [NameInMap("dingUserId")]
            [Validation(Required=false)]
            public string DingUserId { get; set; }

        }

    }

}
