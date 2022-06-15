// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetOrganizationTaskResponseBody : TeaModel {
        /// <summary>
        /// 返回结构体
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetOrganizationTaskResponseBodyResult Result { get; set; }
        public class GetOrganizationTaskResponseBodyResult : TeaModel {
            [NameInMap("ancestorIds")]
            [Validation(Required=false)]
            public List<string> AncestorIds { get; set; }
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }
            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }
            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }
            [NameInMap("visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }
        };

    }

}
