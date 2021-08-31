// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetOaOperatorLogListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetOaOperatorLogListResponseBodyData> Data { get; set; }
        public class GetOaOperatorLogListResponseBodyData : TeaModel {
            /// <summary>
            /// 操作员userId
            /// </summary>
            [NameInMap("opUserId")]
            [Validation(Required=false)]
            public string OpUserId { get; set; }

            /// <summary>
            /// 操作员名字
            /// </summary>
            [NameInMap("opName")]
            [Validation(Required=false)]
            public string OpName { get; set; }

            /// <summary>
            /// 操作时间
            /// </summary>
            [NameInMap("opTime")]
            [Validation(Required=false)]
            public long? OpTime { get; set; }

            /// <summary>
            /// 操作分类（一级）
            /// </summary>
            [NameInMap("category1Name")]
            [Validation(Required=false)]
            public string Category1Name { get; set; }

            /// <summary>
            /// 操作分类（二级）
            /// </summary>
            [NameInMap("category2Name")]
            [Validation(Required=false)]
            public string Category2Name { get; set; }

            /// <summary>
            /// 操作详情
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        /// <summary>
        /// 当前获取记录数
        /// </summary>
        [NameInMap("itemCount")]
        [Validation(Required=false)]
        public long? ItemCount { get; set; }

    }

}
