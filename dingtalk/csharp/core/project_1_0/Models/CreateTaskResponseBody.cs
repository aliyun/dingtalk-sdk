// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateTaskResponseBody : TeaModel {
        /// <summary>
        /// 返回结果对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateTaskResponseBodyResult Result { get; set; }
        public class CreateTaskResponseBodyResult : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }
            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<CreateTaskResponseBodyResultCustomfields> Customfields { get; set; }
            public class CreateTaskResponseBodyResultCustomfields : TeaModel {
                public string CustomfieldId { get; set; }
                public List<CreateTaskResponseBodyResultCustomfieldsValue> Value { get; set; }
                public class CreateTaskResponseBodyResultCustomfieldsValue : TeaModel {
                    public string Title { get; set; }
                }
            }
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }
            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }
        };

    }

}
