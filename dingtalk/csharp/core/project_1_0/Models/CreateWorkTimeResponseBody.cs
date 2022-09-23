// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateWorkTimeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateWorkTimeResponseBodyResult Result { get; set; }
        public class CreateWorkTimeResponseBodyResult : TeaModel {
            [NameInMap("body")]
            [Validation(Required=false)]
            public List<CreateWorkTimeResponseBodyResultBody> Body { get; set; }
            public class CreateWorkTimeResponseBodyResultBody : TeaModel {
                /// <summary>
                /// 工时所属日期
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// 工时关联的数据 ID
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// 实际工时
                /// </summary>
                [NameInMap("workTime")]
                [Validation(Required=false)]
                public long? WorkTime { get; set; }

            }

            /// <summary>
            /// 执行结果描述
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("ok")]
            [Validation(Required=false)]
            public bool? Ok { get; set; }

        }

    }

}
