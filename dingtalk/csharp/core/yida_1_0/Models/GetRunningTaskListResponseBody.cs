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
            /// <b>Example:</b>
            /// <para>2021-02-01</para>
            /// </summary>
            [NameInMap("activeTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("actualActionExecutorId")]
            [Validation(Required=false)]
            public string ActualActionExecutorId { get; set; }

            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-01</para>
            /// </summary>
            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-01</para>
            /// </summary>
            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            [NameInMap("originatorEmail")]
            [Validation(Required=false)]
            public string OriginatorEmail { get; set; }

            [NameInMap("originatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            [NameInMap("originatorName")]
            [Validation(Required=false)]
            public string OriginatorName { get; set; }

            [NameInMap("originatorNameInEnglish")]
            [Validation(Required=false)]
            public string OriginatorNameInEnglish { get; set; }

            [NameInMap("originatorNickName")]
            [Validation(Required=false)]
            public string OriginatorNickName { get; set; }

            [NameInMap("originatorNickNameInEnglish")]
            [Validation(Required=false)]
            public string OriginatorNickNameInEnglish { get; set; }

            [NameInMap("originatorPhoto")]
            [Validation(Required=false)]
            public string OriginatorPhoto { get; set; }

            [NameInMap("outResult")]
            [Validation(Required=false)]
            public string OutResult { get; set; }

            [NameInMap("outResultName")]
            [Validation(Required=false)]
            public string OutResultName { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-123</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>append task</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李四发起的请购单</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>title A</para>
            /// </summary>
            [NameInMap("titleInEnglish")]
            [Validation(Required=false)]
            public string TitleInEnglish { get; set; }

        }

    }

}
