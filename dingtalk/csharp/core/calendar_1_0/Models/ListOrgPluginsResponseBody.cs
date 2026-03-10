// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListOrgPluginsResponseBody : TeaModel {
        [NameInMap("plugins")]
        [Validation(Required=false)]
        public List<ListOrgPluginsResponseBodyPlugins> Plugins { get; set; }
        public class ListOrgPluginsResponseBodyPlugins : TeaModel {
            [NameInMap("logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("pluginClassification")]
            [Validation(Required=false)]
            public string PluginClassification { get; set; }

            [NameInMap("pluginId")]
            [Validation(Required=false)]
            public string PluginId { get; set; }

            [NameInMap("subscribers")]
            [Validation(Required=false)]
            public ListOrgPluginsResponseBodyPluginsSubscribers Subscribers { get; set; }
            public class ListOrgPluginsResponseBodyPluginsSubscribers : TeaModel {
                [NameInMap("deptIds")]
                [Validation(Required=false)]
                public List<string> DeptIds { get; set; }

                [NameInMap("unionIds")]
                [Validation(Required=false)]
                public List<string> UnionIds { get; set; }

            }

        }

    }

}
