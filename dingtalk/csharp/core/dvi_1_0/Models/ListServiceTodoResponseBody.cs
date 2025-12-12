// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class ListServiceTodoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListServiceTodoResponseBodyResult> Result { get; set; }
        public class ListServiceTodoResponseBodyResult : TeaModel {
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("dingTodoId")]
            [Validation(Required=false)]
            public string DingTodoId { get; set; }

            [NameInMap("executors")]
            [Validation(Required=false)]
            public List<ListServiceTodoResponseBodyResultExecutors> Executors { get; set; }
            public class ListServiceTodoResponseBodyResultExecutors : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            [NameInMap("planFinishDate")]
            [Validation(Required=false)]
            public long? PlanFinishDate { get; set; }

            [NameInMap("todoContent")]
            [Validation(Required=false)]
            public string TodoContent { get; set; }

            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
