// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SearchGroupResponseBody : TeaModel {
        /// <summary>
        /// 本次请求条件下的数据总量，此参数为可选参数，默认可不返回。本次请求条件下的数据总量，此参数为可选参数，默认可不返回
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 本次请求所返回的最大记录条数。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 已读未读信息列表
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<SearchGroupResponseBodyRecords> Records { get; set; }
        public class SearchGroupResponseBodyRecords : TeaModel {
            /// <summary>
            /// 开放群ID
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// 群名称
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// 开放团队ID
            /// </summary>
            [NameInMap("openTeamId")]
            [Validation(Required=false)]
            public string OpenTeamId { get; set; }

            /// <summary>
            /// 开放群组ID
            /// </summary>
            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

        }

    }

}
