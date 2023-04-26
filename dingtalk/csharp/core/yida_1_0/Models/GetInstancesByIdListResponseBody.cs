// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetInstancesByIdListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetInstancesByIdListResponseBodyResult> Result { get; set; }
        public class GetInstancesByIdListResponseBodyResult : TeaModel {
            [NameInMap("actionExecutor")]
            [Validation(Required=false)]
            public List<GetInstancesByIdListResponseBodyResultActionExecutor> ActionExecutor { get; set; }
            public class GetInstancesByIdListResponseBodyResultActionExecutor : TeaModel {
                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public GetInstancesByIdListResponseBodyResultActionExecutorName Name { get; set; }
                public class GetInstancesByIdListResponseBodyResultActionExecutorName : TeaModel {
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

            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("instanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("originator")]
            [Validation(Required=false)]
            public GetInstancesByIdListResponseBodyResultOriginator Originator { get; set; }
            public class GetInstancesByIdListResponseBodyResultOriginator : TeaModel {
                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public GetInstancesByIdListResponseBodyResultOriginatorName Name { get; set; }
                public class GetInstancesByIdListResponseBodyResultOriginatorName : TeaModel {
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

        }

    }

}
