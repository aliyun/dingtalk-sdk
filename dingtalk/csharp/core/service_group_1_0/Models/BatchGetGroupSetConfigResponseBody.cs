// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchGetGroupSetConfigResponseBody : TeaModel {
        /// <summary>
        /// 群粗配置列表
        /// </summary>
        [NameInMap("groupSetConfigs")]
        [Validation(Required=false)]
        public List<BatchGetGroupSetConfigResponseBodyGroupSetConfigs> GroupSetConfigs { get; set; }
        public class BatchGetGroupSetConfigResponseBodyGroupSetConfigs : TeaModel {
            /// <summary>
            /// 配置项key
            /// </summary>
            [NameInMap("configKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            /// <summary>
            /// 配置项值
            /// </summary>
            [NameInMap("configValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

        }

    }

}
