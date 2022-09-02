// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class QueryOrgTodoByUserResponseBody : TeaModel {
        /// <summary>
        /// 每页数量
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 翻页token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 待办卡片列表
        /// </summary>
        [NameInMap("todoCards")]
        [Validation(Required=false)]
        public List<QueryOrgTodoByUserResponseBodyTodoCards> TodoCards { get; set; }
        public class QueryOrgTodoByUserResponseBodyTodoCards : TeaModel {
            /// <summary>
            /// 所属应用
            /// </summary>
            [NameInMap("bizTag")]
            [Validation(Required=false)]
            public string BizTag { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// 创建者id
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// 详情页链接
            /// </summary>
            [NameInMap("detailUrl")]
            [Validation(Required=false)]
            public QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl DetailUrl { get; set; }
            public class QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl : TeaModel {
                /// <summary>
                /// 移动端url地址
                /// </summary>
                [NameInMap("appUrl")]
                [Validation(Required=false)]
                public string AppUrl { get; set; }

                /// <summary>
                /// pc端url地址
                /// </summary>
                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

            }

            /// <summary>
            /// 待办截止时间
            /// </summary>
            [NameInMap("dueTime")]
            [Validation(Required=false)]
            public long? DueTime { get; set; }

            /// <summary>
            /// 待办完成状态
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// 优先级
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// 来源id
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// 待办标题
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// 待办id
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
