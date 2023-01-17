// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SearchConnectorsResponseBody : TeaModel {
        /// <summary>
        /// 是否有更多记录
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 连接器信息列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<SearchConnectorsResponseBodyList> List { get; set; }
        public class SearchConnectorsResponseBodyList : TeaModel {
            /// <summary>
            /// 连接器的描述信息
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 连接器的图标
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// 连接器的ID
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 连接器的名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 连接器的提供组织
            /// </summary>
            [NameInMap("providerCorpId")]
            [Validation(Required=false)]
            public string ProviderCorpId { get; set; }

        }

        /// <summary>
        /// 下一页记录的查询位置
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
