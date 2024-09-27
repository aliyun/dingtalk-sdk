// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryCustomerBizTypeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryCustomerBizTypeResponseBodyResult Result { get; set; }
        public class QueryCustomerBizTypeResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>crm_customer</para>
            /// </summary>
            [NameInMap("customerBizType")]
            [Validation(Required=false)]
            public string CustomerBizType { get; set; }

        }

    }

}
