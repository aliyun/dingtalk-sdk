// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class BatchRemovalByFormInstanceIdListRequest : TeaModel {
        /// <summary>
        /// 宜搭应用编码
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// 是否需要宜搭服务端异步执行该任务(选择异步执行删除操作，那么OpenAPI调用会立即返回，并且宜搭服务端会继续执行删除操作直至结束，且允许的单次删除数据量上限更大)
        /// </summary>
        [NameInMap("asynchronousExecution")]
        [Validation(Required=false)]
        public bool? AsynchronousExecution { get; set; }

        /// <summary>
        /// 是否需要触发表单绑定的校验规则、关联业务规则和第三方服务回调（如果您的业务无必要执行这些，那么请填false以降低API的耗时以及获得更大的单次删除数据量上限）
        /// </summary>
        [NameInMap("executeExpression")]
        [Validation(Required=false)]
        public bool? ExecuteExpression { get; set; }

        /// <summary>
        /// 表单实例id列表
        /// </summary>
        [NameInMap("formInstanceIdList")]
        [Validation(Required=false)]
        public List<string> FormInstanceIdList { get; set; }

        /// <summary>
        /// 表单编码
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// 宜搭应用秘钥
        /// </summary>
        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// 钉钉userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
