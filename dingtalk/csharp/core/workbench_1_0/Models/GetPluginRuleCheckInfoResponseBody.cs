// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class GetPluginRuleCheckInfoResponseBody : TeaModel {
        /// <summary>
        /// 权限包code
        /// </summary>
        [NameInMap("packCode")]
        [Validation(Required=false)]
        public string PackCode { get; set; }

        /// <summary>
        /// 校验规则
        /// </summary>
        [NameInMap("pluginRuleCheckDetail")]
        [Validation(Required=false)]
        public string PluginRuleCheckDetail { get; set; }

    }

}
