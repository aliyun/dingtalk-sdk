// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetInstanceByIdResponseBody : TeaModel {
        /// <summary>
        /// actionExecutor
        /// </summary>
        [NameInMap("actionExecutor")]
        [Validation(Required=false)]
        public List<GetInstanceByIdResponseBodyActionExecutor> ActionExecutor { get; set; }
        public class GetInstanceByIdResponseBodyActionExecutor : TeaModel {
            /// <summary>
            /// deptName
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// email
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// name
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public GetInstanceByIdResponseBodyActionExecutorName Name { get; set; }
            public class GetInstanceByIdResponseBodyActionExecutorName : TeaModel {
                /// <summary>
                /// 中文名称
                /// </summary>
                [NameInMap("nameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

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

            }

            /// <summary>
            /// userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// approvedResult
        /// </summary>
        [NameInMap("approvedResult")]
        [Validation(Required=false)]
        public string ApprovedResult { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("createTimeGMT")]
        [Validation(Required=false)]
        public string CreateTimeGMT { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// formUuid
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// instanceStatus
        /// </summary>
        [NameInMap("instanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

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
        public GetInstanceByIdResponseBodyOriginator Originator { get; set; }
        public class GetInstanceByIdResponseBodyOriginator : TeaModel {
            /// <summary>
            /// deptName
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// email
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// name
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public GetInstanceByIdResponseBodyOriginatorName Name { get; set; }
            public class GetInstanceByIdResponseBodyOriginatorName : TeaModel {
                /// <summary>
                /// 中文名称
                /// </summary>
                [NameInMap("nameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

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

            }

            /// <summary>
            /// userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// processCode
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// processInstanceId
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// title
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// version
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

    }

}
