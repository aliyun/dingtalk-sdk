// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetTaskResponseBody : TeaModel {
        /// <summary>
        /// 任务信息
        /// </summary>
        [NameInMap("task")]
        [Validation(Required=false)]
        public GetTaskResponseBodyTask Task { get; set; }
        public class GetTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// 任务开始时间
            /// </summary>
            [NameInMap("beginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// 任务结束时间
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// 子任务失败总数
            /// </summary>
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// 任务失败原因
            /// </summary>
            [NameInMap("failMessage")]
            [Validation(Required=false)]
            public string FailMessage { get; set; }

            /// <summary>
            /// 任务id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 任务状态
            /// 枚举值:
            /// 	INIT: 初始化
            /// 	IN_PROGRESS: 进行中
            /// 	SUCCESS: 成功
            /// 	FAIL: 失败
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 子任务成功总数
            /// </summary>
            [NameInMap("successCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

            /// <summary>
            /// 子任务总数
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
