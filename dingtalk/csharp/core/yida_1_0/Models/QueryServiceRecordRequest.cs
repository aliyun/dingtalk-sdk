// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class QueryServiceRecordRequest : TeaModel {
        /// <summary>
        /// 宜搭应用编码
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

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
        /// 表单实例ID
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 服务在此时间之后调用的
        /// </summary>
        [NameInMap("invokeAfterDateGMT")]
        [Validation(Required=false)]
        public string InvokeAfterDateGMT { get; set; }

        /// <summary>
        /// 服务在此时间之前调用的
        /// </summary>
        [NameInMap("invokeBeforeDateGMT")]
        [Validation(Required=false)]
        public string InvokeBeforeDateGMT { get; set; }

        /// <summary>
        /// 服务调用状态
        /// </summary>
        [NameInMap("invokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        /// <summary>
        /// 分页第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 服务调用地址包含的部分字符串，用于模糊搜索
        /// </summary>
        [NameInMap("requestUrl")]
        [Validation(Required=false)]
        public string RequestUrl { get; set; }

        /// <summary>
        /// 被重试的服务调用唯一ID(此次服务调用是重试哪个执行失败的服务调用)
        /// </summary>
        [NameInMap("sourceUuid")]
        [Validation(Required=false)]
        public string SourceUuid { get; set; }

        /// <summary>
        /// 服务调用是否成功(不传此参数则查询全部的)
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 宜搭应用秘钥
        /// </summary>
        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// 操作人的钉钉userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
