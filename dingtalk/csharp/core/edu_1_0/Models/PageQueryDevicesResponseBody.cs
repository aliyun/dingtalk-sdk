// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class PageQueryDevicesResponseBody : TeaModel {
        /// <summary>
        /// 当前页的记录列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<PageQueryDevicesResponseBodyList> List { get; set; }
        public class PageQueryDevicesResponseBodyList : TeaModel {
            /// <summary>
            /// 设备过期时间
            /// </summary>
            [NameInMap("gmtExpiry")]
            [Validation(Required=false)]
            public long? GmtExpiry { get; set; }

            /// <summary>
            /// 设备型号
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// 设备名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 设备sn码
            /// </summary>
            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            /// <summary>
            /// 设备类型
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 下一个页码
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
