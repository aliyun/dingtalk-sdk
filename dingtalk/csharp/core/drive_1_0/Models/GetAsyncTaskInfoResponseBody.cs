// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetAsyncTaskInfoResponseBody : TeaModel {
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
        /// 失败个数
        /// </summary>
        [NameInMap("failed")]
        [Validation(Required=false)]
        public int? Failed { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 完成个数
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public int? Success { get; set; }

        /// <summary>
        /// 异步任务id
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务总数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
