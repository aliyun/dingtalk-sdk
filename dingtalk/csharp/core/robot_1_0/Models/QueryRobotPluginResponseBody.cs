// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class QueryRobotPluginResponseBody : TeaModel {
        [NameInMap("pluginInfoList")]
        [Validation(Required=false)]
        public List<QueryRobotPluginResponseBodyPluginInfoList> PluginInfoList { get; set; }
        public class QueryRobotPluginResponseBodyPluginInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>@lALPDtXaDkO3j7hgYA</para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>快捷入口名称</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

        }

    }

}
