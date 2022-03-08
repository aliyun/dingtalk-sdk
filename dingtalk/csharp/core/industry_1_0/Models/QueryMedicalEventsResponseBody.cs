// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryMedicalEventsResponseBody : TeaModel {
        /// <summary>
        /// 事件详情列表
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryMedicalEventsResponseBodyContent> Content { get; set; }
        public class QueryMedicalEventsResponseBodyContent : TeaModel {
            /// <summary>
            /// 事件code
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 事件内容
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 事件id
            /// </summary>
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

        }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 数据总量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
