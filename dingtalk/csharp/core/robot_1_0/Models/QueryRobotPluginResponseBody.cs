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
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

        }

    }

}
