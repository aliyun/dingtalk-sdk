// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class LoadBizObjectsResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public LoadBizObjectsResponseBodyData Data { get; set; }
        public class LoadBizObjectsResponseBodyData : TeaModel {
            [NameInMap("bizObjects")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> BizObjects { get; set; }
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
