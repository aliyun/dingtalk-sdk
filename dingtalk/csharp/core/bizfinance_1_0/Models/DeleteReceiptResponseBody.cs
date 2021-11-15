// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class DeleteReceiptResponseBody : TeaModel {
        /// <summary>
        /// 结果列表
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<DeleteReceiptResponseBodyResults> Results { get; set; }
        public class DeleteReceiptResponseBodyResults : TeaModel {
            /// <summary>
            /// 数据唯一编号
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 是否成功
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// 错误码
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// 错误信息
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

        }

    }

}
