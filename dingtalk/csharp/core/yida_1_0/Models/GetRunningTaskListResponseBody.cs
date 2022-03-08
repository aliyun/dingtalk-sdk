// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetRunningTaskListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetRunningTaskListResponseBodyResult> Result { get; set; }
        public class GetRunningTaskListResponseBodyResult : TeaModel {
            /// <summary>
            /// 激活时间
            /// </summary>
            [NameInMap("activeTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            /// <summary>
            /// 实际执行人id
            /// </summary>
            [NameInMap("actualActionExecutorId")]
            [Validation(Required=false)]
            public string ActualActionExecutorId { get; set; }

            /// <summary>
            /// appType
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            /// <summary>
            /// originatorEmail
            /// </summary>
            [NameInMap("originatorEmail")]
            [Validation(Required=false)]
            public string OriginatorEmail { get; set; }

            /// <summary>
            /// originatorId
            /// </summary>
            [NameInMap("originatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            /// <summary>
            /// originatorName
            /// </summary>
            [NameInMap("originatorName")]
            [Validation(Required=false)]
            public string OriginatorName { get; set; }

            /// <summary>
            /// originatorNameEn
            /// </summary>
            [NameInMap("originatorNameInEnglish")]
            [Validation(Required=false)]
            public string OriginatorNameInEnglish { get; set; }

            /// <summary>
            /// originatorNickName
            /// </summary>
            [NameInMap("originatorNickName")]
            [Validation(Required=false)]
            public string OriginatorNickName { get; set; }

            /// <summary>
            /// originatorNickNameEn
            /// </summary>
            [NameInMap("originatorNickNameInEnglish")]
            [Validation(Required=false)]
            public string OriginatorNickNameInEnglish { get; set; }

            /// <summary>
            /// originatorPhoto
            /// </summary>
            [NameInMap("originatorPhoto")]
            [Validation(Required=false)]
            public string OriginatorPhoto { get; set; }

            /// <summary>
            /// outResult
            /// </summary>
            [NameInMap("outResult")]
            [Validation(Required=false)]
            public string OutResult { get; set; }

            /// <summary>
            /// outResultName
            /// </summary>
            [NameInMap("outResultName")]
            [Validation(Required=false)]
            public string OutResultName { get; set; }

            /// <summary>
            /// processInstanceId
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 任务id
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// 任务类型
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// 标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 标题英文
            /// </summary>
            [NameInMap("titleInEnglish")]
            [Validation(Required=false)]
            public string TitleInEnglish { get; set; }

        }

    }

}
