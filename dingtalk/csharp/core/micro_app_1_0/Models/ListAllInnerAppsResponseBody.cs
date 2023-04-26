// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class ListAllInnerAppsResponseBody : TeaModel {
        [NameInMap("appList")]
        [Validation(Required=false)]
        public List<ListAllInnerAppsResponseBodyAppList> AppList { get; set; }
        public class ListAllInnerAppsResponseBodyAppList : TeaModel {
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            [NameInMap("appId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("appStatus")]
            [Validation(Required=false)]
            public int? AppStatus { get; set; }

            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("developType")]
            [Validation(Required=false)]
            public int? DevelopType { get; set; }

            [NameInMap("homepageLink")]
            [Validation(Required=false)]
            public string HomepageLink { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ompLink")]
            [Validation(Required=false)]
            public string OmpLink { get; set; }

            [NameInMap("pcHomepageLink")]
            [Validation(Required=false)]
            public string PcHomepageLink { get; set; }

        }

    }

}
