// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetOperationRecordsResponseBody : TeaModel {
        /// <summary>
        /// 流程实例操作记录数组
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetOperationRecordsResponseBodyResult> Result { get; set; }
        public class GetOperationRecordsResponseBodyResult : TeaModel {
            /// <summary>
            /// action
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// actionExt
            /// </summary>
            [NameInMap("actionExit")]
            [Validation(Required=false)]
            public string ActionExit { get; set; }

            /// <summary>
            /// activeTime
            /// </summary>
            [NameInMap("activeTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            /// <summary>
            /// activityId
            /// </summary>
            [NameInMap("activityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            /// <summary>
            /// id
            /// </summary>
            [NameInMap("dataId")]
            [Validation(Required=false)]
            public long? DataId { get; set; }

            /// <summary>
            /// digitalSign
            /// </summary>
            [NameInMap("digitalSign")]
            [Validation(Required=false)]
            public string DigitalSign { get; set; }

            /// <summary>
            /// files
            /// </summary>
            [NameInMap("files")]
            [Validation(Required=false)]
            public string Files { get; set; }

            /// <summary>
            /// operateTime
            /// </summary>
            [NameInMap("operateTimeGMT")]
            [Validation(Required=false)]
            public string OperateTimeGMT { get; set; }

            /// <summary>
            /// operateType
            /// </summary>
            [NameInMap("operateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            /// <summary>
            /// operatorDisplayName
            /// </summary>
            [NameInMap("operatorDisplayName")]
            [Validation(Required=false)]
            public string OperatorDisplayName { get; set; }

            /// <summary>
            /// operatorName
            /// </summary>
            [NameInMap("operatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// operatorNick
            /// </summary>
            [NameInMap("operatorNickName")]
            [Validation(Required=false)]
            public string OperatorNickName { get; set; }

            /// <summary>
            /// operatorPhotoUrl
            /// </summary>
            [NameInMap("operatorPhotoUrl")]
            [Validation(Required=false)]
            public string OperatorPhotoUrl { get; set; }

            /// <summary>
            /// operatorStatus
            /// </summary>
            [NameInMap("operatorStatus")]
            [Validation(Required=false)]
            public string OperatorStatus { get; set; }

            /// <summary>
            /// operator
            /// </summary>
            [NameInMap("operatorUserId")]
            [Validation(Required=false)]
            public string OperatorUserId { get; set; }

            /// <summary>
            /// processInstanceId
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// remark
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// showName
            /// </summary>
            [NameInMap("showName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// size
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// taskExecuteType
            /// </summary>
            [NameInMap("taskExecuteType")]
            [Validation(Required=false)]
            public string TaskExecuteType { get; set; }

            /// <summary>
            /// taskHoldTime
            /// </summary>
            [NameInMap("taskHoldTimeGMT")]
            [Validation(Required=false)]
            public long? TaskHoldTimeGMT { get; set; }

            /// <summary>
            /// taskId
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// taskType
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// type
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
