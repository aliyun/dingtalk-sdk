// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class QueryTodoTasksResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("todoCards")]
        [Validation(Required=false)]
        public List<QueryTodoTasksResponseBodyTodoCards> TodoCards { get; set; }
        public class QueryTodoTasksResponseBodyTodoCards : TeaModel {
            [NameInMap("bizTag")]
            [Validation(Required=false)]
            public string BizTag { get; set; }

            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("detailUrl")]
            [Validation(Required=false)]
            public QueryTodoTasksResponseBodyTodoCardsDetailUrl DetailUrl { get; set; }
            public class QueryTodoTasksResponseBodyTodoCardsDetailUrl : TeaModel {
                [NameInMap("appUrl")]
                [Validation(Required=false)]
                public string AppUrl { get; set; }

                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

            }

            [NameInMap("dueTime")]
            [Validation(Required=false)]
            public long? DueTime { get; set; }

            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            [NameInMap("orgInfo")]
            [Validation(Required=false)]
            public QueryTodoTasksResponseBodyTodoCardsOrgInfo OrgInfo { get; set; }
            public class QueryTodoTasksResponseBodyTodoCardsOrgInfo : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("originalSource")]
            [Validation(Required=false)]
            public QueryTodoTasksResponseBodyTodoCardsOriginalSource OriginalSource { get; set; }
            public class QueryTodoTasksResponseBodyTodoCardsOriginalSource : TeaModel {
                [NameInMap("sourceTitle")]
                [Validation(Required=false)]
                public string SourceTitle { get; set; }

            }

            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("todoCardView")]
            [Validation(Required=false)]
            public QueryTodoTasksResponseBodyTodoCardsTodoCardView TodoCardView { get; set; }
            public class QueryTodoTasksResponseBodyTodoCardsTodoCardView : TeaModel {
                [NameInMap("actionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                [NameInMap("cardType")]
                [Validation(Required=false)]
                public string CardType { get; set; }

                [NameInMap("circleELType")]
                [Validation(Required=false)]
                public string CircleELType { get; set; }

                [NameInMap("contentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("todoCardContentList")]
                [Validation(Required=false)]
                public List<QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList> TodoCardContentList { get; set; }
                public class QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("todoCardTitle")]
                [Validation(Required=false)]
                public string TodoCardTitle { get; set; }

            }

            [NameInMap("todoStatus")]
            [Validation(Required=false)]
            public string TodoStatus { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
