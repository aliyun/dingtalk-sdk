// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class QueryServiceRecordResponseBody : TeaModel {
        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 服务调用记录数组
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<QueryServiceRecordResponseBodyValues> Values { get; set; }
        public class QueryServiceRecordResponseBodyValues : TeaModel {
            /// <summary>
            /// 表单实例id
            /// </summary>
            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            /// <summary>
            /// 表单编码
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// 服务类型
            /// </summary>
            [NameInMap("hookType")]
            [Validation(Required=false)]
            public string HookType { get; set; }

            /// <summary>
            /// 本次服务调用的唯一ID
            /// </summary>
            [NameInMap("hookUuid")]
            [Validation(Required=false)]
            public string HookUuid { get; set; }

            /// <summary>
            /// 服务调用的实际入参
            /// </summary>
            [NameInMap("invokeParameter")]
            [Validation(Required=false)]
            public string InvokeParameter { get; set; }

            /// <summary>
            /// 服务调用的返回结果
            /// </summary>
            [NameInMap("invokeResult")]
            [Validation(Required=false)]
            public string InvokeResult { get; set; }

            /// <summary>
            /// 服务调用状态
            /// </summary>
            [NameInMap("invokeStatus")]
            [Validation(Required=false)]
            public string InvokeStatus { get; set; }

            /// <summary>
            /// 服务调用是否成功
            /// </summary>
            [NameInMap("invokeSuccess")]
            [Validation(Required=false)]
            public string InvokeSuccess { get; set; }

            /// <summary>
            /// 服务调用地址
            /// </summary>
            [NameInMap("invokeUrl")]
            [Validation(Required=false)]
            public string InvokeUrl { get; set; }

            /// <summary>
            /// 宜搭调用目标服务时传的实际参数
            /// </summary>
            [NameInMap("serviceContent")]
            [Validation(Required=false)]
            public string ServiceContent { get; set; }

            /// <summary>
            /// 服务名称
            /// </summary>
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// 服务调用的实际入参
            /// </summary>
            [NameInMap("serviceParameter")]
            [Validation(Required=false)]
            public string ServiceParameter { get; set; }

            /// <summary>
            /// 重试的服务调用唯一ID(此次服务调用是重试哪个执行失败的服务调用)
            /// </summary>
            [NameInMap("sourceUuid")]
            [Validation(Required=false)]
            public string SourceUuid { get; set; }

        }

    }

}
