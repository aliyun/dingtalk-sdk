// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class BatchUpdateFormDataByInstanceMapRequest : TeaModel {
        /// <summary>
        /// 宜搭应用编码
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// 该任务是否需要服务端异步执行(选择异步执行那么OpenAPI调用会立即返回并且任务在宜搭服务端继续执行，可支持更大的单次更新数据量上限)
        /// </summary>
        [NameInMap("asynchronousExecution")]
        [Validation(Required=false)]
        public bool? AsynchronousExecution { get; set; }

        /// <summary>
        /// 表单编码
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// 是否忽略空值
        /// </summary>
        [NameInMap("ignoreEmpty")]
        [Validation(Required=false)]
        public bool? IgnoreEmpty { get; set; }

        /// <summary>
        /// 是否不需要触发表单绑定的校验规则、关联业务规则和第三方服务回调（如果您的业务无必要执行这些，那么请填true以减小API的耗时以及更大的单次更新数据量上限）
        /// </summary>
        [NameInMap("noExecuteExpression")]
        [Validation(Required=false)]
        public bool? NoExecuteExpression { get; set; }

        /// <summary>
        /// 宜搭应用秘钥
        /// </summary>
        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// 表单实例数据, json字符串, 可以解析成Map, 解析后得到的Map的键是表单实例id, 值是表单实例更新值json字符串。具体结构请参考 https://www.yuque.com/yida/support/agb8im#f26a51f429f9f19aa0b5b3ee847ac556_h3_31
        /// </summary>
        [NameInMap("updateFormDataJsonMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> UpdateFormDataJsonMap { get; set; }

        /// <summary>
        /// 是否使用最新的表单schema版本, 默认false
        /// </summary>
        [NameInMap("useLatestFormSchemaVersion")]
        [Validation(Required=false)]
        public bool? UseLatestFormSchemaVersion { get; set; }

        /// <summary>
        /// 钉钉userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
