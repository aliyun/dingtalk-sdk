// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchGetGroupSetConfigResponseBody : TeaModel {
        [NameInMap("groupSetConfigs")]
        [Validation(Required=false)]
        public List<BatchGetGroupSetConfigResponseBodyGroupSetConfigs> GroupSetConfigs { get; set; }
        public class BatchGetGroupSetConfigResponseBodyGroupSetConfigs : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ROBOT_SWITCH</para>
            /// </summary>
            [NameInMap("configKey")]
            [Validation(Required=false)]
            public string ConfigKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("configValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

        }

    }

}
