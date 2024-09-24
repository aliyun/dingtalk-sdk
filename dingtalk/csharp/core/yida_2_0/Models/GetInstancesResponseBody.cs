// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class GetInstancesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetInstancesResponseBodyData> Data { get; set; }
        public class GetInstancesResponseBodyData : TeaModel {
            [NameInMap("actionExecutor")]
            [Validation(Required=false)]
            public List<GetInstancesResponseBodyDataActionExecutor> ActionExecutor { get; set; }
            public class GetInstancesResponseBodyDataActionExecutor : TeaModel {
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public GetInstancesResponseBodyDataActionExecutorName Name { get; set; }
                public class GetInstancesResponseBodyDataActionExecutorName : TeaModel {
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("approvedResult")]
            [Validation(Required=false)]
            public string ApprovedResult { get; set; }

            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("instanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            [NameInMap("originator")]
            [Validation(Required=false)]
            public GetInstancesResponseBodyDataOriginator Originator { get; set; }
            public class GetInstancesResponseBodyDataOriginator : TeaModel {
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public GetInstancesResponseBodyDataOriginatorName Name { get; set; }
                public class GetInstancesResponseBodyDataOriginatorName : TeaModel {
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
