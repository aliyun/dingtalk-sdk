// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class UpdateTodoTaskExecutorStatusRequest : TeaModel {
        /// <summary>
        /// 执行者状态列表，id需传用户的unionId
        /// </summary>
        [NameInMap("executorStatusList")]
        [Validation(Required=false)]
        public List<UpdateTodoTaskExecutorStatusRequestExecutorStatusList> ExecutorStatusList { get; set; }
        public class UpdateTodoTaskExecutorStatusRequestExecutorStatusList : TeaModel {
            /// <summary>
            /// 执行者id，需传用户的unionId
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 执行者完成状态
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

        }

        /// <summary>
        /// 当前操作者id，需传用户的unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
