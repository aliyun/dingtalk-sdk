// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptsByPageResponseBody : TeaModel {
        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public string HasMore { get; set; }

        /// <summary>
        /// 数据列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryReceiptsByPageResponseBodyList> List { get; set; }
        public class QueryReceiptsByPageResponseBodyList : TeaModel {
            /// <summary>
            /// 模型id
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// 数据来源：审批(approval)，开放接口(openapi)
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// 数据来源于开放时，对应的微应用id
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// 单据数据体json
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

        }

    }

}
