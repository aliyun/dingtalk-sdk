// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ListTodoWorkRecordsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListTodoWorkRecordsResponseBodyResult Result { get; set; }
        public class ListTodoWorkRecordsResponseBodyResult : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListTodoWorkRecordsResponseBodyResultList> List { get; set; }
            public class ListTodoWorkRecordsResponseBodyResultList : TeaModel {
                [NameInMap("forms")]
                [Validation(Required=false)]
                public List<ListTodoWorkRecordsResponseBodyResultListForms> Forms { get; set; }
                public class ListTodoWorkRecordsResponseBodyResultListForms : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

        }

    }

}
