// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class QueryMinutesTodoResponseBody : TeaModel {
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<string> Actions { get; set; }

        [NameInMap("dingtalkTodoList")]
        [Validation(Required=false)]
        public List<QueryMinutesTodoResponseBodyDingtalkTodoList> DingtalkTodoList { get; set; }
        public class QueryMinutesTodoResponseBodyDingtalkTodoList : TeaModel {
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("creatorUnionId")]
            [Validation(Required=false)]
            public string CreatorUnionId { get; set; }

            [NameInMap("deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            [NameInMap("dingtalkTodoId")]
            [Validation(Required=false)]
            public string DingtalkTodoId { get; set; }

            [NameInMap("executorList")]
            [Validation(Required=false)]
            public List<QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList> ExecutorList { get; set; }
            public class QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList : TeaModel {
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            [NameInMap("minutesTodoId")]
            [Validation(Required=false)]
            public string MinutesTodoId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
