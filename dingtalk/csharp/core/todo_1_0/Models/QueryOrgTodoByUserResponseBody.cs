// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class QueryOrgTodoByUserResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("todoCards")]
        [Validation(Required=false)]
        public List<QueryOrgTodoByUserResponseBodyTodoCards> TodoCards { get; set; }
        public class QueryOrgTodoByUserResponseBodyTodoCards : TeaModel {
            [NameInMap("bizTag")]
            [Validation(Required=false)]
            public string BizTag { get; set; }

            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("detailUrl")]
            [Validation(Required=false)]
            public QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl DetailUrl { get; set; }
            public class QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl : TeaModel {
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

            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("sourceExt")]
            [Validation(Required=false)]
            public string SourceExt { get; set; }

            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
