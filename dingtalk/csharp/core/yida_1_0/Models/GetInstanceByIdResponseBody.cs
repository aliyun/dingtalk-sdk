// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetInstanceByIdResponseBody : TeaModel {
        [NameInMap("actionExecutor")]
        [Validation(Required=false)]
        public List<GetInstanceByIdResponseBodyActionExecutor> ActionExecutor { get; set; }
        public class GetInstanceByIdResponseBodyActionExecutor : TeaModel {
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public GetInstanceByIdResponseBodyActionExecutorName Name { get; set; }
            public class GetInstanceByIdResponseBodyActionExecutorName : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("nameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ZhangSan</para>
                /// </summary>
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
        public GetInstanceByIdResponseBodyOriginator Originator { get; set; }
        public class GetInstanceByIdResponseBodyOriginator : TeaModel {
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public GetInstanceByIdResponseBodyOriginatorName Name { get; set; }
            public class GetInstanceByIdResponseBodyOriginatorName : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("nameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ZhangSan</para>
                /// </summary>
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

}
