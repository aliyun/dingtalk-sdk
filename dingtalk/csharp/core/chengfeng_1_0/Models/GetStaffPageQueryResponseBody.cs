// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetStaffPageQueryResponseBody : TeaModel {
        /// <summary>
        /// 查询数据返回
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetStaffPageQueryResponseBodyContent Content { get; set; }
        public class GetStaffPageQueryResponseBodyContent : TeaModel {
            /// <summary>
            /// 员工列表
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<CfStaffResp> Data { get; set; }

            /// <summary>
            /// 当前页码
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// 分页条数
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// 总数量
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
