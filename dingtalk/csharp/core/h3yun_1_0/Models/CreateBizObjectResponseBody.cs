// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class CreateBizObjectResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateBizObjectResponseBodyData Data { get; set; }
        public class CreateBizObjectResponseBodyData : TeaModel {
            /// <summary>
            /// 表单业务数据id
            /// </summary>
            [NameInMap("bizObjectId")]
            [Validation(Required=false)]
            public string BizObjectId { get; set; }

            /// <summary>
            /// 数据模型。DataList=本地存储的列表库，Workflow=工作流应用
            /// </summary>
            [NameInMap("formUsageType")]
            [Validation(Required=false)]
            public string FormUsageType { get; set; }

            /// <summary>
            /// 流程实例id
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// 表单编码
            /// </summary>
            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

        }

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
