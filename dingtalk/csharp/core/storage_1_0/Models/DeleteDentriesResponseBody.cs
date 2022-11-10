// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class DeleteDentriesResponseBody : TeaModel {
        /// <summary>
        /// 批量删除文件结果列表
        /// 最大size:
        /// 	50
        /// </summary>
        [NameInMap("resultItems")]
        [Validation(Required=false)]
        public List<DeleteDentriesResponseBodyResultItems> ResultItems { get; set; }
        public class DeleteDentriesResponseBodyResultItems : TeaModel {
            /// <summary>
            /// 是否是异步任务
            /// 如果操作对象有子节点，则会异步处理
            /// </summary>
            [NameInMap("async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            /// <summary>
            /// 源文件(夹)id
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// 错误原因, 如果为异步任务, 该字段为空
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// 源文件(夹)空间id
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// 是否成功, 如果为异步任务, 该字段为空
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// 异步任务id，用于查询任务执行状态
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
