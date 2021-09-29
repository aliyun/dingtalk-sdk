// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetInstancesResponseBody : TeaModel {
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
        public List<GetInstancesResponseBodyData> Data { get; set; }
        public class GetInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// processInstanceId
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// actioners
            /// </summary>
            [NameInMap("actionExecutor")]
            [Validation(Required=false)]
            public List<GetInstancesResponseBodyDataActionExecutor> ActionExecutor { get; set; }
            public class GetInstancesResponseBodyDataActionExecutor : TeaModel {
                /// <summary>
                /// name
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public GetInstancesResponseBodyDataActionExecutorName Name { get; set; }
                public class GetInstancesResponseBodyDataActionExecutorName : TeaModel {
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }
                };

                /// <summary>
                /// deptName
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// userId
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// email
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

            }

            /// <summary>
            /// approvedResult
            /// </summary>
            [NameInMap("approvedResult")]
            [Validation(Required=false)]
            public string ApprovedResult { get; set; }

            /// <summary>
            /// formUuid
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// data
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// processCode
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            /// <summary>
            /// originator
            /// </summary>
            [NameInMap("originator")]
            [Validation(Required=false)]
            public GetInstancesResponseBodyDataOriginator Originator { get; set; }
            public class GetInstancesResponseBodyDataOriginator : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public GetInstancesResponseBodyDataOriginatorName Name { get; set; }
                public class GetInstancesResponseBodyDataOriginatorName : TeaModel {
                    /// <summary>
                    /// 英文名称
                    /// </summary>
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    /// <summary>
                    /// type
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// 中文名称
                    /// </summary>
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                }
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }
            };

            /// <summary>
            /// title
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// instanceStatus
            /// </summary>
            [NameInMap("instanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// version
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
