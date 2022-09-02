// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class QueryTodoTasksResponseBody : TeaModel {
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
        public List<QueryTodoTasksResponseBodyTodoCards> TodoCards { get; set; }
        public class QueryTodoTasksResponseBodyTodoCards : TeaModel {
            /// <summary>
            /// 所属应用
            /// </summary>
            [NameInMap("bizTag")]
            [Validation(Required=false)]
            public string BizTag { get; set; }

            /// <summary>
            /// 所属分类
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

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
            public QueryTodoTasksResponseBodyTodoCardsDetailUrl DetailUrl { get; set; }
            public class QueryTodoTasksResponseBodyTodoCardsDetailUrl : TeaModel {
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
            /// 所属组织信息
            /// </summary>
            [NameInMap("orgInfo")]
            [Validation(Required=false)]
            public QueryTodoTasksResponseBodyTodoCardsOrgInfo OrgInfo { get; set; }
            public class QueryTodoTasksResponseBodyTodoCardsOrgInfo : TeaModel {
                /// <summary>
                /// 组织corpId
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// 组织名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// 业务来源信息
            /// </summary>
            [NameInMap("originalSource")]
            [Validation(Required=false)]
            public QueryTodoTasksResponseBodyTodoCardsOriginalSource OriginalSource { get; set; }
            public class QueryTodoTasksResponseBodyTodoCardsOriginalSource : TeaModel {
                /// <summary>
                /// 业务来源展示名称
                /// </summary>
                [NameInMap("sourceTitle")]
                [Validation(Required=false)]
                public string SourceTitle { get; set; }

            }

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

            /// <summary>
            /// 待办卡片视图模型
            /// </summary>
            [NameInMap("todoCardView")]
            [Validation(Required=false)]
            public QueryTodoTasksResponseBodyTodoCardsTodoCardView TodoCardView { get; set; }
            public class QueryTodoTasksResponseBodyTodoCardsTodoCardView : TeaModel {
                /// <summary>
                /// link, button, 操作区类型，是链接类型，或者按钮类型
                /// </summary>
                [NameInMap("actionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// 卡片类型
                /// </summary>
                [NameInMap("cardType")]
                [Validation(Required=false)]
                public string CardType { get; set; }

                /// <summary>
                /// 卡片左上角 区域类型是 icon, 或者checkbox 类型的
                /// </summary>
                [NameInMap("circleELType")]
                [Validation(Required=false)]
                public string CircleELType { get; set; }

                /// <summary>
                /// icon, name ,内容区域类型是 icon+value, 或者name+value 类型的
                /// </summary>
                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// 卡片icon
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("todoCardContentList")]
                [Validation(Required=false)]
                public List<QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList> TodoCardContentList { get; set; }
                public class QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList : TeaModel {
                    /// <summary>
                    /// 自定义表单内容名字
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 自定义表单内容值
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// 卡片标题
                /// </summary>
                [NameInMap("todoCardTitle")]
                [Validation(Required=false)]
                public string TodoCardTitle { get; set; }

            }

            /// <summary>
            /// 待办状态
            /// </summary>
            [NameInMap("todoStatus")]
            [Validation(Required=false)]
            public string TodoStatus { get; set; }

        }

        /// <summary>
        /// 数据总量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
