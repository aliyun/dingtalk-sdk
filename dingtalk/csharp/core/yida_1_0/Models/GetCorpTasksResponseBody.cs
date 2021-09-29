// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetCorpTasksResponseBody : TeaModel {
        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 当前第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetCorpTasksResponseBodyData> Data { get; set; }
        public class GetCorpTasksResponseBodyData : TeaModel {
            /// <summary>
            /// originatorNickName
            /// </summary>
            [NameInMap("originatorNickName")]
            [Validation(Required=false)]
            public string OriginatorNickName { get; set; }

            /// <summary>
            /// processInstanceId
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// originatorName
            /// </summary>
            [NameInMap("originatorName")]
            [Validation(Required=false)]
            public string OriginatorName { get; set; }

            /// <summary>
            /// finishTime
            /// </summary>
            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            /// <summary>
            /// activeTime
            /// </summary>
            [NameInMap("activeTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            /// <summary>
            /// actualActionerId
            /// </summary>
            [NameInMap("actualActionerId")]
            [Validation(Required=false)]
            public string ActualActionerId { get; set; }

            /// <summary>
            /// originatorEmail
            /// </summary>
            [NameInMap("originatorEmail")]
            [Validation(Required=false)]
            public string OriginatorEmail { get; set; }

            /// <summary>
            /// title
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// outResultName
            /// </summary>
            [NameInMap("outResultName")]
            [Validation(Required=false)]
            public string OutResultName { get; set; }

            /// <summary>
            /// outResult
            /// </summary>
            [NameInMap("outResult")]
            [Validation(Required=false)]
            public string OutResult { get; set; }

            /// <summary>
            /// originatorPhoto
            /// </summary>
            [NameInMap("originatorPhoto")]
            [Validation(Required=false)]
            public string OriginatorPhoto { get; set; }

            /// <summary>
            /// taskType
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// originatorNickNameEn
            /// </summary>
            [NameInMap("originatorNickNameEn")]
            [Validation(Required=false)]
            public string OriginatorNickNameEn { get; set; }

            /// <summary>
            /// createTime
            /// </summary>
            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// titleEn
            /// </summary>
            [NameInMap("titleInEnglish")]
            [Validation(Required=false)]
            public string TitleInEnglish { get; set; }

            /// <summary>
            /// appType
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// originatorNameEn
            /// </summary>
            [NameInMap("originatorNameInEnglish")]
            [Validation(Required=false)]
            public string OriginatorNameInEnglish { get; set; }

            /// <summary>
            /// originatorId
            /// </summary>
            [NameInMap("originatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            /// <summary>
            /// taskId
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// status
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
