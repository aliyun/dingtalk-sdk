// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class GetDataListResponseBody : TeaModel {
        /// <summary>
        /// 数据列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDataListResponseBodyData> Data { get; set; }
        public class GetDataListResponseBodyData : TeaModel {
            [NameInMap("detail")]
            [Validation(Required=false)]
            public Dictionary<string, string> Detail { get; set; }

        }

        /// <summary>
        /// 字段明细
        /// </summary>
        [NameInMap("dataname")]
        [Validation(Required=false)]
        public Dictionary<string, string> Dataname { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// 分页条数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 响应时间
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
